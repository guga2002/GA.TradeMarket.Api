using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class MigrteNowAsync : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24f664a5-3a42-4db8-9056-63cc1da7dfc0", "AQAAAAIAAYagAAAAEBZDStoXq0ZxycNE5cAeiJZMK6l4aXACySn2cJDMHEB/l0Zy4JmpHOgCcU/ZYDO+oQ==", "6fb652f7-52f1-4ebe-b383-f758073788b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2006, 6, 5, 13, 2, 12, 784, DateTimeKind.Local).AddTicks(6357), "9941a747-e105-4a16-aea5-8f041c3867b7", "mark.gerhold@marks.com", "Muller", "615.751.2358 x981", "ab4847a4-4321-4adf-a318-2397518530e9", "Kihn", "raul" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1981, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(37), "aa95c0d2-9526-4e01-96d2-2cf5cd57d3f4", "nedra.nicolas@ledner.co.uk", "Prosacco", "711.795.2556", "bdaa253e-7990-401f-a203-906d59d642c3", "Ward", "francis.lowe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1982, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(3212), "4e30d035-8b16-439b-b4fd-1e184b91d2fc", "jerrold@haley.ca", "Bartell", "602.671.9085 x08623", "35479a62-757d-4ea0-b453-09663be0290e", "Daniel", "helga.emard" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2009, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(6864), "fb0e8c28-88a3-4e0a-8ac3-3bc9bab5ceec", "mona@quitzonhamill.name", "Willms", "1-111-016-6555 x2384", "ff4451a1-c209-4534-9274-a5fbdf94a6d9", "Weimann", "tobin_labadie" });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2007, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8822), 778 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8825), 608 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8826), 857 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2017, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8828), 629 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8829), 571 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2019, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8831), 102 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8833), 804 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2022, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8834), 802 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2018, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8836), 211 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2021, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8837), 676 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8874), 249 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8876), 113 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8878), 653 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8879), 650 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8881), 132 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 5, 13, 2, 12, 785, DateTimeKind.Local).AddTicks(8882), 977 });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1ahQcnbyVzLGoTZt4NDPmdeWKYp78072", 310m, new DateTime(2024, 10, 26, 13, 2, 12, 784, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3JBNgc7vrt4LwUxV5qbPDMdmCok28448", 234m, new DateTime(2025, 6, 26, 13, 2, 12, 784, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3imbQhUEdDgRYeZsCxGr3Vy9wpTao52026", 180m, new DateTime(2025, 2, 5, 13, 2, 12, 784, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1hKNVMiesH1atTrZ9ypzjGJ3BCb54489", 191m, new DateTime(2024, 10, 11, 13, 2, 12, 784, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3FsKRcSUBHyZ9WrutNfdj3xazqi1JVYop37247", 109m, new DateTime(2024, 11, 30, 13, 2, 12, 784, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1WTH7rYRFws8EeJG4fUjVLkihgZn392759", 307m, new DateTime(2024, 7, 13, 13, 2, 12, 784, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1Bnh1fUvE4Xw2DHx8uLidayRc388609", 196m, new DateTime(2025, 8, 13, 13, 2, 12, 784, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "167wZi5hC8rRUFAPo1YfkvN9XLjm27760", 163m, new DateTime(2025, 5, 2, 13, 2, 12, 784, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 984m, new DateTime(2023, 10, 20, 18, 2, 12, 785, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 898m, new DateTime(2023, 6, 3, 5, 2, 12, 785, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 953m, new DateTime(2023, 7, 18, 21, 2, 12, 785, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 259m, new DateTime(2023, 10, 8, 14, 2, 12, 785, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 6, 5, 13, 2, 12, 781, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Nemo dolores sunt id voluptatum et accusantium ex consequuntur.\nIpsam sed vitae aliquam pariatur.\nTempore voluptas laborum recusandae nesciunt et accusantium enim magni sit.", new DateTime(2024, 5, 21, 17, 2, 12, 787, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "eveniet", new DateTime(2024, 5, 27, 17, 2, 12, 787, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Labore officia qui fugit voluptatibus.\nDolores in in.\nQuia dicta voluptate maiores.\nQuidem vitae distinctio est minima dolor eum est.\nModi aliquid tenetur rerum aperiam aut id exercitationem explicabo.", new DateTime(2024, 5, 7, 16, 2, 12, 787, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Cum id ut qui ratione officiis iusto adipisci magnam facere. Sed qui mollitia omnis aperiam quibusdam. Sit beatae totam qui eaque qui sed explicabo amet nesciunt. Et sit expedita omnis enim voluptatem voluptas velit aliquam provident.", new DateTime(2024, 5, 27, 13, 2, 12, 787, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "quasi", new DateTime(2024, 5, 15, 14, 2, 12, 787, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Est tempora ipsum illum aperiam.\nFugiat earum laudantium.\nRerum id explicabo dolor enim.\nVoluptatem ut voluptatem et.\nIure perspiciatis velit et.\nNon exercitationem eaque.", new DateTime(2024, 5, 18, 14, 2, 12, 787, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Ducimus fugit sint ut esse. Ex ullam dignissimos vitae esse minus laudantium nesciunt. Numquam ullam numquam. Doloribus impedit omnis ipsam quaerat illum.", new DateTime(2024, 5, 27, 5, 2, 12, 787, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Inventore et ullam a.\nDolor est vitae qui aut.\nNesciunt cumque velit velit commodi distinctio.\nUt necessitatibus sit quis debitis occaecati quo voluptatem et.\nOmnis officiis est.\nDoloremque nesciunt velit.", new DateTime(2024, 5, 23, 0, 2, 12, 787, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "perspiciatis", new DateTime(2024, 5, 21, 16, 2, 12, 787, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 19, 13, 2, 12, 787, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 4, 13, 2, 12, 787, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 30, 13, 2, 12, 787, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 24, 13, 2, 12, 787, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 31, 13, 2, 12, 787, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 25, 13, 2, 12, 787, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 1, 13, 2, 12, 787, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 7, 13, 2, 12, 787, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 16, 13, 2, 12, 787, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 3, 13, 2, 12, 787, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 25, 13, 2, 12, 787, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "200", "Auto Loan Account", "6759-8289-8382-0295", new DateTime(2027, 6, 5, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "017", "Savings Account", "6382-1182-8145-2040", new DateTime(2026, 6, 5, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CVV", "CardNumber", "ExpiryDate" },
                values: new object[] { "188", "3463-132936-70824", new DateTime(2026, 6, 5, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "027", "Credit Card Account", "6759-7622-1131-0839", new DateTime(2026, 6, 5, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "821", "Investment Account", "4980-2504-3086-7157", new DateTime(2029, 6, 5, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "609", "Credit Card Account", "6771-8973-9421-3741", new DateTime(2031, 6, 5, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "609", "Credit Card Account", "4344343116941", new DateTime(2031, 6, 5, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "335", "Credit Card Account", "6304-6660-4952-2269", new DateTime(2028, 6, 5, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "035", "Money Market Account", "6767-2769-8084-6030", new DateTime(2033, 6, 5, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "833", "Savings Account", "6011-9750-0585-9381", new DateTime(2027, 6, 5, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "497", "Money Market Account", "6374-1818-6919-7692", new DateTime(2026, 6, 5, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 850m, new DateTime(2024, 5, 25, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 726m, new DateTime(2024, 5, 13, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 781m, new DateTime(2024, 5, 26, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 368m, new DateTime(2024, 5, 20, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 364m, new DateTime(2024, 5, 8, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 161m, new DateTime(2024, 5, 8, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 509m, new DateTime(2024, 5, 18, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 718m, new DateTime(2024, 5, 29, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 907m, new DateTime(2024, 5, 24, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 110m, new DateTime(2024, 5, 26, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 120m, new DateTime(2024, 5, 27, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 260m, new DateTime(2024, 6, 1, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 729m, new DateTime(2024, 5, 17, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 222m, new DateTime(2024, 6, 2, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 405m, new DateTime(2024, 5, 23, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 951m, new DateTime(2024, 5, 22, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 887m, new DateTime(2024, 5, 13, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 128m, new DateTime(2024, 5, 19, 13, 2, 12, 789, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CategoryName",
                value: "Sports");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CategoryName",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CategoryName",
                value: "Movies");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CategoryName",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CategoryName",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CategoryName",
                value: "Baby");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CategoryName",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CategoryName",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.8164920944736270m, "Fantastic Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.4745294625341650m, "Ergonomic Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3547785860310060m, "Licensed Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.323273976620580m, "Ergonomic Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.4136593781818210m, "Unbranded Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.9404254053004010m, "Licensed Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.7975494582947220m, "Sleek Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.846650189488530m, "Practical Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.5828959696387110m, "Handmade Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.06441295128996470m, "Handcrafted Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.6411156872607920m, "Intelligent Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2775189352990840m, "Practical Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.747751974480780m, "Generic Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2054134566135920m, "Incredible Soft Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.7402187862608580m, "Small Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.1048828220778560m, "Intelligent Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.4109531898647780m, "Generic Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3531259180277670m, "Gorgeous Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.003456056357279410m, "Ergonomic Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.6045230943276710m, "Practical Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.8240646160437410m, "Rustic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.5463314398516970m, "Awesome Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.207519672871070m, "Awesome Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.9660654709243910m, "Intelligent Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.7228763685711060m, "Practical Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2283647078157070m, "Intelligent Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2783786042087410m, "Licensed Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2321499734706250m, "Awesome Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 1L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 549m, 84, 819.16m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 5L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 954m, 41, 736.90m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 613m, 71, 784.52m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 146m, 45, 352.35m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 351m, 76, 262.95m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 947m, 68, 416.34m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 198m, 14, 318.74m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 847m, 86, 540.43m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 870m, 95, 913.32m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 4L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 537m, 47, 687.00m });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Dolor earum eaque odit ut.\nVoluptatem aspernatur esse omnis ut quaerat et.\nOfficia et aut ut accusamus cupiditate dolor omnis.\nDoloribus officia velit sed ea nihil culpa corporis sunt ipsam.", new DateTime(2024, 5, 6, 13, 2, 12, 796, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Aut enim nobis ipsum.", new DateTime(2024, 2, 26, 13, 2, 12, 796, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Consequatur molestiae autem expedita dolorem ad.\nCorporis non totam blanditiis cum minima nobis ea natus tempore.\nQuae architecto tenetur hic laudantium cum iste aut animi officia.", new DateTime(2024, 5, 16, 13, 2, 12, 796, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 21, 13, 2, 12, 797, DateTimeKind.Local).AddTicks(9845), "Quidem assumenda praesentium. Quia pariatur id nulla enim et aut. Quam qui facilis." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 12, 13, 2, 12, 797, DateTimeKind.Local).AddTicks(9987), "dolores" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 13, 13, 2, 12, 797, DateTimeKind.Local).AddTicks(9994), "excepturi" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 3, 13, 2, 12, 798, DateTimeKind.Local).AddTicks(1), "blanditiis" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 2, 13, 2, 12, 798, DateTimeKind.Local).AddTicks(40), "possimus" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 1, 13, 2, 12, 798, DateTimeKind.Local).AddTicks(45), "Error laborum aliquam." });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1M7rByLoW3h9qQZmTjxwcF4NKguEp", new DateTime(2024, 6, 1, 13, 2, 12, 799, DateTimeKind.Local).AddTicks(5147), "YBUESZC1619" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1pSANa1KGPYFcmyHjX5MeUL8Rn2CkwqrT9", new DateTime(2024, 5, 31, 13, 2, 12, 799, DateTimeKind.Local).AddTicks(5291), "KQZOFXT1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3yzQrRaZTCJSeVMgDnjB6Ahs5wu293q", new DateTime(2024, 4, 21, 13, 2, 12, 799, DateTimeKind.Local).AddTicks(5336), "NIBEMTZ1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1VXf6LbTANFPo2GeDUdu4w5Wzv7sqc9R8t", new DateTime(2024, 4, 21, 13, 2, 12, 799, DateTimeKind.Local).AddTicks(5376), "WIVEKWG1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "11fgKCvW3R4DNYptzA6o9uZHQrqEiFhLas", new DateTime(2024, 6, 2, 13, 2, 12, 799, DateTimeKind.Local).AddTicks(5416), "HGBOIEF1646" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1Dq7ez5UQR9ESfu8BYT2cawHshoG", new DateTime(2024, 5, 25, 13, 2, 12, 799, DateTimeKind.Local).AddTicks(5526), "BBJOTAV1VOR" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1istGncoWxzruZK7BReQ5aVm91vTMPN", new DateTime(2024, 4, 10, 13, 2, 12, 799, DateTimeKind.Local).AddTicks(5597), "XYVETZE1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "927c8b1f-4fa5-4cd2-9f5b-ab4107337f9a", "AQAAAAIAAYagAAAAEFo6Z24/XqJKLPJatRxYDr4a9qbTKOJHMHLpZDoKaO3ZKKimFqQ5qguPPMAE4w4oGA==", "bfeab9ee-16bf-4621-89c9-3eafb856f928" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1978, 6, 3, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(8263), "402dda98-d6ab-442b-88cc-2a9cdebad8d3", "wilhelm@gorczany.name", "Dickens", "1-040-615-3177 x9410", "75788046-a24d-4d31-93a6-04eed62bffec", "Bartell", "rene" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2010, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(1542), "8c72a89e-505a-4368-a427-1b3e654944ca", "carter_grady@moen.uk", "Pouros", "529.852.8131", "c6e29e2c-4822-4371-9165-95cca2f532b0", "Keeling", "maymie.spencer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2006, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(4624), "157f608b-0b48-4c91-9f1c-f886782b6301", "xavier@bodelindgren.biz", "Murphy", "(660)907-2031", "3ebb8cee-dcab-4a34-91f3-310257a54bdc", "Ruecker", "berneice" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1980, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(7612), "cd7c9ec2-7a12-4a8e-9233-f18fa90891e9", "cyrus@hermanvon.name", "Orn", "(806)707-4387 x17877", "6704b07a-3784-4274-847e-578f3955cd8f", "Swift", "garrison" });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9221), 818 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9226), 959 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1997, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9228), 863 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2018, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9229), 294 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2000, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9231), 264 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9233), 911 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1997, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9235), 232 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9237), 931 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9238), 975 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1997, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9240), 474 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2010, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9241), 526 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9243), 121 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2011, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9247), 541 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9249), 834 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2020, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9251), 768 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2008, 6, 3, 11, 41, 37, 960, DateTimeKind.Local).AddTicks(9253), 617 });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1uA6vTaJePcs82Lypwrxo4EYSX7n28045", 399m, new DateTime(2024, 9, 1, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "16YqgVJQHLAmt7MKznsShRf5ejD2uTa83Ur71341", 301m, new DateTime(2024, 9, 12, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3ub7g8jaDSPBFTvZnKYG3eoq1kVmCEiAWX87548", 117m, new DateTime(2024, 7, 28, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1ZTLXgojScU4apeWEQtNFVdy3s89511", 201m, new DateTime(2025, 5, 3, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1T8sPEHkDWUCxRQXu4ApKcoFJejdYi23238", 292m, new DateTime(2025, 8, 23, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3r4KvbMDwzfJp7tqXL9gsyiFRoESYG47065", 175m, new DateTime(2025, 2, 10, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1pTZw4La36ft8NdyK2qrMWPJvniYjeXoQ977256", 101m, new DateTime(2025, 8, 25, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "37toGN6eDqwWX5xafQLAgFKuVpdcBvE25242", 340m, new DateTime(2024, 12, 21, 11, 41, 37, 959, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 137m, new DateTime(2023, 4, 30, 0, 41, 37, 960, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 441m, new DateTime(2023, 6, 7, 2, 41, 37, 960, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 674m, new DateTime(2024, 3, 29, 21, 41, 37, 960, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 754m, new DateTime(2023, 12, 30, 0, 41, 37, 960, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 6, 3, 11, 41, 37, 957, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Esse maxime ut nihil ullam ullam ratione facilis ut rerum. Qui nobis suscipit totam perferendis quis. Deserunt numquam in. Repudiandae consequuntur ex quis ipsam consequatur sit qui.", new DateTime(2024, 5, 4, 16, 41, 37, 962, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Eligendi voluptas modi architecto.\nLabore qui incidunt adipisci perferendis reprehenderit harum et voluptatem tenetur.\nIste voluptatum et sit et nobis dolorem mollitia nesciunt.", new DateTime(2024, 4, 23, 12, 41, 37, 962, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Veritatis est sit et esse.\nBeatae aut pariatur vero totam.\nAssumenda reprehenderit tenetur reprehenderit optio enim exercitationem eum eius corrupti.", new DateTime(2024, 5, 23, 15, 41, 37, 962, DateTimeKind.Local).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "consequatur", new DateTime(2024, 5, 20, 0, 41, 37, 962, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Delectus dolores porro voluptates perspiciatis aspernatur.\nMolestiae facere ut illo vero.\nEa quam vitae.\nEa aspernatur maxime laudantium.\nEst consequuntur tempora aut quibusdam.\nRerum numquam pariatur voluptatem ut sequi harum eaque enim.", new DateTime(2024, 5, 9, 10, 41, 37, 962, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Aut et eum non saepe molestiae.\nBeatae molestiae possimus quia modi debitis illo.\nSequi autem a id beatae provident eos nemo.\nRerum voluptas dignissimos quas voluptatibus ratione sed.", new DateTime(2024, 5, 9, 10, 41, 37, 962, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Quam rerum ipsa.", new DateTime(2024, 4, 28, 0, 41, 37, 962, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "mollitia", new DateTime(2024, 5, 18, 10, 41, 37, 962, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Quasi ab consectetur laudantium aliquid ea modi sit amet dolorum.", new DateTime(2024, 5, 19, 4, 41, 37, 962, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 5, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 2, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 13, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 12, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 14, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 23, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 7, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 15, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 5, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 26, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 24, 11, 41, 37, 962, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "950", "Checking Account", "4730544558156", new DateTime(2028, 6, 3, 11, 41, 37, 964, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "833", "Auto Loan Account", "5893-5372-0419-8147", new DateTime(2029, 6, 3, 11, 41, 37, 964, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CVV", "CardNumber", "ExpiryDate" },
                values: new object[] { "809", "6371-0774-8778-2712", new DateTime(2031, 6, 3, 11, 41, 37, 964, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "313", "Home Loan Account", "630480392961380395", new DateTime(2030, 6, 3, 11, 41, 37, 964, DateTimeKind.Local).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "855", "Credit Card Account", "6398-1435-0157-0688", new DateTime(2033, 6, 3, 11, 41, 37, 964, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "064", "Auto Loan Account", "5496-3702-8837-9784", new DateTime(2028, 6, 3, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "004", "Checking Account", "5018-6006-4595-7586", new DateTime(2028, 6, 3, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "991", "Home Loan Account", "503857965446820103", new DateTime(2033, 6, 3, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "105", "Credit Card Account", "3025-327783-9998", new DateTime(2030, 6, 3, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "283", "Personal Loan Account", "6389-7027-5299-9200", new DateTime(2030, 6, 3, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "350", "Home Loan Account", "3672-941324-1516", new DateTime(2026, 6, 3, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 173m, new DateTime(2024, 5, 13, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 61m, new DateTime(2024, 5, 18, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 128m, new DateTime(2024, 5, 26, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 678m, new DateTime(2024, 5, 8, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 672m, new DateTime(2024, 5, 28, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 482m, new DateTime(2024, 5, 19, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 261m, new DateTime(2024, 5, 8, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 211m, new DateTime(2024, 5, 11, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 710m, new DateTime(2024, 5, 9, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 958m, new DateTime(2024, 5, 21, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 633m, new DateTime(2024, 5, 26, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 932m, new DateTime(2024, 5, 7, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 416m, new DateTime(2024, 5, 7, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 900m, new DateTime(2024, 5, 17, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 531m, new DateTime(2024, 5, 20, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 761m, new DateTime(2024, 5, 17, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 153m, new DateTime(2024, 5, 20, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 470m, new DateTime(2024, 5, 27, 11, 41, 37, 965, DateTimeKind.Local).AddTicks(2044) });

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
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CategoryName",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CategoryName",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CategoryName",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CategoryName",
                value: "Industrial");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CategoryName",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CategoryName",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CategoryName",
                value: "Grocery");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.0129699856136830m, "Intelligent Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3555568640360720m, "Intelligent Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.004038397762760490m, "Intelligent Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.9992389100676840m, "Practical Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.6683573599777520m, "Fantastic Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.01730201501701980m, "Tasty Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.5359801440196420m, "Rustic Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.435189068318830m, "Handmade Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3674693376314080m, "Awesome Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.06900564782519450m, "Generic Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.7886830890714540m, "Gorgeous Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.1976677669688450m, "Unbranded Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.5519519108423630m, "Handcrafted Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.4717061806907380m, "Sleek Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.4640248442858550m, "Fantastic Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.1042292973202090m, "Generic Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2195606554307940m, "Small Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.9467363243381990m, "Handcrafted Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2839471388732690m, "Practical Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3391831432528340m, "Handcrafted Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.72640342628690m, "Unbranded Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.0970971719747950m, "Tasty Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.8985232892851620m, "Fantastic Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.603822614543830m, "Incredible Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.3251882754769910m, "Practical Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.7445148215674250m, "Gorgeous Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.2887609816963020m, "Fantastic Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 0.06970529727610560m, "Rustic Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 1L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 495m, 62, 151.82m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 5L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 450m, 23, 305.67m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 204m, 28, 186.24m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 179m, 87, 29.04m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 984m, 73, 640.80m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 335m, 58, 886.01m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 842m, 73, 558.88m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 799m, 76, 239.86m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 127m, 56, 812.47m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 4L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 561m, 63, 966.92m });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "et", new DateTime(2024, 5, 4, 11, 41, 37, 971, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Nesciunt similique ea culpa amet.\nDelectus sequi quisquam molestias.\nVitae voluptas facere qui nemo atque quidem aut velit.\nFugit nobis totam ab vel.\nEum et sit et quia asperiores quod sed.", new DateTime(2024, 2, 24, 11, 41, 37, 971, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Quo esse possimus aperiam assumenda inventore nulla error nihil officia. Similique maxime consequuntur. Nam ratione quo ipsa est. Dicta esse alias rem.", new DateTime(2024, 5, 14, 11, 41, 37, 971, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 19, 11, 41, 37, 972, DateTimeKind.Local).AddTicks(8309), "error" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 10, 11, 41, 37, 972, DateTimeKind.Local).AddTicks(8345), "distinctio" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 11, 11, 41, 37, 972, DateTimeKind.Local).AddTicks(8352), "Quos voluptatem saepe delectus ut labore non vero earum provident." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 1, 11, 41, 37, 972, DateTimeKind.Local).AddTicks(8423), "veritatis" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 41, 37, 972, DateTimeKind.Local).AddTicks(8430), "Maiores culpa exercitationem.\nFugit optio consectetur modi asperiores libero illum nihil natus excepturi." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 29, 11, 41, 37, 972, DateTimeKind.Local).AddTicks(8490), "odit" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3E12ri7yQcJqszWNpgekj8YS9P", new DateTime(2024, 5, 30, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3574), "UMNOCST1002" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "354kuJ3EqV1nTYHfZzRvPgoMeyw68xXAms", new DateTime(2024, 5, 29, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3675), "TRQUAMZ1312" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1hun13QVGrke9JSa2AgE65bTwoR", new DateTime(2024, 4, 19, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3720), "HVUUPYY1152" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1UkzPVheqvGo3jLfZdcrHS1pJw", new DateTime(2024, 4, 19, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3758), "OLPAGLN1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1XrYBoDE8LZKzJWQ6ahnAjMewuy", new DateTime(2024, 5, 31, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3825), "FDKIAXV1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3HQrbCGkB7n8icapgeFofDP1LXEy", new DateTime(2024, 5, 23, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3924), "CFDEPTR1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3kNFtKXbYDuox43Lj2v8a69SefZiJWhrpz1", new DateTime(2024, 4, 8, 11, 41, 37, 974, DateTimeKind.Local).AddTicks(3960), "LOFUTNH1106" });
        }
    }
}
