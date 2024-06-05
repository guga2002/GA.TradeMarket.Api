using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class migrateNow : Migration
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
                    { "02174cf0–9412–4cfe - afbf - 59f706d72cf6", 0, new DateTime(2002, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "3ae4cb48-efb1-44ba-8dc3-19f8cad7b417", "aapkhazava22@gmail.com", true, false, null, "Guga", "AAPKHAZAVA22@GMAIL.COM", "GUGAADMIN", "AQAAAAIAAYagAAAAEF+ZrWAZ2Uf2gnK79tx8bWrI4W2vi7yRKCVxqrHQipG1ZaQVvb9jtGbNN38EaKF49Q==", "599042047", true, "b62596ec-53cd-4364-8b58-0c4a47a4fee3", " Apkhazava", false, "gugaadmin" },
                    { "1", 0, new DateTime(1991, 6, 5, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(9788), "cacf77a9-b257-435b-8f91-9cfc4af15f61", "madonna@bradtke.info", false, false, null, "Sipes", null, null, null, "1-587-236-8262", false, "1374e85e-67b0-46a3-97be-da8e83e36fc0", "Mitchell", false, "lavada.maggio" },
                    { "2", 0, new DateTime(2002, 6, 5, 19, 36, 18, 405, DateTimeKind.Local).AddTicks(3766), "a1c5816f-145b-4ce0-b619-99508a902ca8", "douglas_padberg@dooley.co.uk", false, false, null, "Jaskolski", null, null, null, "(076)831-5995 x863", false, "b96cfa6d-c354-40e7-9c2b-a7311b7cc94c", "Wisoky", false, "julius.herzog" },
                    { "3", 0, new DateTime(2000, 6, 5, 19, 36, 18, 405, DateTimeKind.Local).AddTicks(7343), "c3cbf39c-4840-46d5-847b-fbc364b3066b", "vern@walter.biz", false, false, null, "Hayes", null, null, null, "(665)270-0299 x747", false, "24f60a45-2327-4d78-a8bc-262215316e55", "Boehm", false, "kitty_mayer" },
                    { "4", 0, new DateTime(2007, 6, 5, 19, 36, 18, 406, DateTimeKind.Local).AddTicks(883), "b4911625-62a9-4bfd-8e54-47f531bdf88c", "fletcher@grady.co.uk", false, false, null, "Johnston", null, null, null, "361.030.9912", false, "bbf23632-952f-4c9b-9b91-131cb9b090b6", "Schroeder", false, "alek" },
                    { "5", 0, new DateTime(2010, 6, 5, 19, 36, 18, 406, DateTimeKind.Local).AddTicks(4030), "40db103e-d747-4e9a-a23c-1ae05c79119e", "kaycee.schaefer@altenwerth.biz", false, false, null, "Spinka", null, null, null, "1-110-974-6757 x261", false, "be8fc6d6-debe-4955-99ce-e0e9d9176d77", "Swaniawski", false, "reymundo" },
                    { "6", 0, new DateTime(1969, 6, 5, 19, 36, 18, 406, DateTimeKind.Local).AddTicks(7123), "0dc04606-8a43-4de1-9653-0716fc613fa2", "santos_maggio@mante.name", false, false, null, "Keebler", null, null, null, "177-687-1861", false, "66af753c-d4ae-41a5-ac43-09a103c258dc", "Bosco", false, "nikolas.daniel" },
                    { "7", 0, new DateTime(1973, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(441), "6a143355-630c-449c-bd8c-ff64815b1588", "courtney@cummingshagenes.ca", false, false, null, "Parisian", null, null, null, "(478)329-4762", false, "da2424b4-d1a1-40e4-8fa8-f112c79505fc", "McClure", false, "audrey" },
                    { "8", 0, new DateTime(1989, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(3814), "9606d08a-b5c6-4c19-85ca-37c9dbe20de5", "zoey.schamberger@flatleyskiles.name", false, false, null, "DuBuque", null, null, null, "126.590.7920 x336", false, "35b0a8a7-bf87-49d8-bff6-7e555e7452d5", "Price", false, "hulda" }
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Code", "DiscountValue", "ExpiryDate" },
                values: new object[,]
                {
                    { 1L, "3J2A5vK3awGmT8R9XZoPfkBVM7QH96788", 252m, new DateTime(2025, 5, 6, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(6888) },
                    { 2L, "1seUNCBgQ1XYTDx48omy35hSbZ9q87952", 267m, new DateTime(2025, 9, 19, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(6996) },
                    { 3L, "3Zu4KW9AFmxhgedpbTLrSVktcfJEG18438", 102m, new DateTime(2024, 6, 16, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7033) },
                    { 4L, "38vjEVoiw5KA4uPCb2kD1rWczQ6Z3qm9T25553", 233m, new DateTime(2025, 4, 5, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7066) },
                    { 5L, "1YfjGD4AECZo9zyXnuwriF2Lk7p3q91480", 152m, new DateTime(2024, 11, 6, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7104) },
                    { 6L, "1Gcndskz5KrZ1BHEpPfChxuVJ97Si4e60016", 245m, new DateTime(2024, 8, 29, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7138) },
                    { 7L, "1rw5PT6aY4Uoyhgs1b8k27u9ptJqn64295", 167m, new DateTime(2024, 6, 18, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7174) },
                    { 8L, "123g1fPtp7XDEH9UNwrR5YiuCn4yTmQbjSv42428", 126m, new DateTime(2024, 7, 12, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7233) },
                    { 9L, "1kSBZD6zp3fdGcJaWYAs5gTUyxt38115", 369m, new DateTime(2024, 8, 5, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7272) },
                    { 10L, "1BaDStqFLe9N5zEg6mKoUP3cdVrA8TnJ2415", 393m, new DateTime(2025, 7, 28, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7304) },
                    { 11L, "3XKzGJUYVhkdgC9cZ6S1viHqmR5tNL2Tu79503", 112m, new DateTime(2024, 8, 12, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7341) },
                    { 12L, "1nbWgmxJQyVcZDU2ELTseaGdPBp4rko96393", 110m, new DateTime(2024, 8, 23, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7378) },
                    { 13L, "38gRY2Svfs7uWHEiGwZUqdzFQJm16917", 360m, new DateTime(2025, 1, 26, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7414) },
                    { 14L, "3xrJ3fpzDsUthb5QqVWuXSNjaYL20624", 344m, new DateTime(2025, 7, 28, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7446) },
                    { 15L, "3mFdMp9ohibQeJR7AVscktCUu175353", 341m, new DateTime(2025, 2, 4, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7477) },
                    { 16L, "1MH1TxKBaZQP3gcfkqGJsVpFR6bv9w2XD8j1289", 166m, new DateTime(2024, 8, 8, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7562) }
                });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "Buy", "Currency", "LogTime", "Sell" },
                values: new object[] { 1L, 1.0m, "GEL", new DateTime(2024, 6, 5, 19, 36, 18, 401, DateTimeKind.Local).AddTicks(9139), 1.0m });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[,]
                {
                    { 1L, "665", "Brett Bode", "3631-769905-4587", new DateTime(2030, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(4867) },
                    { 2L, "670", "Belle Zemlak", "5020-0437-3547-0812", new DateTime(2029, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(5393) },
                    { 3L, "140", "Fritz Harris", "4576-8874-0702-0458", new DateTime(2032, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(5720) },
                    { 4L, "601", "Fae Kris", "4227-8399-0057-8303", new DateTime(2026, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(6074) },
                    { 5L, "809", "Jacey Spencer", "3499-828201-15227", new DateTime(2030, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(6402) },
                    { 6L, "000", "Maggie Legros", "6767-9477-3680-7203-651", new DateTime(2027, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(6735) },
                    { 7L, "944", "Emmett Cronin", "5461-8407-6035-8689", new DateTime(2030, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(7080) },
                    { 8L, "334", "Flossie Fadel", "4965042728600", new DateTime(2032, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(7341) },
                    { 9L, "064", "Evert Towne", "4141381175676", new DateTime(2026, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(7727) },
                    { 10L, "870", "Justyn Gibson", "677187964880118259", new DateTime(2028, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(8076) },
                    { 11L, "974", "Sally Fadel", "4014314333540", new DateTime(2026, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(8350) },
                    { 12L, "188", "Dejah O'Connell", "6304003837769789", new DateTime(2031, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(8656) },
                    { 13L, "617", "Vicky Douglas", "5412-2131-5042-5742", new DateTime(2028, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(8920) },
                    { 14L, "418", "Bobbie Sanford", "5018-4518-4788-4479", new DateTime(2027, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(9316) },
                    { 15L, "061", "Ulises Bosco", "6011-0909-7670-7021", new DateTime(2030, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(9639) },
                    { 16L, "328", "Patsy Kassulke", "6507-6291-7152-1186-3041", new DateTime(2032, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(9962) },
                    { 17L, "621", "Leon Reichert", "6759-1520-6994-4344-92", new DateTime(2029, 6, 5, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(240) },
                    { 18L, "655", "Aida Smith", "3611-690160-8069", new DateTime(2028, 6, 5, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(554) },
                    { 19L, "134", "Emmalee Parisian", "3528-0381-3666-9741", new DateTime(2032, 6, 5, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(851) },
                    { 20L, "434", "Felicia Anderson", "6706751844482184", new DateTime(2027, 6, 5, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(1159) },
                    { 21L, "030", "Claudie Lemke", "3749-794247-02028", new DateTime(2030, 6, 5, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(1469) },
                    { 22L, "832", "Josue Monahan", "6304294382632056", new DateTime(2029, 6, 5, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(1779) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1L, "Movies" },
                    { 2L, "Games" },
                    { 3L, "Baby" },
                    { 4L, "Garden" },
                    { 5L, "Music" },
                    { 6L, "Shoes" },
                    { 7L, "Beauty" },
                    { 8L, "Books" },
                    { 9L, "Industrial" },
                    { 10L, "Kids" },
                    { 11L, "Outdoors" },
                    { 12L, "Books" },
                    { 13L, "Baby" },
                    { 14L, "Books" },
                    { 15L, "Jewelery" },
                    { 16L, "Tools" },
                    { 17L, "Baby" },
                    { 18L, "Toys" },
                    { 19L, "Toys" },
                    { 20L, "Sports" }
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
                    { 1L, 475m, new DateTime(2023, 10, 28, 11, 36, 18, 407, DateTimeKind.Local).AddTicks(5450), "1" },
                    { 2L, 819m, new DateTime(2024, 3, 23, 14, 36, 18, 407, DateTimeKind.Local).AddTicks(5458), "2" },
                    { 3L, 350m, new DateTime(2023, 10, 10, 7, 36, 18, 407, DateTimeKind.Local).AddTicks(5460), "3" },
                    { 4L, 148m, new DateTime(2023, 8, 24, 2, 36, 18, 407, DateTimeKind.Local).AddTicks(5461), "4" },
                    { 5L, 811m, new DateTime(2023, 8, 2, 1, 36, 18, 407, DateTimeKind.Local).AddTicks(5463), "5" },
                    { 6L, 431m, new DateTime(2023, 9, 27, 23, 36, 18, 407, DateTimeKind.Local).AddTicks(5465), "6" },
                    { 7L, 875m, new DateTime(2023, 6, 15, 0, 36, 18, 407, DateTimeKind.Local).AddTicks(5466), "7" },
                    { 8L, 852m, new DateTime(2023, 10, 31, 20, 36, 18, 407, DateTimeKind.Local).AddTicks(5468), "8" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Price", "ProductCategoryId", "ProductName" },
                values: new object[,]
                {
                    { 1L, 0.1199774952588060m, 1L, "Awesome Metal Fish" },
                    { 2L, 0.2191978140388510m, 2L, "Handmade Fresh Towels" },
                    { 3L, 0.2175163043149110m, 3L, "Sleek Steel Chair" },
                    { 4L, 0.4900740917535490m, 4L, "Licensed Soft Computer" },
                    { 5L, 0.02029484941155220m, 5L, "Awesome Rubber Sausages" },
                    { 6L, 0.7824387228240590m, 6L, "Sleek Fresh Cheese" },
                    { 7L, 0.9092841907787180m, 7L, "Intelligent Cotton Chicken" },
                    { 8L, 0.9279871432085480m, 8L, "Awesome Plastic Soap" },
                    { 9L, 0.5996093060213140m, 9L, "Unbranded Plastic Ball" },
                    { 10L, 0.2618185061205110m, 1L, "Unbranded Plastic Bacon" },
                    { 11L, 0.6636549505905810m, 3L, "Handcrafted Plastic Table" },
                    { 12L, 0.8249837118902130m, 4L, "Ergonomic Fresh Chicken" },
                    { 13L, 0.1983739567730270m, 3L, "Awesome Soft Sausages" },
                    { 14L, 0.9551086656633880m, 6L, "Sleek Fresh Pants" },
                    { 15L, 0.1668360118826410m, 11L, "Refined Soft Bike" },
                    { 16L, 0.7620677267789460m, 12L, "Sleek Concrete Chair" },
                    { 17L, 0.8215582841999580m, 13L, "Unbranded Soft Bacon" },
                    { 18L, 0.681178864683030m, 14L, "Ergonomic Concrete Chicken" },
                    { 19L, 0.3332634446116290m, 15L, "Handcrafted Steel Computer" },
                    { 20L, 0.6080077535239790m, 16L, "Handmade Metal Chicken" },
                    { 21L, 0.3943398993493410m, 17L, "Tasty Soft Shirt" },
                    { 22L, 0.8373996879794650m, 8L, "Sleek Soft Towels" },
                    { 23L, 0.445839449262230m, 9L, "Unbranded Plastic Hat" },
                    { 24L, 0.3246124196953260m, 14L, "Small Concrete Chair" },
                    { 25L, 0.8480842362281310m, 13L, "Rustic Fresh Mouse" },
                    { 26L, 0.06588603462917140m, 4L, "Awesome Metal Mouse" },
                    { 27L, 0.8598529866845530m, 3L, "Generic Soft Chicken" },
                    { 28L, 0.1250473407925970m, 6L, "Unbranded Concrete Computer" },
                    { 29L, 0.6867088389753370m, 1L, "Rustic Steel Sausages" },
                    { 30L, 0.4184936100237570m, 2L, "Intelligent Metal Ball" },
                    { 31L, 0.9966621110933180m, 3L, "Incredible Cotton Towels" },
                    { 32L, 0.3568352098309010m, 4L, "Gorgeous Rubber Salad" },
                    { 33L, 0.7716057433819570m, 5L, "Refined Granite Keyboard" },
                    { 34L, 0.3978252216978750m, 6L, "Fantastic Plastic Chips" },
                    { 35L, 0.6797630827033680m, 7L, "Handmade Metal Towels" },
                    { 36L, 0.903425375922360m, 8L, "Handmade Concrete Pizza" },
                    { 37L, 0.9865304442819550m, 9L, "Generic Concrete Computer" },
                    { 38L, 0.7392258065079110m, 1L, "Fantastic Plastic Chips" },
                    { 39L, 0.2204467709685270m, 11L, "Handmade Rubber Tuna" },
                    { 40L, 0.2035961374996030m, 14L, "Gorgeous Rubber Sausages" },
                    { 41L, 0.6063543994993340m, 3L, "Rustic Rubber Chicken" },
                    { 42L, 0.2852602672695990m, 6L, "Intelligent Frozen Keyboard" },
                    { 43L, 0.3948335787748440m, 15L, "Fantastic Plastic Bike" },
                    { 44L, 0.4561094340000280m, 2L, "Fantastic Soft Salad" },
                    { 45L, 0.5278948956693140m, 18L, "Rustic Rubber Ball" },
                    { 46L, 0.3888452368755620m, 4L, "Small Steel Table" },
                    { 47L, 0.6713734610766130m, 15L, "Practical Steel Chair" },
                    { 48L, 0.1710872151696260m, 19L, "Unbranded Fresh Computer" },
                    { 49L, 0.1961798324200240m, 20L, "Handmade Frozen Salad" },
                    { 50L, 0.2893336375966960m, 8L, "Generic Concrete Bike" },
                    { 51L, 0.1497343575428170m, 14L, "Small Steel Ball" },
                    { 52L, 0.3842044437580190m, 13L, "Intelligent Metal Towels" },
                    { 53L, 0.8937054258897260m, 19L, "Awesome Fresh Bike" },
                    { 54L, 0.4142864648289580m, 16L, "Ergonomic Frozen Mouse" },
                    { 55L, 0.6891507955611480m, 11L, "Tasty Soft Gloves" },
                    { 56L, 0.7580327189391610m, 13L, "Fantastic Fresh Pants" }
                });

            migrationBuilder.InsertData(
                table: "Bonuses",
                columns: new[] { "Id", "CustomerId", "EnrollmentDate", "Points" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2006, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5597), 958 },
                    { 2L, 2L, new DateTime(1999, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5600), 778 },
                    { 3L, 2L, new DateTime(2007, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5602), 356 },
                    { 4L, 3L, new DateTime(2016, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5604), 683 },
                    { 5L, 4L, new DateTime(1998, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5606), 876 },
                    { 6L, 1L, new DateTime(2015, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5607), 201 },
                    { 7L, 1L, new DateTime(2003, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5609), 983 },
                    { 8L, 2L, new DateTime(2013, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5610), 760 },
                    { 9L, 3L, new DateTime(2020, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5612), 661 },
                    { 10L, 2L, new DateTime(2020, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5614), 802 },
                    { 11L, 4L, new DateTime(1996, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5616), 179 },
                    { 12L, 1L, new DateTime(1995, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5617), 766 },
                    { 13L, 2L, new DateTime(2010, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5619), 950 },
                    { 14L, 4L, new DateTime(2005, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5621), 516 },
                    { 15L, 2L, new DateTime(2016, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5622), 908 },
                    { 16L, 2L, new DateTime(2023, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5624), 372 },
                    { 17L, 5L, new DateTime(1999, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5626), 104 },
                    { 18L, 6L, new DateTime(2013, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5627), 972 },
                    { 19L, 7L, new DateTime(1997, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5629), 886 },
                    { 20L, 8L, new DateTime(1999, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5630), 813 },
                    { 21L, 4L, new DateTime(2022, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5632), 370 },
                    { 22L, 5L, new DateTime(2004, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5634), 536 },
                    { 23L, 6L, new DateTime(2019, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5636), 387 },
                    { 24L, 8L, new DateTime(2004, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5638), 698 },
                    { 25L, 7L, new DateTime(2018, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5640), 411 },
                    { 26L, 4L, new DateTime(2013, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5642), 690 },
                    { 27L, 5L, new DateTime(2009, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5644), 591 },
                    { 28L, 2L, new DateTime(2011, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5645), 166 },
                    { 29L, 8L, new DateTime(2013, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5647), 261 },
                    { 30L, 7L, new DateTime(2001, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5648), 437 },
                    { 31L, 2L, new DateTime(2015, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5650), 766 },
                    { 32L, 6L, new DateTime(2014, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5652), 557 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Message", "NotificationDate", "UserId" },
                values: new object[,]
                {
                    { 1L, "Est illo enim nobis deleniti magnam ut eum corrupti deleniti.", new DateTime(2024, 6, 2, 9, 36, 18, 409, DateTimeKind.Local).AddTicks(5486), 1L },
                    { 2L, "ut", new DateTime(2024, 5, 18, 7, 36, 18, 409, DateTimeKind.Local).AddTicks(5622), 2L },
                    { 3L, "numquam", new DateTime(2024, 6, 1, 7, 36, 18, 409, DateTimeKind.Local).AddTicks(5629), 3L },
                    { 4L, "animi", new DateTime(2024, 5, 3, 23, 36, 18, 409, DateTimeKind.Local).AddTicks(5636), 4L },
                    { 5L, "Minima laboriosam officiis est iure. Eius quo sequi est qui esse deleniti possimus enim. Minus voluptatem ab fugit id. Cum ullam temporibus et earum.", new DateTime(2024, 5, 21, 11, 36, 18, 409, DateTimeKind.Local).AddTicks(5642), 1L },
                    { 6L, "Ut sit praesentium ut dolores consectetur veniam numquam quia quia. Recusandae ducimus ad perspiciatis facere delectus doloribus aut voluptatibus ex. Recusandae eos possimus quia. Ut similique maxime aliquam quae laboriosam nobis itaque. Libero aut necessitatibus et excepturi quas iusto dolore atque expedita.", new DateTime(2024, 5, 6, 5, 36, 18, 409, DateTimeKind.Local).AddTicks(5817), 2L },
                    { 7L, "Ipsum sapiente iure facere architecto aspernatur voluptas nulla harum.", new DateTime(2024, 5, 23, 20, 36, 18, 409, DateTimeKind.Local).AddTicks(6027), 3L },
                    { 8L, "Enim pariatur qui animi.\nVelit commodi fugit rerum reiciendis ex.\nVitae ipsam non corrupti illum repudiandae doloremque.\nRerum iste repellat aspernatur ea.", new DateTime(2024, 6, 1, 1, 36, 18, 409, DateTimeKind.Local).AddTicks(6066), 4L },
                    { 9L, "Officiis dignissimos impedit cumque eius omnis repellendus cumque dolorem perspiciatis. Culpa neque doloribus. Nam aliquam soluta explicabo sed ut dignissimos animi tenetur quia. Omnis veritatis dolores quod. Incidunt nulla laudantium eum autem quod neque. Nulla placeat enim est quos corporis impedit saepe.", new DateTime(2024, 5, 7, 14, 36, 18, 409, DateTimeKind.Local).AddTicks(6155), 5L },
                    { 10L, "perspiciatis", new DateTime(2024, 5, 18, 16, 36, 18, 409, DateTimeKind.Local).AddTicks(6404), 6L },
                    { 11L, "Tempora id esse sunt molestiae necessitatibus delectus aut est.\nAut enim quis.\nDolorem incidunt minima quibusdam non dolorum totam.\nSequi eum et velit maxime mollitia nisi excepturi impedit.\nEt officiis et porro.\nSint et enim porro ut sed.", new DateTime(2024, 5, 2, 3, 36, 18, 409, DateTimeKind.Local).AddTicks(6410), 7L },
                    { 12L, "Beatae et ipsa fuga est adipisci asperiores ipsa ullam. Voluptatem sit blanditiis sunt ea in doloremque consequatur aliquid. Consectetur doloribus illo nesciunt velit sed ipsam.", new DateTime(2024, 5, 14, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(6580), 8L },
                    { 13L, "In atque est quae veniam aut unde nobis. Nemo quaerat qui harum aliquam error ipsum dolores. Officiis neque dolor incidunt enim amet unde perferendis eos. Animi ipsa est ipsam. Numquam possimus accusantium quis et cum. Et voluptas maiores earum assumenda et saepe corrupti.", new DateTime(2024, 4, 26, 13, 36, 18, 409, DateTimeKind.Local).AddTicks(6666), 4L },
                    { 14L, "est", new DateTime(2024, 5, 14, 15, 36, 18, 409, DateTimeKind.Local).AddTicks(6869), 6L },
                    { 15L, "Velit delectus cum laboriosam accusamus magnam porro quis minus iure.", new DateTime(2024, 6, 3, 8, 36, 18, 409, DateTimeKind.Local).AddTicks(6876), 7L },
                    { 16L, "qui", new DateTime(2024, 5, 5, 14, 36, 18, 409, DateTimeKind.Local).AddTicks(6907), 6L },
                    { 17L, "Numquam eos voluptatem voluptas dolorem.\nQuam fuga non velit sint blanditiis nulla blanditiis dolores dolor.\nOdio officia sapiente beatae cumque.", new DateTime(2024, 5, 4, 0, 36, 18, 409, DateTimeKind.Local).AddTicks(6913), 4L },
                    { 18L, "Odit dolore ut perspiciatis atque. Et sit sed atque et harum molestiae expedita aperiam. Quo consequatur modi animi architecto exercitationem ut vel laborum ipsum. Rerum ratione ipsa commodi est non ut labore voluptatem et. Eos quisquam eveniet expedita quia pariatur repudiandae est qui omnis. Vel omnis minus natus nisi vero doloribus.", new DateTime(2024, 6, 1, 20, 36, 18, 409, DateTimeKind.Local).AddTicks(7017), 8L }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "Status" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2024, 5, 26, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7503), "Done" },
                    { 2L, 2L, new DateTime(2024, 5, 25, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7507), "Decline" },
                    { 3L, 3L, new DateTime(2024, 5, 16, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7509), "Done" },
                    { 4L, 2L, new DateTime(2024, 5, 24, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7511), "processing" },
                    { 5L, 3L, new DateTime(2024, 5, 29, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7512), "Done" },
                    { 6L, 4L, new DateTime(2024, 5, 27, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7514), "Sent" },
                    { 7L, 2L, new DateTime(2024, 5, 13, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7515), "done" },
                    { 8L, 1L, new DateTime(2024, 5, 25, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7516), "Done" },
                    { 9L, 4L, new DateTime(2024, 5, 30, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7518), "Done" },
                    { 10L, 2L, new DateTime(2024, 5, 19, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7519), "done" },
                    { 11L, 1L, new DateTime(2024, 6, 4, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7520), "Done" },
                    { 12L, 5L, new DateTime(2024, 5, 31, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7522), "Done" },
                    { 13L, 6L, new DateTime(2024, 5, 24, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7523), "Decline" },
                    { 14L, 7L, new DateTime(2024, 5, 20, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7525), "Done" },
                    { 15L, 2L, new DateTime(2024, 5, 30, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7526), "processing" },
                    { 16L, 8L, new DateTime(2024, 6, 1, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7527), "Done" },
                    { 17L, 5L, new DateTime(2024, 5, 14, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7529), "done" },
                    { 18L, 2L, new DateTime(2024, 5, 17, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7530), "done" },
                    { 19L, 7L, new DateTime(2024, 5, 8, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7531), "Sent" },
                    { 20L, 6L, new DateTime(2024, 5, 14, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7533), "Done" },
                    { 21L, 7L, new DateTime(2024, 5, 7, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7534), "Processing" },
                    { 22L, 8L, new DateTime(2024, 5, 22, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7535), "Done" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CustomerId", "ProductId", "Rating", "ReviewDate", "ReviewText" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, 3, new DateTime(2024, 5, 21, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2021), "Velit dolor voluptate eaque repellat. Eos praesentium at officiis dolores quaerat minima. Aut iure consectetur et quis nesciunt non cumque nostrum. Et id sint similique molestiae aspernatur repellendus fugiat consequatur. Voluptatem tempora quo nihil cupiditate nostrum at voluptas distinctio reprehenderit. Quas nobis distinctio doloremque facere." },
                    { 2L, 2L, 2L, 5, new DateTime(2024, 4, 12, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2301), "Voluptatum quis rem doloribus quibusdam ut autem neque distinctio. Voluptatem tenetur asperiores perferendis expedita. Ut sed officiis enim aspernatur doloribus et nobis fugit. Maiores at quaerat reprehenderit blanditiis." },
                    { 3L, 3L, 3L, 4, new DateTime(2024, 5, 13, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2410), "Praesentium odio ut possimus assumenda. Quis iure commodi perspiciatis nesciunt repellendus. Eum delectus harum consequatur quaerat magnam. Ut praesentium temporibus eligendi delectus aut fugit. Veniam quidem temporibus. Magnam eaque aperiam commodi vel quis." },
                    { 4L, 2L, 4L, 3, new DateTime(2024, 6, 3, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2559), "perferendis" },
                    { 5L, 2L, 5L, 2, new DateTime(2024, 5, 2, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2566), "Debitis est ut consequatur ea incidunt inventore adipisci. Ratione accusantium quam ut harum delectus eos ratione ipsum cum. Voluptas rem assumenda numquam ut id. Laboriosam soluta aut tenetur sit." },
                    { 6L, 1L, 6L, 4, new DateTime(2024, 5, 1, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2673), "enim" },
                    { 7L, 5L, 11L, 3, new DateTime(2024, 5, 21, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2733), "Odio et corporis culpa tempora nesciunt aut voluptas cumque minima." },
                    { 8L, 6L, 12L, 5, new DateTime(2024, 4, 12, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2767), "Et corporis modi. Rerum non ut. Fugiat et deserunt eius nihil eos nobis repellendus officiis quod. Sint accusamus qui." },
                    { 9L, 7L, 7L, 4, new DateTime(2024, 5, 13, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2842), "deserunt" },
                    { 10L, 8L, 13L, 3, new DateTime(2024, 6, 3, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2847), "Qui aut et ex et. Et doloribus perferendis aut reprehenderit eaque voluptatem eum. Enim velit ducimus quia ut non nisi deserunt incidunt ipsam. Nisi fuga dolorum maiores aut non numquam alias enim sequi." }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "OrderId", "PaymentDate", "PaymentMethod", "paymentMethodId" },
                values: new object[,]
                {
                    { 1L, 228m, 1L, new DateTime(2024, 5, 31, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2032), "ATM", 1L },
                    { 2L, 207m, 2L, new DateTime(2024, 5, 12, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2038), "Mobile Bank", 2L },
                    { 3L, 334m, 3L, new DateTime(2024, 5, 10, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2040), "ATM", 3L },
                    { 4L, 137m, 4L, new DateTime(2024, 5, 13, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2042), "Credit card", 4L },
                    { 5L, 423m, 5L, new DateTime(2024, 5, 10, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2044), "ATM", 5L },
                    { 6L, 117m, 1L, new DateTime(2024, 5, 13, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2046), "Visa Card", 6L },
                    { 7L, 667m, 3L, new DateTime(2024, 5, 21, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2048), "ATM", 7L },
                    { 8L, 156m, 2L, new DateTime(2024, 5, 26, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2050), "Mobile Bank", 8L },
                    { 9L, 173m, 3L, new DateTime(2024, 5, 27, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2052), "ATM", 1L },
                    { 10L, 150m, 4L, new DateTime(2024, 5, 9, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2054), "Visa Card", 3L },
                    { 11L, 73m, 5L, new DateTime(2024, 5, 14, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2056), "ATM", 2L },
                    { 12L, 309m, 2L, new DateTime(2024, 5, 21, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2057), "Master Card", 4L },
                    { 13L, 386m, 3L, new DateTime(2024, 5, 11, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2059), "ATM", 5L },
                    { 14L, 552m, 1L, new DateTime(2024, 5, 26, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2061), "ATM", 6L },
                    { 15L, 266m, 6L, new DateTime(2024, 5, 24, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2063), "Wallet", 7L },
                    { 16L, 931m, 7L, new DateTime(2024, 5, 24, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2065), "ATM", 4L },
                    { 17L, 141m, 4L, new DateTime(2024, 5, 7, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2066), "Apple pay", 5L },
                    { 18L, 479m, 3L, new DateTime(2024, 6, 2, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2068), "ATM", 3L }
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
                    { 1L, 1L, "Consequatur optio qui.\nQuia quia non iure quia expedita consequatur.\nEst velit suscipit similique quia quidem aut aut.\nAt expedita non nulla.\nQuo eos omnis.", new DateTime(2024, 5, 6, 19, 36, 18, 419, DateTimeKind.Local).AddTicks(4894), "Active" },
                    { 2L, 2L, "Et ea nihil ad nemo aut qui quibusdam beatae sed.", new DateTime(2024, 2, 26, 19, 36, 18, 419, DateTimeKind.Local).AddTicks(5157), "Passed" },
                    { 3L, 3L, "Omnis explicabo debitis quia perspiciatis.", new DateTime(2024, 5, 16, 19, 36, 18, 419, DateTimeKind.Local).AddTicks(5202), "Declined" },
                    { 4L, 4L, "Eius laboriosam consequatur illum itaque repellendus id cupiditate aut quaerat.", new DateTime(2024, 5, 6, 19, 36, 18, 419, DateTimeKind.Local).AddTicks(5224), "Processing" },
                    { 5L, 5L, "Ab et praesentium.", new DateTime(2024, 2, 26, 19, 36, 18, 419, DateTimeKind.Local).AddTicks(5262), "To be ready" },
                    { 6L, 6L, "Incidunt ea voluptatem molestiae nihil beatae tenetur odit porro. Pariatur deleniti est doloribus. Fugit dignissimos impedit culpa veritatis labore perspiciatis.", new DateTime(2024, 5, 16, 19, 36, 18, 419, DateTimeKind.Local).AddTicks(5315), "Archived" }
                });

            migrationBuilder.InsertData(
                table: "Shippings",
                columns: new[] { "Id", "Carrier", "OrderId", "ShippingDate", "Status", "TrackingNumber" },
                values: new object[,]
                {
                    { 1L, "1zRkKahWmB3Q58Vd1NHc6qeP7MDTZw", 1L, new DateTime(2024, 6, 1, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9334), "Sent from abroad", "THDEMCU1590" },
                    { 2L, "1tZ7JiHhF2GQqxR6wYredSpX9PK8oD", 2L, new DateTime(2024, 5, 31, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9475), "Recieved from abroad", "XVBUMFJ1533" },
                    { 3L, "39XaGyvroE8JxtNMjizeZH7wU6K1Qng5", 3L, new DateTime(2024, 4, 21, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9523), "recieve in sorting centre", "OKDIARI1457" },
                    { 4L, "3RwpBdP1JhkWnexmYbD7qacy4LF69rXvTgV", 4L, new DateTime(2024, 4, 21, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9569), "delivered", "IIAUGUW1" },
                    { 5L, "18ktvFbKUSrATeY1QduBfNqgHh", 5L, new DateTime(2024, 6, 2, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9615), "Unsuccesfull delivery", "FDQOBSQ1" },
                    { 6L, "1hgfJFUwRXrcp6E71Tq92yQCunGameido", 6L, new DateTime(2024, 5, 25, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9653), "recieved", "XFPUETS1" },
                    { 7L, "3yTsSCxfrWoQ6GP4NveabhY7mgUJZMcDu", 7L, new DateTime(2024, 4, 10, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9747), "boxing", "JKJOWFD1" }
                });

            migrationBuilder.InsertData(
                table: "ReceiptDetails",
                columns: new[] { "ProductId", "ReceiptId", "DiscountUnitPrice", "Id", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1L, 1L, 772m, 1L, 29, 161.55m },
                    { 1L, 5L, 471m, 6L, 88, 177.82m },
                    { 1L, 11L, 768m, 11L, 72, 611.09m },
                    { 1L, 15L, 457m, 16L, 83, 301.37m },
                    { 2L, 2L, 837m, 7L, 87, 444.66m },
                    { 2L, 3L, 360m, 2L, 73, 234.70m },
                    { 2L, 12L, 971m, 17L, 89, 7.30m },
                    { 2L, 13L, 70m, 12L, 96, 298.41m },
                    { 3L, 2L, 382m, 3L, 32, 712.66m },
                    { 3L, 3L, 570m, 8L, 28, 618.88m },
                    { 3L, 12L, 146m, 13L, 17, 741.00m },
                    { 3L, 13L, 193m, 18L, 25, 704.75m },
                    { 4L, 2L, 65m, 9L, 38, 207.81m },
                    { 4L, 3L, 547m, 4L, 46, 986.43m },
                    { 4L, 10L, 562m, 14L, 54, 754.07m },
                    { 4L, 12L, 546m, 19L, 37, 258.06m },
                    { 5L, 3L, 941m, 10L, 99, 96.24m },
                    { 5L, 4L, 867m, 5L, 84, 851.67m },
                    { 5L, 13L, 331m, 20L, 98, 793.56m },
                    { 5L, 14L, 743m, 15L, 21, 183.94m }
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
