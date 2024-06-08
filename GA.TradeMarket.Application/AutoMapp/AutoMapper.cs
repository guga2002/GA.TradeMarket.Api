using AutoMapper;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.Models.RequestModels;
using GA.TradeMarket.Domain.Entitites;

namespace GA.TradeMarket.Application.AutoMapp
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {

            CreateMap<BonusProgram, BonusProgramModel>();
            CreateMap<BonusProgram, BonusProgramModelIn>().ReverseMap();

            CreateMap<Coupon, CouponModel>();
            CreateMap<CouponModelIn, Coupon>().ReverseMap();

            CreateMap<Notification,NotificationModel>();
            CreateMap<Notification, NotificationModelIn>().ReverseMap();

            CreateMap<Order,OrderModel>();
            CreateMap<Order, OrderModelIn>().ReverseMap();

            CreateMap<PaymentMethod, PaymentMethodModel>();
            CreateMap<PaymentMethodModelIn, PaymentMethod>().ReverseMap();

            CreateMap<Payment, PaymentModel>();
            CreateMap<PaymentModelIn, Payment>().ReverseMap();

            CreateMap<ReturnRequest, ReturnRequestModel>();
            CreateMap<ReturnRequestModelIn, ReturnRequest>().ReverseMap();

            CreateMap<Review, ReviewModel>();
            CreateMap<ReviewModelIn, Review>().ReverseMap();

            CreateMap<Shipping, ShippingModel>();
            CreateMap<ShippingModelIn, Shipping>().ReverseMap();

            CreateMap<ExchangeRate,ExchangeRateModel>().ReverseMap();

            CreateMap<Coupon, CouponModel>();
            CreateMap<CouponModelIn, Coupon>().ReverseMap();

            CreateMap<Customer, CustomerModel>();
            CreateMap<CustomerModelIn, Customer>().ReverseMap();
            CreateMap<Person, PersonModel>().ReverseMap();

            CreateMap<ProductCategory, ProductCategoryModel>();
            CreateMap<ProductCategory, ProductCategoryModelIn>().ReverseMap();

            CreateMap<Product, ProductModel>();
            CreateMap<Product, ProductModelIn>().ReverseMap();

            CreateMap<Receipt, ReceiptModel>();
            CreateMap<Receipt, ReceiptModelIn>().ReverseMap();

            CreateMap<ReceiptDetail, ReceiptDetailModel>();

            CreateMap<ReturnRequest, ReturnRequestModel>();
            CreateMap<ReturnRequest, ReturnRequestModelIn>().ReverseMap();


        }

    }
}
