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
    public sealed class DiscountService : AbstractService, IDiscountService
    {
        private readonly UserManager<Person> userManager;
        private readonly SmtpService smtp;
        public DiscountService(IUnitOfWork obj, IMapper map,UserManager<Person> user,SmtpService smtp) : base(obj, map)
        {
            this.userManager = user;
            this.smtp = smtp;
        }
        public async Task AddAsync(BonusProgramModelIn item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            var customer = await obj.CustomerRepository.GetByIdWithDetailsAsync(item.CustomerId);
            if (customer is null)
            {
                throw new NoUserExistException(ErrorKeys.NoCustommer);
            }

            var map = mapper.Map<BonusProgram>(item);
            await obj.bonusProgramRepository.AddAsync(map);
            string body = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Loyalty Program Notification</title>
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
            <h1>კეთილი იყოს თქვენი მობრძანება ჩვენს ლოიალობის, სისტემაში!</h1>
        </div>
        <div class=""content"">
            <p>ძვირფასო:{customer.Person.Name},</p>
            <p>მოხარული ვართ გაცნობოთ, რომ თქვენ ჩაირიცხეთ ჩვენს ლოიალობის პროგრამაში. აქ არის დეტალები:</p>
            <div class=""details"">
                <p><span>მომხმარებლის სახელი:</span>{customer.Person.Name + ' ' + customer.Person.Surname}</p>
                <p><span>ქულათა რაოდენობა:</span>{item.Points}</p>
                <p><span>გაწევრიანების თარიღი:</span>{item.EnrollmentDate}</p>
            </div>
            <p>მადლობa, რომ ხართ ერთგული მომხმარებელი. ჩვენ ვაფასებთ თქვენს მუდმივ მხარდაჭერას და მოუთმენლად ველით დაჯილდოვებას თქვენ ექსკლუზიური შეღავათებითა და შეთავაზებებით.</p>
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
            smtp.SendMessage(customer.Person?.Email, $"ახალი ლოიალობის პროგრამა შენს სახელზე-{DateTime.Now.ToShortTimeString()}", body);

        }

        public async Task AddCouponAsync(CouponModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            if(string.IsNullOrEmpty(mod.Code)) { 
            
                throw new ArgumentNullException(nameof(mod));
            }
            var map = mapper.Map<Coupon>(mod);
            await obj.CouponRepository.AddAsync(map);
        }

        public async Task DeleteAsync(long item)
        {
            await obj.bonusProgramRepository.DeleteByIdAsync(item);
        }

        public async Task<IEnumerable<BonusProgramModel>> GetAllWithDetailsAsync()
        {
            var res= await obj.bonusProgramRepository.GetAllWithDetailsAsync();
            if(res.Any())
            {
                var  mapped= mapper.Map<IEnumerable<BonusProgramModel>>(res);
                if(mapped.Any())
                {
                    return mapped;
                }
            }
            throw new NoItemFoundException(ErrorKeys.NoBonus);
        }

        public async Task<IEnumerable<CouponModel>> GetAllCouponAsync()
        {
            var res = await obj.CouponRepository.GetAllWithDetailsAsync();
            if (res.Any())
            {
                var mapped = mapper.Map<IEnumerable<CouponModel>>(res);
                if (mapped.Any())
                {
                    return mapped;
                }
            }
            throw new NoItemFoundException(ErrorKeys.NoCoupon);
        }

        public async Task<BonusProgramModel> GetByIdAsync(long Id)
        {
            var bonus=await obj.bonusProgramRepository.GetByIdAsync(Id);
            if(bonus is not  null)
            {
                var mapped=mapper.Map<BonusProgramModel>(bonus);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task RemoveCouponAsync(long a)
        {
            await obj.CouponRepository.DeleteByIdAsync(a);
        }

        public async Task UpdateAsync(BonusProgramModelIn item)
        {
           ArgumentNullException.ThrowIfNull(item, ErrorKeys.ArgumentNull);
            if(item.EnrollmentDate>DateTime.Now||item.EnrollmentDate< new DateTime(1933,01,01))
            {
                throw new MarketException(ErrorKeys.DateValidation);
            }
            var mapped=mapper.Map<BonusProgram>(item);
            if (mapped is not null) 
            obj.bonusProgramRepository.Update(mapped);
            await obj.SaveAsync();
        }

        public async Task UpdateCouponAsync(CouponModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, ErrorKeys.ArgumentNull);
            if (mod.ExpiryDate>DateTime.Now)
            {
                throw new MarketException(ErrorKeys.DateValidation);
            }
            var mapped = mapper.Map<Coupon>(mod);
            if (mapped is not null)
                obj.CouponRepository.Update(mapped);
            await obj.SaveAsync();
        }

        public async Task<IEnumerable<BonusProgramModel>> GetMyLoyalityProgram(string username)
        {
            var user= await userManager.FindByNameAsync(username);
            if (user is not null)
            {
                var loiality = await obj.bonusProgramRepository.GetAllWithDetailsAsync();
                var programs = loiality.Where(io => io.CustomerId == user.Customer.Id).ToList();
                var mapped = mapper.Map<IEnumerable<BonusProgramModel>>(programs);
                return mapped;
            }
            throw new MarketException(ErrorKeys.NoBonus);
        }
    }
}
