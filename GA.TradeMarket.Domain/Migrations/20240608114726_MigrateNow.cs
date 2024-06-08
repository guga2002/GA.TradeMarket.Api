using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class MigrateNow : Migration
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
                    IsSeen = table.Column<bool>(type: "bit", nullable: false),
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
                    { "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 0, new DateTime(2002, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "4e018283-84b1-4f71-b357-c83a8d3198e7", "guram.apkhazava908@ens.tsu.ge", true, false, null, "Guga", "guram.apkhazava908@ens.tsu.ge", "Guga13guga", "AQAAAAIAAYagAAAAECzJPfeOrrgQ/mEuZCtdk5zzoIJACCRbHv6aqFkzUsVACgsG4KfmT3ka9hgzx0TKfg==", "599042047", true, "a50b72b4-a239-40c5-9bec-61963df74908", " Apkhazava", false, "Guga13guga" },
                    { "1", 0, new DateTime(1971, 6, 8, 15, 47, 25, 676, DateTimeKind.Local).AddTicks(2052), "812ec7e0-3eff-4675-a11e-5e4857117cef", "asa@upton.com", false, false, null, "Davis", null, null, null, "(486)050-5601 x270", false, "19f104e8-5aa0-4e5b-8d57-07b90d9b435f", "Grant", false, "alayna_ryan" },
                    { "2", 0, new DateTime(1993, 6, 8, 15, 47, 25, 676, DateTimeKind.Local).AddTicks(5325), "073eeba5-964c-4b49-bbe2-87e0ea87211a", "paige@ryanrempel.name", false, false, null, "Heaney", null, null, null, "320.399.9859", false, "0abfd361-44ee-46a8-93ed-34070f0c8334", "Okuneva", false, "zoey.wolff" },
                    { "3", 0, new DateTime(1969, 6, 8, 15, 47, 25, 676, DateTimeKind.Local).AddTicks(8331), "eb3ac95a-46a3-450a-bd5c-99271e2db70d", "gwendolyn@cronasatterfield.info", false, false, null, "Bosco", null, null, null, "(288)976-3076 x160", false, "e18757fe-4f59-4cbc-a2da-00f974874c14", "Wunsch", false, "lennie.effertz" },
                    { "4", 0, new DateTime(2009, 6, 8, 15, 47, 25, 677, DateTimeKind.Local).AddTicks(1899), "0cfb3cb3-93f4-48fe-954e-b02c5c080713", "reed.prosacco@schumm.biz", false, false, null, "Rutherford", null, null, null, "1-880-162-8684", false, "13638485-aa01-484e-b9bc-a129fb5d64d7", "Pfeffer", false, "skye.welch" },
                    { "5", 0, new DateTime(1994, 6, 8, 15, 47, 25, 677, DateTimeKind.Local).AddTicks(5048), "9fb90562-5de5-40b8-a777-c24d20853e11", "nayeli.hamill@kuphalcorwin.biz", false, false, null, "Lebsack", null, null, null, "(632)680-3635", false, "1f255fff-4623-40ca-8ef4-bbec6684cf5a", "Parisian", false, "mia" },
                    { "6", 0, new DateTime(2003, 6, 8, 15, 47, 25, 677, DateTimeKind.Local).AddTicks(8317), "2ca74fef-c5d6-4498-97a3-b62f7eda431c", "dax@beatty.uk", false, false, null, "Carroll", null, null, null, "354-678-0064 x809", false, "c1907c7c-bf0e-4190-8971-3a827b0cfb65", "Rath", false, "lou" },
                    { "7", 0, new DateTime(2006, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(1149), "b932f5ed-11f0-4d2e-91d1-2ab8d6f347bf", "minerva@adams.ca", false, false, null, "Rath", null, null, null, "1-568-960-6125 x0345", false, "982f9ee3-4810-49ee-930d-40055ce02c45", "McCullough", false, "dovie_ferry" },
                    { "8", 0, new DateTime(1976, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(4445), "2a208d77-0439-4d80-8c7b-4db0ec48d108", "wyman.borer@mcglynnkiehn.com", false, false, null, "Homenick", null, null, null, "1-811-494-1863", false, "7b9ad071-3d44-48d3-b115-306fdade489e", "D'Amore", false, "meaghan" }
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Code", "DiscountValue", "ExpiryDate" },
                values: new object[,]
                {
                    { 1L, "32fzWqaXSrEDAbecKJm5VLT6ZnY22489", 148m, new DateTime(2025, 4, 14, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9228) },
                    { 2L, "3r1GupTfiymaNFHkgBZbwMUq9zv6R8En99296", 356m, new DateTime(2024, 12, 17, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9324) },
                    { 3L, "1Me35tikaqf4BhGN9cPw1yxTjsEZL72025", 204m, new DateTime(2024, 12, 4, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9359) },
                    { 4L, "1a5HEwDUi3eSPkcugbrXsJ7zVM948F51572", 208m, new DateTime(2024, 12, 19, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9413) },
                    { 5L, "35znDhY98JTdE3GZVwR6NjvtyAW85120", 196m, new DateTime(2025, 5, 1, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9445) },
                    { 6L, "3XMRzrNf7sLtGEKhe4CSowqacBiDZpn171095", 209m, new DateTime(2025, 6, 17, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9474) },
                    { 7L, "1HENaTG1gcMYKhsAUnquv79rSXpbCj4Vt83103", 396m, new DateTime(2024, 9, 6, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9507) },
                    { 8L, "1yw6ip1Hh7DFZxVzRB9QuqftMA259696", 100m, new DateTime(2025, 8, 5, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9541) },
                    { 9L, "1bGYa7hQ8JXSK3io4q6WcszfFjrmwE97066", 123m, new DateTime(2025, 6, 15, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9569) },
                    { 10L, "1gN6xMmUupzGaPqi2YhtS8ETCWj5v61176", 380m, new DateTime(2025, 3, 10, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9599) },
                    { 11L, "3nYeAcTi9Pbyu1sVJtLB5vGWxq35216", 305m, new DateTime(2025, 1, 13, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9630) },
                    { 12L, "3rU64m8dgDN9Cw5T7i2enWMXckBGHbV50928", 100m, new DateTime(2025, 8, 29, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9743) },
                    { 13L, "1ZbJV8dpC6tgDosELPUqm4STaHRXW2Fhw61754", 367m, new DateTime(2025, 10, 6, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9776) },
                    { 14L, "1imSEocFNekBQt7qwDpHaRJgL48dUZ94159", 203m, new DateTime(2024, 11, 19, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9809) },
                    { 15L, "1aUVMC4pBqJ9wj3Z7W1yPdD6hKmk31705", 133m, new DateTime(2025, 8, 14, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9839) },
                    { 16L, "3vfJHKzNonbc16C2MwkS3d8jWB7588951", 318m, new DateTime(2025, 4, 24, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9869) }
                });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "Buy", "Currency", "LogTime", "Sell" },
                values: new object[] { 1L, 1.0m, "GEL", new DateTime(2024, 6, 8, 15, 47, 25, 673, DateTimeKind.Local).AddTicks(6462), 1.0m });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[,]
                {
                    { 1L, "853", "Mac Ullrich", "4091-0430-1072-9798", new DateTime(2028, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(4846) },
                    { 2L, "412", "Candace Emmerich", "6767-2531-7454-9671-399", new DateTime(2030, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(5183) },
                    { 3L, "324", "Fausto Klein", "3529-6406-2408-9735", new DateTime(2031, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(5494) },
                    { 4L, "892", "Maida Tremblay", "6759-1447-0415-8700-38", new DateTime(2032, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(5875) },
                    { 5L, "560", "Clifford Marquardt", "4340467248775", new DateTime(2031, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(6153) },
                    { 6L, "874", "Nat Torphy", "6767-3353-6851-9879-37", new DateTime(2031, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(6493) },
                    { 7L, "295", "Demetris White", "6399-6981-3821-4637", new DateTime(2033, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(6850) },
                    { 8L, "840", "Stefan Beatty", "3787-217336-96319", new DateTime(2033, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(7154) },
                    { 9L, "402", "Amparo Connelly", "6480-6245-7808-1022-7970", new DateTime(2033, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(7542) },
                    { 10L, "178", "Bud Mann", "3542-9048-0207-4908", new DateTime(2031, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(7876) },
                    { 11L, "595", "Sean Christiansen", "6378-7639-1089-6632", new DateTime(2029, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(8167) },
                    { 12L, "713", "Clement Hyatt", "6371-7072-8372-2328", new DateTime(2029, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(8457) },
                    { 13L, "392", "Mariana Boyle", "6767-2910-2156-8033-15", new DateTime(2030, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(8834) },
                    { 14L, "672", "Guadalupe Hahn", "3053-613906-8537", new DateTime(2030, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(9151) },
                    { 15L, "643", "Keshawn Prosacco", "6767-0234-7748-9134", new DateTime(2030, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(9387) },
                    { 16L, "338", "Antonette O'Kon", "6771-8947-5867-6811", new DateTime(2026, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(9711) },
                    { 17L, "602", "Ola Wolff", "3719-814363-60095", new DateTime(2026, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(9972) },
                    { 18L, "000", "Cleora Gutmann", "6767-2917-9614-9195-413", new DateTime(2031, 6, 8, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(246) },
                    { 19L, "542", "Anahi Kemmer", "6381-3931-0214-8686", new DateTime(2029, 6, 8, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(528) },
                    { 20L, "437", "Abraham Kling", "5020951754450285", new DateTime(2031, 6, 8, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(836) },
                    { 21L, "254", "Sonia Cummerata", "3529-8199-9607-3432", new DateTime(2029, 6, 8, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1095) },
                    { 22L, "882", "Gerhard Gleason", "3756-980509-55838", new DateTime(2030, 6, 8, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1381) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1L, "Health" },
                    { 2L, "Shoes" },
                    { 3L, "Baby" },
                    { 4L, "Tools" },
                    { 5L, "Grocery" },
                    { 6L, "Books" },
                    { 7L, "Outdoors" },
                    { 8L, "Health" },
                    { 9L, "Home" },
                    { 10L, "Kids" },
                    { 11L, "Toys" },
                    { 12L, "Garden" },
                    { 13L, "Games" },
                    { 14L, "Toys" },
                    { 15L, "Garden" },
                    { 16L, "Clothing" },
                    { 17L, "Health" },
                    { 18L, "Music" },
                    { 19L, "Home" },
                    { 20L, "Music" }
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
                    { 1L, 425m, new DateTime(2023, 5, 28, 16, 47, 25, 678, DateTimeKind.Local).AddTicks(5987), "1" },
                    { 2L, 763m, new DateTime(2023, 6, 10, 13, 47, 25, 678, DateTimeKind.Local).AddTicks(5990), "2" },
                    { 3L, 824m, new DateTime(2024, 5, 15, 2, 47, 25, 678, DateTimeKind.Local).AddTicks(5992), "3" },
                    { 4L, 542m, new DateTime(2023, 5, 1, 0, 47, 25, 678, DateTimeKind.Local).AddTicks(5993), "4" },
                    { 5L, 103m, new DateTime(2023, 8, 30, 13, 47, 25, 678, DateTimeKind.Local).AddTicks(6042), "5" },
                    { 6L, 598m, new DateTime(2023, 10, 17, 0, 47, 25, 678, DateTimeKind.Local).AddTicks(6044), "6" },
                    { 7L, 116m, new DateTime(2024, 2, 27, 0, 47, 25, 678, DateTimeKind.Local).AddTicks(6046), "7" },
                    { 8L, 770m, new DateTime(2023, 9, 3, 11, 47, 25, 678, DateTimeKind.Local).AddTicks(6047), "02174cf0–9412–4cfe - afbf - 59f706d72cf6" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Price", "ProductCategoryId", "ProductName" },
                values: new object[,]
                {
                    { 1L, 764.29m, 1L, "Rustic Plastic Bacon" },
                    { 2L, 983.33m, 2L, "Practical Granite Salad" },
                    { 3L, 259.88m, 3L, "Unbranded Concrete Bike" },
                    { 4L, 237.72m, 4L, "Ergonomic Metal Chicken" },
                    { 5L, 803.82m, 5L, "Generic Rubber Mouse" },
                    { 6L, 651.92m, 6L, "Refined Fresh Fish" },
                    { 7L, 616.15m, 7L, "Fantastic Rubber Table" },
                    { 8L, 446.36m, 8L, "Awesome Concrete Sausages" },
                    { 9L, 25.19m, 9L, "Gorgeous Metal Gloves" },
                    { 10L, 261.01m, 1L, "Rustic Fresh Towels" },
                    { 11L, 876.04m, 3L, "Rustic Wooden Salad" },
                    { 12L, 54.38m, 4L, "Fantastic Steel Hat" },
                    { 13L, 114.35m, 3L, "Intelligent Fresh Hat" },
                    { 14L, 21.92m, 6L, "Small Frozen Mouse" },
                    { 15L, 654.00m, 11L, "Intelligent Fresh Tuna" },
                    { 16L, 390.39m, 12L, "Gorgeous Fresh Shirt" },
                    { 17L, 459.20m, 13L, "Incredible Steel Ball" },
                    { 18L, 886.35m, 14L, "Rustic Fresh Soap" },
                    { 19L, 158.65m, 15L, "Intelligent Cotton Salad" },
                    { 20L, 681.98m, 16L, "Sleek Granite Salad" },
                    { 21L, 381.80m, 17L, "Small Frozen Mouse" },
                    { 22L, 284.46m, 8L, "Awesome Steel Salad" },
                    { 23L, 128.11m, 9L, "Tasty Plastic Mouse" },
                    { 24L, 148.46m, 14L, "Licensed Wooden Computer" },
                    { 25L, 304.65m, 13L, "Incredible Metal Chips" },
                    { 26L, 505.11m, 4L, "Handmade Granite Sausages" },
                    { 27L, 982.04m, 3L, "Tasty Frozen Pizza" },
                    { 28L, 621.44m, 6L, "Incredible Cotton Keyboard" },
                    { 29L, 810.13m, 1L, "Small Soft Cheese" },
                    { 30L, 999.30m, 2L, "Handcrafted Cotton Hat" },
                    { 31L, 457.89m, 3L, "Unbranded Cotton Fish" },
                    { 32L, 910.37m, 4L, "Incredible Rubber Ball" },
                    { 33L, 82.74m, 5L, "Licensed Steel Bacon" },
                    { 34L, 648.96m, 6L, "Tasty Plastic Soap" },
                    { 35L, 512.78m, 7L, "Handcrafted Concrete Soap" },
                    { 36L, 656.64m, 8L, "Gorgeous Metal Computer" },
                    { 37L, 483.74m, 9L, "Incredible Cotton Shirt" },
                    { 38L, 118.55m, 1L, "Tasty Steel Bike" },
                    { 39L, 392.67m, 11L, "Rustic Cotton Chips" },
                    { 40L, 342.32m, 14L, "Intelligent Frozen Chips" },
                    { 41L, 160.08m, 3L, "Awesome Granite Car" },
                    { 42L, 8.46m, 6L, "Rustic Metal Sausages" },
                    { 43L, 952.38m, 15L, "Practical Granite Sausages" },
                    { 44L, 414.74m, 2L, "Refined Steel Chicken" },
                    { 45L, 680.08m, 18L, "Ergonomic Fresh Salad" },
                    { 46L, 163.65m, 4L, "Generic Frozen Ball" },
                    { 47L, 490.97m, 15L, "Licensed Cotton Shoes" },
                    { 48L, 195.46m, 19L, "Ergonomic Fresh Salad" },
                    { 49L, 608.05m, 20L, "Ergonomic Fresh Cheese" },
                    { 50L, 2.55m, 8L, "Fantastic Concrete Sausages" },
                    { 51L, 292.47m, 14L, "Refined Concrete Chicken" },
                    { 52L, 628.21m, 13L, "Sleek Metal Shirt" },
                    { 53L, 432.92m, 19L, "Intelligent Wooden Chair" },
                    { 54L, 192.06m, 16L, "Licensed Steel Gloves" },
                    { 55L, 144.83m, 11L, "Small Wooden Shoes" },
                    { 56L, 335.16m, 13L, "Practical Frozen Chair" }
                });

            migrationBuilder.InsertData(
                table: "Bonuses",
                columns: new[] { "Id", "CustomerId", "EnrollmentDate", "Points" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2007, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6167), 980 },
                    { 2L, 2L, new DateTime(1995, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6169), 171 },
                    { 3L, 2L, new DateTime(2023, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6171), 392 },
                    { 4L, 3L, new DateTime(2011, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6172), 658 },
                    { 5L, 4L, new DateTime(1997, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6174), 939 },
                    { 6L, 1L, new DateTime(1995, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6176), 338 },
                    { 7L, 1L, new DateTime(2023, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6177), 123 },
                    { 8L, 2L, new DateTime(2011, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6179), 849 },
                    { 9L, 3L, new DateTime(2004, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6180), 901 },
                    { 10L, 2L, new DateTime(1996, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6182), 136 },
                    { 11L, 4L, new DateTime(2023, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6184), 382 },
                    { 12L, 1L, new DateTime(2002, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6185), 594 },
                    { 13L, 2L, new DateTime(2020, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6187), 637 },
                    { 14L, 4L, new DateTime(2007, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6188), 438 },
                    { 15L, 2L, new DateTime(1999, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6191), 514 },
                    { 16L, 2L, new DateTime(2023, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6192), 169 },
                    { 17L, 5L, new DateTime(2023, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6193), 766 },
                    { 18L, 6L, new DateTime(2021, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6195), 799 },
                    { 19L, 7L, new DateTime(2022, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6197), 873 },
                    { 20L, 8L, new DateTime(1999, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6199), 821 },
                    { 21L, 4L, new DateTime(2005, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6200), 726 },
                    { 22L, 5L, new DateTime(1999, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6201), 217 },
                    { 23L, 6L, new DateTime(2000, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6203), 595 },
                    { 24L, 8L, new DateTime(2003, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6205), 172 },
                    { 25L, 7L, new DateTime(2006, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6206), 755 },
                    { 26L, 4L, new DateTime(2015, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6208), 714 },
                    { 27L, 5L, new DateTime(2021, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6209), 533 },
                    { 28L, 2L, new DateTime(2014, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6211), 753 },
                    { 29L, 8L, new DateTime(1997, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6212), 432 },
                    { 30L, 7L, new DateTime(1997, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6214), 795 },
                    { 31L, 2L, new DateTime(2002, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6215), 924 },
                    { 32L, 6L, new DateTime(2003, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6218), 405 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "IsSeen", "Message", "NotificationDate", "UserId" },
                values: new object[,]
                {
                    { 1L, false, "laudantium", new DateTime(2024, 5, 3, 20, 47, 25, 680, DateTimeKind.Local).AddTicks(5801), 1L },
                    { 2L, false, "quod", new DateTime(2024, 5, 31, 1, 47, 25, 680, DateTimeKind.Local).AddTicks(5852), 2L },
                    { 3L, false, "perferendis", new DateTime(2024, 6, 2, 6, 47, 25, 680, DateTimeKind.Local).AddTicks(5859), 3L },
                    { 4L, false, "Aperiam dolores ipsa sint neque quaerat id deserunt. Nulla sit eveniet voluptatem ut natus consectetur ea corrupti. Ex ut excepturi. Consequuntur distinctio dolore sed voluptatibus quia. Sit nihil a non eum et. Non ipsam praesentium quia adipisci iusto.", new DateTime(2024, 5, 16, 6, 47, 25, 680, DateTimeKind.Local).AddTicks(5864), 4L },
                    { 5L, false, "aliquam", new DateTime(2024, 5, 11, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(6120), 1L },
                    { 6L, false, "Odit dicta repellat omnis aut placeat adipisci.", new DateTime(2024, 5, 10, 12, 47, 25, 680, DateTimeKind.Local).AddTicks(6126), 2L },
                    { 7L, false, "iste", new DateTime(2024, 6, 1, 8, 47, 25, 680, DateTimeKind.Local).AddTicks(6152), 3L },
                    { 8L, false, "sed", new DateTime(2024, 5, 6, 20, 47, 25, 680, DateTimeKind.Local).AddTicks(6157), 4L },
                    { 9L, false, "Deleniti sunt molestiae perspiciatis dolor nisi pariatur molestiae. Voluptatibus ullam iste cum ipsum dolores. Molestiae incidunt sint facere vitae. Placeat at totam est iste delectus. Ut quaerat voluptate qui quis atque.", new DateTime(2024, 5, 22, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(6162), 5L },
                    { 10L, false, "Repellendus dolore explicabo aut aut reiciendis consequuntur.", new DateTime(2024, 5, 28, 10, 47, 25, 680, DateTimeKind.Local).AddTicks(6324), 6L },
                    { 11L, false, "incidunt", new DateTime(2024, 5, 24, 1, 47, 25, 680, DateTimeKind.Local).AddTicks(6349), 7L },
                    { 12L, false, "Est aut enim nam illum aut saepe molestias dolorem adipisci.\nIpsum sunt adipisci quia reprehenderit accusamus quaerat sint.\nCorrupti ut et ea.\nQuibusdam quisquam voluptas aut adipisci dicta inventore ipsa delectus ut.", new DateTime(2024, 5, 4, 3, 47, 25, 680, DateTimeKind.Local).AddTicks(6353), 8L },
                    { 13L, false, "blanditiis", new DateTime(2024, 5, 11, 12, 47, 25, 680, DateTimeKind.Local).AddTicks(6579), 4L },
                    { 14L, false, "Nihil saepe facilis iure quam autem ut.", new DateTime(2024, 6, 5, 10, 47, 25, 680, DateTimeKind.Local).AddTicks(6585), 6L },
                    { 15L, false, "Non numquam minus quia. Laudantium ipsum a alias ea iste perferendis harum voluptates. Provident nihil et aut commodi. Sed asperiores et reiciendis voluptate distinctio ea recusandae ipsa. Dolores rerum et esse deleniti libero sed et.", new DateTime(2024, 6, 6, 6, 47, 25, 680, DateTimeKind.Local).AddTicks(6612), 7L },
                    { 16L, false, "Repudiandae ipsa similique in tempore possimus et.", new DateTime(2024, 6, 7, 17, 47, 25, 680, DateTimeKind.Local).AddTicks(6785), 6L },
                    { 17L, false, "Nobis magni aspernatur.\nAut inventore maiores culpa dolores et enim deserunt.\nMagnam est aut sit quis et incidunt harum.\nPossimus maiores officia voluptatem et mollitia ut.\nHic omnis culpa cumque qui.", new DateTime(2024, 5, 24, 21, 47, 25, 680, DateTimeKind.Local).AddTicks(6812), 4L },
                    { 18L, false, "Deleniti commodi tempora ex unde.\nDicta amet sit est similique et vitae.\nMolestiae quae itaque repudiandae vel tempora.\nNostrum asperiores non omnis et quo molestiae quis.", new DateTime(2024, 5, 15, 11, 47, 25, 680, DateTimeKind.Local).AddTicks(6911), 8L }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "Status" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2024, 5, 17, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7270), "Done" },
                    { 2L, 2L, new DateTime(2024, 6, 6, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7273), "Decline" },
                    { 3L, 3L, new DateTime(2024, 5, 23, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7274), "Done" },
                    { 4L, 2L, new DateTime(2024, 5, 16, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7275), "processing" },
                    { 5L, 3L, new DateTime(2024, 5, 17, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7277), "Done" },
                    { 6L, 4L, new DateTime(2024, 5, 16, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7278), "Sent" },
                    { 7L, 2L, new DateTime(2024, 5, 25, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7279), "done" },
                    { 8L, 1L, new DateTime(2024, 5, 31, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7281), "Done" },
                    { 9L, 4L, new DateTime(2024, 5, 22, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7282), "Done" },
                    { 10L, 2L, new DateTime(2024, 6, 4, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7283), "done" },
                    { 11L, 1L, new DateTime(2024, 5, 11, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7285), "Done" },
                    { 12L, 5L, new DateTime(2024, 5, 22, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7286), "Done" },
                    { 13L, 6L, new DateTime(2024, 6, 7, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7288), "Decline" },
                    { 14L, 7L, new DateTime(2024, 6, 6, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7289), "Done" },
                    { 15L, 2L, new DateTime(2024, 5, 29, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7290), "processing" },
                    { 16L, 8L, new DateTime(2024, 5, 14, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7292), "Done" },
                    { 17L, 5L, new DateTime(2024, 5, 29, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7293), "done" },
                    { 18L, 2L, new DateTime(2024, 6, 5, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7294), "done" },
                    { 19L, 7L, new DateTime(2024, 5, 12, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7296), "Sent" },
                    { 20L, 6L, new DateTime(2024, 6, 1, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7297), "Done" },
                    { 21L, 7L, new DateTime(2024, 6, 5, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7298), "Processing" },
                    { 22L, 8L, new DateTime(2024, 5, 24, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7300), "Done" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CustomerId", "ProductId", "Rating", "ReviewDate", "ReviewText" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, 3, new DateTime(2024, 5, 24, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(2438), "Amet tenetur tempora iure nulla. Ut aut a delectus quis quibusdam eaque. Mollitia molestiae cupiditate maiores autem tempora." },
                    { 2L, 2L, 2L, 5, new DateTime(2024, 4, 15, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(2624), "Aspernatur et eius quo commodi in deleniti. Reprehenderit dolorem quam. Praesentium tempore possimus qui quia molestiae et sapiente animi ullam." },
                    { 3L, 3L, 3L, 4, new DateTime(2024, 5, 16, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(2750), "Amet ut explicabo voluptatum ut velit dolorem. Expedita molestiae veritatis sint rerum laboriosam recusandae qui sit nulla. Sit vitae et et magni mollitia nesciunt sed sit atque. Debitis rerum qui odit totam est. Quod voluptate cumque culpa voluptas eos vitae expedita dolorum consequatur." },
                    { 4L, 2L, 4L, 3, new DateTime(2024, 6, 6, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(2900), "Expedita harum facere dolores qui. Officiis eum optio qui harum voluptatem. Aperiam laudantium voluptatem ut quos dolores fugit illo accusamus consequuntur. Quo asperiores assumenda. Enim possimus libero eaque. Rerum aliquid aut." },
                    { 5L, 2L, 5L, 2, new DateTime(2024, 5, 5, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(3039), "Eveniet consequatur non id commodi molestiae molestiae aut. Sapiente incidunt veritatis consequatur voluptas libero dolor. Excepturi est laborum alias ut excepturi minima ex. Est in optio aut nobis aut tenetur voluptas fugiat suscipit. Non odio ut rerum quis laboriosam et eveniet reprehenderit dolores. Nostrum est officia modi voluptatum alias hic." },
                    { 6L, 1L, 6L, 4, new DateTime(2024, 5, 4, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(3225), "Molestias atque quis optio facere." },
                    { 7L, 5L, 11L, 3, new DateTime(2024, 5, 24, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(3243), "provident" },
                    { 8L, 6L, 12L, 5, new DateTime(2024, 4, 15, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(3249), "Sint at quod magni pariatur ad excepturi ea omnis labore." },
                    { 9L, 7L, 7L, 4, new DateTime(2024, 5, 16, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(3279), "quibusdam" },
                    { 10L, 8L, 13L, 3, new DateTime(2024, 6, 6, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(3284), "Ut est ipsum voluptatem voluptas eius." }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "OrderId", "PaymentDate", "PaymentMethod", "paymentMethodId" },
                values: new object[,]
                {
                    { 1L, 880m, 1L, new DateTime(2024, 5, 25, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1614), "ATM", 1L },
                    { 2L, 792m, 2L, new DateTime(2024, 5, 21, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1619), "Mobile Bank", 2L },
                    { 3L, 189m, 3L, new DateTime(2024, 6, 3, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1621), "ATM", 3L },
                    { 4L, 784m, 4L, new DateTime(2024, 5, 21, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1623), "Credit card", 4L },
                    { 5L, 654m, 5L, new DateTime(2024, 6, 5, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1625), "ATM", 5L },
                    { 6L, 651m, 1L, new DateTime(2024, 6, 3, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1627), "Visa Card", 6L },
                    { 7L, 720m, 3L, new DateTime(2024, 5, 18, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1629), "ATM", 7L },
                    { 8L, 969m, 2L, new DateTime(2024, 5, 25, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1631), "Mobile Bank", 8L },
                    { 9L, 393m, 3L, new DateTime(2024, 5, 27, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1633), "ATM", 1L },
                    { 10L, 637m, 4L, new DateTime(2024, 5, 18, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1635), "Visa Card", 3L },
                    { 11L, 54m, 5L, new DateTime(2024, 5, 16, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1637), "ATM", 2L },
                    { 12L, 326m, 2L, new DateTime(2024, 5, 28, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1639), "Master Card", 4L },
                    { 13L, 813m, 3L, new DateTime(2024, 5, 23, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1640), "ATM", 5L },
                    { 14L, 675m, 1L, new DateTime(2024, 5, 21, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1642), "ATM", 6L },
                    { 15L, 951m, 6L, new DateTime(2024, 5, 10, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1644), "Wallet", 7L },
                    { 16L, 32m, 7L, new DateTime(2024, 5, 28, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1646), "ATM", 4L },
                    { 17L, 867m, 4L, new DateTime(2024, 5, 21, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1647), "Apple pay", 5L },
                    { 18L, 562m, 3L, new DateTime(2024, 5, 12, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1649), "ATM", 3L }
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
                    { 10L, false, 1L },
                    { 11L, false, 1L },
                    { 12L, true, 14L },
                    { 13L, false, 13L },
                    { 14L, true, 17L },
                    { 15L, false, 18L },
                    { 16L, false, 19L },
                    { 17L, true, 20L },
                    { 18L, false, 21L },
                    { 19L, true, 9L },
                    { 20L, false, 20L }
                });

            migrationBuilder.InsertData(
                table: "ReturnRequests",
                columns: new[] { "Id", "OrderId", "Reason", "RequestDate", "Status" },
                values: new object[,]
                {
                    { 1L, 1L, "odio", new DateTime(2024, 5, 9, 15, 47, 25, 689, DateTimeKind.Local).AddTicks(8135), "Active" },
                    { 2L, 2L, "ut", new DateTime(2024, 2, 29, 15, 47, 25, 689, DateTimeKind.Local).AddTicks(8183), "Passed" },
                    { 3L, 3L, "Laborum odit asperiores omnis.", new DateTime(2024, 5, 19, 15, 47, 25, 689, DateTimeKind.Local).AddTicks(8191), "Declined" },
                    { 4L, 4L, "Esse recusandae et commodi dolorum officiis.", new DateTime(2024, 5, 9, 15, 47, 25, 689, DateTimeKind.Local).AddTicks(8257), "Processing" },
                    { 5L, 5L, "Earum ea veritatis non facilis qui qui laudantium.", new DateTime(2024, 2, 29, 15, 47, 25, 689, DateTimeKind.Local).AddTicks(8283), "To be ready" },
                    { 6L, 6L, "aliquid", new DateTime(2024, 5, 19, 15, 47, 25, 689, DateTimeKind.Local).AddTicks(8315), "Archived" }
                });

            migrationBuilder.InsertData(
                table: "Shippings",
                columns: new[] { "Id", "Carrier", "OrderId", "ShippingDate", "Status", "TrackingNumber" },
                values: new object[,]
                {
                    { 1L, "33AKbiWwDSNvpq59R82GxuhBcVy7H", 1L, new DateTime(2024, 6, 4, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7610), "Sent from abroad", "CKWICII1" },
                    { 2L, "32kS6GtncXQHD3zhmdgTeFYiPMBRvsf", 2L, new DateTime(2024, 6, 3, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7764), "Recieved from abroad", "ITSOMSY1" },
                    { 3L, "17L2CeS8BaqyzHXnhuEoPgiQjxUMNtw6", 3L, new DateTime(2024, 4, 24, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7806), "recieve in sorting centre", "WJDUBOP1" },
                    { 4L, "39pvAsHNGtri1oxk3TKYCDQBz7W", 4L, new DateTime(2024, 4, 24, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7844), "delivered", "NFBEEAL1" },
                    { 5L, "3Nf4bB3ijeHT52AvSJpDXaUGKyWV", 5L, new DateTime(2024, 6, 5, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7878), "Unsuccesfull delivery", "JXUOBLP1252" },
                    { 6L, "11VUuTQziBD5eWm3xnGovsYyH42aFSt8ZR", 6L, new DateTime(2024, 5, 28, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7916), "recieved", "WEYOLYE1327" },
                    { 7L, "3YCN1R2sDrS9BTPobUdFLMHnXAhw4v", 7L, new DateTime(2024, 4, 13, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7960), "boxing", "KQLECAH1" }
                });

            migrationBuilder.InsertData(
                table: "ReceiptDetails",
                columns: new[] { "ProductId", "ReceiptId", "DiscountUnitPrice", "Id", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1L, 1L, 545m, 1L, 75, 556.25m },
                    { 1L, 5L, 433m, 6L, 44, 887.16m },
                    { 1L, 11L, 975m, 11L, 27, 1.85m },
                    { 1L, 15L, 612m, 16L, 56, 92.74m },
                    { 2L, 2L, 247m, 7L, 76, 999.32m },
                    { 2L, 3L, 577m, 2L, 70, 695.01m },
                    { 2L, 12L, 544m, 17L, 53, 672.46m },
                    { 2L, 13L, 562m, 12L, 45, 110.06m },
                    { 3L, 2L, 832m, 3L, 72, 647.47m },
                    { 3L, 3L, 246m, 8L, 15, 49.85m },
                    { 3L, 12L, 121m, 13L, 20, 541.97m },
                    { 3L, 13L, 557m, 18L, 24, 664.36m },
                    { 4L, 2L, 771m, 9L, 17, 170.67m },
                    { 4L, 3L, 67m, 4L, 22, 601.39m },
                    { 4L, 10L, 883m, 14L, 87, 83.65m },
                    { 4L, 12L, 242m, 19L, 92, 915.86m },
                    { 5L, 3L, 708m, 10L, 68, 417.57m },
                    { 5L, 4L, 538m, 5L, 79, 526.76m },
                    { 5L, 13L, 489m, 20L, 78, 412.98m },
                    { 5L, 14L, 147m, 15L, 16, 472.91m }
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
