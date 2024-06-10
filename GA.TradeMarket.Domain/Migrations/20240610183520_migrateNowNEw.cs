using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class migrateNowNEw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    DateOfLastModification = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wishlists_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a9cf213-628a-44d7-87e0-eb718ab2178a", "GURAM.APKHAZAVA908@ENS.TSU.GE", "AQAAAAIAAYagAAAAEIXLjVkK9Ll1DcAKNzIEM5TAU6hBXWplAITXs6lHeUCyECOeQf9yRB6fAO3J+KcYIQ==", "b0dac53e-1440-4f89-8af1-fa8a93bd728a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1990, 6, 10, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(4663), "e25fe557-6528-4fd5-b57f-d3f62cd2ee1c", "maxime@jakubowski.com", "Carter", "393-122-0536", "f554730e-c944-462a-99b2-7b6359b503f0", "Okuneva", "bert" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2013, 6, 10, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(8016), "9b86a914-403d-41c3-89b2-73cb6f80038f", "claude_tillman@feil.info", "Bauch", "(845)561-2820", "fbd692dc-ecec-4105-aba3-6f1337895ca4", "Predovic", "jocelyn.rosenbaum" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1992, 6, 10, 22, 35, 20, 152, DateTimeKind.Local).AddTicks(1114), "8a7af1e1-25a2-4c0f-b137-e61a678e564c", "jaron@oreillygutkowski.com", "Legros", "(395)067-4951 x9563", "ce8b1e29-6947-4dd4-9631-0f6f7da3c2f1", "Fay", "malcolm_beatty" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1990, 6, 10, 22, 35, 20, 152, DateTimeKind.Local).AddTicks(4452), "ab684e51-9e75-4deb-80c7-cf596b8aa09d", "alphonso.cormier@towne.us", "Howell", "(482)308-2812", "34c96839-4b04-4d60-9b79-7d91e786ea0d", "Hagenes", "meagan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1995, 6, 10, 22, 35, 20, 152, DateTimeKind.Local).AddTicks(7085), "98351a75-cf7e-4237-9f56-edb5f0e93639", "daniella@roberts.uk", "Mertz", "1-111-102-8008 x5655", "2867f8fd-b7e4-49ae-ab6f-019a496c1c68", "Hackett", "albertha" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2009, 6, 10, 22, 35, 20, 152, DateTimeKind.Local).AddTicks(9960), "535cbe20-0c86-4a2c-ac9c-91d2ab2273e9", "geovanny_olson@ohara.ca", "Goyette", "(361)881-1510 x61303", "fd183c48-6622-4f07-8e13-d3b93bf8596c", "Dickens", "orlando_hilpert" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1987, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(3004), "7078519c-3f71-43b8-b4c0-6eb86f9e87a3", "joelle@boylesimonis.us", "Rohan", "(282)442-9319", "5bf1b6e1-cb6e-44c3-9ede-2afc1254b114", "Waters", "royal.hand" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1982, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(6051), "d64f7cb0-4e08-425e-a428-61a09bd5b072", "shawn_pagac@larson.com", "Halvorson", "1-624-510-5039 x1326", "fc8cc81d-553e-42a9-bb58-340aad616735", "Rowe", "melody.hammes" });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2017, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7910), 249 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1995, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7914), 475 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2020, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7915), 999 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1996, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7917), 669 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7919), 802 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2019, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7920), 439 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7922), 769 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7923), 252 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2001, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7925), 426 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7926), 328 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2007, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7929), 586 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7931), 198 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2017, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7932), 768 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2008, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7934), 816 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1996, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7935), 633 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2008, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7937), 134 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2012, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7938), 929 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2020, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7940), 300 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7941), 581 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2008, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7943), 474 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2004, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7945), 453 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7946), 280 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2018, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7948), 264 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2015, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7949), 392 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7951), 363 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7952), 576 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2020, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7954), 369 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2010, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7955), 735 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7957), 313 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7959), 932 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7960), 324 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 10, 22, 35, 20, 153, DateTimeKind.Local).AddTicks(7962), 834 });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "34LvPWimcbgMf7ZUF2aBqJ65uzRDXTsox48828", 177m, new DateTime(2024, 10, 18, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "11Ew3zHr9koun2UmaWNTLhg5MjVpQscG97777", 241m, new DateTime(2024, 11, 28, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1MD8zGryWHcNVj6vPidSEAx3Q4gFuZXJsK25382", 304m, new DateTime(2025, 1, 27, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1XPBUyaDRcLtQn5kAS62Gfmo4x1jpC9gJ12207", 363m, new DateTime(2024, 7, 3, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1u2ksCxvaX4DNdqPBoH1KcwLgVAYzZe85038", 305m, new DateTime(2024, 7, 27, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3ySFLA7cW1joRhbpvQmkDqwrT2N26443", 119m, new DateTime(2025, 4, 14, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1Gsog8fDvdSJMuNQFwth3kKTre4zLA10804", 269m, new DateTime(2024, 8, 28, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3THeN967E1AZWwFMzBaryukcgjhU3581", 226m, new DateTime(2025, 3, 4, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "31ULrApbnGYCkXjFSeyEBN7tWKh11393", 363m, new DateTime(2025, 7, 19, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3dZRjWC4D7LgQk2EnqKyAeBzhSxsfcFpt46312", 329m, new DateTime(2025, 2, 24, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3MxrXWmjPRESQhJs8Cgf4audD5o976L2131", 105m, new DateTime(2025, 1, 16, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "16w1skV3Y2FCLrSfUj7oBEKNxP64992", 361m, new DateTime(2024, 12, 20, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1eBVtwZnqRHu1av83jEgsPcd9MW44358", 333m, new DateTime(2025, 3, 11, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1f8BWZqbTkngejvKY5XVhJzMDrFUxpoyma79270", 171m, new DateTime(2025, 4, 6, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3pzZJqKD1a6r8yYt4gRikcLbmA58276", 326m, new DateTime(2024, 8, 18, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1YHDfbU21vVXA4zdGPNw9CycomJn58155", 284m, new DateTime(2025, 7, 31, 22, 35, 20, 151, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 668m, new DateTime(2024, 1, 9, 3, 35, 20, 153, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 844m, new DateTime(2023, 11, 25, 20, 35, 20, 153, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 225m, new DateTime(2024, 2, 12, 7, 35, 20, 153, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 445m, new DateTime(2023, 7, 5, 1, 35, 20, 153, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 200m, new DateTime(2023, 6, 9, 5, 35, 20, 153, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 756m, new DateTime(2024, 4, 10, 10, 35, 20, 153, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 254m, new DateTime(2023, 11, 1, 5, 35, 20, 153, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 463m, new DateTime(2023, 6, 14, 10, 35, 20, 153, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 6, 10, 22, 35, 20, 148, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "est", new DateTime(2024, 5, 7, 19, 35, 20, 155, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Nihil amet nisi debitis dolorem.", new DateTime(2024, 5, 8, 21, 35, 20, 155, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Et quis distinctio aliquam. Qui aut rem enim. Eos voluptatem pariatur sit dolores numquam iure in.", new DateTime(2024, 5, 9, 15, 35, 20, 155, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "quisquam", new DateTime(2024, 5, 26, 17, 35, 20, 155, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Aspernatur explicabo nihil qui et blanditiis placeat laboriosam sed deleniti.", new DateTime(2024, 5, 25, 5, 35, 20, 155, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Corporis aut eius expedita qui cum quibusdam.", new DateTime(2024, 6, 9, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Est facilis quibusdam eum reprehenderit voluptatibus.", new DateTime(2024, 5, 18, 13, 35, 20, 155, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Totam cupiditate modi pariatur veniam vel qui impedit optio cumque.\nRem numquam odio sed distinctio modi et rerum reiciendis non.\nNon et eveniet sunt optio quia ab.\nNon et saepe quis repudiandae ipsam aliquam expedita dolores quia.\nNam consequatur ut vero libero nulla similique.", new DateTime(2024, 5, 27, 6, 35, 20, 155, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Ex quos minima ullam laudantium non cum tenetur.", new DateTime(2024, 5, 15, 1, 35, 20, 155, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "et", new DateTime(2024, 6, 2, 16, 35, 20, 155, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Quia hic molestias et autem.", new DateTime(2024, 6, 9, 5, 35, 20, 155, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Aut sit sint dolor perspiciatis saepe.\nPossimus exercitationem quis reiciendis.", new DateTime(2024, 5, 7, 5, 35, 20, 155, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Laborum nobis id eaque commodi sunt rerum consequatur quos molestias.", new DateTime(2024, 5, 23, 16, 35, 20, 155, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Hic consequatur adipisci nostrum dolor. Eveniet cupiditate aut modi placeat labore quae distinctio. Quia dolores perspiciatis beatae expedita consequuntur. Sint nulla dolore modi voluptatum numquam odio. Libero consequuntur excepturi quasi nostrum aut aut est nostrum est.", new DateTime(2024, 5, 19, 14, 35, 20, 155, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Molestias consectetur quia.", new DateTime(2024, 5, 22, 4, 35, 20, 155, DateTimeKind.Local).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "assumenda", new DateTime(2024, 5, 26, 8, 35, 20, 155, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Facere ut laboriosam libero.\nSed quia id.", new DateTime(2024, 5, 14, 3, 35, 20, 155, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "optio", new DateTime(2024, 5, 24, 1, 35, 20, 155, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 27, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 29, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 5, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 13, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 25, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 16, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 28, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 9, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 6, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 12, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 8, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 24, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 14, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 25, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 15, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 29, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 28, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 8, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 1, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 18, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 4, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 19, 22, 35, 20, 155, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "303", "Naomi Larkin", "6759769434626727", new DateTime(2031, 6, 10, 22, 35, 20, 157, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "697", "Herbert Welch", "4112-5196-7862-5431", new DateTime(2030, 6, 10, 22, 35, 20, 157, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "594", "Addie Koelpin", "4082848182949", new DateTime(2029, 6, 10, 22, 35, 20, 157, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "220", "Lucy Blick", "6759-5386-3725-2826-586", new DateTime(2031, 6, 10, 22, 35, 20, 157, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "611", "Marisol O'Kon", "3682-089199-6737", new DateTime(2030, 6, 10, 22, 35, 20, 157, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "416", "Felipe Bashirian", "6759-7793-5581-0492-98", new DateTime(2027, 6, 10, 22, 35, 20, 157, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "179", "Nigel Cronin", "3788-768284-99860", new DateTime(2032, 6, 10, 22, 35, 20, 157, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "019", "Edmond Lemke", "6771-8914-3205-3987", new DateTime(2032, 6, 10, 22, 35, 20, 157, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "518", "Ted Champlin", "6445-6216-1341-5542-2540", new DateTime(2026, 6, 10, 22, 35, 20, 157, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "753", "Abraham Keebler", "6759-0662-0957-7399-432", new DateTime(2028, 6, 10, 22, 35, 20, 157, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "397", "Nelda Steuber", "6767-5234-5590-1027-716", new DateTime(2029, 6, 10, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "262", "Oran Ebert", "6304-3264-7441-8216", new DateTime(2031, 6, 10, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "987", "Scarlett Bechtelar", "3529-5385-7467-1470", new DateTime(2032, 6, 10, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "634", "Cecil Wiegand", "58932248878873534", new DateTime(2027, 6, 10, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "547", "Hattie Koepp", "4327257604929", new DateTime(2033, 6, 10, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "807", "Michelle Prosacco", "5365-8964-3816-0052", new DateTime(2028, 6, 10, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "696", "Louvenia Rosenbaum", "6759-6826-0194-3155-122", new DateTime(2026, 6, 10, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "122", "Raina Cassin", "4996692572402", new DateTime(2033, 6, 10, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "824", "Ashley Walter", "5893-5565-6957-0419", new DateTime(2027, 6, 10, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "187", "Nicholaus Wolf", "5478-7390-7731-2929", new DateTime(2028, 6, 10, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "137", "River Berge", "6759-8598-1018-3716-934", new DateTime(2028, 6, 10, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "827", "Justina Walker", "3485-789824-93716", new DateTime(2030, 6, 10, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 78m, new DateTime(2024, 5, 12, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 351m, new DateTime(2024, 6, 5, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 465m, new DateTime(2024, 5, 15, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 593m, new DateTime(2024, 5, 26, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 758m, new DateTime(2024, 5, 26, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 263m, new DateTime(2024, 5, 16, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 815m, new DateTime(2024, 6, 7, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 838m, new DateTime(2024, 5, 30, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 584m, new DateTime(2024, 5, 27, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 537m, new DateTime(2024, 5, 21, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 897m, new DateTime(2024, 5, 28, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 730m, new DateTime(2024, 5, 17, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 503m, new DateTime(2024, 5, 22, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 507m, new DateTime(2024, 5, 17, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 729m, new DateTime(2024, 6, 6, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 307m, new DateTime(2024, 5, 26, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 605m, new DateTime(2024, 5, 30, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 120m, new DateTime(2024, 5, 31, 22, 35, 20, 158, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CategoryName",
                value: "Garden");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CategoryName",
                value: "Grocery");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CategoryName",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CategoryName",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CategoryName",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CategoryName",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CategoryName",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CategoryName",
                value: "Jewelery");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CategoryName",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CategoryName",
                value: "Home");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CategoryName",
                value: "Grocery");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CategoryName",
                value: "Baby");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CategoryName",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CategoryName",
                value: "Books");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CategoryName",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CategoryName",
                value: "Sports");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 315.33m, "Practical Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.08m, "Generic Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 631.66m, "Awesome Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 364.85m, "Gorgeous Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 634.34m, "Practical Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 286.30m, "Licensed Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 763.67m, "Fantastic Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 30.00m, "Fantastic Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 922.39m, "Refined Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 944.53m, "Unbranded Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 770.54m, "Gorgeous Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 128.46m, "Fantastic Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 917.22m, "Handcrafted Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 347.96m, "Awesome Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 301.39m, "Sleek Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 527.51m, "Ergonomic Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 858.66m, "Ergonomic Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 450.31m, "Licensed Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 68.64m, "Handmade Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 302.01m, "Ergonomic Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 81.80m, "Tasty Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 432.59m, "Incredible Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 496.53m, "Unbranded Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 483.15m, "Handmade Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 653.59m, "Practical Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 217.62m, "Awesome Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 294.50m, "Incredible Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 251.23m, "Handmade Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 2.29m, "Small Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5.46m, "Intelligent Metal Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 615.30m, "Rustic Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 668.17m, "Awesome Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 913.71m, "Unbranded Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 14.89m, "Generic Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 204.07m, "Licensed Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 122.58m, "Intelligent Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 361.50m, "Handmade Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 127.91m, "Gorgeous Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 690.34m, "Generic Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 70.25m, "Licensed Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 892.14m, "Rustic Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 996.45m, "Sleek Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 241.16m, "Licensed Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 725.36m, "Practical Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 550.26m, "Unbranded Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 136.55m, "Sleek Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 219.02m, "Gorgeous Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 387.46m, "Handmade Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 919.84m, "Generic Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 875.23m, "Handmade Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 78.48m, "Ergonomic Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 401.09m, "Small Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 669.45m, "Practical Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 425.70m, "Gorgeous Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 726.77m, "Unbranded Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 311.04m, "Small Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 1L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 444m, 80, 15.26m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 5L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 803m, 99, 837.87m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 11L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 836m, 66, 710.16m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 15L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 753m, 98, 759.85m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 149m, 75, 93.60m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 299m, 23, 858.49m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 872m, 70, 333.18m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 945m, 22, 340.03m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 95m, 87, 355.44m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 68m, 71, 510.83m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 556m, 28, 852.25m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 495m, 90, 563.07m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 109m, 33, 49.99m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 282m, 83, 989.16m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 10L },
                columns: new[] { "DiscountUnitPrice", "UnitPrice" },
                values: new object[] { 707m, 483.87m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 686m, 66, 684.18m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 423m, 42, 526.00m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 4L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 957m, 17, 840.81m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 258m, 99, 329.77m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 14L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 125m, 91, 422.29m });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Dolore reiciendis qui consequatur unde quia fuga.", new DateTime(2024, 5, 11, 22, 35, 20, 165, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "suscipit", new DateTime(2024, 3, 2, 22, 35, 20, 165, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "dolores", new DateTime(2024, 5, 21, 22, 35, 20, 165, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Omnis quia iure fugit nihil odit iusto dignissimos sit.", new DateTime(2024, 5, 11, 22, 35, 20, 165, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "eveniet", new DateTime(2024, 3, 2, 22, 35, 20, 165, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "necessitatibus", new DateTime(2024, 5, 21, 22, 35, 20, 165, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 35, 20, 167, DateTimeKind.Local).AddTicks(756), "Impedit dolorem aspernatur vitae commodi mollitia consequuntur explicabo enim." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 17, 22, 35, 20, 167, DateTimeKind.Local).AddTicks(857), "Aspernatur sit sint ullam et occaecati.\nQuia nihil dignissimos sit non voluptatem hic perspiciatis enim.\nLabore ut et iusto.\nEos laudantium et et eum quis aut et suscipit.\nSunt cumque omnis velit impedit dolor quas earum.\nQuisquam rerum vitae autem recusandae." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 18, 22, 35, 20, 167, DateTimeKind.Local).AddTicks(1089), "Voluptatem omnis veniam repellendus ut tempora nihil.\nMaxime facilis ullam.\nConsectetur suscipit natus eveniet in rerum.\nNobis et perferendis.\nCum quaerat totam vel hic ut nostrum." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 35, 20, 167, DateTimeKind.Local).AddTicks(1236), "Fuga velit maxime asperiores. Dicta atque eum sit qui voluptate quaerat quo culpa numquam. Nihil eligendi facilis ab cum quibusdam adipisci aliquam. Qui ab sed minima molestiae incidunt cumque quasi doloremque reiciendis. Dignissimos qui sunt perferendis eum officia occaecati cum et." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 35, 20, 167, DateTimeKind.Local).AddTicks(1383), "Praesentium enim tempora est." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 6, 22, 35, 20, 167, DateTimeKind.Local).AddTicks(1432), "Corrupti qui dolorem esse.\nAut dolorum non.\nVoluptatibus provident corrupti et voluptas voluptas.\nSit reiciendis cupiditate nulla harum nulla.\nError voluptatem quod." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 35, 20, 167, DateTimeKind.Local).AddTicks(1521), "voluptas" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 17, 22, 35, 20, 167, DateTimeKind.Local).AddTicks(1527), "Eos in dolor ullam provident odit necessitatibus.\nUnde et nulla rerum et cupiditate enim sint.\nEum quia quidem deleniti.\nVoluptatem eum qui iure doloribus.\nAliquam dolores rerum." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 18, 22, 35, 20, 167, DateTimeKind.Local).AddTicks(1647), "Optio et eveniet quia nesciunt qui esse vel animi laboriosam.\nHic sed cum fugiat nobis.\nHarum libero nobis nobis sit sapiente.\nOptio et alias dolores qui libero deserunt deserunt.\nEaque odit dolorum assumenda.\nDeleniti ab doloribus qui itaque cumque fugit est." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 35, 20, 167, DateTimeKind.Local).AddTicks(1780), "Molestias nihil alias ex voluptatibus corrupti sed ut laboriosam voluptatem.\nUt accusamus harum ea atque ipsam praesentium illum." });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3S2rCDwXBbeTmh3vZFW7G1g5NyKjM", new DateTime(2024, 6, 6, 22, 35, 20, 168, DateTimeKind.Local).AddTicks(9597), "TPMIPRU1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3be2iMKmqdgYkxpAaTjSZ5hyoVvQNJ4Esz", new DateTime(2024, 6, 5, 22, 35, 20, 168, DateTimeKind.Local).AddTicks(9775), "PZVIGWP1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3YaZwCtrq4iUVAWKJ78DFEmN9uP6g", new DateTime(2024, 4, 26, 22, 35, 20, 168, DateTimeKind.Local).AddTicks(9823), "VQWOAEC1VEW" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1TnhaF6WbokcZGpQ1CSgzwVtJYqd", new DateTime(2024, 4, 26, 22, 35, 20, 168, DateTimeKind.Local).AddTicks(9866), "DOWICDM1613" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1oM4UDW25JzqTScykZvKadXwEhY", new DateTime(2024, 6, 7, 22, 35, 20, 168, DateTimeKind.Local).AddTicks(9909), "UGSUGQA1388" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "33mV17uJShytocpw8MQRUKjXxC", new DateTime(2024, 5, 30, 22, 35, 20, 168, DateTimeKind.Local).AddTicks(9948), "LTPIKNQ1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1YzAyb4KGDvtwkML9uZdgrfsB8WPURQ5m1", new DateTime(2024, 4, 15, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(28), "JPNUPWV1" });

            migrationBuilder.InsertData(
                table: "Wishlists",
                columns: new[] { "Id", "CustomerId", "DateOfLastModification", "productId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2024, 6, 10, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(353), 1L },
                    { 2L, 2L, new DateTime(2024, 6, 10, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(356), 21L },
                    { 3L, 3L, new DateTime(2024, 6, 10, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(357), 3L },
                    { 4L, 4L, new DateTime(2024, 6, 10, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(358), 4L },
                    { 5L, 5L, new DateTime(2024, 6, 10, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(359), 5L },
                    { 6L, 6L, new DateTime(2024, 6, 10, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(360), 6L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_CustomerId",
                table: "Wishlists",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_productId",
                table: "Wishlists",
                column: "productId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a65e80f-e02f-436d-8e5d-1d4b5d6638ef", "guram.apkhazava908@ens.tsu.ge", "AQAAAAIAAYagAAAAEHIbWqBPVtlCVWUESKZ3iCG8QXX/qme+jnRbTKaU8lLLSpB3vyt/HQUzY8iE3tY9KQ==", "8f541e6f-362a-4515-a4d3-b61cad734428" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1965, 6, 10, 14, 37, 23, 707, DateTimeKind.Local).AddTicks(4683), "4e189c68-52a4-4589-8b22-0b0d9456b023", "felton_windler@vonrueden.info", "Schaden", "(114)501-0869", "446bf247-0df9-4e46-b94d-f82bb405078c", "Auer", "larue" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1992, 6, 10, 14, 37, 23, 708, DateTimeKind.Local).AddTicks(1535), "87c6bf55-1902-4991-ab40-ba0731c3ff2b", "flo@morissette.us", "Spencer", "(372)701-6533", "efc649ab-1693-42f4-874a-924b14db8c6d", "Price", "sabryna.schroeder" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1973, 6, 10, 14, 37, 23, 708, DateTimeKind.Local).AddTicks(9369), "44323c4b-76a3-4ff3-9db2-33fbe95f528b", "shanelle_kunze@dare.uk", "Wiza", "1-695-699-2762 x38672", "dea64662-5c02-405c-a4ea-e72bb976dd8d", "Reynolds", "arely_hickle" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1969, 6, 10, 14, 37, 23, 709, DateTimeKind.Local).AddTicks(5815), "ecb03f86-8baf-4d34-a807-f137ec20af59", "bella_boyle@hintz.uk", "Mante", "(008)860-0390", "456b123e-4e09-47c7-a3b6-31dbb40fb9c3", "Satterfield", "elta" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1983, 6, 10, 14, 37, 23, 711, DateTimeKind.Local).AddTicks(6141), "15db4185-c520-4479-b1ab-401331a97428", "gordon@medhurst.ca", "Champlin", "551.615.8940 x09707", "1406e37b-0717-4071-aa52-5a080b677c00", "Marquardt", "raegan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2008, 6, 10, 14, 37, 23, 712, DateTimeKind.Local).AddTicks(3791), "d1ce3ed7-92f0-4921-be4a-49efda504cb5", "vernice.gutmann@auer.us", "Prohaska", "1-097-649-0556 x3125", "06a0eedf-daf2-4887-af01-c759ae88bacc", "Beer", "rodolfo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1983, 6, 10, 14, 37, 23, 713, DateTimeKind.Local).AddTicks(5090), "c15f8554-52e2-4e53-9319-f0dc22a4ce53", "mossie_klein@halvorson.ca", "Herzog", "(161)114-6086", "420992b3-3c3b-490e-aa16-34dad5d6be87", "Schneider", "randy" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2009, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(1822), "107b5a03-0aa9-4675-93e2-5ec02da84351", "octavia_jacobi@murphycollins.uk", "Pouros", "462-563-4394 x142", "1eeb15d5-bc00-4592-a562-afa4c3d00272", "Collins", "camryn" });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2008, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(6963), 238 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(6972), 751 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(6975), 519 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2017, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(6977), 687 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2011, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(6980), 142 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(6983), 291 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1997, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(6986), 778 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2018, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(6988), 766 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2019, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(6991), 354 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(6994), 186 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2016, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(6996), 533 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2022, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7000), 697 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2000, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7003), 160 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1996, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7006), 914 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2002, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7009), 623 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7011), 980 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7014), 626 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2021, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7017), 560 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7019), 705 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2008, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7022), 851 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2011, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7025), 843 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2002, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7027), 534 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2015, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7043), 117 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2017, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7046), 367 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7049), 299 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7051), 530 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1997, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7054), 486 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2000, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7056), 791 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2012, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7060), 934 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7062), 605 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7065), 687 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 10, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(7068), 927 });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "19BTixFEprXULWoqGyjgR8aJk316569", 230m, new DateTime(2025, 7, 26, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3uqVfks96JDTMjbepAE7d2owvSWt5HgNPQ47189", 228m, new DateTime(2024, 7, 30, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1YoHvQTUwnGD28uZNFXpmS6MWfC742636", 372m, new DateTime(2024, 12, 13, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3jMod7KJavf8ZzwEy5SHUbDQRuBqYXhinL288186", 302m, new DateTime(2024, 11, 4, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3FYa9QvVn5BCujWmi1cgPJe4XzU14311", 146m, new DateTime(2025, 5, 20, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3SQc95tvaVYHTNkLCgx26hqdmPUiubKGpj60058", 218m, new DateTime(2024, 10, 3, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1j6287dARSVKroZQtuHbhBJ5qvCgxkTyF87253", 167m, new DateTime(2024, 8, 9, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3aJVxMr2ZgzWHoPkBEYnvRX86Q555590", 333m, new DateTime(2025, 6, 8, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3dXcUhCYvqgBHuyiMV9xWbmQ3E4FT6PRr83868", 310m, new DateTime(2024, 12, 18, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1H1vhWMB6riXEaZqwzdptVNum3Dfek85673", 164m, new DateTime(2024, 8, 19, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3voYwdxuZt6a9VChDsW5qiT2BySN1550", 315m, new DateTime(2025, 2, 24, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3sZ19Eg75Mi6TnVaJQoc3DHqKGWvfj4778", 336m, new DateTime(2024, 12, 7, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3HiB9wQWcqAxt8GUJeNauDYX3kP26sy7vV86483", 370m, new DateTime(2025, 5, 22, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1PvqKaL4WGDjks9VM87FEimQz6bc2g34529", 126m, new DateTime(2024, 11, 17, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1hGfetg2xpzXoyiL4Y56NuA1D9a88445", 159m, new DateTime(2024, 8, 11, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1sqSD6ijGExKXQyrWRCVPZh2cJ35aHM54156", 111m, new DateTime(2025, 2, 20, 14, 37, 23, 706, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 860m, new DateTime(2023, 11, 16, 19, 37, 23, 714, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 485m, new DateTime(2024, 2, 24, 14, 37, 23, 714, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 650m, new DateTime(2024, 3, 5, 2, 37, 23, 714, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 616m, new DateTime(2023, 11, 13, 12, 37, 23, 714, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 229m, new DateTime(2024, 3, 29, 16, 37, 23, 714, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 291m, new DateTime(2023, 11, 19, 5, 37, 23, 714, DateTimeKind.Local).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 508m, new DateTime(2023, 11, 26, 12, 37, 23, 714, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 306m, new DateTime(2023, 11, 7, 10, 37, 23, 714, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 6, 10, 14, 37, 23, 701, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Quia nulla ullam nam fugiat.", new DateTime(2024, 6, 10, 0, 37, 23, 721, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Voluptatum eos excepturi.\nEligendi veniam laborum rerum sit aut consequatur eius nihil.\nAmet et qui nihil iste quia aliquid.\nArchitecto dignissimos aspernatur molestiae quo.", new DateTime(2024, 5, 15, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "sit", new DateTime(2024, 5, 28, 8, 37, 23, 721, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Aut molestias quia asperiores.", new DateTime(2024, 5, 10, 22, 37, 23, 721, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "architecto", new DateTime(2024, 5, 13, 20, 37, 23, 721, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Quam et quos saepe odit inventore est omnis repellat et.", new DateTime(2024, 6, 1, 22, 37, 23, 721, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Vel magnam sint. Sit quis inventore exercitationem tenetur. Dolorum porro labore eveniet. Et maiores dignissimos. Tempora sit aperiam assumenda fuga porro nobis eos voluptas. Sed culpa nemo natus atque.", new DateTime(2024, 6, 9, 4, 37, 23, 721, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "sed", new DateTime(2024, 5, 29, 2, 37, 23, 721, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Et fuga maxime neque.\nSoluta id qui atque vero in eum quam dolores.\nAut asperiores corporis fugit laborum qui error qui nihil.\nSint consequatur dolore soluta praesentium omnis aut in dolorum eos.\nRerum labore laudantium pariatur labore voluptate.", new DateTime(2024, 5, 27, 8, 37, 23, 721, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Ea temporibus non quia omnis asperiores neque quis. Unde qui iure voluptatem voluptatem. Doloribus qui est vero necessitatibus doloribus quis. Sequi mollitia dolorem est vel tempore veritatis. Et sit tenetur sed nostrum.", new DateTime(2024, 5, 15, 13, 37, 23, 721, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "quis", new DateTime(2024, 5, 9, 9, 37, 23, 721, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Deserunt molestias vitae accusantium et facilis aliquid.", new DateTime(2024, 6, 5, 16, 37, 23, 721, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Est consectetur eum.\nUt et repellendus consequatur consequatur ut cupiditate cumque ut aut.", new DateTime(2024, 5, 10, 22, 37, 23, 721, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Fuga aut ea non consequatur in iusto et ipsum perspiciatis.", new DateTime(2024, 5, 10, 21, 37, 23, 721, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Et dolorum corporis.\nDolores quisquam ea veritatis sunt velit excepturi saepe sint illo.", new DateTime(2024, 5, 28, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Consequuntur sunt quis dolor sit laboriosam quis voluptatem magni.\nMolestias rem cumque dolores dignissimos eius.", new DateTime(2024, 5, 14, 2, 37, 23, 721, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Ut iure sit ea.\nIpsam ut et dolores enim voluptas omnis adipisci est.\nIllum ea quia omnis sed.\nDolores et ipsum praesentium ratione.", new DateTime(2024, 6, 2, 23, 37, 23, 721, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Ab dicta a sapiente aut rerum et at.\nBeatae ad rerum sed est nemo quis est cum perspiciatis.\nAutem nihil quisquam est facilis nulla atque accusantium.", new DateTime(2024, 5, 5, 2, 37, 23, 721, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 3, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 20, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 25, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 14, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 30, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 24, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 17, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 12, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 12, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 4, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 21, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 13, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 16, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 1, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 16, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 18, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 28, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 28, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 31, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 16, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 28, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 27, 14, 37, 23, 721, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "460", "Triston Mitchell", "58939283607581585130", new DateTime(2030, 6, 10, 14, 37, 23, 728, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "035", "Lera Jaskolski", "3472-487266-30640", new DateTime(2028, 6, 10, 14, 37, 23, 728, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "904", "Justus Dach", "6759-9905-4695-0339-19", new DateTime(2026, 6, 10, 14, 37, 23, 728, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "253", "Aida Kertzmann", "5429-4071-5705-3173", new DateTime(2032, 6, 10, 14, 37, 23, 728, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "953", "Rodrigo Nicolas", "670965877021644996", new DateTime(2030, 6, 10, 14, 37, 23, 728, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "741", "Gail Moore", "6011-9485-8804-0679", new DateTime(2030, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "049", "Elisha Hirthe", "3487-490594-23106", new DateTime(2029, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "218", "Theron Ward", "6759-5738-5567-4710-958", new DateTime(2029, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "888", "Marjolaine Ritchie", "5020180367529823435", new DateTime(2026, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "141", "Ola Turner", "6011-2875-4807-4886", new DateTime(2027, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "023", "Mariane MacGyver", "6706583015698929303", new DateTime(2027, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "997", "Izaiah Hintz", "3528-7449-4020-0520", new DateTime(2027, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "302", "Kenton Pfannerstill", "6444-0516-0722-2365", new DateTime(2028, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "183", "Beryl Feest", "6771-8946-9137-7675", new DateTime(2033, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "804", "Major Reynolds", "6771-8957-6561-5130", new DateTime(2030, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "619", "Nicolette Hermann", "3642-054507-1316", new DateTime(2026, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "165", "Evie Simonis", "6392-3756-2705-4405", new DateTime(2027, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "714", "Charles Weber", "6378-3010-6783-6299", new DateTime(2026, 6, 10, 14, 37, 23, 729, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "356", "Elenora McClure", "6759-7878-1701-2839-31", new DateTime(2027, 6, 10, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "246", "Jazmyne Aufderhar", "3577-0103-1474-9025", new DateTime(2029, 6, 10, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "390", "Bonnie Armstrong", "3641-007096-7368", new DateTime(2026, 6, 10, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "603", "Shane Lubowitz", "3724-226963-00900", new DateTime(2033, 6, 10, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 833m, new DateTime(2024, 6, 4, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 178m, new DateTime(2024, 6, 4, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 523m, new DateTime(2024, 5, 29, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 346m, new DateTime(2024, 5, 28, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 103m, new DateTime(2024, 6, 4, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 724m, new DateTime(2024, 5, 29, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 257m, new DateTime(2024, 5, 25, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 441m, new DateTime(2024, 5, 17, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 764m, new DateTime(2024, 5, 21, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 113m, new DateTime(2024, 5, 23, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 173m, new DateTime(2024, 5, 29, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 504m, new DateTime(2024, 5, 25, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 712m, new DateTime(2024, 5, 21, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 965m, new DateTime(2024, 5, 22, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 648m, new DateTime(2024, 5, 25, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 869m, new DateTime(2024, 6, 7, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 847m, new DateTime(2024, 5, 19, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 127m, new DateTime(2024, 5, 23, 14, 37, 23, 730, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CategoryName",
                value: "Jewelery");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CategoryName",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CategoryName",
                value: "Industrial");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CategoryName",
                value: "Jewelery");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CategoryName",
                value: "Books");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CategoryName",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CategoryName",
                value: "Computers");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CategoryName",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CategoryName",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CategoryName",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CategoryName",
                value: "Baby");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CategoryName",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CategoryName",
                value: "Grocery");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CategoryName",
                value: "Computers");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CategoryName",
                value: "Home");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CategoryName",
                value: "Computers");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CategoryName",
                value: "Books");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CategoryName",
                value: "Grocery");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CategoryName",
                value: "Industrial");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 499.36m, "Licensed Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 178.52m, "Licensed Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 759.13m, "Unbranded Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 310.80m, "Ergonomic Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 616.64m, "Refined Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 72.35m, "Rustic Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 843.63m, "Ergonomic Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 116.33m, "Fantastic Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 385.22m, "Refined Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 727.47m, "Rustic Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 778.67m, "Awesome Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 792.49m, "Refined Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 832.47m, "Small Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 467.40m, "Ergonomic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 397.28m, "Intelligent Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 507.48m, "Awesome Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 482.95m, "Handcrafted Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 374.28m, "Sleek Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 189.55m, "Fantastic Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 472.34m, "Handcrafted Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 136.18m, "Refined Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 763.03m, "Practical Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 674.08m, "Fantastic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 493.39m, "Handcrafted Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 683.57m, "Tasty Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 221.03m, "Handcrafted Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 873.74m, "Incredible Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 35.90m, "Practical Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 558.86m, "Refined Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 567.22m, "Sleek Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 808.77m, "Refined Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 26.20m, "Incredible Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 314.47m, "Gorgeous Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 858.03m, "Handmade Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 759.41m, "Tasty Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 289.02m, "Handcrafted Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 252.83m, "Licensed Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 259.46m, "Sleek Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 727.13m, "Licensed Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 736.70m, "Unbranded Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 782.78m, "Unbranded Soft Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 903.75m, "Handcrafted Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 680.47m, "Refined Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 429.27m, "Ergonomic Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 908.78m, "Sleek Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 568.25m, "Unbranded Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 278.71m, "Sleek Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 510.16m, "Gorgeous Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 483.41m, "Ergonomic Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 896.56m, "Practical Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 158.52m, "Practical Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 168.24m, "Incredible Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 269.31m, "Fantastic Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 174.90m, "Practical Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 964.83m, "Gorgeous Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 521.33m, "Small Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 1L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 941m, 25, 329.83m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 5L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 564m, 88, 174.68m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 11L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 306m, 46, 467.00m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 15L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 127m, 24, 95.68m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 43m, 58, 333.39m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 294m, 17, 573.19m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 962m, 20, 119.48m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 295m, 21, 755.01m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 613m, 97, 439.23m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 468m, 25, 984.98m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 771m, 92, 734.03m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 768m, 64, 381.17m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 102m, 37, 359.44m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 900m, 43, 530.09m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 10L },
                columns: new[] { "DiscountUnitPrice", "UnitPrice" },
                values: new object[] { 606m, 811.77m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 866m, 87, 787.27m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 401m, 15, 215.61m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 4L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 203m, 63, 557.62m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 863m, 86, 185.41m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 14L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 478m, 70, 878.86m });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "In laudantium sed at tempora sed rerum et temporibus cumque.", new DateTime(2024, 5, 11, 14, 37, 23, 755, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Esse harum maxime veritatis quia.", new DateTime(2024, 3, 2, 14, 37, 23, 755, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Consequatur est ad rem tempore.\nQuis voluptate quidem incidunt eos.\nAnimi dolorem est enim quia qui tenetur voluptatum aliquid magni.\nDolore eum eaque.\nEos ratione consequatur quibusdam qui eum inventore.", new DateTime(2024, 5, 21, 14, 37, 23, 755, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Unde incidunt sapiente neque accusamus culpa. Voluptatum dolorem adipisci saepe nemo et corrupti. Atque natus non inventore. Omnis quasi nostrum doloribus sed iste sit dolorem. Consequatur quasi eos voluptas iste. Corporis laborum non hic sit est tempore odio exercitationem.", new DateTime(2024, 5, 11, 14, 37, 23, 755, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Sit eos harum accusamus quas dolores doloribus ut.", new DateTime(2024, 3, 2, 14, 37, 23, 755, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Non officia rem ipsa et labore. Harum eius rerum at distinctio tenetur voluptatem culpa magni aspernatur. Reprehenderit ea qui illum aut velit. Cum ut aliquid. Assumenda eveniet ipsam sed rerum quis qui voluptas aut. Rem quasi quaerat aut enim hic aut ea earum.", new DateTime(2024, 5, 21, 14, 37, 23, 755, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 26, 14, 37, 23, 761, DateTimeKind.Local).AddTicks(6086), "omnis" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 17, 14, 37, 23, 761, DateTimeKind.Local).AddTicks(6211), "In nobis repellat consequatur est voluptates aspernatur corrupti quam." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 18, 14, 37, 23, 761, DateTimeKind.Local).AddTicks(6434), "Ea eum in et animi omnis ut.\nVoluptatem nemo sapiente necessitatibus qui.\nQuae qui ut quia quia ut rerum impedit iste.\nPossimus voluptatem beatae officiis quis quo distinctio." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 8, 14, 37, 23, 761, DateTimeKind.Local).AddTicks(6761), "Laudantium dolor ab sequi explicabo incidunt eum." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 7, 14, 37, 23, 761, DateTimeKind.Local).AddTicks(6821), "Quia provident ipsum consequatur consequatur nisi neque exercitationem consequatur quae.\nRepudiandae eveniet voluptas quaerat doloribus.\nOmnis inventore culpa et.\nUt velit veniam cum aut molestiae." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 37, 23, 761, DateTimeKind.Local).AddTicks(7072), "Fugiat nulla deleniti sit.\nCulpa et qui non omnis voluptas distinctio voluptates aut consequatur.\nFugit voluptates corporis id totam at." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 26, 14, 37, 23, 761, DateTimeKind.Local).AddTicks(7263), "velit" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 17, 14, 37, 23, 761, DateTimeKind.Local).AddTicks(7277), "Modi nam ut nisi enim mollitia.\nUnde sed eum id.\nExpedita sed omnis accusamus incidunt at.\nDelectus aut enim eius cumque quae.\nAccusantium beatae corporis delectus.\nNesciunt accusamus accusantium voluptatibus recusandae aliquam dolorum sed." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 18, 14, 37, 23, 761, DateTimeKind.Local).AddTicks(7637), "Veritatis et rerum officiis numquam neque qui dignissimos voluptatum. Tempora praesentium aut molestiae. Voluptates ut qui velit dicta maxime vel et ducimus. Necessitatibus delectus sit ut possimus asperiores. Iure ut non aut ea saepe sed aliquam." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 8, 14, 37, 23, 761, DateTimeKind.Local).AddTicks(7989), "Error corporis et culpa ut." });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1mVtr3jPyuK8nhG1eiW9cD72ZkpQ", new DateTime(2024, 6, 6, 14, 37, 23, 766, DateTimeKind.Local).AddTicks(8360), "IHWAMSI1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1Yjydn87CDTkUp9K5LRvQuVcH4a1Z", new DateTime(2024, 6, 5, 14, 37, 23, 766, DateTimeKind.Local).AddTicks(8591), "WYSEMPX1168" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "39sDBTC5zaXEopAj6uJUbdinqV7", new DateTime(2024, 4, 26, 14, 37, 23, 766, DateTimeKind.Local).AddTicks(8672), "DKBEMUL1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1zcgfsu8xFjEtnPvkwmDiGWh6qoMZH", new DateTime(2024, 4, 26, 14, 37, 23, 766, DateTimeKind.Local).AddTicks(8800), "VGOASJW1315" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1au3KD9pP7qZMUBrNwey1s6jG4Tx", new DateTime(2024, 6, 7, 14, 37, 23, 766, DateTimeKind.Local).AddTicks(8899), "MFHAAFH1487" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1Wn7scy6TAuPbotLg1jqpJSF8QD9Ev2iwB", new DateTime(2024, 5, 30, 14, 37, 23, 766, DateTimeKind.Local).AddTicks(8970), "HQSOTTN1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3xXZsKr8QJ6NCLtn3ARHPbTh9WSvc", new DateTime(2024, 4, 15, 14, 37, 23, 766, DateTimeKind.Local).AddTicks(9045), "PXZABME1254" });
        }
    }
}
