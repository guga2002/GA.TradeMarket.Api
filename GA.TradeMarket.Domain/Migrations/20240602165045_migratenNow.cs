using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class migratenNow : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardHolderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    CategoryName = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    ProductName = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Carrier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    { "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 0, new DateTime(2002, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "762047f7-5309-45e8-8661-adb3dc7eaf86", "aapkhazava22@gmail.com", true, false, null, "Guga", "AAPKHAZAVA22@GMAIL.COM", "GUGAADMIN", "AQAAAAIAAYagAAAAEIrsoSaYg3KvtX0awWxhPbe7m7nHG+IohW1gLT3ZtbUuip/e4BUepGUkIU5QH1wibA==", "599042047", true, "226354a5-86f5-4fbb-82c4-4e1fb6765a32", " Apkhazava", false, "gugaadmin" },
                    { "1", 0, new DateTime(1992, 6, 2, 20, 50, 44, 607, DateTimeKind.Local).AddTicks(520), "dadbfaad-68b4-4638-80e4-fcd02d68756c", "demetris.hackett@terry.co.uk", false, false, null, "Ledner", null, null, null, "979-320-2769", false, "7a43f6ca-3e10-403e-907f-25f2492f1a73", "Stroman", false, "robbie" },
                    { "2", 0, new DateTime(2005, 6, 2, 20, 50, 44, 607, DateTimeKind.Local).AddTicks(4644), "2ae8d3b8-1c90-496e-9141-8ccf5b6bbbb0", "nels@beier.ca", false, false, null, "Hudson", null, null, null, "200-470-7431", false, "fc7f983c-5be9-4f1f-ad91-ce99c1441e5c", "Rempel", false, "stevie" },
                    { "3", 0, new DateTime(1991, 6, 2, 20, 50, 44, 607, DateTimeKind.Local).AddTicks(7399), "441be1e7-e100-405f-81b3-fb345b1f0629", "jerrell@abbott.ca", false, false, null, "Larson", null, null, null, "322.424.7200", false, "a7d526b8-7887-40ce-81e2-153e83489038", "Vandervort", false, "claudia" },
                    { "4", 0, new DateTime(1977, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(420), "63695683-22b5-45b3-9083-68c0b642bae8", "luigi_lowe@gleason.us", false, false, null, "Lemke", null, null, null, "694.489.8196", false, "6da8d0b0-e519-4f6f-b149-d5bee0d9f2b8", "Crist", false, "paxton" }
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Code", "DiscountValue", "ExpiryDate" },
                values: new object[,]
                {
                    { 1L, "1ECXM6uGpc1AWbwfi8tsqy7Sk543392", 251m, new DateTime(2025, 10, 14, 20, 50, 44, 606, DateTimeKind.Local).AddTicks(7812) },
                    { 2L, "319jQa6JnhmCb3G4wiRz57d8LZF61591", 118m, new DateTime(2024, 12, 7, 20, 50, 44, 606, DateTimeKind.Local).AddTicks(7902) },
                    { 3L, "3245izVNvjFr78oMZCsf1hGbgW6xuEcnS19689", 345m, new DateTime(2025, 5, 15, 20, 50, 44, 606, DateTimeKind.Local).AddTicks(7938) },
                    { 4L, "1ATarmkGMfjVKNPb4cz89s2YCJQ6EXueW96298", 101m, new DateTime(2024, 8, 13, 20, 50, 44, 606, DateTimeKind.Local).AddTicks(8006) },
                    { 5L, "1dRVhzT18EQDiu5Y2k3LpUvgSZJBb7Xs76317", 281m, new DateTime(2025, 1, 21, 20, 50, 44, 606, DateTimeKind.Local).AddTicks(8042) },
                    { 6L, "3zomMWHGtsd62wC5S8nQbpyJiBTj19K48243", 208m, new DateTime(2025, 1, 18, 20, 50, 44, 606, DateTimeKind.Local).AddTicks(8074) },
                    { 7L, "12PuEGMHnKBdbXtyzNLsfFJRkQ4w973xrD72406", 395m, new DateTime(2024, 7, 5, 20, 50, 44, 606, DateTimeKind.Local).AddTicks(8105) },
                    { 8L, "1DvqfRnd6rXzCP5bhV9isGK2xcN55869", 178m, new DateTime(2025, 6, 26, 20, 50, 44, 606, DateTimeKind.Local).AddTicks(8142) }
                });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "Buy", "Currency", "LogTime", "Sell" },
                values: new object[] { 1L, 1.0m, "GEL", new DateTime(2024, 6, 2, 20, 50, 44, 604, DateTimeKind.Local).AddTicks(4706), 1.0m });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[,]
                {
                    { 1L, "175", "Personal Loan Account", "6706884457305044", new DateTime(2032, 6, 2, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(108) },
                    { 2L, "154", "Savings Account", "6449-4571-1642-1205", new DateTime(2033, 6, 2, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(468) },
                    { 3L, "345", "Auto Loan Account", "503815698648563020", new DateTime(2028, 6, 2, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(790) },
                    { 4L, "574", "Credit Card Account", "4894-2067-4629-7468", new DateTime(2033, 6, 2, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(1157) },
                    { 5L, "478", "Home Loan Account", "5178-4231-3870-8234", new DateTime(2033, 6, 2, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(1428) },
                    { 6L, "193", "Home Loan Account", "6759-8819-1566-5528", new DateTime(2031, 6, 2, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(1710) },
                    { 7L, "439", "Credit Card Account", "6304551465062455", new DateTime(2027, 6, 2, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(1947) },
                    { 8L, "930", "Checking Account", "6771-8942-1375-2157", new DateTime(2028, 6, 2, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(2208) },
                    { 9L, "389", "Money Market Account", "6011-9648-0896-3285", new DateTime(2027, 6, 2, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(2511) },
                    { 10L, "636", "Personal Loan Account", "6706506511959173", new DateTime(2027, 6, 2, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(2771) },
                    { 11L, "593", "Checking Account", "4472746450979", new DateTime(2032, 6, 2, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3027) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1L, "Garden" },
                    { 2L, "Kids" },
                    { 3L, "Industrial" },
                    { 4L, "Garden" },
                    { 5L, "Movies" },
                    { 6L, "Sports" },
                    { 7L, "Computers" },
                    { 8L, "Books" },
                    { 9L, "Grocery" },
                    { 10L, "Tools" }
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
                    { 1L, 121m, new DateTime(2024, 3, 30, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(1961), "1" },
                    { 2L, 275m, new DateTime(2024, 3, 27, 7, 50, 44, 608, DateTimeKind.Local).AddTicks(1967), "2" },
                    { 3L, 557m, new DateTime(2023, 11, 9, 1, 50, 44, 608, DateTimeKind.Local).AddTicks(1969), "3" },
                    { 4L, 632m, new DateTime(2023, 10, 1, 23, 50, 44, 608, DateTimeKind.Local).AddTicks(1970), "4" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Price", "ProductCategoryId", "ProductName" },
                values: new object[,]
                {
                    { 1L, 0.9769139255852110m, 1L, "Sleek Steel Fish" },
                    { 2L, 0.2423756411080440m, 2L, "Small Fresh Soap" },
                    { 3L, 0.1095439796749350m, 3L, "Licensed Plastic Pants" },
                    { 4L, 0.1169930684884530m, 4L, "Rustic Soft Shoes" },
                    { 5L, 0.8513664257818320m, 5L, "Tasty Wooden Shoes" },
                    { 6L, 0.2769163344326630m, 6L, "Generic Cotton Sausages" },
                    { 7L, 0.8311701554633210m, 7L, "Handmade Rubber Shoes" },
                    { 8L, 0.8998930107807970m, 8L, "Intelligent Concrete Towels" },
                    { 9L, 0.3341109826597690m, 9L, "Generic Steel Chips" },
                    { 10L, 0.01023621663870960m, 1L, "Fantastic Fresh Car" },
                    { 11L, 0.137799080294620m, 3L, "Practical Wooden Pizza" },
                    { 12L, 0.8920679190394550m, 4L, "Sleek Plastic Mouse" },
                    { 13L, 0.3634897011449230m, 3L, "Refined Soft Table" },
                    { 14L, 0.7307625576318240m, 6L, "Incredible Wooden Car" },
                    { 15L, 0.8240924372551390m, 1L, "Handcrafted Concrete Salad" },
                    { 16L, 0.4843404616576110m, 2L, "Refined Soft Bike" },
                    { 17L, 0.2468174403920780m, 3L, "Awesome Steel Cheese" },
                    { 18L, 0.8707581461816520m, 4L, "Small Concrete Fish" },
                    { 19L, 0.4849513374842890m, 5L, "Incredible Cotton Hat" },
                    { 20L, 0.4152807967773790m, 6L, "Fantastic Rubber Chair" },
                    { 21L, 0.7115973332096360m, 7L, "Fantastic Cotton Keyboard" },
                    { 22L, 0.008043071655095550m, 8L, "Awesome Steel Chair" },
                    { 23L, 0.9136845613360820m, 9L, "Licensed Concrete Tuna" },
                    { 24L, 0.7571008862779890m, 1L, "Handcrafted Cotton Hat" },
                    { 25L, 0.1580135870880490m, 3L, "Handmade Steel Keyboard" },
                    { 26L, 0.1249321068579620m, 4L, "Tasty Frozen Shirt" },
                    { 27L, 0.8880735782472570m, 3L, "Unbranded Wooden Computer" },
                    { 28L, 0.2581431965011270m, 6L, "Tasty Fresh Pizza" }
                });

            migrationBuilder.InsertData(
                table: "Bonuses",
                columns: new[] { "Id", "CustomerId", "EnrollmentDate", "Points" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(1997, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2117), 655 },
                    { 2L, 2L, new DateTime(2021, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2120), 107 },
                    { 3L, 2L, new DateTime(2018, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2122), 289 },
                    { 4L, 3L, new DateTime(2017, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2123), 967 },
                    { 5L, 4L, new DateTime(2016, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2125), 667 },
                    { 6L, 1L, new DateTime(2019, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2127), 788 },
                    { 7L, 1L, new DateTime(2003, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2128), 319 },
                    { 8L, 2L, new DateTime(2021, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2130), 585 },
                    { 9L, 3L, new DateTime(1995, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2131), 758 },
                    { 10L, 2L, new DateTime(2014, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2133), 172 },
                    { 11L, 4L, new DateTime(2002, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2134), 481 },
                    { 12L, 1L, new DateTime(2023, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2136), 832 },
                    { 13L, 2L, new DateTime(2019, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2137), 368 },
                    { 14L, 4L, new DateTime(2011, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2139), 275 },
                    { 15L, 2L, new DateTime(2001, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2140), 617 },
                    { 16L, 2L, new DateTime(2006, 6, 2, 20, 50, 44, 608, DateTimeKind.Local).AddTicks(2141), 854 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Message", "NotificationDate", "UserId" },
                values: new object[,]
                {
                    { 1L, "doloribus", new DateTime(2024, 5, 27, 17, 50, 44, 610, DateTimeKind.Local).AddTicks(2896), 1L },
                    { 2L, "Repellendus alias dolore illo maiores accusamus. Aut qui quo sed. Praesentium explicabo voluptatum debitis recusandae est consequatur.", new DateTime(2024, 5, 8, 20, 50, 44, 610, DateTimeKind.Local).AddTicks(2948), 2L },
                    { 3L, "Fuga rem asperiores animi quaerat. Quae et quae repudiandae suscipit eos. Explicabo alias quam facere quos aliquid. Sint aut ut. Aut et doloribus voluptatem saepe eos voluptatum. Eos quibusdam sint vitae ex consectetur.", new DateTime(2024, 5, 30, 13, 50, 44, 610, DateTimeKind.Local).AddTicks(3156), 3L },
                    { 4L, "Ea enim error.", new DateTime(2024, 5, 3, 1, 50, 44, 610, DateTimeKind.Local).AddTicks(3281), 4L },
                    { 5L, "Quam dolore placeat ut.", new DateTime(2024, 4, 24, 2, 50, 44, 610, DateTimeKind.Local).AddTicks(3300), 1L },
                    { 6L, "Minus quam impedit ex dolorem est et.", new DateTime(2024, 5, 5, 12, 50, 44, 610, DateTimeKind.Local).AddTicks(3316), 2L },
                    { 7L, "Perferendis magnam temporibus rem perspiciatis illum.", new DateTime(2024, 5, 2, 19, 50, 44, 610, DateTimeKind.Local).AddTicks(3373), 3L },
                    { 8L, "Atque est quia dicta fugiat incidunt rerum.\nAmet necessitatibus et sint fugiat velit.", new DateTime(2024, 5, 19, 0, 50, 44, 610, DateTimeKind.Local).AddTicks(3397), 4L },
                    { 9L, "Quis ut et fugiat.", new DateTime(2024, 5, 20, 7, 50, 44, 610, DateTimeKind.Local).AddTicks(3445), 1L }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "Status" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2024, 5, 19, 20, 50, 44, 610, DateTimeKind.Local).AddTicks(3723), "Done" },
                    { 2L, 2L, new DateTime(2024, 5, 12, 20, 50, 44, 610, DateTimeKind.Local).AddTicks(3726), "Decline" },
                    { 3L, 3L, new DateTime(2024, 5, 22, 20, 50, 44, 610, DateTimeKind.Local).AddTicks(3728), "Done" },
                    { 4L, 2L, new DateTime(2024, 5, 5, 20, 50, 44, 610, DateTimeKind.Local).AddTicks(3729), "processing" },
                    { 5L, 3L, new DateTime(2024, 5, 16, 20, 50, 44, 610, DateTimeKind.Local).AddTicks(3730), "Done" },
                    { 6L, 4L, new DateTime(2024, 5, 27, 20, 50, 44, 610, DateTimeKind.Local).AddTicks(3732), "Sent" },
                    { 7L, 2L, new DateTime(2024, 5, 8, 20, 50, 44, 610, DateTimeKind.Local).AddTicks(3733), "done" },
                    { 8L, 1L, new DateTime(2024, 5, 13, 20, 50, 44, 610, DateTimeKind.Local).AddTicks(3734), "Done" },
                    { 9L, 4L, new DateTime(2024, 5, 8, 20, 50, 44, 610, DateTimeKind.Local).AddTicks(3735), "Done" },
                    { 10L, 2L, new DateTime(2024, 6, 1, 20, 50, 44, 610, DateTimeKind.Local).AddTicks(3737), "done" },
                    { 11L, 1L, new DateTime(2024, 5, 13, 20, 50, 44, 610, DateTimeKind.Local).AddTicks(3738), "Done" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CustomerId", "ProductId", "Rating", "ReviewDate", "ReviewText" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, 3, new DateTime(2024, 5, 18, 20, 50, 44, 620, DateTimeKind.Local).AddTicks(7505), "Earum praesentium dolore adipisci quod voluptatibus aliquid perferendis.\nDolorum quos voluptate alias non." },
                    { 2L, 2L, 2L, 5, new DateTime(2024, 4, 9, 20, 50, 44, 620, DateTimeKind.Local).AddTicks(7614), "Et reprehenderit aperiam totam ullam tempora impedit iste non expedita.\nLaborum eos ullam.\nEos dolores sunt nobis." },
                    { 3L, 3L, 3L, 4, new DateTime(2024, 5, 10, 20, 50, 44, 620, DateTimeKind.Local).AddTicks(7755), "reprehenderit" },
                    { 4L, 2L, 4L, 3, new DateTime(2024, 5, 31, 20, 50, 44, 620, DateTimeKind.Local).AddTicks(7760), "Voluptates quia soluta." },
                    { 5L, 2L, 5L, 2, new DateTime(2024, 4, 29, 20, 50, 44, 620, DateTimeKind.Local).AddTicks(7775), "sint" },
                    { 6L, 1L, 6L, 4, new DateTime(2024, 4, 28, 20, 50, 44, 620, DateTimeKind.Local).AddTicks(7780), "amet" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "OrderId", "PaymentDate", "PaymentMethod", "paymentMethodId" },
                values: new object[,]
                {
                    { 1L, 557m, 1L, new DateTime(2024, 5, 10, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3270), "ATM", 1L },
                    { 2L, 970m, 2L, new DateTime(2024, 5, 26, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3276), "ATM", 2L },
                    { 3L, 79m, 3L, new DateTime(2024, 5, 11, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3277), "ATM", 3L },
                    { 4L, 161m, 4L, new DateTime(2024, 5, 30, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3279), "ATM", 4L },
                    { 5L, 109m, 5L, new DateTime(2024, 5, 29, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3281), "ATM", 5L },
                    { 6L, 540m, 1L, new DateTime(2024, 5, 13, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3283), "ATM", 6L },
                    { 7L, 204m, 3L, new DateTime(2024, 5, 10, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3285), "ATM", 7L },
                    { 8L, 336m, 2L, new DateTime(2024, 5, 24, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3287), "ATM", 8L },
                    { 9L, 340m, 3L, new DateTime(2024, 5, 10, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3289), "ATM", 1L },
                    { 10L, 152m, 4L, new DateTime(2024, 5, 28, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3291), "ATM", 3L },
                    { 11L, 654m, 5L, new DateTime(2024, 5, 21, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3292), "ATM", 2L },
                    { 12L, 201m, 2L, new DateTime(2024, 5, 16, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3294), "ATM", 4L },
                    { 13L, 306m, 3L, new DateTime(2024, 5, 7, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3295), "ATM", 5L },
                    { 14L, 39m, 1L, new DateTime(2024, 5, 18, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3297), "ATM", 6L },
                    { 15L, 90m, 6L, new DateTime(2024, 5, 7, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3299), "ATM", 7L },
                    { 16L, 433m, 7L, new DateTime(2024, 5, 27, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3300), "ATM", 4L },
                    { 17L, 736m, 4L, new DateTime(2024, 5, 16, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3302), "ATM", 5L },
                    { 18L, 139m, 3L, new DateTime(2024, 5, 18, 20, 50, 44, 612, DateTimeKind.Local).AddTicks(3304), "ATM", 3L }
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
                    { 1L, 1L, "Minima doloremque alias laudantium ut doloribus et nemo doloribus qui. Ut sint ab et quos recusandae. Reprehenderit impedit et. Neque molestias fugiat odit. Tenetur magni iure maiores et. Ducimus consectetur qui et et voluptatem placeat exercitationem suscipit.", new DateTime(2024, 5, 3, 20, 50, 44, 619, DateTimeKind.Local).AddTicks(2171), "Active" },
                    { 2L, 2L, "Blanditiis quae architecto ut minus porro.", new DateTime(2024, 2, 23, 20, 50, 44, 619, DateTimeKind.Local).AddTicks(2459), "Passed" },
                    { 3L, 3L, "Adipisci nostrum dolor sint rerum non nihil libero.\nVeritatis corporis qui ut qui dolor ducimus repudiandae ea.\nEos autem corporis quisquam sed dolore suscipit.\nIpsa maxime repellendus qui qui molestias vel autem occaecati.\nQuaerat voluptatum sed accusantium.\nLibero eveniet ab nemo illum error.", new DateTime(2024, 5, 13, 20, 50, 44, 619, DateTimeKind.Local).AddTicks(2485), "Declined" }
                });

            migrationBuilder.InsertData(
                table: "Shippings",
                columns: new[] { "Id", "Carrier", "OrderId", "ShippingDate", "Status", "TrackingNumber" },
                values: new object[,]
                {
                    { 1L, "3w2pbxZi8SVrNKhqmXydPQ5FGauAgLW", 1L, new DateTime(2024, 5, 29, 20, 50, 44, 622, DateTimeKind.Local).AddTicks(2742), "Sent from abroad", "FQTOTJF1818" },
                    { 2L, "18kTWZSGzgypXsR3LjNvQif7D2rMn", 2L, new DateTime(2024, 5, 28, 20, 50, 44, 622, DateTimeKind.Local).AddTicks(2873), "Recieved from abroad", "LWZABSI1" },
                    { 3L, "1R8i9ZaHyJrL4hoF6EtjKxQvpdDez5cSm1", 3L, new DateTime(2024, 4, 18, 20, 50, 44, 622, DateTimeKind.Local).AddTicks(2979), "recieve in sorting centre", "TZQECXZ1941" },
                    { 4L, "3WF4z9yCc8o6knbwDQKAjRatMLY2", 4L, new DateTime(2024, 4, 18, 20, 50, 44, 622, DateTimeKind.Local).AddTicks(3115), "delivered", "CBPIINR1" },
                    { 5L, "3nXFaJcfmqd58D2pzQWLY4w1UbuxHTiK", 5L, new DateTime(2024, 5, 30, 20, 50, 44, 622, DateTimeKind.Local).AddTicks(3178), "Unsuccesfull delivery", "IDZUPRL1861" },
                    { 6L, "1xiag3Pu2Fkv4JyndCGes8VKTz5ScmQ", 6L, new DateTime(2024, 5, 22, 20, 50, 44, 622, DateTimeKind.Local).AddTicks(3380), "recieved", "ZDIOCSI1" },
                    { 7L, "1154Q3aVEedxCzFZAJtyL98snUY", 7L, new DateTime(2024, 4, 7, 20, 50, 44, 622, DateTimeKind.Local).AddTicks(3422), "boxing", "XNBOMDY1" }
                });

            migrationBuilder.InsertData(
                table: "ReceiptDetails",
                columns: new[] { "ProductId", "ReceiptId", "DiscountUnitPrice", "Id", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1L, 1L, 240m, 1L, 57, 382.88m },
                    { 1L, 5L, 582m, 6L, 85, 329.27m },
                    { 2L, 2L, 683m, 7L, 12, 126.55m },
                    { 2L, 3L, 864m, 2L, 17, 95.94m },
                    { 3L, 2L, 268m, 3L, 19, 335.26m },
                    { 3L, 3L, 542m, 8L, 51, 818.98m },
                    { 4L, 2L, 460m, 9L, 14, 406.30m },
                    { 4L, 3L, 592m, 4L, 98, 291.09m },
                    { 5L, 3L, 898m, 10L, 62, 909.43m },
                    { 5L, 4L, 644m, 5L, 96, 517.81m }
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
