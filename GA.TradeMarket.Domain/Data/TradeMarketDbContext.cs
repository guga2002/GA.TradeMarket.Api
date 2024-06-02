using GA.TradeMarket.Domain.Configurations;
using GA.TradeMarket.Domain.Entitites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GA.TradeMarket.Domain.Data
{
    public class TradeMarketDbContext(DbContextOptions<TradeMarketDbContext> bs) : IdentityDbContext<Person>(bs)
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ReceiptDetail> ReceiptsDetails { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<BonusProgram> Bonuses { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> paymentMethods { get; set; }
        public DbSet<ReturnRequest> returnRequest { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Shipping> Shippings { get; set; }

        public DbSet<ExchangeRate> ExhcnageRates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExchangeRateConfig());
            modelBuilder.ApplyConfiguration(new CouponConfig());
            modelBuilder.ApplyConfiguration(new PeopleConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new BonusProgramConfig());
            modelBuilder.ApplyConfiguration(new NotificationConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfig());
            modelBuilder.ApplyConfiguration(new PaymentConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ReceiptConfig());
            modelBuilder.ApplyConfiguration(new ReceiptDetailConfig());
            modelBuilder.ApplyConfiguration(new ReturmRequestConfig());
            modelBuilder.ApplyConfiguration(new ReviewConfig());
            modelBuilder.ApplyConfiguration(new ShipingConfig());

            Console.WriteLine("Aqvar");
            Random rand = new Random();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ReceiptDetail>()
                .HasKey(rd => new { rd.ProductId, rd.ReceiptId });

            modelBuilder.Entity<ReceiptDetail>()
                .HasOne(rd => rd.Product)
                .WithMany(p => p.ReceiptDetails)
                .HasForeignKey(rd => rd.ProductId);

            modelBuilder.Entity<ReceiptDetail>()
                .HasOne(rd => rd.Receipt)
                .WithMany(r => r.ReceiptDetails)
                .HasForeignKey(rd => rd.ReceiptId);

        }
    }

}
