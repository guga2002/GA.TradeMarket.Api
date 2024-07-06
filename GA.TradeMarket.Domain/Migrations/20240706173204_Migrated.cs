using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Migrated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ed49dbd-14ea-4f9b-bc8c-c644e32fbd2f", "AQAAAAIAAYagAAAAEMUUVt8FaZXFaUv9UasSUddsadhBQpyyHzQXoxSCsZMXt8Ln8wR+x0ApUQqoR6zgkw==", "dcf195c3-4770-4001-8047-6860b2aaace9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1989, 7, 6, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(6599), "c3c6fb2c-2124-43a5-aa9d-0a52e9440458", "arnulfo@hintz.name", "Jakubowski", "(785)155-1607 x151", "dc7c1978-8719-456d-b810-ebb0ef7d2fea", "Auer", "kaelyn_witting" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1966, 7, 6, 21, 32, 3, 472, DateTimeKind.Local).AddTicks(267), "2460dc95-b689-4308-b359-213db78f7f2f", "ezequiel.senger@ohara.uk", "Wintheiser", "(388)361-9761 x820", "a02234e9-23f9-4a0f-8824-bca8e2c547a1", "Nitzsche", "serena" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1972, 7, 6, 21, 32, 3, 472, DateTimeKind.Local).AddTicks(3358), "c4472aac-2921-40f7-a583-a6682212cec0", "telly_bednar@bahringer.ca", "Purdy", "(627)441-6619", "637a223d-59f1-45b2-8b50-810a69569024", "Torphy", "chanelle" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1966, 7, 6, 21, 32, 3, 472, DateTimeKind.Local).AddTicks(6508), "d98a6fcb-941a-411d-aa7c-1915da550a37", "fabiola@glover.us", "Prosacco", "(480)924-9275", "1fc73f1a-3a9e-43eb-8406-69e9ca5c0c05", "Stanton", "heloise_stehr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1979, 7, 6, 21, 32, 3, 473, DateTimeKind.Local).AddTicks(509), "71d54a8b-ea57-4ca9-bafa-2c20e5c81935", "elisabeth_lowe@farrell.uk", "Hermann", "253-089-1563 x0554", "be55de48-23fd-498a-8bac-49e6d082c638", "Graham", "jena" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2003, 7, 6, 21, 32, 3, 473, DateTimeKind.Local).AddTicks(3883), "49d150b6-2667-4269-ab8d-b86151b91f55", "maida_weissnat@johnswunsch.info", "Koelpin", "227-381-5102", "30117a26-127b-4c04-8a4c-ef61f10bf081", "Muller", "alec.price" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2011, 7, 6, 21, 32, 3, 473, DateTimeKind.Local).AddTicks(7085), "61f3e276-7e1d-4dd2-982d-2f49d63bc87f", "russell@gloverbogisich.name", "Spencer", "784.172.6847 x5912", "12ab6030-5c7a-495a-b1d7-6a4a6ed6e6b2", "Schowalter", "emily" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1975, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(617), "f9299378-a04f-46af-a8f5-3b0c299658d7", "karlie@white.uk", "Steuber", "(212)968-1823", "57559af4-6bf4-41df-82a4-df878609eb70", "D'Amore", "zachery_schultz" });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2573), 613 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2020, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2576), 221 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2021, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2578), 975 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2579), 874 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2018, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2581), 334 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1995, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2582), 712 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1995, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2585), 806 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2000, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2586), 878 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2012, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2588), 361 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2017, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2590), 944 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2008, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2592), 951 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2000, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2593), 813 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2595), 484 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2010, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2596), 376 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2021, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2598), 644 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2010, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2600), 947 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2601), 950 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2016, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2603), 632 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2017, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2605), 218 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1996, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2607), 676 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2001, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2608), 774 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2008, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2610), 172 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2611), 707 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2613), 625 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2021, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2615), 965 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2022, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2616), 125 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2618), 307 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2619), 159 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2018, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2621), 636 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2000, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2622), 683 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2019, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2624), 544 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 7, 6, 21, 32, 3, 474, DateTimeKind.Local).AddTicks(2625), 476 });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3cqdYN1ys6XFjhKau52wvRnJ3DHP83419", 131m, new DateTime(2025, 1, 4, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1oj1VP9q8gtsfAbvp6nizrhmJdwDQZ14258", 392m, new DateTime(2025, 10, 27, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "39Dw7vZUydHWqQg8JKE42pzVo5YCiX15542", 108m, new DateTime(2025, 1, 26, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3PtbxVEqJmCAR2fezhGHTQZiFkynjdw93199", 141m, new DateTime(2025, 6, 11, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1RQqa9biU1zCsXnxpcyLE7g8m5D55810", 385m, new DateTime(2025, 1, 3, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1sbXh3WQkMEc8gCxyrt2BHFTzRDpiJKqm37164", 329m, new DateTime(2024, 10, 27, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3ex3qzbhKSogiM2RZ8mBdfsGCuF1paDW653046", 388m, new DateTime(2024, 7, 24, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1vKUsj3VBAeQhbuF1gJiMZkLxm2NT8aHc16514", 163m, new DateTime(2025, 5, 31, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1R8wfj9gQnvpaciNWX3meMBKkZG28732", 312m, new DateTime(2024, 12, 29, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1hYHQ18BR9y25xSutMq7VAiDGXJeFnwmvU76677", 211m, new DateTime(2025, 1, 22, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3ocu42BnwQLrkgSfAmCtPDvMJ652566", 278m, new DateTime(2025, 4, 2, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3i5mWPksZ7oQaJ8AhN1UvuM3FE420160", 335m, new DateTime(2025, 11, 7, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3mTRDtPwU8r4Yih9pMGe16fHcJySFou5773308", 133m, new DateTime(2024, 11, 6, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3D4XYQ73APSyxisdtnJeTRU9cazCLrpHGK631423", 246m, new DateTime(2025, 11, 17, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3NEKVX8drBHZR6tDy49jmb7FYUpCvWGn40479", 210m, new DateTime(2025, 11, 7, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1tTszgmihJYu82PHCf6bkWSM4r614", 167m, new DateTime(2025, 6, 22, 21, 32, 3, 471, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 557m, new DateTime(2024, 6, 1, 16, 32, 3, 474, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 109m, new DateTime(2023, 10, 17, 14, 32, 3, 474, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 323m, new DateTime(2023, 8, 27, 10, 32, 3, 474, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 129m, new DateTime(2024, 3, 19, 22, 32, 3, 474, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 480m, new DateTime(2023, 11, 4, 17, 32, 3, 474, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 131m, new DateTime(2023, 12, 7, 2, 32, 3, 474, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 673m, new DateTime(2023, 10, 8, 18, 32, 3, 474, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 183m, new DateTime(2023, 8, 24, 13, 32, 3, 474, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 7, 6, 21, 32, 3, 468, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Excepturi est sapiente quia minus nam vel excepturi veniam reprehenderit.", new DateTime(2024, 6, 4, 15, 32, 3, 476, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Consectetur possimus laboriosam facilis perspiciatis maiores incidunt earum assumenda. Nisi reiciendis minus ad qui eligendi error numquam et aut. Vitae sed fuga porro ut id. Optio dolorem rerum. Sit quis est. Tenetur iusto repudiandae quasi quas.", new DateTime(2024, 6, 1, 5, 32, 3, 476, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Qui nemo ut excepturi modi doloremque.\nEt ullam blanditiis.\nDucimus sapiente dolores ipsum.\nMolestiae et occaecati expedita consectetur nam commodi.\nDeserunt corporis minus sed et a.", new DateTime(2024, 6, 7, 6, 32, 3, 476, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "In voluptatem quia magni dolores qui unde dolor facilis. Quod perspiciatis consequatur. Dolorem vero eum magni. Ipsa harum quis dolorum nam quas corporis quis necessitatibus et. Nostrum mollitia voluptatibus ea est quae aliquam voluptatibus expedita illo.", new DateTime(2024, 5, 27, 5, 32, 3, 476, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Id quo enim fuga omnis dolores.\nAd est itaque sint voluptas.\nTempore et quae.", new DateTime(2024, 6, 3, 0, 32, 3, 476, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Delectus facere culpa.\nVeniam facilis nihil molestiae labore tempore.\nIure cum quibusdam doloribus natus rerum alias maiores.\nOccaecati porro ut facilis.", new DateTime(2024, 6, 26, 15, 32, 3, 476, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "iusto", new DateTime(2024, 5, 31, 8, 32, 3, 476, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Veniam nam temporibus qui vitae quidem corporis non nobis corrupti.\nTotam consequatur voluptas atque voluptas voluptatem fugit unde.\nPlaceat rerum omnis repellat.\nAut voluptas voluptatem alias et.\nIn libero assumenda cum quod reprehenderit adipisci.\nId voluptatem fugit minima vitae nobis ut.", new DateTime(2024, 6, 25, 11, 32, 3, 476, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Quo necessitatibus itaque vel et vel.", new DateTime(2024, 6, 24, 13, 32, 3, 476, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Quidem a corrupti facere.\nNisi illum aut repellat reprehenderit perferendis voluptatem.\nPerferendis voluptas veniam iusto sint est quis.", new DateTime(2024, 6, 30, 12, 32, 3, 476, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Perferendis quos beatae nemo aliquam aliquid exercitationem officiis excepturi. Nihil modi ut enim error qui mollitia et. Dolores totam voluptatem nihil. Occaecati ipsum perspiciatis enim earum molestiae voluptatem. Voluptatem placeat impedit consequatur qui repellendus quasi possimus.", new DateTime(2024, 5, 27, 2, 32, 3, 476, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Non qui fugit nulla sed.\nDolores ab eum magni sunt dolor veniam enim cumque repudiandae.", new DateTime(2024, 6, 10, 8, 32, 3, 476, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Libero error eos sequi reprehenderit dicta.", new DateTime(2024, 6, 30, 2, 32, 3, 476, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Assumenda totam deleniti dolores architecto. Aut labore dolor molestias nostrum provident quam aperiam culpa. Quidem ut quia ea sit velit quidem voluptas est. Occaecati nihil dolores in eligendi nihil rerum unde dolor. Laborum modi quasi et accusamus non earum et. Id vero quasi error est at.", new DateTime(2024, 6, 29, 12, 32, 3, 476, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Modi ipsa fugiat iste dolor.", new DateTime(2024, 6, 21, 3, 32, 3, 476, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Cumque sint amet suscipit recusandae ut. Accusantium ut laborum earum perspiciatis consequuntur. Cumque voluptatum adipisci animi. Deleniti recusandae repellat dicta. Et recusandae sapiente et et enim aut possimus dolorem molestiae.", new DateTime(2024, 6, 18, 9, 32, 3, 476, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Est quos ad sint incidunt error atque voluptas omnis. Ipsum voluptate autem. Itaque dolor quidem. Quis rem assumenda. Sed eos cum cum. Eos quis odit.", new DateTime(2024, 5, 31, 17, 32, 3, 476, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Dignissimos voluptas alias ipsum minus placeat omnis veniam quia omnis.\nNatus quo non dolorum nostrum facere et nesciunt.\nDolorem qui et sit inventore recusandae soluta.\nDoloribus autem et sint soluta non.", new DateTime(2024, 6, 10, 12, 32, 3, 476, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 30, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2024, 7, 3, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2024, 7, 2, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2024, 7, 1, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 23, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 30, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 28, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 25, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 27, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 7, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 29, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 9, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 27, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 17, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 12, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 22, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 25, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 21, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 16, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 23, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 24, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 21, 21, 32, 3, 476, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "846", "Darrin Cummings", "4668779362706", new DateTime(2028, 7, 6, 21, 32, 3, 477, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "330", "Gust Berge", "6767-7995-8803-8548-63", new DateTime(2030, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "328", "Jamil Bartoletti", "6759-4680-9777-7675", new DateTime(2029, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "927", "Bertha Schaden", "6507-6873-0062-8335", new DateTime(2032, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "065", "Manuela Bergstrom", "6759-1413-0103-5061", new DateTime(2026, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "151", "Elfrieda Kris", "6304172890463309092", new DateTime(2031, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "019", "Caesar Turcotte", "5495-1698-2141-9748", new DateTime(2032, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "748", "Mollie Turner", "4753471974337", new DateTime(2033, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "836", "Brendon Kuhlman", "6767-1841-8182-5653-86", new DateTime(2027, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "246", "Wanda Reinger", "6771-8991-6044-3171", new DateTime(2031, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "453", "Adah Hintz", "501837868960544670", new DateTime(2028, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "987", "Margot Luettgen", "4210598612282", new DateTime(2027, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "391", "Jena Zulauf", "3006-776995-5389", new DateTime(2032, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "472", "Paul Flatley", "503831425475890585", new DateTime(2029, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "180", "Myron Schaefer", "6771-8938-9650-5536", new DateTime(2033, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "597", "Haskell Donnelly", "5481-5352-3090-5954", new DateTime(2031, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "961", "Johann Torp", "6304-9381-4230-9906", new DateTime(2028, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "094", "Corine Kovacek", "4967389896594", new DateTime(2029, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "801", "Keyon Stoltenberg", "6759-5342-4728-2157-780", new DateTime(2027, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "538", "Litzy Adams", "6399-9039-1669-3964", new DateTime(2029, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "599", "Magali Abernathy", "6304-6018-5890-8366", new DateTime(2032, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "066", "Helena Bayer", "3703-477878-85356", new DateTime(2026, 7, 6, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 55m, new DateTime(2024, 6, 15, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 101m, new DateTime(2024, 6, 27, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 324m, new DateTime(2024, 6, 13, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 855m, new DateTime(2024, 6, 23, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 384m, new DateTime(2024, 6, 16, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 528m, new DateTime(2024, 6, 19, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 96m, new DateTime(2024, 6, 26, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 992m, new DateTime(2024, 6, 15, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 871m, new DateTime(2024, 6, 25, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 195m, new DateTime(2024, 6, 24, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 315m, new DateTime(2024, 6, 25, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 831m, new DateTime(2024, 7, 3, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 633m, new DateTime(2024, 6, 24, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 348m, new DateTime(2024, 6, 21, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 444m, new DateTime(2024, 6, 27, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 249m, new DateTime(2024, 6, 11, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 814m, new DateTime(2024, 6, 21, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 907m, new DateTime(2024, 6, 21, 21, 32, 3, 478, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CategoryName",
                value: "Baby");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CategoryName",
                value: "Movies");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CategoryName",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CategoryName",
                value: "Industrial");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CategoryName",
                value: "Kids");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CategoryName",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CategoryName",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CategoryName",
                value: "Kids");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CategoryName",
                value: "Garden");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CategoryName",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CategoryName",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CategoryName",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CategoryName",
                value: "Health");

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
                value: "Health");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CategoryName",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 211.65m, "Refined Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 232.85m, "Rustic Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 382.67m, "Fantastic Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 236.71m, "Tasty Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 613.26m, "Tasty Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 37.84m, "Generic Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 49.08m, "Licensed Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 654.33m, "Small Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 754.66m, "Handmade Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 636.11m, "Gorgeous Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 649.95m, "Ergonomic Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 290.54m, "Generic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 281.76m, "Intelligent Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 707.30m, "Handcrafted Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 988.65m, "Licensed Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 918.61m, "Unbranded Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 348.06m, "Ergonomic Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 937.32m, "Refined Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 90.55m, "Handcrafted Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 36.43m, "Tasty Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 780.04m, "Unbranded Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 166.24m, "Generic Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 951.69m, "Incredible Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 322.93m, "Fantastic Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 524.50m, "Practical Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 943.39m, "Incredible Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 106.06m, "Generic Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 602.42m, "Refined Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 808.99m, "Intelligent Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 148.94m, "Gorgeous Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 241.50m, "Licensed Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 686.87m, "Gorgeous Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 767.79m, "Ergonomic Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 59.98m, "Licensed Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 777.26m, "Handmade Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 815.92m, "Fantastic Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 65.42m, "Ergonomic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 752.50m, "Intelligent Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 861.59m, "Unbranded Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 526.41m, "Practical Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 299.81m, "Intelligent Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 360.27m, "Ergonomic Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 961.37m, "Practical Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 393.38m, "Handcrafted Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 835.30m, "Practical Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 846.67m, "Intelligent Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 563.36m, "Generic Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 356.43m, "Sleek Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 792.64m, "Rustic Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 315.56m, "Tasty Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 139.22m, "Unbranded Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 388.13m, "Practical Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 353.47m, "Sleek Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 387.43m, "Handcrafted Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 785.21m, "Intelligent Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 149.13m, "Refined Granite Hat" });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 1L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 864m, 43, 523.29m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 5L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 227m, 15, 755.18m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 11L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 226m, 76, 356.00m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 15L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 466m, 26, 995.74m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 996m, 84, 67.98m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 349m, 73, 927.76m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 565m, 11, 94.95m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 443m, 54, 778.98m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 981m, 50, 577.64m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 743m, 57, 96.59m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 353m, 76, 517.11m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 578m, 37, 415.66m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 404m, 20, 240.66m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 155m, 13, 598.64m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 10L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 754m, 37, 565.81m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 946m, 26, 975.49m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 954m, 74, 958.31m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 4L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 232m, 63, 910.24m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 951m, 53, 263.69m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 14L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 653m, 82, 629.58m });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Pariatur sunt voluptatem reiciendis totam dolor et aut iure.", new DateTime(2024, 6, 6, 21, 32, 3, 485, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Quia modi quia possimus ut totam et ut adipisci.\nNihil deleniti quos soluta labore ut saepe accusantium eum sed.\nAliquam vel quisquam ut deserunt aut.\nReprehenderit aliquam minima enim aspernatur est repellat distinctio quia rem.", new DateTime(2024, 3, 28, 21, 32, 3, 485, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Et sint aliquid eligendi quod libero eveniet.", new DateTime(2024, 6, 16, 21, 32, 3, 485, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Ut omnis earum quia qui earum ad.\nAt eum asperiores enim distinctio.", new DateTime(2024, 6, 6, 21, 32, 3, 485, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Qui omnis minus enim autem tempore illo voluptatem autem. Et et doloremque mollitia et ducimus qui aliquam nemo. Inventore porro nihil minima ut incidunt nulla.", new DateTime(2024, 3, 28, 21, 32, 3, 485, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Maiores sit aut odit velit vitae repudiandae possimus veniam quia.\nSapiente deserunt corrupti veniam numquam maiores quod.", new DateTime(2024, 6, 16, 21, 32, 3, 485, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 21, 21, 32, 3, 487, DateTimeKind.Local).AddTicks(4294), "Perspiciatis aut nesciunt rerum natus accusantium doloremque consequatur. Aut aperiam distinctio praesentium atque. Aut veritatis nesciunt nam sint facilis. Vel dignissimos totam omnis temporibus ut. Non doloribus consectetur vel." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 13, 21, 32, 3, 487, DateTimeKind.Local).AddTicks(4521), "Aut dolore est vel et non dolor quidem aut." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 13, 21, 32, 3, 487, DateTimeKind.Local).AddTicks(4555), "Voluptas sapiente eos velit rem voluptatem ipsa laudantium.\nEst aut ipsam explicabo consequuntur ullam qui accusamus perferendis." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 7, 4, 21, 32, 3, 487, DateTimeKind.Local).AddTicks(4622), "Vero atque commodi repudiandae libero quibusdam." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 32, 3, 487, DateTimeKind.Local).AddTicks(4648), "non" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 1, 21, 32, 3, 487, DateTimeKind.Local).AddTicks(4687), "Sapiente minima maxime minus dolor quas dolores. Et error eum autem repudiandae sequi sit. Beatae tempora consequatur sed tempore quisquam autem. Amet consequatur cupiditate ipsa." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 21, 21, 32, 3, 487, DateTimeKind.Local).AddTicks(4780), "iure" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 13, 21, 32, 3, 487, DateTimeKind.Local).AddTicks(4784), "Ea nisi est facilis nostrum qui dolores similique. Nulla temporibus velit ullam officia. Et optio vel facere repellat asperiores voluptatem vitae. Sed temporibus et a consequuntur. Et omnis modi est." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 13, 21, 32, 3, 487, DateTimeKind.Local).AddTicks(4906), "Vero delectus architecto ad molestiae nemo." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 7, 4, 21, 32, 3, 487, DateTimeKind.Local).AddTicks(4929), "Cum velit voluptas nulla ut labore voluptatem sed sit." });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3AyfJYnjk7cwTMtQm8vFes5SL93z4Ca", new DateTime(2024, 7, 2, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(276), "XNWEWFE1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1sJhBT1AndKcgCL8mWN57ftiQR492x3a", new DateTime(2024, 7, 1, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(393), "QAEOBYZ1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3uXpEzy29aHGjcQZm5KVkthArMs", new DateTime(2024, 5, 22, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(436), "WJLIPMZ1470" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3cJbgBFYQ5yvxs4HjD2oCM6TAz7NmUGetV", new DateTime(2024, 5, 22, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(504), "OZIUARE1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3x8VMuQaqeP93gSRW1fZHz74c6rKkGFyLYj", new DateTime(2024, 7, 3, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(548), "XHNIVUP1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3QDjerktz2mq4K1TvVLPci7pwS", new DateTime(2024, 6, 25, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(589), "XQIEVAJ1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "37PF4b2vs1ayTYgzxBmujoQndJNiVcGRLkX", new DateTime(2024, 5, 11, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(624), "ZYXODOD1" });

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 7, 6, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 7, 6, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 7, 6, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 4L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 7, 6, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 5L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 7, 6, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 6L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 7, 6, 21, 32, 3, 489, DateTimeKind.Local).AddTicks(890));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62b4eef8-f679-4fdd-aefe-b712a1a9fb74", "AQAAAAIAAYagAAAAEGLcSu/VseLqEPKxz/+q5UoFkfUnoYgNUBQwa5zZubyvNvWIiIVCclc85C4sipZizg==", "e2f83f72-7ec5-4353-80ef-2e56ea9a1623" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1987, 6, 28, 13, 17, 52, 149, DateTimeKind.Local).AddTicks(699), "7afe0d47-54e1-4961-977f-7678a589e73b", "alysson@gulgowski.com", "Cole", "571.672.7909 x83723", "e2e88dde-d7dc-438a-80a9-dfc6412f7c1b", "Rice", "nina_nitzsche" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1996, 6, 28, 13, 17, 52, 149, DateTimeKind.Local).AddTicks(4172), "8834c198-5598-43f7-b3b0-cdc59045df20", "krystina@leuschke.uk", "Towne", "130.489.6593", "344174a1-1bfa-4949-ab8a-de77d6e6ca38", "Stehr", "dora.boehm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2004, 6, 28, 13, 17, 52, 149, DateTimeKind.Local).AddTicks(7589), "61fd0459-521c-4ccc-8bf6-1f862e66af1d", "jadyn.dare@kiehneffertz.com", "Breitenberg", "740-426-0386 x04760", "c2ff8189-cdb9-41c2-9f3b-57d71bd2efeb", "Haag", "dusty.rogahn" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1990, 6, 28, 13, 17, 52, 150, DateTimeKind.Local).AddTicks(676), "cc32cadd-c827-4528-b30f-5a6a17674eeb", "albertha_borer@littel.ca", "Cronin", "1-101-796-2355 x379", "c33da485-7171-45ae-9b66-ae17c3c69ed7", "Harris", "margot" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1981, 6, 28, 13, 17, 52, 150, DateTimeKind.Local).AddTicks(3427), "390c46b3-a080-4ebc-a6de-a2fa15d757c8", "regan@altenwerth.uk", "Batz", "(083)918-4406", "2b3846d5-57d3-4bc5-abaf-c77b07aa40d4", "Bartoletti", "eloisa_hamill" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2004, 6, 28, 13, 17, 52, 150, DateTimeKind.Local).AddTicks(6323), "3222bba7-e746-4146-8415-88a3569af8f4", "jeremy@heaney.com", "Heathcote", "834.394.7936 x40017", "21b1aad1-be63-47fc-8137-0756d8f07050", "Will", "annie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2012, 6, 28, 13, 17, 52, 150, DateTimeKind.Local).AddTicks(9638), "37a4abed-870f-4d38-9150-89ba017031d6", "pete_balistreri@heaney.uk", "Heller", "1-687-252-7148 x342", "1a648bbb-aa66-47bd-96bf-1b3268109f0a", "Prohaska", "brendon.vonrueden" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1974, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(3044), "89853df1-0978-43a9-a784-7b6528587046", "sofia.schneider@krisdurgan.biz", "Vandervort", "(441)736-2423 x1898", "69d800bc-4583-4243-bf0b-8e9f4fb10b89", "Harber", "aida" });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5100), 301 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5103), 149 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2020, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5105), 307 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2017, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5107), 708 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2018, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5108), 365 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2001, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5110), 113 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5111), 430 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2019, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5113), 571 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2007, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5114), 229 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5116), 610 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2019, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5117), 530 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2015, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5119), 203 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5121), 735 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2016, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5122), 299 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5124), 520 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2000, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5125), 865 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2022, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5127), 933 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2016, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5129), 278 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5130), 449 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5132), 822 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5133), 864 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5135), 794 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2008, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5136), 315 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2021, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5138), 903 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5139), 251 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5141), 208 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2008, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5142), 570 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2002, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5144), 535 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5145), 468 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5146), 580 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2004, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5183), 214 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 6, 28, 13, 17, 52, 151, DateTimeKind.Local).AddTicks(5184), 849 });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "33DdRxX2yKYinwr9WMUhgmAVZEQj48Tvq76533", 161m, new DateTime(2025, 5, 20, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1VZbXFiHAJ4uRtUv7zET5dNcw215916", 183m, new DateTime(2024, 11, 27, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1F2miGCaeM6rYvLxWRgA4HPwVqtZoz67916", 350m, new DateTime(2025, 9, 30, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3Bfn7qzc2PQXphVEK6ywmWHkUbN8eR15360", 387m, new DateTime(2024, 7, 21, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1wZsDPV2iEQrFXKL4pB1a8yc7Rkn9dbzMJ60978", 134m, new DateTime(2025, 8, 26, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "35jdGFrNcA6DXyVPf9RonUkZ7pqBE3xKQe97283", 394m, new DateTime(2025, 2, 15, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1JUaFzb6xmeMwKuRrE4WyjdcDvLosA1q8h75285", 309m, new DateTime(2025, 8, 20, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1VFgfH36Yq4dPiEQWs92R8Ltwjz36788", 278m, new DateTime(2024, 12, 11, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1YBaCT1K5wp7PGMJtmDAjVFNghsyiuQ8vrZ6903", 217m, new DateTime(2024, 9, 25, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "15iyMCrx1A7WD2wVpLTNbQ8gKahqjU6z90834", 274m, new DateTime(2025, 4, 6, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3yiL8hDAU9d64x5MtQkcHSfmbNrRFj3qupP28327", 385m, new DateTime(2025, 11, 4, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "12XLVUdNGDEsfpnA5i8u14zSCqv6QtrF10070", 269m, new DateTime(2025, 3, 4, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1dFi3uMQrBC9JZESx8tPRzesWcbhaNv27836", 148m, new DateTime(2025, 4, 20, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3wLeR5MUYAsrvTHhWc6Zy4NjPC9Q99124", 356m, new DateTime(2025, 11, 3, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1po28fYiRajQSwuv1WyceCHNXAqKMdxFV5h41333", 391m, new DateTime(2024, 8, 13, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1UikFH6BoJPhqLWZupn1NV7aCx34058", 122m, new DateTime(2025, 2, 19, 13, 17, 52, 148, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 874m, new DateTime(2024, 4, 18, 12, 17, 52, 151, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 719m, new DateTime(2023, 8, 8, 17, 17, 52, 151, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 659m, new DateTime(2023, 11, 23, 1, 17, 52, 151, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 626m, new DateTime(2024, 3, 11, 5, 17, 52, 151, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 940m, new DateTime(2023, 5, 20, 0, 17, 52, 151, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 681m, new DateTime(2024, 4, 29, 8, 17, 52, 151, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 959m, new DateTime(2024, 1, 22, 12, 17, 52, 151, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 242m, new DateTime(2023, 10, 31, 5, 17, 52, 151, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 6, 28, 13, 17, 52, 146, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "quaerat", new DateTime(2024, 6, 14, 6, 17, 52, 153, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "architecto", new DateTime(2024, 6, 22, 7, 17, 52, 153, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "amet", new DateTime(2024, 6, 23, 3, 17, 52, 153, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "ut", new DateTime(2024, 5, 25, 21, 17, 52, 153, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "natus", new DateTime(2024, 6, 27, 8, 17, 52, 153, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "inventore", new DateTime(2024, 6, 17, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Et quisquam totam est omnis ut. Iure fuga voluptatibus id beatae occaecati dolorem. Eius repellat nostrum molestiae quo voluptates et soluta. Id est et dicta dolores voluptatem rerum tenetur aspernatur. Officia et enim. Alias sit repellat molestiae culpa deleniti quisquam illo ut.", new DateTime(2024, 6, 14, 11, 17, 52, 153, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "laudantium", new DateTime(2024, 6, 6, 10, 17, 52, 153, DateTimeKind.Local).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Et aut aliquam recusandae. Voluptatem repellat ipsum dolorem et officia dicta dignissimos porro cumque. Omnis doloribus ea sint eius sit. Quia deleniti voluptas qui. Provident dolor sed ut sed et. Quia incidunt neque facere tempore pariatur illo.", new DateTime(2024, 5, 20, 10, 17, 52, 153, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "eum", new DateTime(2024, 6, 15, 11, 17, 52, 153, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Libero pariatur at ut officia.\nOccaecati delectus doloribus qui similique autem occaecati.\nQuae ducimus est nam aut saepe maxime minus sit.\nOmnis aut ipsam.", new DateTime(2024, 5, 23, 11, 17, 52, 153, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Est est minus.\nCum omnis earum.\nAut non nihil aliquam dignissimos quis.\nFuga consectetur numquam qui incidunt id veniam sit unde.\nTenetur omnis ea et distinctio ut non iure.", new DateTime(2024, 6, 13, 11, 17, 52, 153, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "reprehenderit", new DateTime(2024, 6, 1, 6, 17, 52, 153, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Omnis aut quis.\nAmet eos eaque aliquid.\nVoluptas aspernatur quisquam eos maxime sed animi excepturi.", new DateTime(2024, 6, 12, 22, 17, 52, 153, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Iusto sapiente corporis veritatis corporis voluptatem unde voluptatem.\nDistinctio hic corporis adipisci quo.", new DateTime(2024, 5, 27, 11, 17, 52, 153, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Ex excepturi rerum quas nihil facere ea provident tempore.\nAut voluptas eligendi consectetur.", new DateTime(2024, 6, 14, 7, 17, 52, 153, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Quia iure ea ipsam sequi deleniti nobis sed voluptas nemo. Quia et repellendus. Aspernatur delectus consectetur.", new DateTime(2024, 6, 17, 16, 17, 52, 153, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Nulla et voluptatibus minus.\nQui sunt et ratione eligendi architecto.", new DateTime(2024, 6, 15, 0, 17, 52, 153, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 21, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 4, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 23, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 16, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 16, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 30, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 19, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 14, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 24, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 10, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 25, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 9, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 9, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 27, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 4, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 15, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 21, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 12, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 9, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 27, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 9, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 15, 13, 17, 52, 153, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "138", "Mercedes Jacobson", "6373-1664-5317-4455", new DateTime(2029, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "014", "Shana Langworth", "67638268725837715115", new DateTime(2033, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "874", "Carmela Cremin", "3528-9938-7302-6564", new DateTime(2030, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "221", "Zachery Hackett", "6771-8972-5036-5841", new DateTime(2026, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "603", "Austyn Lebsack", "6706774365722750889", new DateTime(2033, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "482", "Garrett Goodwin", "3029-802488-4219", new DateTime(2029, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "096", "Cara Gottlieb", "50184035207203133", new DateTime(2030, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "999", "Buford Lockman", "6391-1248-1044-2550", new DateTime(2026, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "890", "Nicola Gibson", "6304726295198603457", new DateTime(2031, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "519", "Kiera Batz", "3490-532006-08718", new DateTime(2029, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "340", "Lina Wisoky", "3495-742250-17494", new DateTime(2031, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "050", "Emery Okuneva", "3437-642997-20539", new DateTime(2028, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "808", "Hayden Klocko", "3529-7403-5413-8437", new DateTime(2031, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "964", "Edmund DuBuque", "6706009311103372494", new DateTime(2031, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "829", "Alana Yundt", "5893-1200-3133-0462", new DateTime(2030, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "265", "Brody Hintz", "4352-9801-1132-4371", new DateTime(2033, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "255", "Macie Miller", "3408-061164-77000", new DateTime(2030, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "478", "Harvey Zboncak", "6394-3091-1440-0498", new DateTime(2033, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "505", "Jazmyn Donnelly", "670920536779548676", new DateTime(2032, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "459", "Hattie Hamill", "3018-042931-1388", new DateTime(2032, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "481", "Jalen Kohler", "3528-2384-4058-1018", new DateTime(2029, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "146", "Dayna Wehner", "6767-8034-6906-1144", new DateTime(2027, 6, 28, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 426m, new DateTime(2024, 6, 10, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 821m, new DateTime(2024, 6, 23, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 896m, new DateTime(2024, 6, 19, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 718m, new DateTime(2024, 6, 22, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 62m, new DateTime(2024, 6, 8, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 595m, new DateTime(2024, 6, 10, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 31m, new DateTime(2024, 6, 24, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 645m, new DateTime(2024, 6, 7, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 632m, new DateTime(2024, 6, 20, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 790m, new DateTime(2024, 6, 25, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 658m, new DateTime(2024, 6, 6, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 779m, new DateTime(2024, 6, 8, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 855m, new DateTime(2024, 6, 22, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 444m, new DateTime(2024, 6, 8, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 872m, new DateTime(2024, 6, 22, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 971m, new DateTime(2024, 6, 5, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 67m, new DateTime(2024, 6, 22, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 169m, new DateTime(2024, 6, 15, 13, 17, 52, 155, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CategoryName",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CategoryName",
                value: "Health");

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
                value: "Garden");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CategoryName",
                value: "Movies");

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
                value: "Industrial");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CategoryName",
                value: "Garden");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CategoryName",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CategoryName",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CategoryName",
                value: "Health");

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
                value: "Music");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CategoryName",
                value: "Home");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CategoryName",
                value: "Jewelery");

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
                values: new object[] { 917.74m, "Gorgeous Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 991.19m, "Practical Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 711.59m, "Unbranded Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 129.00m, "Licensed Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 41.37m, "Awesome Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 414.98m, "Awesome Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 641.22m, "Unbranded Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 841.34m, "Awesome Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 415.01m, "Fantastic Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 769.11m, "Practical Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 741.69m, "Handcrafted Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 328.21m, "Tasty Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 393.20m, "Intelligent Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 685.48m, "Unbranded Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 758.86m, "Refined Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 383.17m, "Incredible Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 76.25m, "Handcrafted Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 960.50m, "Incredible Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 971.96m, "Sleek Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 134.91m, "Small Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 551.85m, "Gorgeous Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 662.56m, "Gorgeous Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 578.94m, "Awesome Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 141.53m, "Tasty Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 701.51m, "Gorgeous Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 617.27m, "Awesome Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 715.58m, "Incredible Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 284.33m, "Unbranded Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 865.01m, "Tasty Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 579.24m, "Handmade Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 53.96m, "Incredible Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 16.73m, "Refined Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 147.61m, "Sleek Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 737.23m, "Refined Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 759.54m, "Refined Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 346.51m, "Tasty Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 389.03m, "Tasty Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 287.65m, "Licensed Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 873.58m, "Tasty Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 918.08m, "Handmade Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 32.27m, "Intelligent Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 336.54m, "Small Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 685.78m, "Fantastic Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 179.06m, "Unbranded Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 190.90m, "Awesome Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 602.66m, "Incredible Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 583.06m, "Handmade Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 355.17m, "Handmade Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 569.83m, "Rustic Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 536.23m, "Unbranded Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 173.88m, "Unbranded Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 437.33m, "Tasty Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 552.14m, "Tasty Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 908.84m, "Rustic Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 895.16m, "Sleek Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 684.01m, "Awesome Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 1L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 870m, 10, 932.64m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 5L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 84m, 60, 348.34m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 11L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 736m, 58, 750.70m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 15L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 902m, 40, 525.92m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 668m, 10, 970.06m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 155m, 22, 918.29m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 78m, 15, 106.77m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 638m, 84, 699.72m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 869m, 43, 951.09m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 627m, 77, 774.51m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 585m, 98, 299.93m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 40m, 81, 233.30m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 406m, 49, 323.42m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 687m, 44, 452.42m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 10L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 937m, 95, 398.21m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 121m, 19, 478.57m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 46m, 68, 180.44m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 4L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 640m, 34, 942.88m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 58m, 40, 27.69m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 14L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 132m, 33, 971.16m });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Ut sequi eos molestiae dolorem incidunt non quia aut.\nDucimus quia reiciendis quia dignissimos eum in hic soluta.\nDoloremque est nihil enim dolor.\nMolestias dolorem doloribus consequatur quas omnis ut.\nEt qui repellendus aut maxime repellendus.\nMagni eius odit corporis ipsa qui et ipsam repellat itaque.", new DateTime(2024, 5, 29, 13, 17, 52, 161, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "alias", new DateTime(2024, 3, 20, 13, 17, 52, 161, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Nemo illo placeat voluptatem aut.\nAperiam omnis eligendi deleniti.\nItaque quia reprehenderit tempora eos hic culpa.", new DateTime(2024, 6, 8, 13, 17, 52, 161, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Ipsa dolor cupiditate.", new DateTime(2024, 5, 29, 13, 17, 52, 161, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Quas maxime numquam. Distinctio ea et laboriosam officiis ea alias. Veniam molestias aut rem. Architecto a omnis commodi impedit sit id.", new DateTime(2024, 3, 20, 13, 17, 52, 161, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Quaerat et est. Aliquam ab qui non id fugit soluta. Ut placeat voluptatem at.", new DateTime(2024, 6, 8, 13, 17, 52, 161, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 13, 13, 17, 52, 163, DateTimeKind.Local).AddTicks(6776), "minus" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 17, 52, 163, DateTimeKind.Local).AddTicks(6809), "Sit eaque neque. Nihil et soluta eius fugiat est reprehenderit facere. Molestiae aliquam aliquam eius architecto sint id." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 5, 13, 17, 52, 163, DateTimeKind.Local).AddTicks(6912), "Veritatis maiores impedit voluptatem molestias aliquam dolor voluptatem eveniet aspernatur." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 17, 52, 163, DateTimeKind.Local).AddTicks(6991), "Laboriosam beatae at. Sit laborum nulla architecto. In sapiente tempore iure velit. Odio qui quasi." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 25, 13, 17, 52, 163, DateTimeKind.Local).AddTicks(7049), "similique" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 24, 13, 17, 52, 163, DateTimeKind.Local).AddTicks(7054), "Impedit quia quaerat sapiente iste.\nCupiditate culpa perspiciatis autem et asperiores.\nPossimus voluptatem autem rerum consequatur molestiae.\nAut ut repellendus dolores veritatis doloremque." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 13, 13, 17, 52, 163, DateTimeKind.Local).AddTicks(7197), "Ipsum quam tempora qui.\nQui ut facilis eius molestiae provident quia non.\nUt et dolores.\nAd ut inventore reprehenderit in et dolorem.\nA quos ut sed ut voluptatem tempora consequuntur.\nEt et consequuntur beatae quia ea voluptatem in." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 5, 13, 17, 52, 163, DateTimeKind.Local).AddTicks(7325), "Eveniet quasi voluptatum modi et voluptatem incidunt unde sit aperiam.\nId ipsum aut nam aliquam fuga sit eius voluptatem asperiores.\nEum quia consequatur autem omnis alias repudiandae libero et saepe.\nAtque corporis cum autem quia facilis maxime." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 5, 13, 17, 52, 163, DateTimeKind.Local).AddTicks(7479), "Sed rerum aperiam sapiente eius similique." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 17, 52, 163, DateTimeKind.Local).AddTicks(7498), "Vitae rerum eos in delectus ut est corrupti optio iste." });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "32Kn8pxEQed1zF465YstATPcuNr9MjmJyBa", new DateTime(2024, 6, 24, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(1481), "WYXACDM1130" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3DXJ8ckwFE7CnqaofBLgQ2V41S9RP", new DateTime(2024, 6, 23, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(1624), "FGNAKPH1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1y6YkFAK1CEzQr583q4bdohSDnwm9tZs", new DateTime(2024, 5, 14, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(1664), "VSXEVEC1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3N3LM5VkHGuh9So2QvqiWCtpKRJbDXfFU1", new DateTime(2024, 5, 14, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(1703), "HXQOIOM1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1LR93SAZ8hBNPwd2qvtcEenMmQsgD6a", new DateTime(2024, 6, 25, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(1742), "APFIADJ1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3BFJhPkgeEZiS7aq8DMTxucw1XYR9v6z3Wm", new DateTime(2024, 6, 17, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(1778), "PZRUMEL1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1KDvRAz2NbkEujMZX7cxhFopiQsw4GJy", new DateTime(2024, 5, 3, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(1851), "CFTUWSJ1047" });

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 28, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 28, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 28, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 4L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 28, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 5L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 28, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 6L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 28, 13, 17, 52, 165, DateTimeKind.Local).AddTicks(2102));
        }
    }
}
