using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Application.Validation;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;
using GA.TradeMarket.Persistance.SMTP;

namespace GA.TradeMarket.Application.Services
{
    public class ShippingService : AbstractService, IShippingService
    {
        private readonly SmtpService ser;
        public ShippingService(IUnitOfWork obj, IMapper map,SmtpService ser) : base(obj, map)
        {
            this.ser= ser;
        }
        

        public async Task AddAsync(ShippingModelIn item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            if (string.IsNullOrEmpty(item.TrackingNumber))
            {
                throw new ArgumentNullException(nameof(item.TrackingNumber));
            }
            var order = await obj.OrderRepository.GetByIdWithDetailsAsync(item.OrderId);
            if (order is null)
            {
                throw new NoItemFoundException(nameof(item));
            }
            var mapped = mapper.Map<Shipping>(item);
            if (mapped is not null)
            {
                await obj.ShipingRepository.AddAsync(mapped);

                string body = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Shipping Notification</title>
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
            background: #007bff;
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
            background: #007bff;
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
            border: 1px solid #007bff;
            background-color: #e7f3ff;
            border-radius: 5px;
        }}
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header"">
            <h1>Shipping Notification</h1>
        </div>
        <div class=""content"">
            <p>ძვირფასო, {order.Customer.Person.Name}</p>
            <p>მოხარული ვართ გაცნობოთ, რომ თქვენი შეკვეთა გამოიგზავნა. აქ არის დეტალები:</p>
            <div class=""details"">
                <p><span>შეკვეთის იდენტიფიკატორი:</span> {order.Id}</p>
                <p><span>Tracking ნომერი:</span> {item.TrackingNumber}</p>
                <p><span>გადამზიდი:</span> {item.Carrier}</p>
                <p><span>გამოგზავნის თარიღი:</span>{item.Carrier}</p>
                <p><span>მიმდინარე სტატუსი:</span></p>
                <div class=""status-box"">
                    <p>{item.Status}</p>
                </div>
            </div>
            <p>თქვენ შეგიძლიათ თვალყური ადევნოთ თქვენს გადაზიდვას მოწოდებული Tracking ნომრის გამოყენებით. მადლობა რომ გვირჩევ ჩვენ.</p>
            <p>საუკეთესო სურვილებით,</p>
            <p>G.Apkha</p>
        </div>
        <div class=""footer"">
            <p>&copy; 2024 G.Apkha, ყველა უფლება დაცულია.</p>
        </div>
    </div>
</body>
</html>
";
                ser.SendMessage(order.Customer.Person.Email, $"შეკვეთა გამოიდზავნა:{DateTime.Now}", body);
            }
        }

        public async Task AddNotificationAsync(NotificationModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            if (string.IsNullOrEmpty(mod.Message))
            {
                throw new ArgumentNullException(nameof(mod.Message));
            }
            var order = await obj.OrderRepository.GetByIdAsync(mod.UserId);
            if (order is null)
            {
                throw new NoItemFoundException(nameof(order));
            }
            var mapped = mapper.Map<Notification>(mod);
            if (mapped is not null)
            {
                await obj.NotificationRepository.AddAsync(mapped);
                await obj.SaveAsync();
            }
        }

        public async Task DeleteAsync(long item)
        {
           await obj.ShipingRepository.DeleteByIdAsync(item);
        }

        public async Task<IEnumerable<ShippingModel>> GetAllWithDetailsAsync()
        {
            var res = await obj.ShipingRepository.GetAllWithDetailsAsync();
            if(res.Any())
            {
                var mapped = mapper.Map<IEnumerable<ShippingModel>>(res);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task<IEnumerable<NotificationModel>> GetAllNotificationAsync()
        {
            var res = await obj.NotificationRepository.GetAllWithDetailsAsync();
            if (res.Any())
            {
                var mapped = mapper.Map<IEnumerable<NotificationModel>>(res);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task<ShippingModel> GetByIdAsync(long Id)
        {
            var res = await obj.ShipingRepository.GetByIdAsync(Id);
            if (res is not null)
            {
                var mapped = mapper.Map<ShippingModel>(res);
                return mapped;
            }
            throw new NoItemFoundException(ErrorKeys.NotFound);
        }

        public async Task RemoveNotificationAsync(long a)
        {
            await obj.NotificationRepository.DeleteByIdAsync(a);
        }

        public async Task UpdateAsync(ShippingModelIn item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            if (string.IsNullOrEmpty(item.TrackingNumber))
            {
                throw new ArgumentNullException(nameof(item.TrackingNumber));
            }
            var order = await obj.OrderRepository.GetByIdAsync(item.OrderId);
            if (order is null)
            {
                throw new NoItemFoundException(nameof(item));
            }
            var mapped = mapper.Map<Shipping>(item);
            if (mapped is not null)
            {
                 obj.ShipingRepository.Update(mapped);
                await obj.SaveAsync();
            }
        }

        public async Task UpdateNotificationAsync(NotificationModelIn mod)
        {
            ArgumentNullException.ThrowIfNull(mod, nameof(mod));
            if (string.IsNullOrEmpty(mod.Message))
            {
                throw new ArgumentNullException(nameof(mod.Message));
            }
            var order = await obj.OrderRepository.GetByIdAsync(mod.UserId);
            if (order is null)
            {
                throw new NoItemFoundException(nameof(order));
            }
            var mapped = mapper.Map<Notification>(mod);
            if (mapped is not null)
            {
                obj.NotificationRepository.Update(mapped);
                await obj.SaveAsync();
            }
        }

        public async Task<bool> UpdateShippingStatus(ShippingStatusUpdateModel update)
        {
            var shipping =await  obj.ShipingRepository.GetByIdWithDetailsAsync(update.shippingId);
            if (shipping is not null)
            {
                shipping.Status = update.NewStatus;
                await obj.SaveAsync();
                string body = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Shipping Status Update</title>
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
            background: #28a745;
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
            background: #28a745;
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
            border: 1px solid #28a745;
            background-color: #eaf6ea;
            border-radius: 5px;
        }}
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header"">
            <h1>გადაზიდვის სტატუსი განახლდა.</h1>
        </div>
        <div class=""content"">
            <p>ძვირფასო, {shipping.Order.Customer.Person.Name}</p>
            <p>მოხარული ვარ შეგატყობინოთ, რომ თქვენი შეკვეთის გადაზიდვის სტატუსი განახლდა:</p>
            <div class=""details"">
                <p><span>შეკვეთის იდენტიფიკატორი:</span> {shipping.Order.Id}</p>
                <p><span>გადაზიდვის იდენტიფიკატორი:</span>{shipping.Id}</p>
                <p><span>განახლების თარიღი:</span>{DateTime.Now.ToShortDateString()}</p>
                <p><span>განახლებული სტატუსი:</span></p>
                <div class=""status-box"">
                    <p>{shipping.Status}</p>
                </div>
            </div>
            <p>თქვენ შეგიძლიათ თვალი ადევნოთ გადაზიდვას Tracking კოდის გამოყენებით.მადლობას გიხდით ჩვენი არჩევისთვის.</p>
            <p>საუკეთესო სურვილებით,</p>
            <p>G.Apkha</p>
        </div>
        <div class=""footer"">
            <p>&copy; 2024 G.Apkha, ყველა უფლება დაცულია</p>
        </div>
    </div>
</body>
</html>
";
                ser.SendMessage(shipping.Order.Customer.Person.Email, $"გადაზიდვის სტატუსი განახლდა-{DateTime.Now.ToShortTimeString()}", body);
                return true;
            }
            return false;
        }


        public async Task SendNotificationstoUsers()
        {
            var notifications = await obj.NotificationRepository.GetAllWithDetailsAsync();
            var listOfUnSeened = notifications.Where(io => io.IsSeen == false).ToList();
            foreach (var notification in listOfUnSeened)
            {
                var body = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
<meta charset=""UTF-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<title>სპეციალური შეთავაზება შენთვის!</title>
<style>
    body {{
        font-family: Arial, sans-serif;
        background-color: #f4f4f4;
        margin: 0;
        padding: 0;
    }}
    .container {{
        max-width: 600px;
        margin: 0 auto;
        padding: 20px;
        background-color: #fff;
        border-radius: 8px;
        box-shadow: 0 2px 4px rgba(0,0,0,0.1);
    }}
    .header {{
        background-color: #007bff;
        color: #fff;
        text-align: center;
        padding: 10px 0;
        border-radius: 8px 8px 0 0;
    }}
    .content {{
        padding: 20px;
    }}
    .footer {{
        text-align: center;
        color: #888;
        font-size: 12px;
        margin-top: 20px;
    }}
</style>
</head>
<body>
<div class=""container"">
    <div class=""header"">
        <h1>განსაკუთრებული შეთავაზება!</h1>
    </div>
    <div class=""content"">
        <p>Dear Customer,</p>
        <p>ჩვენ მოხარული ვართ შემოგთავაზოთ სპეციალური ფასდაკლებები ჩვენს პროდუქტებზე. არ გამოგრჩეს.</p>
        <h2>შეთავაზება:</h2>
        <ul>
            <li>{notification.Message}</li>
        </ul>
        <p>Visit our website or contact us for more details and to make your purchase.</p>
        <p>Thank you for choosing us!</p>
    </div>
    <div class=""footer"">
        <p>This email was sent to you because you subscribed to our newsletter. If you wish to unsubscribe, <a href=""#"">click here</a>.</p>
    </div>
</div>
</body>
</html>
";
                ser.SendMessage(notification.User.Person.Email, $"სპეციალური შეთავაზება, შენთვის-{DateTime.Now.ToShortTimeString()}", body);
                notification.IsSeen = true;
            }
            await obj.SaveAsync();
        }


        public async Task<IEnumerable<NotificationModel>> GetAllUnsentNotifications()
        {
            var res = await obj.NotificationRepository.GetAllWithDetailsAsync();
            var filtered = res.Where(io => io.IsSeen = false).ToList();
            var mapped=mapper.Map<IEnumerable<NotificationModel>>(filtered);
            return mapped;
        }
    }
}
