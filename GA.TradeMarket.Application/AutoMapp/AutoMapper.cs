using AutoMapper;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Domain.Entitites;

namespace GA.TradeMarket.Application.AutoMapp
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<Person, PersonModel>()
                .ReverseMap();

            CreateMap<Receipt, ReceiptModel>()
            .ForMember(dest => dest.ReceiptDetailsIds, opt => opt.MapFrom(src => src.ReceiptDetails.Select(rd => rd.Id)))
             .ReverseMap();

            CreateMap<Product, ProductModel>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ForMember(dest => dest.ReceiptDetailIds, opt => opt.MapFrom(src => src.ReceiptDetails.Select(rd => rd.Id)));

            CreateMap<ProductModel, Product>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => new ProductCategory { CategoryName = src.CategoryName })) 
                .ForMember(dest => dest.ReceiptDetails, opt => opt.Ignore());

            CreateMap<ReceiptDetail, ReceiptDetailModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DiscountUnitPrice, opt => opt.MapFrom(src => src.DiscountUnitPrice))
                .ForMember(dest => dest.ReceiptId, opt => opt.MapFrom(src => src.ReceiptId))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity));

            CreateMap<ReceiptDetailModel, ReceiptDetail>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ReceiptId, opt => opt.MapFrom(src => src.ReceiptId))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.DiscountUnitPrice, opt => opt.MapFrom(src => src.DiscountUnitPrice))
                .ForMember(dest => dest.Receipt, opt => opt.Ignore())
                .ForMember(dest => dest.Product, opt => opt.Ignore());

            CreateMap<Customer, CustomerModel>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Person.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Person.Surname))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.Person.BirthDate))
                .ForMember(dest => dest.DiscountValue, opt => opt.MapFrom(src => src.DiscountValue))
                .ForMember(dest => dest.ReceiptsIds, opt => opt.MapFrom(src => src.Reviews.Select(r => r.Id)));

            CreateMap<CustomerModel, Customer>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForPath(dest => dest.Person.Name, opt => opt.MapFrom(src => src.Name))
                .ForPath(dest => dest.Person.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForPath(dest => dest.Person.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
                .ForMember(dest => dest.DiscountValue, opt => opt.MapFrom(src => src.DiscountValue))
                .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.ReceiptsIds.Select(id => new Receipt { Id = id })));

            CreateMap<CustomerModel, Person>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate));

            CreateMap<Person, CustomerModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate));

            CreateMap<ProductCategory, ProductCategoryModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.ProductIds, opt => opt.MapFrom(src => src.Products.Select(p => p.Id)));

            CreateMap<ProductCategoryModel, ProductCategory>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.Products, opt => opt.Ignore());

            CreateMap<BonusProgram, BonusProgramModel>().ReverseMap();

            CreateMap<CouponModel, Coupon>().ReverseMap();

            CreateMap<Notification,NotificationModel>().ReverseMap();

            CreateMap<Order,OrderModel>().ReverseMap();

            CreateMap<PaymentMethodModel, PaymentMethod>().ReverseMap();

            CreateMap<PaymentModel, Payment>().ReverseMap();

            CreateMap<ReturnRequestModel,ReturnRequest>().ReverseMap();

            CreateMap<ReviewModel, Review>().ReverseMap();

            CreateMap<ShippingModel,Shipping>().ReverseMap();

            CreateMap<ExchangeRate,ExchangeRateModel>().ReverseMap();

        }

    }
}
