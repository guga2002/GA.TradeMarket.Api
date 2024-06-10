
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Persistance.SMTP;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class OrderController : ControllerBase
    {
        private readonly IOrderService ser;
        private readonly ILogger<OrderController> logger;
        private readonly UserManager<Person> userManager;
        private readonly SmtpService smtpService;
        private readonly IMemoryCache cash;
        public OrderController(IOrderService se, ILogger<OrderController> logg, SmtpService smtpService, UserManager<Person> userManager,IMemoryCache cash)
        {
            this.ser = se;
            this.logger = logg;
            this.smtpService = smtpService;
            this.userManager = userManager;
            this.cash = cash;
        }

        /// <summary>
        /// Get  details about my orders(current user) 
        /// </summary>
        /// <remarks>
        /// allowed only **customers**
        /// </remarks>
        [HttpGet]
        [Route(nameof(MyOrder))]
        [Authorize(Roles ="customer")]
        public async Task<ActionResult<OrderModel>> MyOrder()
        {
            try
            {
                var user = User.Identity?.Name;
                if(user is null)
                {
                    return Unauthorized(ErrorKeys.NoCustommer);
                }
                var res = await  ser.GetMyOrder(user);
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"error while retrieving my orders{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Get details about orders
        /// </summary>
        /// <remarks>
        /// allowed only operator,manager -- **enable cashing**
        /// </remarks>
        [HttpGet]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetAllWithDetailsAsync()
        {
            try
            {
                var cashedkey = "GetAllOrders";

                if(cash.TryGetValue(cashedkey,out IEnumerable<OrderModel>? orders))
                {
                    if(orders is not null)
                    {
                        return Ok(orders);
                    }
                }
                var res=await ser.GetAllWithDetailsAsync();
                if(res.Any())
                {
                    cash.Set(cashedkey,res,TimeSpan.FromMinutes(10));
                    return Ok(res);
                }
                return BadRequest(res);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error ocured while retrieving data{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///Get details about order by id
        /// </summary>
        /// <remarks>
        ///  allowed operator,manager -- **enable  cashing**
        /// </remarks>
        [HttpGet]
        [Route("{Id:long}")]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult<OrderModel>> GetByIdAsync([FromRoute]long Id)
        {
            try
            {
                var cashedkey = $"ordermodelbyiid{Id}";
                if(cash.TryGetValue(cashedkey, out OrderModel? orders))
                {
                    if(orders is not null)
                    {
                        return Ok(orders);
                    }
                }
               var res=await ser.GetByIdAsync(Id);
                if(res is not null)
                {
                    cash.Set(cashedkey, res, TimeSpan.FromMinutes(10));
                    return Ok(res);
                }
                return NotFound(Id);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error while fetching data with id{Id}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///Add new order to DB 
        /// </summary>
        /// <remarks>
        /// allow **customer**
        /// </remarks>
        [HttpPost]
        [Authorize(Roles ="customer")]
        public async Task<ActionResult> AddAsync([FromBody]OrderModelIn item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var userName = User.Identity?.Name;
                    if (userName == null)
                    {
                        return Unauthorized(ErrorKeys.General);
                    }
                    var user = await userManager.FindByNameAsync(userName);
                    if (user == null)
                    {
                        return Unauthorized(ErrorKeys.General);
                    }
                    await ser.AddAsync(item);
                    string body = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
<meta charset=""UTF-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<title>New Order Notification</title>
<style>
    body {{
        font-family: Arial, sans-serif;
        background-color: #f4f4f4;
        margin: 0;
        padding: 0;
    }}
    .container {{
        max-width: 600px;
        margin: 20px auto;
        padding: 20px;
        background-color: #fff;
        border-radius: 8px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    }}
    h2 {{
        color: #333;
    }}
    p {{
        color: #666;
        line-height: 1.6;
    }}
    .order-details {{
        margin-top: 20px;
        border-top: 1px solid #ccc;
        padding-top: 20px;
    }}
    .order-details p {{
        margin: 10px 0;
    }}
</style>
</head>
<body>
<div class=""container"">
    <h2>თქვენს სახელზე ფიქსირდება ახალი შეკვეთა</h2>
    <p>გამარჯობა,{user.Name}, შენ განათავსე ახალი შეკვეთა პლათფორმაზე!</p>
    <div class=""order-details"">
        <p><strong>მომხმარებელი:</strong>{user.Name + ' ' + user.Surname}</p>
        <p><strong>შეკვეთს თარიღი:</strong> {item.OrderDate}</p>
        <p><strong>სტატუსი:</strong>{item.Status}</p>
    </div>
    <p>მადლობა რომ გვირჩევ ჩვენ.</p>
</div>
</body>
</html>
";
                    smtpService.SendMessage(user.Email, $"ახალი შეკვეთა შენს სახელზე:{DateTime.Now.ToShortTimeString()}", body);
                    return Ok(item);
                }
                return BadRequest(ErrorKeys.InternalServerError);
            }
            catch (Exception exp)
            {
                logger.LogError($"Error while add order: {exp.Message}", exp);
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        ///  remove order from DB
        /// </summary>
        /// <remarks>
        ///  allow **operator,manager**
        /// </remarks>
        [HttpDelete]
        [Route("{Id:long}")]
        [Authorize(Roles ="operator,manager")]
        public async Task<ActionResult> DeleteAsync(long Id)
        {
            try
            {
                await ser.DeleteAsync(Id);
                return Ok(Id);
            }
            catch (Exception exp)
            {
                logger.LogWarning($"error while deleting  order:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Update order details 
        /// </summary>
        /// <remarks>
        ///  allowed **customer,operator**
        /// </remarks>
        [HttpPut]
        [Authorize(Roles ="customer,operator")]
        public async Task<ActionResult> UpdateAsync([FromBody]OrderModelIn item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await ser.UpdateAsync(item);
                    var userName = User.Identity?.Name;
                    if (userName == null)
                    {
                        return Unauthorized(ErrorKeys.General);
                    }
                    var user = await userManager.FindByNameAsync(userName);
                    if (user == null)
                    {
                        return Unauthorized(ErrorKeys.General);
                    }
                    string body = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
<meta charset=""UTF-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<title>New Order Notification</title>
<style>
    body {{
        font-family: Arial, sans-serif;
        background-color: #f4f4f4;
        margin: 0;
        padding: 0;
    }}
    .container {{
        max-width: 600px;
        margin: 20px auto;
        padding: 20px;
        background-color: #fff;
        border-radius: 8px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    }}
    h2 {{
        color: #333;
    }}
    p {{
        color: #666;
        line-height: 1.6;
    }}
    .order-details {{
        margin-top: 20px;
        border-top: 1px solid #ccc;
        padding-top: 20px;
    }}
    .order-details p {{
        margin: 10px 0;
    }}
</style>
</head>
<body>
<div class=""container"">
    <h2>თქვენი შეკვეთის დეტალები განახლდა</h2>
    <p>Hello,</p>
    <p>გამარჯობა,{user.Name}, შენი შეკვეთის დეტალები განახლდა</p>
    <div class=""order-details"">
        <p><strong>მომხმარებელი:</strong>{user.Surname + ' ' + user.Name}</p>
        <p><strong>შეკვეთს თარიღი:</strong> {item.OrderDate}</p>
        <p><strong>სტატუსი:</strong>{item.Status}</p>
        <p><strong>მომხმარებლის იდენტიფიკატორი:</strong>{item.CustomerId}</p>
    </div>
    <p>მადლობა რომ გვირჩევ ჩვენ.</p>
</div>
</body>
</html>
";
                    smtpService.SendMessage(user.Email, $"თქვენი შეკვეთა განახლდა:{DateTime.Now.ToShortTimeString()}", body);
                    return Ok(item);
                }
                return BadRequest(ErrorKeys.InternalServerError);
            }
            catch (Exception exp )
            {
                logger.LogCritical($"error while updating order details: {exp.Message}");
                return BadRequest(exp.Message);
            }
        }

        /// <summary>
        /// Update status of order
        /// </summary>
        /// <remarks>
        /// allowed  to  this endpoint is **operator**
        /// </remarks>
        [HttpPost]
        [Route("UpdateStatus")]
        [Authorize(Roles ="operator")]
        public async Task<ActionResult> UpdateStatus([FromBody]UpdateStatusModelIn ord)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await ser.UpdateStatus(ord);
                    return Ok(ord);
                }
                return BadRequest(ErrorKeys.InternalServerError);
            }
            catch (Exception exp)
            {
                logger.LogCritical($"Error while tring update status:{exp.Message}");
                return BadRequest($"{exp.Message}");
            }
        }

        /// <summary>
        ///Get current status of order
        /// </summary>
        /// <remarks>
        /// allowed **customer,operator**
        /// </remarks>
        [HttpGet]
        [Route("Status/{Id:long}")]
        [Authorize(Roles ="customer,operator")]
        public async Task<ActionResult> OrderStatus(long  Id)
        {
            try
            {
                var res= await ser.CheckStatus(Id);
                if(string.IsNullOrEmpty(res))
                {
                    return NotFound(ErrorKeys.NotFound);
                }
                return Ok(res);
            }
            catch (Exception exp)
            {
                logger.LogError($"error while  trying get order status:{exp.Message}");
                return BadRequest(exp.Message);
            }
        }
    }
}
