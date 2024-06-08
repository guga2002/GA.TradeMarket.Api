using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Application.Validation;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;
using GA.TradeMarket.Persistance.SMTP;
using Microsoft.AspNetCore.Identity;

namespace GA.TradeMarket.Application.Services
{
    public class OrderService : AbstractService, IOrderService
    {
        private readonly UserManager<Person> userManager;
        private readonly SmtpService ser;
        public OrderService(IUnitOfWork obj, IMapper map,UserManager<Person> usermanage,SmtpService ser) : base(obj, map)
        {
            this.userManager = usermanage;
            this.ser = ser;
        }

        public async Task AddAsync(OrderModelIn item)
        {
          ArgumentNullException.ThrowIfNull(item, nameof(item));
           var custommer = await obj.CustomerRepository.GetByIdAsync(item.CustomerId);
            if(custommer is null)
            {
                throw new TradeMarket.Application.Validation.MarketException(ErrorKeys.NoCustommer);
            }
            var mapped = mapper.Map<Order>(item);
            await obj.OrderRepository.AddAsync(mapped);
        }

        public async Task DeleteAsync(long item)
        {
           await obj.OrderRepository.DeleteByIdAsync(item);
        }

        public async Task<IEnumerable<OrderModel>> GetAllWithDetailsAsync()
        {
           var res=await obj.OrderRepository.GetAllWithDetailsAsync();
            if(res.Any())
            {
                var mapped= mapper.Map<IEnumerable<OrderModel>>(res);
                return mapped;
            }
            throw new MarketException(ErrorKeys.NotFound);
        }

        public async Task<OrderModel> GetByIdAsync(long Id)
        {
            var res = await obj.OrderRepository.GetByIdAsync(Id);
            if(res is not null)
            {
                var  mapped=mapper.Map<OrderModel>(res);
                return mapped;
            }
            throw new MarketException(ErrorKeys.NotFound);
        }

        public async Task UpdateAsync(OrderModelIn item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            var custommer = await obj.CustomerRepository.GetByIdAsync(item.CustomerId);
            if (custommer is null)
            {
                throw new TradeMarket.Application.Validation.MarketException(ErrorKeys.NoCustommer);
            }
            var mapped = mapper.Map<Order>(item);
            obj.OrderRepository.Update(mapped);
        }

        public async Task<string> CheckStatus(long orderId)
        {
            var order = await  obj.OrderRepository.GetByIdAsync(orderId);
            if(order is not null)
            {
                return order.Status;
            }
            throw new ArgumentException("No order Exist on this Id");
        }

        public async Task UpdateStatus(UpdateStatusModelIn ord)
        {
            ArgumentNullException.ThrowIfNull(ord, nameof(ord));
            var order = await obj.OrderRepository.GetByIdWithDetailsAsync(ord.OrderId);
            if (order is not null)
            {
                order.Status = ord.Status;
                await obj.SaveAsync();
                string body = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Order Status Update</title>
    <style>
        body {{
            font-family: Arial, sans-serif;
            line-height: 1.6;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }}
        .container {{
            width: 80%;
            margin: auto;
            overflow: hidden;
        }}
        .header {{
            background: #4CAF50;
            color: #ffffff;
            padding: 10px 0;
            text-align: center;
        }}
        .content {{
            background: #ffffff;
            padding: 20px;
            margin-top: 20px;
        }}
        .footer {{
            background: #4CAF50;
            color: #ffffff;
            text-align: center;
            padding: 10px 0;
            margin-top: 20px;
        }}
        .content p {{
            font-size: 16px;
        }}
        .content .details {{
            margin: 20px 0;
        }}
        .content .details span {{
            font-weight: bold;
        }}
        .status-box {{
            margin-top: 20px;
            padding: 10px;
            border: 1px solid #4CAF50;
            background-color: #e8f5e9;
            border-radius: 5px;
        }}
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header"">
            <h1>შეკვეთს სტატუს განახლდა</h1>
        </div>
        <div class=""content"">
            <p>ძვირასო,{order.Customer.Person.Name}</p>
            <p>ჩვენ ვწერთ, რომ გაცნობოთ თქვენი შეკვეთის მიმდინარე სტატუსის შესახებ. აქ არის დეტალიs:</p>
            <div class=""details"">
                <p><span>შეკვეთს იდენტიფიკატორი:</span>{order.Id}</p>
                <p><span>შეკვეთს თარიღი:</span>{order.OrderDate}</p>
                <p><span>შეკვეთს სტატუსი:</span></p>
                <div class=""status-box"">
                    <p>{order.Status}</p>
                </div>
            </div>
            <p>გატყობინებთ რომ თქვენს შეკვეთაზე  სტატუსი განახლდა</p>
            <p>საუკეთესო სურვილებით,</p>
            <p>G.Apkha</p>
        </div>
        <div class=""footer"">
            <p>&copy; 2024 G.Apkha. ყველა უფლება დაცულია.</p>
        </div>
    </div>
</body>
</html>
";
                ser.SendMessage(order.Customer?.Person?.Email, $"შეკვეთს სტატუსი განახლდა:{DateTime.Now.ToShortTimeString()}", body);

            }
        }

        public async Task<IEnumerable<OrderModel>> GetMyOrder(string username)
        {
           var user=await userManager.FindByNameAsync(username);
            if(user is not null)
            {
               var orders=await obj.OrderRepository.GetAllWithDetailsAsync();
               var filteredobjects= orders.Where(io=>io.CustomerId==user.Customer.Id).ToList();
                var mapped=mapper.Map<IEnumerable<OrderModel>>(filteredobjects);
                return mapped;
            }
            throw new MarketException(ErrorKeys.NoCustommer);
        }
    }
}
