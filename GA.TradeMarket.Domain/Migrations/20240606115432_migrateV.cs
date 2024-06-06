using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class migrateV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25e446cc-9bce-4f9e-aee8-7c8490387ed7", "AQAAAAIAAYagAAAAED5lnFFF5WWGq2kbmym5ronT+NE/6sUikqB9tfaflECIZkhIaAGrknT+QTRZFKr0pw==", "64dbfd49-08b1-4c53-9d2d-1c73a796a0d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2002, 6, 6, 15, 54, 30, 949, DateTimeKind.Local).AddTicks(1276), "2e3e7878-d0ba-4495-82f2-6f9592625c32", "leola@tillmankassulke.ca", "Lang", "(852)455-5897 x568", "09cc16fa-efc7-46db-a288-f7188aa2988b", "McGlynn", "rhoda.paucek" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1996, 6, 6, 15, 54, 30, 950, DateTimeKind.Local).AddTicks(2924), "caaba42a-e683-4d02-a8b4-628c106c9c38", "gustave.braun@whitespinka.co.uk", "Lehner", "(390)251-8791", "11b58e7d-49de-4835-942e-c3cbc763e8e1", "Predovic", "teagan_homenick" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1990, 6, 6, 15, 54, 30, 950, DateTimeKind.Local).AddTicks(8569), "c2f78733-1165-4e0a-a897-ca2c900c3699", "joaquin_metz@hilpert.com", "Rutherford", "452.465.2306", "35f37133-623d-488e-a64c-82cc3ae23d0e", "Cartwright", "mara_gleason" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2013, 6, 6, 15, 54, 30, 953, DateTimeKind.Local).AddTicks(1172), "91945edc-e793-4ca3-8f63-1624ebf939a0", "felicia@oberbrunnercrona.ca", "Kunze", "1-237-401-8152", "f59ca2ee-f882-42fb-a08e-980f18bbaff5", "Corkery", "hardy_okuneva" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1996, 6, 6, 15, 54, 30, 953, DateTimeKind.Local).AddTicks(8471), "6c851b8e-ad88-4bf8-8332-58d9c825ce80", "vincent@sawaynbechtelar.info", "Funk", "1-933-502-8313 x1990", "6484ef31-8fa4-4b69-95f0-cfa46af3a458", "Dach", "noah" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1967, 6, 6, 15, 54, 30, 954, DateTimeKind.Local).AddTicks(4625), "a8b4f503-2833-4906-aae6-07ee056b8a21", "sigmund@cummerata.co.uk", "Skiles", "281-839-7278 x156", "59ca6a9d-1ddd-4fff-a754-6f6987a8acf9", "Crooks", "kira" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1998, 6, 6, 15, 54, 30, 955, DateTimeKind.Local).AddTicks(1641), "599fc16c-fb9c-4224-9cd8-f829de02320f", "carley.windler@marvin.uk", "Ruecker", "473.456.7216 x048", "9631bcf4-a3fb-4b24-8699-42578ba83608", "Stark", "jadon" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2013, 6, 6, 15, 54, 30, 955, DateTimeKind.Local).AddTicks(7606), "1ab79499-61bc-4bd0-b418-ee5e65e06534", "norwood.quigley@wintheiser.name", "O'Hara", "556-424-9392 x062", "3404a20c-aaad-47d2-ac81-21d3bcf95413", "Weissnat", "pat.wiza" });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2425), 317 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2441), 306 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2004, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2444), 541 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2015, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2449), 534 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2012, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2453), 762 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2020, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2458), 863 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2011, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2462), 498 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2001, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2466), 861 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2470), 136 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2001, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2474), 570 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2011, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2479), 204 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2018, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2483), 888 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2488), 825 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2012, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2492), 561 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2011, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2497), 512 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2501), 393 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2505), 408 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2510), 560 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1996, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2514), 808 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2002, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2518), 518 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1996, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2523), 866 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2527), 647 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2002, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2546), 419 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2011, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2550), 554 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2000, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2554), 141 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2015, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2558), 821 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2562), 418 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2016, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2566), 368 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2012, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2570), 787 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2574), 634 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2578), 651 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2015, 6, 6, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(2582), 310 });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1awjizZJvKEeCtypR6HkdbqXgfP8B42D78212", 389m, new DateTime(2025, 2, 7, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1MWTepNfjoHBwyi1mt8angCFduqLc759Q59676", 213m, new DateTime(2025, 2, 28, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3tdrZyqoCLX3s95mYU4nzi2EA6HMb55255", 206m, new DateTime(2024, 12, 14, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1sQmPwAGXcx6ikBMdtL7FK8NoayW27107", 232m, new DateTime(2025, 6, 14, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1qEuBMdKCSw86nQWZADmb17N5JicjRfHx3t74769", 160m, new DateTime(2025, 8, 15, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1d6wxioXMcrq2GFVpgfS3by7knWZ78006", 172m, new DateTime(2025, 2, 2, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3U3NmvaobH1BVetjJQnPLsM4E7hxSp52962", 343m, new DateTime(2024, 7, 29, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "34soyVAXtF271np9M6kvimeJjBhzW8GL56774", 264m, new DateTime(2025, 7, 13, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1JsrQGdYU4RcfTegk3hSFvzDM8EPt80579", 160m, new DateTime(2025, 1, 10, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3L5qJ1xoMr6RKpDkEwunvdPsQfXt69857", 131m, new DateTime(2025, 3, 15, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1vVM1o5KGwXU9QdiNn4rmyLBzfxEgDJ6T32782", 377m, new DateTime(2025, 3, 17, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3PkBVbDztXjn8C6u1maicLxvyUr3R55035", 231m, new DateTime(2024, 8, 13, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3fm4MBKudWNHjewGLqc2CZoFsV130980", 164m, new DateTime(2024, 7, 12, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3dm3XMzEi2P6BjL5g7Wns48yaC16848", 221m, new DateTime(2025, 7, 31, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1SZn8NLgXbUG7CQmJD3KTo6p1jsq4dcBVP26552", 193m, new DateTime(2025, 3, 16, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "127UrGowyWNFvMgVjsn5bmTQY8e1i6ht80048", 127m, new DateTime(2024, 11, 19, 15, 54, 30, 948, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 553m, new DateTime(2023, 12, 30, 5, 54, 30, 956, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 285m, new DateTime(2023, 10, 10, 17, 54, 30, 956, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 661m, new DateTime(2023, 6, 21, 3, 54, 30, 956, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 117m, new DateTime(2024, 4, 29, 15, 54, 30, 956, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 877m, new DateTime(2023, 7, 9, 1, 54, 30, 956, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 307m, new DateTime(2023, 6, 20, 22, 54, 30, 956, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 664m, new DateTime(2024, 1, 17, 19, 54, 30, 956, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 555m, new DateTime(2024, 4, 8, 20, 54, 30, 956, DateTimeKind.Local).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 6, 6, 15, 54, 30, 939, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Et voluptas eos doloremque repellendus minus temporibus libero fugit et.\nNobis dolorem quis illo recusandae quia enim quas et.\nAut necessitatibus animi ex quasi quis dolores suscipit quo.\nEum voluptatem neque sequi qui atque.\nEst voluptas rerum.", new DateTime(2024, 5, 5, 3, 54, 30, 963, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Deleniti dicta earum.", new DateTime(2024, 5, 19, 19, 54, 30, 964, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Nulla tenetur illum eos deserunt aut occaecati ullam earum dolores.", new DateTime(2024, 4, 27, 6, 54, 30, 964, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "quia", new DateTime(2024, 5, 1, 19, 54, 30, 964, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Omnis voluptates ad eius nam quia nemo modi. Consequatur consequatur magni illo est saepe qui delectus nihil. Sed vero suscipit distinctio quidem perferendis quibusdam minima beatae labore.", new DateTime(2024, 5, 12, 23, 54, 30, 964, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "neque", new DateTime(2024, 5, 16, 18, 54, 30, 964, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "dolore", new DateTime(2024, 6, 3, 7, 54, 30, 964, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Doloribus natus autem voluptate optio et.\nTotam possimus tempore.\nVoluptas iste deleniti adipisci in temporibus ut ut cumque nesciunt.", new DateTime(2024, 6, 4, 2, 54, 30, 964, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Officiis amet beatae molestias.", new DateTime(2024, 5, 20, 1, 54, 30, 964, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Hic dolor quia eos mollitia.", new DateTime(2024, 6, 4, 19, 54, 30, 964, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Doloribus fugiat quo labore deserunt accusantium. Quia nulla ullam nostrum. Et autem sit odit. Ut quidem in at consectetur illum est eaque. Alias nemo temporibus corrupti repudiandae quae rerum quam iure qui. Aut nesciunt quam.", new DateTime(2024, 6, 5, 3, 54, 30, 964, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "et", new DateTime(2024, 5, 29, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Ut explicabo fugit.", new DateTime(2024, 5, 19, 17, 54, 30, 964, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Nemo quisquam atque impedit. Aperiam ullam earum delectus sapiente molestiae. Aut aliquid ducimus et quasi in quia iste quaerat blanditiis. Omnis quas eaque necessitatibus deserunt praesentium accusamus omnis dolores voluptas. In aut molestias dolorum quidem quidem repellendus officia non.", new DateTime(2024, 5, 3, 5, 54, 30, 964, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "qui", new DateTime(2024, 5, 12, 4, 54, 30, 964, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Nobis sequi eveniet.\nUt eius consectetur.\nItaque consequatur ratione inventore autem.\nFugiat consequatur exercitationem iste dolor explicabo est sit itaque.\nPlaceat impedit aspernatur et aut hic.\nAut sed qui.", new DateTime(2024, 5, 15, 3, 54, 30, 964, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Voluptatum est quia amet architecto illo maiores porro.\nQuos iste et est mollitia nihil odit ex ratione.\nCum rerum recusandae reprehenderit est.\nUt et autem atque ipsum laborum amet corrupti expedita perferendis.\nDebitis exercitationem totam quam autem.", new DateTime(2024, 5, 3, 14, 54, 30, 964, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "in", new DateTime(2024, 5, 7, 21, 54, 30, 964, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 11, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 30, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 13, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 1, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 10, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 5, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 10, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 17, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 25, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 29, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 4, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 9, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 22, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 29, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 11, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 25, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 31, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 24, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 8, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 20, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 9, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 8, 15, 54, 30, 964, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "800", "Gennaro Stokes", "4048-6497-6752-4317", new DateTime(2028, 6, 6, 15, 54, 30, 973, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "744", "Donnell Rosenbaum", "6771846782137103", new DateTime(2029, 6, 6, 15, 54, 30, 974, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "114", "Brandon Wilderman", "6771-8904-5125-0649", new DateTime(2026, 6, 6, 15, 54, 30, 974, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "512", "Kole Smith", "6771-8987-8885-1062", new DateTime(2030, 6, 6, 15, 54, 30, 974, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "409", "Haylee Nicolas", "6372-3280-6897-8719", new DateTime(2031, 6, 6, 15, 54, 30, 974, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "377", "Kaela Homenick", "6395-7383-3381-4577", new DateTime(2032, 6, 6, 15, 54, 30, 974, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "664", "Christina Nicolas", "676236078550174964", new DateTime(2027, 6, 6, 15, 54, 30, 975, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "113", "Ahmed Kassulke", "5138-3197-0224-9994", new DateTime(2026, 6, 6, 15, 54, 30, 975, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "040", "Scottie Heathcote", "3731-181935-19211", new DateTime(2033, 6, 6, 15, 54, 30, 975, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "976", "Domingo Deckow", "4680011011579", new DateTime(2027, 6, 6, 15, 54, 30, 975, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "923", "Janessa Schinner", "4249954317656", new DateTime(2031, 6, 6, 15, 54, 30, 975, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "470", "Alek Abernathy", "3447-643690-88493", new DateTime(2031, 6, 6, 15, 54, 30, 975, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "794", "Gideon Botsford", "6472-2304-2540-9009", new DateTime(2026, 6, 6, 15, 54, 30, 975, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "225", "Jarrett Funk", "5170-9364-0192-9441", new DateTime(2031, 6, 6, 15, 54, 30, 975, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "866", "Lafayette Waelchi", "676338900553648909", new DateTime(2026, 6, 6, 15, 54, 30, 975, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "205", "Shanelle Barton", "5020-1161-3820-6312", new DateTime(2030, 6, 6, 15, 54, 30, 976, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "640", "Nat Barton", "6381-0120-0328-4123", new DateTime(2032, 6, 6, 15, 54, 30, 976, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "722", "Bailey Huel", "3792-232800-21222", new DateTime(2026, 6, 6, 15, 54, 30, 976, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "264", "Danika Macejkovic", "5020-1154-0720-1947", new DateTime(2029, 6, 6, 15, 54, 30, 976, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "577", "Christiana Auer", "6771-8969-9119-6143", new DateTime(2032, 6, 6, 15, 54, 30, 976, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "165", "Ophelia Lehner", "3678-616973-5547", new DateTime(2029, 6, 6, 15, 54, 30, 976, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "672", "Elsa Casper", "6011-6255-9956-4572-3804", new DateTime(2029, 6, 6, 15, 54, 30, 976, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 839m, new DateTime(2024, 5, 27, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 972m, new DateTime(2024, 5, 27, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 115m, new DateTime(2024, 5, 30, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 460m, new DateTime(2024, 5, 27, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 210m, new DateTime(2024, 5, 22, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 262m, new DateTime(2024, 5, 29, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 889m, new DateTime(2024, 5, 26, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 151m, new DateTime(2024, 5, 28, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 684m, new DateTime(2024, 5, 25, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 82m, new DateTime(2024, 5, 28, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 371m, new DateTime(2024, 5, 22, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 521m, new DateTime(2024, 5, 24, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 875m, new DateTime(2024, 5, 18, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 689m, new DateTime(2024, 5, 29, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 612m, new DateTime(2024, 5, 8, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 210m, new DateTime(2024, 5, 30, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 854m, new DateTime(2024, 5, 15, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 451m, new DateTime(2024, 5, 9, 15, 54, 30, 977, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CategoryName",
                value: "Books");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CategoryName",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CategoryName",
                value: "Baby");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CategoryName",
                value: "Grocery");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CategoryName",
                value: "Sports");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CategoryName",
                value: "Sports");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CategoryName",
                value: "Movies");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CategoryName",
                value: "Home");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CategoryName",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CategoryName",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CategoryName",
                value: "Kids");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CategoryName",
                value: "Computers");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CategoryName",
                value: "Jewelery");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CategoryName",
                value: "Kids");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CategoryName",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CategoryName",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CategoryName",
                value: "Garden");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 799.12m, "Tasty Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 751.34m, "Unbranded Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 574.49m, "Unbranded Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 820.90m, "Awesome Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 409.09m, "Licensed Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 546.32m, "Fantastic Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 750.99m, "Fantastic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 881.69m, "Unbranded Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 450.10m, "Unbranded Steel Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 536.17m, "Tasty Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 201.58m, "Handcrafted Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 506.86m, "Generic Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 343.29m, "Rustic Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 410.76m, "Ergonomic Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 138.29m, "Tasty Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 372.87m, "Awesome Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 337.88m, "Gorgeous Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 782.89m, "Refined Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 475.34m, "Sleek Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 648.62m, "Practical Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 664.69m, "Tasty Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 684.06m, "Ergonomic Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 43.90m, "Tasty Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 803.72m, "Awesome Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 500.50m, "Tasty Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 463.13m, "Refined Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 124.15m, "Intelligent Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 222.17m, "Practical Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 741.55m, "Incredible Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 865.98m, "Intelligent Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 186.62m, "Small Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 914.31m, "Handmade Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 738.71m, "Intelligent Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 798.92m, "Incredible Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 418.25m, "Awesome Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 136.52m, "Awesome Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 824.86m, "Practical Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 5.57m, "Intelligent Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 904.02m, "Tasty Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 408.21m, "Fantastic Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 367.81m, "Tasty Soft Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 456.96m, "Small Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 648.02m, "Practical Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 552.57m, "Handcrafted Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 740.82m, "Tasty Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 199.80m, "Ergonomic Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 256.42m, "Intelligent Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 181.74m, "Handcrafted Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 790.51m, "Small Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 195.21m, "Unbranded Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 957.09m, "Handcrafted Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 565.99m, "Awesome Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 119.90m, "Tasty Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 941.64m, "Ergonomic Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 23.70m, "Handcrafted Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 327.95m, "Handmade Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 1L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 639m, 25, 208.73m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 5L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 799m, 80, 85.77m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 11L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 549m, 33, 673.90m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 15L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 371m, 17, 288.31m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 110m, 56, 816.48m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 966m, 37, 856.40m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 388m, 40, 723.03m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 53m, 18, 467.60m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 409m, 63, 522.99m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 539m, 41, 987.68m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 733m, 94, 448.80m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 958m, 74, 169.20m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 243m, 46, 981.64m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 684m, 88, 874.20m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 10L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 821m, 14, 393.83m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 648m, 47, 820.74m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 218m, 18, 626.70m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 4L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 522m, 27, 924.90m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 534m, 94, 491.33m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 14L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 993m, 39, 508.52m });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Voluptas hic magni praesentium. Quos id enim beatae deleniti perspiciatis aut aut. Laboriosam at laudantium cupiditate.", new DateTime(2024, 5, 7, 15, 54, 31, 15, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "veniam", new DateTime(2024, 2, 27, 15, 54, 31, 15, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Consectetur illum reiciendis est iure accusamus aut adipisci. Sint officia fugit praesentium voluptatem quidem iste veritatis doloribus sint. Velit voluptates dolorem et quasi eos. Aut est nobis est nisi. Et velit nemo omnis illum quia eos deleniti accusantium. Atque cumque vel provident voluptatibus atque facilis enim et.", new DateTime(2024, 5, 17, 15, 54, 31, 15, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Dolor dolorem sed molestiae dignissimos dolores voluptas repudiandae dolorum cumque.", new DateTime(2024, 5, 7, 15, 54, 31, 15, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Aut possimus non accusamus aut.\nQuaerat voluptatum quos.\nVoluptatibus consectetur iste.", new DateTime(2024, 2, 27, 15, 54, 31, 15, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Molestiae qui minima at pariatur qui.", new DateTime(2024, 5, 17, 15, 54, 31, 15, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 54, 31, 23, DateTimeKind.Local).AddTicks(8284), "Voluptate et non aut sit vero corrupti suscipit. Necessitatibus quia neque sed autem magni laborum accusamus. Et odit inventore expedita. Iusto omnis fuga ut doloribus consequuntur quae qui." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 54, 31, 23, DateTimeKind.Local).AddTicks(8874), "Est maiores quae dolores." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 14, 15, 54, 31, 23, DateTimeKind.Local).AddTicks(8923), "Maxime mollitia facere quo sed unde repellat sint libero a.\nIure et quisquam voluptas facilis in ad.\nMaxime qui quidem.\nDebitis repudiandae beatae non deleniti." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 54, 31, 23, DateTimeKind.Local).AddTicks(9121), "Ipsum est quod." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 3, 15, 54, 31, 23, DateTimeKind.Local).AddTicks(9158), "Nulla repellat non reprehenderit tenetur sequi excepturi tempora.\nEa quas ad aperiam.\nRerum deleniti explicabo nostrum." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 54, 31, 23, DateTimeKind.Local).AddTicks(9349), "rerum" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 54, 31, 23, DateTimeKind.Local).AddTicks(9388), "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 54, 31, 23, DateTimeKind.Local).AddTicks(9400), "Eum et enim qui inventore sequi assumenda voluptate quia." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 14, 15, 54, 31, 23, DateTimeKind.Local).AddTicks(9467), "Aliquid aut itaque non ratione eligendi iusto omnis asperiores. Voluptatibus sint natus. Optio quidem ipsa. Sed rem deserunt enim asperiores ut. Impedit libero pariatur laborum earum nam suscipit necessitatibus qui. Dolor a exercitationem odio rerum ut molestiae officia." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 54, 31, 23, DateTimeKind.Local).AddTicks(9811), "Numquam qui animi quibusdam sequi tempora. Voluptatibus id eligendi est velit neque fugit. Quis dolores necessitatibus. Temporibus et enim rem autem molestias repudiandae." });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1GAjgcrL1J9DtqEYoURZ83dQabz", new DateTime(2024, 6, 2, 15, 54, 31, 30, DateTimeKind.Local).AddTicks(5960), "VYCUPFF1VET" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3cZMorCEignGT6UWKuRYB7qJ3XDd9tHmsh", new DateTime(2024, 6, 1, 15, 54, 31, 30, DateTimeKind.Local).AddTicks(6351), "PPOUCUR1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1qct6FBUSxQnhGEPaX5zvYRdZLru8b", new DateTime(2024, 4, 22, 15, 54, 31, 30, DateTimeKind.Local).AddTicks(6482), "EZSOINH1155" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1G5SkimRLavTMendNobZ3jw6hCV2usUD7Px", new DateTime(2024, 4, 22, 15, 54, 31, 30, DateTimeKind.Local).AddTicks(6647), "ETZUPWB1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "34RpC8jmigoYSZKTvJdEW1FcGL57Vr", new DateTime(2024, 6, 3, 15, 54, 31, 30, DateTimeKind.Local).AddTicks(6771), "LRHUSNY1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1ygtDcaYSKzu8PA2nj3FxbqkNMmRUB9d4", new DateTime(2024, 5, 26, 15, 54, 31, 30, DateTimeKind.Local).AddTicks(6888), "KZQOVCR1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3CHideTrS4WGtj1E7Y6Ug5RxyQkZFPzXcq", new DateTime(2024, 4, 11, 15, 54, 31, 30, DateTimeKind.Local).AddTicks(7034), "HHQIKEW1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ae4cb48-efb1-44ba-8dc3-19f8cad7b417", "AQAAAAIAAYagAAAAEF+ZrWAZ2Uf2gnK79tx8bWrI4W2vi7yRKCVxqrHQipG1ZaQVvb9jtGbNN38EaKF49Q==", "b62596ec-53cd-4364-8b58-0c4a47a4fee3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1991, 6, 5, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(9788), "cacf77a9-b257-435b-8f91-9cfc4af15f61", "madonna@bradtke.info", "Sipes", "1-587-236-8262", "1374e85e-67b0-46a3-97be-da8e83e36fc0", "Mitchell", "lavada.maggio" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2002, 6, 5, 19, 36, 18, 405, DateTimeKind.Local).AddTicks(3766), "a1c5816f-145b-4ce0-b619-99508a902ca8", "douglas_padberg@dooley.co.uk", "Jaskolski", "(076)831-5995 x863", "b96cfa6d-c354-40e7-9c2b-a7311b7cc94c", "Wisoky", "julius.herzog" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2000, 6, 5, 19, 36, 18, 405, DateTimeKind.Local).AddTicks(7343), "c3cbf39c-4840-46d5-847b-fbc364b3066b", "vern@walter.biz", "Hayes", "(665)270-0299 x747", "24f60a45-2327-4d78-a8bc-262215316e55", "Boehm", "kitty_mayer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2007, 6, 5, 19, 36, 18, 406, DateTimeKind.Local).AddTicks(883), "b4911625-62a9-4bfd-8e54-47f531bdf88c", "fletcher@grady.co.uk", "Johnston", "361.030.9912", "bbf23632-952f-4c9b-9b91-131cb9b090b6", "Schroeder", "alek" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2010, 6, 5, 19, 36, 18, 406, DateTimeKind.Local).AddTicks(4030), "40db103e-d747-4e9a-a23c-1ae05c79119e", "kaycee.schaefer@altenwerth.biz", "Spinka", "1-110-974-6757 x261", "be8fc6d6-debe-4955-99ce-e0e9d9176d77", "Swaniawski", "reymundo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1969, 6, 5, 19, 36, 18, 406, DateTimeKind.Local).AddTicks(7123), "0dc04606-8a43-4de1-9653-0716fc613fa2", "santos_maggio@mante.name", "Keebler", "177-687-1861", "66af753c-d4ae-41a5-ac43-09a103c258dc", "Bosco", "nikolas.daniel" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1973, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(441), "6a143355-630c-449c-bd8c-ff64815b1588", "courtney@cummingshagenes.ca", "Parisian", "(478)329-4762", "da2424b4-d1a1-40e4-8fa8-f112c79505fc", "McClure", "audrey" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1989, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(3814), "9606d08a-b5c6-4c19-85ca-37c9dbe20de5", "zoey.schamberger@flatleyskiles.name", "DuBuque", "126.590.7920 x336", "35b0a8a7-bf87-49d8-bff6-7e555e7452d5", "Price", "hulda" });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5597), 958 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5600), 778 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2007, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5602), 356 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2016, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5604), 683 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5606), 876 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2015, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5607), 201 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5609), 983 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5610), 760 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2020, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5612), 661 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2020, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5614), 802 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1996, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5616), 179 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1995, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5617), 766 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2010, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5619), 950 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5621), 516 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2016, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5622), 908 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5624), 372 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5626), 104 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5627), 972 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1997, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5629), 886 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5630), 813 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2022, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5632), 370 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2004, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5634), 536 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2019, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5636), 387 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2004, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5638), 698 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2018, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5640), 411 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5642), 690 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5644), 591 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2011, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5645), 166 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5647), 261 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2001, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5648), 437 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2015, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5650), 766 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 6, 5, 19, 36, 18, 407, DateTimeKind.Local).AddTicks(5652), 557 });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3J2A5vK3awGmT8R9XZoPfkBVM7QH96788", 252m, new DateTime(2025, 5, 6, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1seUNCBgQ1XYTDx48omy35hSbZ9q87952", 267m, new DateTime(2025, 9, 19, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3Zu4KW9AFmxhgedpbTLrSVktcfJEG18438", 102m, new DateTime(2024, 6, 16, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "38vjEVoiw5KA4uPCb2kD1rWczQ6Z3qm9T25553", 233m, new DateTime(2025, 4, 5, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1YfjGD4AECZo9zyXnuwriF2Lk7p3q91480", 152m, new DateTime(2024, 11, 6, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1Gcndskz5KrZ1BHEpPfChxuVJ97Si4e60016", 245m, new DateTime(2024, 8, 29, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1rw5PT6aY4Uoyhgs1b8k27u9ptJqn64295", 167m, new DateTime(2024, 6, 18, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "123g1fPtp7XDEH9UNwrR5YiuCn4yTmQbjSv42428", 126m, new DateTime(2024, 7, 12, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1kSBZD6zp3fdGcJaWYAs5gTUyxt38115", 369m, new DateTime(2024, 8, 5, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1BaDStqFLe9N5zEg6mKoUP3cdVrA8TnJ2415", 393m, new DateTime(2025, 7, 28, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3XKzGJUYVhkdgC9cZ6S1viHqmR5tNL2Tu79503", 112m, new DateTime(2024, 8, 12, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1nbWgmxJQyVcZDU2ELTseaGdPBp4rko96393", 110m, new DateTime(2024, 8, 23, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "38gRY2Svfs7uWHEiGwZUqdzFQJm16917", 360m, new DateTime(2025, 1, 26, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3xrJ3fpzDsUthb5QqVWuXSNjaYL20624", 344m, new DateTime(2025, 7, 28, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3mFdMp9ohibQeJR7AVscktCUu175353", 341m, new DateTime(2025, 2, 4, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1MH1TxKBaZQP3gcfkqGJsVpFR6bv9w2XD8j1289", 166m, new DateTime(2024, 8, 8, 19, 36, 18, 404, DateTimeKind.Local).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 475m, new DateTime(2023, 10, 28, 11, 36, 18, 407, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 819m, new DateTime(2024, 3, 23, 14, 36, 18, 407, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 350m, new DateTime(2023, 10, 10, 7, 36, 18, 407, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 148m, new DateTime(2023, 8, 24, 2, 36, 18, 407, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 811m, new DateTime(2023, 8, 2, 1, 36, 18, 407, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 431m, new DateTime(2023, 9, 27, 23, 36, 18, 407, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 875m, new DateTime(2023, 6, 15, 0, 36, 18, 407, DateTimeKind.Local).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 852m, new DateTime(2023, 10, 31, 20, 36, 18, 407, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 6, 5, 19, 36, 18, 401, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Est illo enim nobis deleniti magnam ut eum corrupti deleniti.", new DateTime(2024, 6, 2, 9, 36, 18, 409, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "ut", new DateTime(2024, 5, 18, 7, 36, 18, 409, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "numquam", new DateTime(2024, 6, 1, 7, 36, 18, 409, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "animi", new DateTime(2024, 5, 3, 23, 36, 18, 409, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Minima laboriosam officiis est iure. Eius quo sequi est qui esse deleniti possimus enim. Minus voluptatem ab fugit id. Cum ullam temporibus et earum.", new DateTime(2024, 5, 21, 11, 36, 18, 409, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Ut sit praesentium ut dolores consectetur veniam numquam quia quia. Recusandae ducimus ad perspiciatis facere delectus doloribus aut voluptatibus ex. Recusandae eos possimus quia. Ut similique maxime aliquam quae laboriosam nobis itaque. Libero aut necessitatibus et excepturi quas iusto dolore atque expedita.", new DateTime(2024, 5, 6, 5, 36, 18, 409, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Ipsum sapiente iure facere architecto aspernatur voluptas nulla harum.", new DateTime(2024, 5, 23, 20, 36, 18, 409, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Enim pariatur qui animi.\nVelit commodi fugit rerum reiciendis ex.\nVitae ipsam non corrupti illum repudiandae doloremque.\nRerum iste repellat aspernatur ea.", new DateTime(2024, 6, 1, 1, 36, 18, 409, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Officiis dignissimos impedit cumque eius omnis repellendus cumque dolorem perspiciatis. Culpa neque doloribus. Nam aliquam soluta explicabo sed ut dignissimos animi tenetur quia. Omnis veritatis dolores quod. Incidunt nulla laudantium eum autem quod neque. Nulla placeat enim est quos corporis impedit saepe.", new DateTime(2024, 5, 7, 14, 36, 18, 409, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "perspiciatis", new DateTime(2024, 5, 18, 16, 36, 18, 409, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Tempora id esse sunt molestiae necessitatibus delectus aut est.\nAut enim quis.\nDolorem incidunt minima quibusdam non dolorum totam.\nSequi eum et velit maxime mollitia nisi excepturi impedit.\nEt officiis et porro.\nSint et enim porro ut sed.", new DateTime(2024, 5, 2, 3, 36, 18, 409, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Beatae et ipsa fuga est adipisci asperiores ipsa ullam. Voluptatem sit blanditiis sunt ea in doloremque consequatur aliquid. Consectetur doloribus illo nesciunt velit sed ipsam.", new DateTime(2024, 5, 14, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "In atque est quae veniam aut unde nobis. Nemo quaerat qui harum aliquam error ipsum dolores. Officiis neque dolor incidunt enim amet unde perferendis eos. Animi ipsa est ipsam. Numquam possimus accusantium quis et cum. Et voluptas maiores earum assumenda et saepe corrupti.", new DateTime(2024, 4, 26, 13, 36, 18, 409, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "est", new DateTime(2024, 5, 14, 15, 36, 18, 409, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Velit delectus cum laboriosam accusamus magnam porro quis minus iure.", new DateTime(2024, 6, 3, 8, 36, 18, 409, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "qui", new DateTime(2024, 5, 5, 14, 36, 18, 409, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Numquam eos voluptatem voluptas dolorem.\nQuam fuga non velit sint blanditiis nulla blanditiis dolores dolor.\nOdio officia sapiente beatae cumque.", new DateTime(2024, 5, 4, 0, 36, 18, 409, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Odit dolore ut perspiciatis atque. Et sit sed atque et harum molestiae expedita aperiam. Quo consequatur modi animi architecto exercitationem ut vel laborum ipsum. Rerum ratione ipsa commodi est non ut labore voluptatem et. Eos quisquam eveniet expedita quia pariatur repudiandae est qui omnis. Vel omnis minus natus nisi vero doloribus.", new DateTime(2024, 6, 1, 20, 36, 18, 409, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 26, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 25, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 16, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 24, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 29, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 27, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 13, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 25, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 30, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 19, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 4, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 31, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 24, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 20, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 30, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 1, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 14, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 17, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 8, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 14, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 7, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 22, 19, 36, 18, 409, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "665", "Brett Bode", "3631-769905-4587", new DateTime(2030, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "670", "Belle Zemlak", "5020-0437-3547-0812", new DateTime(2029, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "140", "Fritz Harris", "4576-8874-0702-0458", new DateTime(2032, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "601", "Fae Kris", "4227-8399-0057-8303", new DateTime(2026, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "809", "Jacey Spencer", "3499-828201-15227", new DateTime(2030, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "000", "Maggie Legros", "6767-9477-3680-7203-651", new DateTime(2027, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "944", "Emmett Cronin", "5461-8407-6035-8689", new DateTime(2030, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "334", "Flossie Fadel", "4965042728600", new DateTime(2032, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "064", "Evert Towne", "4141381175676", new DateTime(2026, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "870", "Justyn Gibson", "677187964880118259", new DateTime(2028, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "974", "Sally Fadel", "4014314333540", new DateTime(2026, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "188", "Dejah O'Connell", "6304003837769789", new DateTime(2031, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "617", "Vicky Douglas", "5412-2131-5042-5742", new DateTime(2028, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "418", "Bobbie Sanford", "5018-4518-4788-4479", new DateTime(2027, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "061", "Ulises Bosco", "6011-0909-7670-7021", new DateTime(2030, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "328", "Patsy Kassulke", "6507-6291-7152-1186-3041", new DateTime(2032, 6, 5, 19, 36, 18, 411, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "621", "Leon Reichert", "6759-1520-6994-4344-92", new DateTime(2029, 6, 5, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "655", "Aida Smith", "3611-690160-8069", new DateTime(2028, 6, 5, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "134", "Emmalee Parisian", "3528-0381-3666-9741", new DateTime(2032, 6, 5, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "434", "Felicia Anderson", "6706751844482184", new DateTime(2027, 6, 5, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "030", "Claudie Lemke", "3749-794247-02028", new DateTime(2030, 6, 5, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "832", "Josue Monahan", "6304294382632056", new DateTime(2029, 6, 5, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 228m, new DateTime(2024, 5, 31, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 207m, new DateTime(2024, 5, 12, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 334m, new DateTime(2024, 5, 10, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 137m, new DateTime(2024, 5, 13, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 423m, new DateTime(2024, 5, 10, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 117m, new DateTime(2024, 5, 13, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 667m, new DateTime(2024, 5, 21, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 156m, new DateTime(2024, 5, 26, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 173m, new DateTime(2024, 5, 27, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 150m, new DateTime(2024, 5, 9, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 73m, new DateTime(2024, 5, 14, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 309m, new DateTime(2024, 5, 21, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 386m, new DateTime(2024, 5, 11, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 552m, new DateTime(2024, 5, 26, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 266m, new DateTime(2024, 5, 24, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 931m, new DateTime(2024, 5, 24, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 141m, new DateTime(2024, 5, 7, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 479m, new DateTime(2024, 6, 2, 19, 36, 18, 412, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CategoryName",
                value: "Movies");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CategoryName",
                value: "Baby");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CategoryName",
                value: "Garden");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CategoryName",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CategoryName",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CategoryName",
                value: "Books");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CategoryName",
                value: "Industrial");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CategoryName",
                value: "Kids");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CategoryName",
                value: "Books");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CategoryName",
                value: "Baby");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CategoryName",
                value: "Books");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CategoryName",
                value: "Jewelery");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CategoryName",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CategoryName",
                value: "Baby");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CategoryName",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CategoryName",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CategoryName",
                value: "Sports");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.1199774952588060m, "Awesome Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2191978140388510m, "Handmade Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2175163043149110m, "Sleek Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.4900740917535490m, "Licensed Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.02029484941155220m, "Awesome Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.7824387228240590m, "Sleek Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.9092841907787180m, "Intelligent Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.9279871432085480m, "Awesome Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.5996093060213140m, "Unbranded Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2618185061205110m, "Unbranded Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.6636549505905810m, "Handcrafted Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.8249837118902130m, "Ergonomic Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.1983739567730270m, "Awesome Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.9551086656633880m, "Sleek Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.1668360118826410m, "Refined Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.7620677267789460m, "Sleek Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.8215582841999580m, "Unbranded Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.681178864683030m, "Ergonomic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3332634446116290m, "Handcrafted Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.6080077535239790m, "Handmade Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3943398993493410m, "Tasty Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.8373996879794650m, "Sleek Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.445839449262230m, "Unbranded Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3246124196953260m, "Small Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.8480842362281310m, "Rustic Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.06588603462917140m, "Awesome Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.8598529866845530m, "Generic Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.1250473407925970m, "Unbranded Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.6867088389753370m, "Rustic Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.4184936100237570m, "Intelligent Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.9966621110933180m, "Incredible Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3568352098309010m, "Gorgeous Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.7716057433819570m, "Refined Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3978252216978750m, "Fantastic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.6797630827033680m, "Handmade Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.903425375922360m, "Handmade Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.9865304442819550m, "Generic Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.7392258065079110m, "Fantastic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2204467709685270m, "Handmade Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2035961374996030m, "Gorgeous Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.6063543994993340m, "Rustic Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2852602672695990m, "Intelligent Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3948335787748440m, "Fantastic Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.4561094340000280m, "Fantastic Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.5278948956693140m, "Rustic Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3888452368755620m, "Small Steel Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.6713734610766130m, "Practical Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.1710872151696260m, "Unbranded Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.1961798324200240m, "Handmade Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2893336375966960m, "Generic Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.1497343575428170m, "Small Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3842044437580190m, "Intelligent Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.8937054258897260m, "Awesome Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.4142864648289580m, "Ergonomic Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.6891507955611480m, "Tasty Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.7580327189391610m, "Fantastic Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 1L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 772m, 29, 161.55m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 5L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 471m, 88, 177.82m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 11L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 768m, 72, 611.09m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 15L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 457m, 83, 301.37m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 837m, 87, 444.66m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 360m, 73, 234.70m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 971m, 89, 7.30m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 70m, 96, 298.41m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 382m, 32, 712.66m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 570m, 28, 618.88m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 146m, 17, 741.00m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 193m, 25, 704.75m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 65m, 38, 207.81m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 547m, 46, 986.43m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 10L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 562m, 54, 754.07m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 546m, 37, 258.06m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 941m, 99, 96.24m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 4L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 867m, 84, 851.67m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 331m, 98, 793.56m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 14L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 743m, 21, 183.94m });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Consequatur optio qui.\nQuia quia non iure quia expedita consequatur.\nEst velit suscipit similique quia quidem aut aut.\nAt expedita non nulla.\nQuo eos omnis.", new DateTime(2024, 5, 6, 19, 36, 18, 419, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Et ea nihil ad nemo aut qui quibusdam beatae sed.", new DateTime(2024, 2, 26, 19, 36, 18, 419, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Omnis explicabo debitis quia perspiciatis.", new DateTime(2024, 5, 16, 19, 36, 18, 419, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Eius laboriosam consequatur illum itaque repellendus id cupiditate aut quaerat.", new DateTime(2024, 5, 6, 19, 36, 18, 419, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Ab et praesentium.", new DateTime(2024, 2, 26, 19, 36, 18, 419, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Incidunt ea voluptatem molestiae nihil beatae tenetur odit porro. Pariatur deleniti est doloribus. Fugit dignissimos impedit culpa veritatis labore perspiciatis.", new DateTime(2024, 5, 16, 19, 36, 18, 419, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 21, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2021), "Velit dolor voluptate eaque repellat. Eos praesentium at officiis dolores quaerat minima. Aut iure consectetur et quis nesciunt non cumque nostrum. Et id sint similique molestiae aspernatur repellendus fugiat consequatur. Voluptatem tempora quo nihil cupiditate nostrum at voluptas distinctio reprehenderit. Quas nobis distinctio doloremque facere." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 12, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2301), "Voluptatum quis rem doloribus quibusdam ut autem neque distinctio. Voluptatem tenetur asperiores perferendis expedita. Ut sed officiis enim aspernatur doloribus et nobis fugit. Maiores at quaerat reprehenderit blanditiis." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2410), "Praesentium odio ut possimus assumenda. Quis iure commodi perspiciatis nesciunt repellendus. Eum delectus harum consequatur quaerat magnam. Ut praesentium temporibus eligendi delectus aut fugit. Veniam quidem temporibus. Magnam eaque aperiam commodi vel quis." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 3, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2559), "perferendis" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 2, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2566), "Debitis est ut consequatur ea incidunt inventore adipisci. Ratione accusantium quam ut harum delectus eos ratione ipsum cum. Voluptas rem assumenda numquam ut id. Laboriosam soluta aut tenetur sit." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 1, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2673), "enim" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 21, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2733), "Odio et corporis culpa tempora nesciunt aut voluptas cumque minima." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 12, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2767), "Et corporis modi. Rerum non ut. Fugiat et deserunt eius nihil eos nobis repellendus officiis quod. Sint accusamus qui." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2842), "deserunt" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 3, 19, 36, 18, 421, DateTimeKind.Local).AddTicks(2847), "Qui aut et ex et. Et doloribus perferendis aut reprehenderit eaque voluptatem eum. Enim velit ducimus quia ut non nisi deserunt incidunt ipsam. Nisi fuga dolorum maiores aut non numquam alias enim sequi." });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1zRkKahWmB3Q58Vd1NHc6qeP7MDTZw", new DateTime(2024, 6, 1, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9334), "THDEMCU1590" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1tZ7JiHhF2GQqxR6wYredSpX9PK8oD", new DateTime(2024, 5, 31, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9475), "XVBUMFJ1533" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "39XaGyvroE8JxtNMjizeZH7wU6K1Qng5", new DateTime(2024, 4, 21, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9523), "OKDIARI1457" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3RwpBdP1JhkWnexmYbD7qacy4LF69rXvTgV", new DateTime(2024, 4, 21, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9569), "IIAUGUW1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "18ktvFbKUSrATeY1QduBfNqgHh", new DateTime(2024, 6, 2, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9615), "FDQOBSQ1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1hgfJFUwRXrcp6E71Tq92yQCunGameido", new DateTime(2024, 5, 25, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9653), "XFPUETS1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3yTsSCxfrWoQ6GP4NveabhY7mgUJZMcDu", new DateTime(2024, 4, 10, 19, 36, 18, 422, DateTimeKind.Local).AddTicks(9747), "JKJOWFD1" });
        }
    }
}
