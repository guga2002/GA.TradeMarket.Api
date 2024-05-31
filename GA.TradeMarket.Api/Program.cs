using GA.TradeMarket.Application.AutoMapp;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Services;
using GA.TradeMarket.Domain.Data;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Domain.Interfaces;
using GA.TradeMarket.Infrastructure.Repositories;
using GA.TradeMarket.Infrastructure.UniteOfWorkRelated;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<TradeMarketDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("GugassConnection"));
});


builder.Services.AddAutoMapper(typeof(GA.TradeMarket.Application.AutoMapp.AutoMapper));

builder.Services.AddControllers();

builder.Services.AddMemoryCache();

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<UserManager<Person>>();
builder.Services.AddScoped<SignInManager<Person>>();
builder.Services.AddScoped<RoleManager<IdentityRole>>();

builder.Services.AddScoped<IUnitOfWork, UniteOfWork>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IReceiptDetailRepository, ReceiptDetailRepository>();
builder.Services.AddScoped<IReceiptRepository, ReceiptRepository>();

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IStatisticService, StatisticService>();
builder.Services.AddScoped<IReceiptService, ReceiptService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "It Step final Project", Version = "v1" });
    opt.AddSecurityDefinition("auth", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.ApiKey,
        Name = "Authorization",
        In = ParameterLocation.Header,
        Description = "Enter token there"
    });
    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
{
    {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Auth"
            }
        },
        new string[] { }
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
            ValidAudience = "https://localhost:7049",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("65E255FF-F399-42D4-9C7F-D5D08B0EC285")),
        };
    });

builder.Services.AddCors(options =>
{
    options.AddPolicy("RequestPipeline",
        builder =>
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            builder.WithOrigins("https://localhost:7049")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
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