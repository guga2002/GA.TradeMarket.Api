using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Services;
using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using GA.TradeMarket.Infrastructure.Repositories;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;
using GA.TradeMarket.Persistance.SMTP;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using RGBA.Optio.Domain.Services;
using System.Reflection;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddDbContext<TradeMarketDbContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("GugassConnection"));
        });


        builder.Services.AddAutoMapper(typeof(GA.TradeMarket.Application.AutoMapp.AutoMapper));

        builder.Services.AddControllers().AddJsonOptions(options =>
        {

        }); ;

        builder.Services.AddMemoryCache();

        builder.Services.AddHttpContextAccessor();

        #region Add scopes to DI
        builder.Services.AddScoped<UserManager<Person>>();
        builder.Services.AddScoped<SignInManager<Person>>();
        builder.Services.AddScoped<RoleManager<IdentityRole>>();

        builder.Services.AddScoped<IUnitOfWork, UniteOfWork>();
        builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
        builder.Services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
        builder.Services.AddScoped<IProductRepository, ProductRepository>();
        builder.Services.AddScoped<IReceiptDetailRepository, ReceiptDetailRepository>();
        builder.Services.AddScoped<IReceiptRepository, ReceiptRepository>();
        builder.Services.AddScoped<ICouponRepository, CouponRepository>();
        builder.Services.AddScoped<IBonusProgramRepository, BonusRepository>();
        builder.Services.AddScoped<INotificationRepository, NotificationRepository>();
        builder.Services.AddScoped<IOrderRepository, OrderRepository>();
        builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
        builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
        builder.Services.AddScoped<IReturnRequestRepository, ReturnRequestRepository>();
        builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
        builder.Services.AddScoped<IShipingRepository, ShipingRepository>();
        builder.Services.AddScoped<IExchangeRateRepository, ExchangeRateRepository>();
        builder.Services.AddScoped<IWishListRepository, WishListRepository>();

        builder.Services.AddScoped<ICustomerService, CustomerService>();
        builder.Services.AddScoped<IProductService, ProductService>();
        builder.Services.AddScoped<IStatisticService, StatisticService>();
        builder.Services.AddScoped<IReceiptService, ReceiptService>();
        builder.Services.AddScoped<IUserIdentityService, UserIdentityServices>();
        builder.Services.AddScoped<IAfterSoldService, AfterSoldService>();
        builder.Services.AddScoped<IDiscountService, DiscountService>();
        builder.Services.AddScoped<IPaymentService, PaymentService>();
        builder.Services.AddScoped<IShippingService, ShippingService>();
        builder.Services.AddScoped<ICurrencyService, CurrencyService>();
        builder.Services.AddScoped<IOrderService, OrderService>();
        builder.Services.AddScoped<IWishListService,WIshListService>();

        builder.Services.AddSingleton<SmtpService>();
        #endregion

        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddSwaggerGen(opt =>
        {
            opt.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "It Step Final Project",
                Description = "Final Project, Online Trade Market",
                TermsOfService = new Uri("https://github.com/guga2002/GA.TradeMarket.Api/blob/master/README.md"),
                Contact = new OpenApiContact
                {
                    Name = "Contact Me",
                    Url = new Uri("https://www.linkedin.com/in/guga-apkhazava-938a40237/")
                },
                License = new OpenApiLicense
                {
                    Name = "License, Source Code",
                    Url = new Uri("https://github.com/guga2002/GA.TradeMarket.Api")
                }
            });


            opt.AddSecurityDefinition("auth", new OpenApiSecurityScheme
            {
                Type = SecuritySchemeType.ApiKey,
                Name = "Authorization",
                In = ParameterLocation.Header,
                Description = "Enter token here"
            });

            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            opt.IncludeXmlComments(xmlPath);

            opt.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "auth" 
                }
            },
            Array.Empty<string>()
                }
            });
        });


        builder.Services.AddIdentity<Person, IdentityRole>()
            .AddEntityFrameworkStores<TradeMarketDbContext>()
            .AddDefaultTokenProviders();



        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "https://localhost:7049",
                    ValidAudience = "https://localhost:7049/",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("65E255FF-F399-42D4-9C7F-D5D08B0EC285")),
                };
            });

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.Cookie.HttpOnly = true;
            options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            options.Cookie.SameSite = SameSiteMode.Strict;
            options.Cookie.Name = "ItStepCookiesPolicy";
            options.LoginPath = "/UserIdentity/SignIn";
            options.SlidingExpiration = true;
            options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
        });

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("RequestPipeline",
                builder =>
                {
                    if (builder == null) throw new ArgumentNullException(nameof(builder));
                    builder.AllowAnyOrigin()
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment()||app.Environment.IsProduction())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "It Step Georgia v1");
            });

        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthentication();

        app.UseAuthorization();

        app.UseCors("RequestPipeline");

        app.MapControllers();

        app.Run();
    }
}

