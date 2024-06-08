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
    public class AfterSoldService : AbstractService, IAfterSoldService
    {
        private readonly UserManager<Person> _userManager;
        private readonly SmtpService smtp;
        public AfterSoldService(IUnitOfWork obj, IMapper map, UserManager<Person> _userManager,SmtpService ser) : base(obj, map)
        {
            this._userManager = _userManager;
            this.smtp = ser;
        }

        public async Task AddAsync(ReturnRequestModelIn item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            var order = await obj.OrderRepository.GetByIdWithDetailsAsync(item.OrderId);
            if (order is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoOrder);
            }
            var person = order.Customer.Person;
            string body = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Return Request Notification</title>
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
            background: #50b3a2;
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
            background: #50b3a2;
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
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header"">
            <h1>დაბრუნების მოთხოვნა განთავსდა</h1>
        </div>
        <div class=""content"">
            <p>გამარჯობა,{person.Name}</p>
            <p>ჩვენ მივიღეთ ინფორმაცია შეკვეთს დაბრუნების თაობაზე, შემდეგი დეტალებით:</p>
            <div class=""details"">
                <p><span>Order ID:</span>{item.OrderId}</p>
                <p><span>Request Date:</span>{item.RequestDate} </p>
                <p><span>Reason for Return:</span>{item.Reason}</p>
                <p><span>Status:</span>{item.Status}</p>
            </div>
            <p>ჩვენი გუნდი განიხილავს შენს მოთხოვნას, მალევე დაგიბრუნებთ უკუკავშირს.</p>
            <p>მადლობა მოთმინებისთვის,.</p>
            <p>საუკეთესო სურვილებით,</p>
            <p>G.Apkha</p>
        </div>
        <div class=""footer"">
            <p>&copy; 2024 G.apkha, ყველა უფლება დაცულია.</p>
        </div>
    </div>
</body>
</html>
";
           
            var mapped=mapper.Map<ReturnRequest>(item);
            if(mapped is not null)
            {
               await  obj.ReturnRequestRepository.AddAsync(mapped);
                smtp.SendMessage(person.Email,$"დაბრუნების მოთხოვნა:{DateTime.Now.ToShortTimeString()}",body);
            }
        }

        public async Task AddReviewAsync(ReviewModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            var product = await obj.ProductRepository.GetByIdAsync(mod.ProductId);
            if (product is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoOrder);
            }
            var customer= await obj.CustomerRepository.GetByIdAsync(mod.CustomerId);
            if (customer is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoCustommer);
            }
            var mapped = mapper.Map<Review>(mod);
            if (mapped is not null)
            {
                await obj.reviewRepository.AddAsync(mapped);
            }
        }

        public async Task DeleteAsync(long item)
        {
            await obj.ReturnRequestRepository.DeleteByIdAsync(item);
        }

        public async Task<IEnumerable<ReturnRequestModel>> GetAllWithDetailsAsync()
        {
            var returnreq = await obj.ReturnRequestRepository.GetAllWithDetailsAsync();
            if(returnreq.Any())
            {
                var mapped=mapper.Map<IEnumerable<ReturnRequestModel>>(returnreq);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task<IEnumerable<ReviewModel>> GetAllReviewsAsync()
        {
            var returnreq = await obj.reviewRepository.GetAllWithDetailsAsync();
            if (returnreq.Any())
            {
                var mapped = mapper.Map<IEnumerable<ReviewModel>>(returnreq);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task<ReturnRequestModel> GetByIdAsync(long Id)
        {
            var returnreq = await obj.ReturnRequestRepository.GetByIdAsync(Id);
            if (returnreq is not null)
            {
                var mapped = mapper.Map<ReturnRequestModel>(returnreq);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task RemoveReviewAsync(long a)
        {
            await obj.reviewRepository.DeleteByIdAsync(a);
        }

        public async Task UpdateAsync(ReturnRequestModelIn item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            var order = await obj.OrderRepository.GetByIdAsync(item.OrderId);
            if (order is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoOrder);
            }
            var mapped = mapper.Map<ReturnRequest>(item);
            if (mapped is not null)
            {
                obj.ReturnRequestRepository.Update(mapped);
            }
            else
            {
                throw new TradeMarket.Application.Validation.MarketException("Mapped not was succesfully");            
            }

        }

        public async Task UpdateReviewAsync(ReviewModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            var product = await obj.ProductRepository.GetByIdAsync(mod.ProductId);
            if (product is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoOrder);
            }
            var customer = await obj.CustomerRepository.GetByIdAsync(mod.CustomerId);
            if (customer is null)
            {
                throw new NoItemFoundException(ErrorKeys.NoCustommer);
            }
            var mapped = mapper.Map<Review>(mod);
            if (mapped is not null)
            {
                obj.reviewRepository.Update(mapped);
            }
        }

        public async Task<IEnumerable<ReturnRequestModel>> GetAllMyReturnRequests(string username)
        {
            var user=await _userManager.FindByNameAsync(username);
            if (user is null) { throw new MarketException(ErrorKeys.NoCustommer); }
            var res = await obj.ReturnRequestRepository.GetAllWithDetailsAsync();
           var returnRequests=res.Where(io => io.Order.CustomerId == user.Customer.Id).ToList();
            if(returnRequests.Any())
            {
                var mapped=mapper.Map<IEnumerable<ReturnRequestModel>>(returnRequests);
                return mapped;
            }
            return new List<ReturnRequestModel>();
        }
    }
}
