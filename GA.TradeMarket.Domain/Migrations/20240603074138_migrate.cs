using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class migrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Currency = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Buy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sell = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LogTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CardHolderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OperationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_PersonId",
                        column: x => x.PersonId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bonuses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bonuses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Customers_UserId",
                        column: x => x.UserId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    paymentMethodId = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentMethods_paymentMethodId",
                        column: x => x.paymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    IsCheckedOut = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnRequests",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnRequests_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shippings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    TrackingNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Carrier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shippings_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptDetails",
                columns: table => new
                {
                    ReceiptId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptDetails", x => new { x.ProductId, x.ReceiptId });
                    table.ForeignKey(
                        name: "FK_ReceiptDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiptDetails_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "341743f0 - asd2–42de - afbf - 59kmkkmk72cf6", "341743f0 - asd2–42de - afbf - 59kmkkmk72cf6", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 0, new DateTime(2002, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "927c8b1f-4fa5-4cd2-9f5b-ab4107337f9a", "aapkhazava22@gmail.com", true, false, null, "Guga", "AAPKHAZAVA22@GMAIL.COM", "GUGAADMIN", "AQAAAAIAAYagAAAAEFo6Z24/XqJKLPJatRxYDr4a9qbTKOJHMHLpZDoKaO3ZKKimFqQ5qguPPMAE4w4oGA==", "599042047", true, "bfeab9ee-16bf-4621-89c9-3eafb856f928", " Apkhazava", false, "gugaadmin" },
                    { "1", 0, new DateTime(1978, 6, 3, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(8263), "402dda98-d6ab-442b-88cc-2a9cdebad8d3", "wilhelm@gorczany.name", false, false, null, "Dickens", null, null, null, "1-040-615-3177 x9410", false, "75788046-a24d-4d31-93a6-04eed62bffec", "Bartell", false, "rene" },
                    { "2", 0, new DateTime(2010, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(1542), "8c72a89e-505a-4368-a427-1b3e654944ca", "carter_grady@moen.uk", false, false, null, "Pouros", null, null, null, "529.852.8131", false, "c6e29e2c-4822-4371-9165-95cca2f532b0", "Keeling", false, "maymie.spencer" },
                    { "3", 0, new DateTime(2006, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(4624), "157f608b-0b48-4c91-9f1c-f886782b6301", "xavier@bodelindgren.biz", false, false, null, "Murphy", null, null, null, "(660)907-2031", false, "3ebb8cee-dcab-4a34-91f3-310257a54bdc", "Ruecker", false, "berneice" },
                    { "4", 0, new DateTime(1980, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(7612), "cd7c9ec2-7a12-4a8e-9233-f18fa90891e9", "cyrus@hermanvon.name", false, false, null, "Orn", null, null, null, "(806)707-4387 x17877", false, "6704b07a-3784-4274-847e-578f3955cd8f", "Swift", false, "garrison" }
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Code", "DiscountValue", "ExpiryDate" },
                values: new object[,]
                {
                    { 1L, "1uA6vTaJePcs82Lypwrxo4EYSX7n28045", 399m, new DateTime(2024, 9, 1, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(3845) },
                    { 2L, "16YqgVJQHLAmt7MKznsShRf5ejD2uTa83Ur71341", 301m, new DateTime(2024, 9, 12, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(3944) },
                    { 3L, "3ub7g8jaDSPBFTvZnKYG3eoq1kVmCEiAWX87548", 117m, new DateTime(2024, 7, 28, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(3984) },
                    { 4L, "1ZTLXgojScU4apeWEQtNFVdy3s89511", 201m, new DateTime(2025, 5, 3, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(4022) },
                    { 5L, "1T8sPEHkDWUCxRQXu4ApKcoFJejdYi23238", 292m, new DateTime(2025, 8, 23, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(4053) },
                    { 6L, "3r4KvbMDwzfJp7tqXL9gsyiFRoESYG47065", 175m, new DateTime(2025, 2, 10, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(4084) },
                    { 7L, "1pTZw4La36ft8NdyK2qrMWPJvniYjeXoQ977256", 101m, new DateTime(2025, 8, 25, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(4116) },
                    { 8L, "37toGN6eDqwWX5xafQLAgFKuVpdcBvE25242", 340m, new DateTime(2024, 12, 21, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(4183) }
                });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "Buy", "Currency", "LogTime", "Sell" },
                values: new object[] { 1L, 1.0m, "GEL", new DateTime(2024, 6, 3, 11, 41, 37, 957, DateTimeKind.Local).AddTicks(918), 1.0m });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[,]
                {
                    { 1L, "950", "Checking Account", "4730544558156", new DateTime(2028, 6, 3, 11, 41, 37, 964, DateTimeKind.Local).AddTicks(8298) },
                    { 2L, "833", "Auto Loan Account", "5893-5372-0419-8147", new DateTime(2029, 6, 3, 11, 41, 37, 964, DateTimeKind.Local).AddTicks(8842) },
                    { 3L, "809", "Credit Card Account", "6371-0774-8778-2712", new DateTime(2031, 6, 3, 11, 41, 37, 964, DateTimeKind.Local).AddTicks(9198) },
                    { 4L, "313", "Home Loan Account", "630480392961380395", new DateTime(2030, 6, 3, 11, 41, 37, 964, DateTimeKind.Local).AddTicks(9552) },
                    { 5L, "855", "Credit Card Account", "6398-1435-0157-0688", new DateTime(2033, 6, 3, 11, 41, 37, 964, DateTimeKind.Local).AddTicks(9831) },
                    { 6L, "064", "Auto Loan Account", "5496-3702-8837-9784", new DateTime(2028, 6, 3, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(119) },
                    { 7L, "004", "Checking Account", "5018-6006-4595-7586", new DateTime(2028, 6, 3, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(454) },
                    { 8L, "991", "Home Loan Account", "503857965446820103", new DateTime(2033, 6, 3, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(768) },
                    { 9L, "105", "Credit Card Account", "3025-327783-9998", new DateTime(2030, 6, 3, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1031) },
                    { 10L, "283", "Personal Loan Account", "6389-7027-5299-9200", new DateTime(2030, 6, 3, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1315) },
                    { 11L, "350", "Home Loan Account", "3672-941324-1516", new DateTime(2026, 6, 3, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1624) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1L, "Baby" },
                    { 2L, "Tools" },
                    { 3L, "Clothing" },
                    { 4L, "Tools" },
                    { 5L, "Clothing" },
                    { 6L, "Industrial" },
                    { 7L, "Beauty" },
                    { 8L, "Kids" },
                    { 9L, "Toys" },
                    { 10L, "Grocery" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "341743f0 - asd2–42de - afbf - 59kmkkmk72cf6", "02174cf0–9412–4cfe - afbf - 59f706d72cf6" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "DiscountValue", "OperationDate", "PersonId" },
                values: new object[,]
                {
                    { 1L, 137m, new DateTime(2023, 4, 30, 0, 41, 37, 960, DateTimeKind.Local).AddTicks(9061), "1" },
                    { 2L, 441m, new DateTime(2023, 6, 7, 2, 41, 37, 960, DateTimeKind.Local).AddTicks(9066), "2" },
                    { 3L, 674m, new DateTime(2024, 3, 29, 21, 41, 37, 960, DateTimeKind.Local).AddTicks(9068), "3" },
                    { 4L, 754m, new DateTime(2023, 12, 30, 0, 41, 37, 960, DateTimeKind.Local).AddTicks(9070), "4" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Price", "ProductCategoryId", "ProductName" },
                values: new object[,]
                {
                    { 1L, 0.0129699856136830m, 1L, "Intelligent Concrete Chips" },
                    { 2L, 0.3555568640360720m, 2L, "Intelligent Rubber Soap" },
                    { 3L, 0.004038397762760490m, 3L, "Intelligent Plastic Chicken" },
                    { 4L, 0.9992389100676840m, 4L, "Practical Steel Gloves" },
                    { 5L, 0.6683573599777520m, 5L, "Fantastic Metal Tuna" },
                    { 6L, 0.01730201501701980m, 6L, "Tasty Soft Keyboard" },
                    { 7L, 0.5359801440196420m, 7L, "Rustic Cotton Bike" },
                    { 8L, 0.435189068318830m, 8L, "Handmade Soft Towels" },
                    { 9L, 0.3674693376314080m, 9L, "Awesome Steel Fish" },
                    { 10L, 0.06900564782519450m, 1L, "Generic Cotton Keyboard" },
                    { 11L, 0.7886830890714540m, 3L, "Gorgeous Frozen Bike" },
                    { 12L, 0.1976677669688450m, 4L, "Unbranded Rubber Keyboard" },
                    { 13L, 0.5519519108423630m, 3L, "Handcrafted Frozen Table" },
                    { 14L, 0.4717061806907380m, 6L, "Sleek Wooden Chips" },
                    { 15L, 0.4640248442858550m, 1L, "Fantastic Wooden Chips" },
                    { 16L, 0.1042292973202090m, 2L, "Generic Metal Fish" },
                    { 17L, 0.2195606554307940m, 3L, "Small Plastic Computer" },
                    { 18L, 0.9467363243381990m, 4L, "Handcrafted Concrete Cheese" },
                    { 19L, 0.2839471388732690m, 5L, "Practical Granite Chips" },
                    { 20L, 0.3391831432528340m, 6L, "Handcrafted Concrete Sausages" },
                    { 21L, 0.72640342628690m, 7L, "Unbranded Granite Bike" },
                    { 22L, 0.0970971719747950m, 8L, "Tasty Cotton Car" },
                    { 23L, 0.8985232892851620m, 9L, "Fantastic Wooden Salad" },
                    { 24L, 0.603822614543830m, 1L, "Incredible Frozen Table" },
                    { 25L, 0.3251882754769910m, 3L, "Practical Concrete Mouse" },
                    { 26L, 0.7445148215674250m, 4L, "Gorgeous Soft Shoes" },
                    { 27L, 0.2887609816963020m, 3L, "Fantastic Wooden Chips" },
                    { 28L, 0.06970529727610560m, 6L, "Rustic Fresh Sausages" }
                });

            migrationBuilder.InsertData(
                table: "Bonuses",
                columns: new[] { "Id", "CustomerId", "EnrollmentDate", "Points" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2003, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9221), 818 },
                    { 2L, 2L, new DateTime(2006, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9226), 959 },
                    { 3L, 2L, new DateTime(1997, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9228), 863 },
                    { 4L, 3L, new DateTime(2018, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9229), 294 },
                    { 5L, 4L, new DateTime(2000, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9231), 264 },
                    { 6L, 1L, new DateTime(1999, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9233), 911 },
                    { 7L, 1L, new DateTime(1997, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9235), 232 },
                    { 8L, 2L, new DateTime(1999, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9237), 931 },
                    { 9L, 3L, new DateTime(2014, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9238), 975 },
                    { 10L, 2L, new DateTime(1997, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9240), 474 },
                    { 11L, 4L, new DateTime(2010, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9241), 526 },
                    { 12L, 1L, new DateTime(1998, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9243), 121 },
                    { 13L, 2L, new DateTime(2011, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9247), 541 },
                    { 14L, 4L, new DateTime(2014, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9249), 834 },
                    { 15L, 2L, new DateTime(2020, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9251), 768 },
                    { 16L, 2L, new DateTime(2008, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9253), 617 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Message", "NotificationDate", "UserId" },
                values: new object[,]
                {
                    { 1L, "Esse maxime ut nihil ullam ullam ratione facilis ut rerum. Qui nobis suscipit totam perferendis quis. Deserunt numquam in. Repudiandae consequuntur ex quis ipsam consequatur sit qui.", new DateTime(2024, 5, 4, 16, 41, 37, 962, DateTimeKind.Local).AddTicks(7286), 1L },
                    { 2L, "Eligendi voluptas modi architecto.\nLabore qui incidunt adipisci perferendis reprehenderit harum et voluptatem tenetur.\nIste voluptatum et sit et nobis dolorem mollitia nesciunt.", new DateTime(2024, 4, 23, 12, 41, 37, 962, DateTimeKind.Local).AddTicks(7503), 2L },
                    { 3L, "Veritatis est sit et esse.\nBeatae aut pariatur vero totam.\nAssumenda reprehenderit tenetur reprehenderit optio enim exercitationem eum eius corrupti.", new DateTime(2024, 5, 23, 15, 41, 37, 962, DateTimeKind.Local).AddTicks(7622), 3L },
                    { 4L, "consequatur", new DateTime(2024, 5, 20, 0, 41, 37, 962, DateTimeKind.Local).AddTicks(7693), 4L },
                    { 5L, "Delectus dolores porro voluptates perspiciatis aspernatur.\nMolestiae facere ut illo vero.\nEa quam vitae.\nEa aspernatur maxime laudantium.\nEst consequuntur tempora aut quibusdam.\nRerum numquam pariatur voluptatem ut sequi harum eaque enim.", new DateTime(2024, 5, 9, 10, 41, 37, 962, DateTimeKind.Local).AddTicks(7701), 1L },
                    { 6L, "Aut et eum non saepe molestiae.\nBeatae molestiae possimus quia modi debitis illo.\nSequi autem a id beatae provident eos nemo.\nRerum voluptas dignissimos quas voluptatibus ratione sed.", new DateTime(2024, 5, 9, 10, 41, 37, 962, DateTimeKind.Local).AddTicks(7843), 2L },
                    { 7L, "Quam rerum ipsa.", new DateTime(2024, 4, 28, 0, 41, 37, 962, DateTimeKind.Local).AddTicks(7930), 3L },
                    { 8L, "mollitia", new DateTime(2024, 5, 18, 10, 41, 37, 962, DateTimeKind.Local).AddTicks(7945), 4L },
                    { 9L, "Quasi ab consectetur laudantium aliquid ea modi sit amet dolorum.", new DateTime(2024, 5, 19, 4, 41, 37, 962, DateTimeKind.Local).AddTicks(7949), 1L }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "Status" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2024, 5, 5, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8235), "Done" },
                    { 2L, 2L, new DateTime(2024, 6, 2, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8239), "Decline" },
                    { 3L, 3L, new DateTime(2024, 5, 13, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8240), "Done" },
                    { 4L, 2L, new DateTime(2024, 5, 12, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8241), "processing" },
                    { 5L, 3L, new DateTime(2024, 5, 14, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8243), "Done" },
                    { 6L, 4L, new DateTime(2024, 5, 23, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8244), "Sent" },
                    { 7L, 2L, new DateTime(2024, 5, 7, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8245), "done" },
                    { 8L, 1L, new DateTime(2024, 5, 15, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8246), "Done" },
                    { 9L, 4L, new DateTime(2024, 5, 5, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8248), "Done" },
                    { 10L, 2L, new DateTime(2024, 5, 26, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8249), "done" },
                    { 11L, 1L, new DateTime(2024, 5, 24, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8250), "Done" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CustomerId", "ProductId", "Rating", "ReviewDate", "ReviewText" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, 3, new DateTime(2024, 5, 19, 11, 41, 37, 972, DateTimeKind.Local).AddTicks(8309), "error" },
                    { 2L, 2L, 2L, 5, new DateTime(2024, 4, 10, 11, 41, 37, 972, DateTimeKind.Local).AddTicks(8345), "distinctio" },
                    { 3L, 3L, 3L, 4, new DateTime(2024, 5, 11, 11, 41, 37, 972, DateTimeKind.Local).AddTicks(8352), "Quos voluptatem saepe delectus ut labore non vero earum provident." },
                    { 4L, 2L, 4L, 3, new DateTime(2024, 6, 1, 11, 41, 37, 972, DateTimeKind.Local).AddTicks(8423), "veritatis" },
                    { 5L, 2L, 5L, 2, new DateTime(2024, 4, 30, 11, 41, 37, 972, DateTimeKind.Local).AddTicks(8430), "Maiores culpa exercitationem.\nFugit optio consectetur modi asperiores libero illum nihil natus excepturi." },
                    { 6L, 1L, 6L, 4, new DateTime(2024, 4, 29, 11, 41, 37, 972, DateTimeKind.Local).AddTicks(8490), "odit" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "OrderId", "PaymentDate", "PaymentMethod", "paymentMethodId" },
                values: new object[,]
                {
                    { 1L, 173m, 1L, new DateTime(2024, 5, 13, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1876), "ATM", 1L },
                    { 2L, 61m, 2L, new DateTime(2024, 5, 18, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1882), "ATM", 2L },
                    { 3L, 128m, 3L, new DateTime(2024, 5, 26, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1884), "ATM", 3L },
                    { 4L, 678m, 4L, new DateTime(2024, 5, 8, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1886), "ATM", 4L },
                    { 5L, 672m, 5L, new DateTime(2024, 5, 28, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2018), "ATM", 5L },
                    { 6L, 482m, 1L, new DateTime(2024, 5, 19, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2022), "ATM", 6L },
                    { 7L, 261m, 3L, new DateTime(2024, 5, 8, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2025), "ATM", 7L },
                    { 8L, 211m, 2L, new DateTime(2024, 5, 11, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2026), "ATM", 8L },
                    { 9L, 710m, 3L, new DateTime(2024, 5, 9, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2028), "ATM", 1L },
                    { 10L, 958m, 4L, new DateTime(2024, 5, 21, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2030), "ATM", 3L },
                    { 11L, 633m, 5L, new DateTime(2024, 5, 26, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2032), "ATM", 2L },
                    { 12L, 932m, 2L, new DateTime(2024, 5, 7, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2034), "ATM", 4L },
                    { 13L, 416m, 3L, new DateTime(2024, 5, 7, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2035), "ATM", 5L },
                    { 14L, 900m, 1L, new DateTime(2024, 5, 17, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2037), "ATM", 6L },
                    { 15L, 531m, 6L, new DateTime(2024, 5, 20, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2039), "ATM", 7L },
                    { 16L, 761m, 7L, new DateTime(2024, 5, 17, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2041), "ATM", 4L },
                    { 17L, 153m, 4L, new DateTime(2024, 5, 20, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2042), "ATM", 5L },
                    { 18L, 470m, 3L, new DateTime(2024, 5, 27, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2044), "ATM", 3L }
                });

            migrationBuilder.InsertData(
                table: "Receipts",
                columns: new[] { "Id", "IsCheckedOut", "OrderId" },
                values: new object[,]
                {
                    { 1L, false, 1L },
                    { 2L, true, 2L },
                    { 3L, false, 3L },
                    { 4L, true, 1L },
                    { 5L, false, 4L },
                    { 6L, false, 3L },
                    { 7L, true, 2L },
                    { 8L, false, 3L },
                    { 9L, true, 2L },
                    { 10L, false, 1L }
                });

            migrationBuilder.InsertData(
                table: "ReturnRequests",
                columns: new[] { "Id", "OrderId", "Reason", "RequestDate", "Status" },
                values: new object[,]
                {
                    { 1L, 1L, "et", new DateTime(2024, 5, 4, 11, 41, 37, 971, DateTimeKind.Local).AddTicks(2926), "Active" },
                    { 2L, 2L, "Nesciunt similique ea culpa amet.\nDelectus sequi quisquam molestias.\nVitae voluptas facere qui nemo atque quidem aut velit.\nFugit nobis totam ab vel.\nEum et sit et quia asperiores quod sed.", new DateTime(2024, 2, 24, 11, 41, 37, 971, DateTimeKind.Local).AddTicks(2969), "Passed" },
                    { 3L, 3L, "Quo esse possimus aperiam assumenda inventore nulla error nihil officia. Similique maxime consequuntur. Nam ratione quo ipsa est. Dicta esse alias rem.", new DateTime(2024, 5, 14, 11, 41, 37, 971, DateTimeKind.Local).AddTicks(3202), "Declined" }
                });

            migrationBuilder.InsertData(
                table: "Shippings",
                columns: new[] { "Id", "Carrier", "OrderId", "ShippingDate", "Status", "TrackingNumber" },
                values: new object[,]
                {
                    { 1L, "3E12ri7yQcJqszWNpgekj8YS9P", 1L, new DateTime(2024, 5, 30, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3574), "Sent from abroad", "UMNOCST1002" },
                    { 2L, "354kuJ3EqV1nTYHfZzRvPgoMeyw68xXAms", 2L, new DateTime(2024, 5, 29, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3675), "Recieved from abroad", "TRQUAMZ1312" },
                    { 3L, "1hun13QVGrke9JSa2AgE65bTwoR", 3L, new DateTime(2024, 4, 19, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3720), "recieve in sorting centre", "HVUUPYY1152" },
                    { 4L, "1UkzPVheqvGo3jLfZdcrHS1pJw", 4L, new DateTime(2024, 4, 19, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3758), "delivered", "OLPAGLN1" },
                    { 5L, "1XrYBoDE8LZKzJWQ6ahnAjMewuy", 5L, new DateTime(2024, 5, 31, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3825), "Unsuccesfull delivery", "FDKIAXV1" },
                    { 6L, "3HQrbCGkB7n8icapgeFofDP1LXEy", 6L, new DateTime(2024, 5, 23, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3924), "recieved", "CFDEPTR1" },
                    { 7L, "3kNFtKXbYDuox43Lj2v8a69SefZiJWhrpz1", 7L, new DateTime(2024, 4, 8, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3960), "boxing", "LOFUTNH1106" }
                });

            migrationBuilder.InsertData(
                table: "ReceiptDetails",
                columns: new[] { "ProductId", "ReceiptId", "DiscountUnitPrice", "Id", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1L, 1L, 495m, 1L, 62, 151.82m },
                    { 1L, 5L, 450m, 6L, 23, 305.67m },
                    { 2L, 2L, 204m, 7L, 28, 186.24m },
                    { 2L, 3L, 179m, 2L, 87, 29.04m },
                    { 3L, 2L, 984m, 3L, 73, 640.80m },
                    { 3L, 3L, 335m, 8L, 58, 886.01m },
                    { 4L, 2L, 842m, 9L, 73, 558.88m },
                    { 4L, 3L, 799m, 4L, 76, 239.86m },
                    { 5L, 3L, 127m, 10L, 56, 812.47m },
                    { 5L, 4L, 561m, 5L, 63, 966.92m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bonuses_CustomerId",
                table: "Bonuses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DiscountValue",
                table: "Customers",
                column: "DiscountValue",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_OperationDate",
                table: "Customers",
                column: "OperationDate",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PersonId",
                table: "Customers",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderDate",
                table: "Orders",
                column: "OrderDate",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_paymentMethodId",
                table: "Payments",
                column: "paymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryName",
                table: "ProductCategories",
                column: "CategoryName",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Price",
                table: "Products",
                column: "Price",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductName",
                table: "Products",
                column: "ProductName",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptDetails_DiscountUnitPrice",
                table: "ReceiptDetails",
                column: "DiscountUnitPrice",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptDetails_Quantity",
                table: "ReceiptDetails",
                column: "Quantity",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptDetails_ReceiptId",
                table: "ReceiptDetails",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptDetails_UnitPrice",
                table: "ReceiptDetails",
                column: "UnitPrice",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_IsCheckedOut",
                table: "Receipts",
                column: "IsCheckedOut",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_OrderId",
                table: "Receipts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnRequests_OrderId",
                table: "ReturnRequests",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Shippings_OrderId",
                table: "Shippings",
                column: "OrderId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bonuses");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "ExchangeRates");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ReceiptDetails");

            migrationBuilder.DropTable(
                name: "ReturnRequests");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Shippings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
