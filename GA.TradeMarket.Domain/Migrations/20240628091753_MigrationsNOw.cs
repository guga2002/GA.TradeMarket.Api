using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class MigrationsNOw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 3L,
                column: "CategoryName",
                value: "Computers");

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
                keyValue: 16L,
                column: "CategoryName",
                value: "Shoes");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92fc87c3-907d-4818-b0fc-e8b653ad2aa1", "AQAAAAIAAYagAAAAECCiaClFOF4tSfBsetMaJUSvdtcbmGnpwgB4Luj7Gq0b+WHE/YuHu/0bAZODfxwkGg==", "3e9cb122-fe0a-4f44-8a94-1478b66d8d7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1965, 6, 10, 23, 59, 16, 802, DateTimeKind.Local).AddTicks(335), "25ee6e29-f918-499e-a9dd-0b71ecb9d188", "esmeralda_adams@kassulkejakubowski.ca", "Hodkiewicz", "385-608-7208 x58905", "0ad6bb5f-b39f-4fc1-86c2-42ce9dcfb1d7", "Eichmann", "rosemarie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2003, 6, 10, 23, 59, 16, 802, DateTimeKind.Local).AddTicks(6049), "9e17d17f-ab10-459a-9441-c15ed6cacae7", "alexander.crona@cristwolf.co.uk", "Torphy", "(410)975-5016 x77688", "a74fdd1e-850e-4e07-bfcd-f816f959a97f", "Jones", "meagan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1984, 6, 10, 23, 59, 16, 803, DateTimeKind.Local).AddTicks(1617), "b5e03833-d48d-4168-83ba-4bb3318fba69", "taya_lind@leuschkejones.us", "Paucek", "903-626-7286", "4ad1072c-f762-40a8-ac72-187e762f7571", "Kautzer", "cedrick_sanford" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1998, 6, 10, 23, 59, 16, 803, DateTimeKind.Local).AddTicks(6703), "6a83c20d-7a89-41b3-9b4c-99179e150942", "emery@wilkinson.biz", "Kshlerin", "916-243-6702 x80429", "0b9b120a-0747-4e9e-be36-0d44c726eb83", "Gutkowski", "freida_goodwin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1967, 6, 10, 23, 59, 16, 804, DateTimeKind.Local).AddTicks(2635), "6ceb64bd-661c-4ec0-858a-f11514aa6928", "hope.predovic@ankunding.biz", "Kuhic", "(819)094-6013 x129", "ff84bb6d-d33b-471e-8b20-8195762b6a3d", "Altenwerth", "kimberly.kozey" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1999, 6, 10, 23, 59, 16, 804, DateTimeKind.Local).AddTicks(9079), "5ac7df95-d138-48da-be45-ae40cda81a2c", "marvin_weimann@moore.name", "Abbott", "1-354-390-4150 x6692", "2d8bb1ce-0fdc-4467-a358-4cc8bc645722", "Torphy", "everardo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1973, 6, 10, 23, 59, 16, 805, DateTimeKind.Local).AddTicks(5635), "84332523-d207-486f-96e6-f7e9c403c9d7", "cordelia@grimesreilly.ca", "Wolf", "1-480-386-6428 x55018", "dbf59578-9534-4de2-9b41-6a8934cf795a", "West", "aaron" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1992, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(1317), "6debfd68-a5f4-4a1c-9467-5a5b6fe5b101", "jermain.lynch@breitenberg.co.uk", "Prohaska", "370.830.2034", "be123cb7-4bf4-4439-91a4-7aa18d4782f0", "Marquardt", "boris" });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2000, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(3987), 754 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(3992), 604 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2016, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(3994), 839 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(3996), 992 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1997, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(3998), 643 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1995, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4000), 518 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4002), 404 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2004, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4004), 438 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2002, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4006), 897 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1995, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4007), 647 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4009), 118 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2002, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4011), 328 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2010, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4013), 232 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4014), 365 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4016), 854 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2000, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4018), 503 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4020), 239 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2015, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4022), 110 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4024), 942 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4026), 944 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2017, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4028), 548 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2015, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4030), 721 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4039), 334 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2000, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4041), 617 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4043), 916 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2010, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4045), 653 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2010, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4047), 144 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2017, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4048), 575 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2002, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4051), 498 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2016, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4052), 257 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4054), 127 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 10, 23, 59, 16, 806, DateTimeKind.Local).AddTicks(4056), 579 });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1mN9sAwiFyauvMqTPVZW2bXCr4Y8fopkxE59767", 167m, new DateTime(2025, 4, 22, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1bGkFYnB2iscwZjXR5u9dPVLNWHA127789", 301m, new DateTime(2024, 9, 5, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3vyXEhxwMtFSkRgLW4aqGsTHe7Pm1U222537", 107m, new DateTime(2025, 2, 3, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1qBrJpR7jHbkfmNZGuoXCD1L5W38510", 375m, new DateTime(2025, 6, 18, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1hmjv7W1xsEyk836PCtJduTf2bR36320", 145m, new DateTime(2025, 1, 19, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3Nc6aubPRe5pioLYGWJhjdXBtD2g781849", 224m, new DateTime(2025, 6, 26, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3R8Nn2EjkZGUJ5ufPwgWmxKYco3Hh643242", 105m, new DateTime(2024, 7, 5, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1ya9cpE1MKFsJG6qRVgu8Dt7z4YjXeP75235", 391m, new DateTime(2025, 8, 16, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3tAZdcr1uPqa7bBMQyRiv5VCJUo3T28007", 338m, new DateTime(2025, 4, 29, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3FM6miAWHRjaLyE9TK1rVewnPg385339", 271m, new DateTime(2024, 11, 30, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3K7MRdbCeQWYPghr1vfZi5V62o83139", 171m, new DateTime(2025, 3, 13, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "38rzSCg7ToLqeNc1x4QFhBHstZw28228", 118m, new DateTime(2024, 10, 28, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "17zpqnNf2L5Z4S8iPdjG91wXFc88019", 286m, new DateTime(2025, 4, 17, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1QFz9EdXwT7s5h2J6fyBLAcDgMqKjut35661", 295m, new DateTime(2025, 3, 31, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1QnUC16PeRL8sqc3XYMizGpaDTvuK57819", 379m, new DateTime(2024, 7, 12, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1yTLX5BvUENaM6KRdWp8P9uGYz87197", 353m, new DateTime(2024, 8, 8, 23, 59, 16, 801, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 149m, new DateTime(2023, 11, 13, 12, 59, 16, 806, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 738m, new DateTime(2023, 4, 24, 3, 59, 16, 806, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 240m, new DateTime(2023, 12, 2, 0, 59, 16, 806, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 368m, new DateTime(2023, 5, 1, 7, 59, 16, 806, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 916m, new DateTime(2023, 8, 10, 13, 59, 16, 806, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 647m, new DateTime(2024, 2, 4, 19, 59, 16, 806, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 905m, new DateTime(2023, 10, 7, 4, 59, 16, 806, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 237m, new DateTime(2024, 5, 10, 14, 59, 16, 806, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 6, 10, 23, 59, 16, 797, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "repellendus", new DateTime(2024, 5, 4, 18, 59, 16, 811, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Nobis repellendus debitis occaecati.", new DateTime(2024, 5, 23, 19, 59, 16, 812, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Laboriosam voluptatum autem non ut illo.\nNon commodi odit.\nUt eaque exercitationem qui.", new DateTime(2024, 5, 8, 21, 59, 16, 812, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Porro eveniet nisi minus distinctio incidunt nihil illum ut.", new DateTime(2024, 5, 27, 6, 59, 16, 812, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "ut", new DateTime(2024, 5, 15, 11, 59, 16, 812, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Rem et quia dolore aut excepturi sed.\nNesciunt qui at quam.\nEa ducimus vel repellat porro qui voluptas.", new DateTime(2024, 6, 6, 1, 59, 16, 812, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Quam aut ut vel.", new DateTime(2024, 5, 21, 2, 59, 16, 812, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "enim", new DateTime(2024, 6, 2, 11, 59, 16, 812, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Suscipit voluptatibus in aut et deserunt et. Officia exercitationem eos earum. Recusandae quia aut delectus. Est aspernatur cum officiis illo enim repellendus vitae.", new DateTime(2024, 5, 1, 3, 59, 16, 812, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Dolore rerum voluptas ut. Sint iure et recusandae voluptatem. In quisquam voluptatem et eligendi vero cupiditate repellendus reprehenderit.", new DateTime(2024, 6, 7, 12, 59, 16, 812, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "saepe", new DateTime(2024, 5, 15, 4, 59, 16, 812, DateTimeKind.Local).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Ratione distinctio facilis deleniti officia consequatur et similique qui qui. Eaque temporibus accusamus culpa culpa ut quos ea. Aut consequuntur aut dicta rerum accusamus qui ipsum repellendus neque. Placeat corrupti sit nam quae commodi nisi. Molestias ratione ad earum suscipit quo.", new DateTime(2024, 5, 14, 0, 59, 16, 812, DateTimeKind.Local).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "magni", new DateTime(2024, 5, 9, 20, 59, 16, 812, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Ut incidunt quod minus est. Pariatur nemo neque incidunt molestiae nobis. Dolores labore qui est odit excepturi voluptas qui. Quae aut deleniti nulla ipsum enim quia officia repudiandae. Nemo aspernatur quo vitae provident.", new DateTime(2024, 5, 13, 22, 59, 16, 812, DateTimeKind.Local).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Aut sequi et repellat.", new DateTime(2024, 6, 2, 21, 59, 16, 812, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Aut a iure nulla corrupti corrupti.\nReprehenderit voluptate ea quae eius delectus natus.\nDolorem explicabo libero soluta non nobis voluptas.\nQuis velit et illo magni rem quidem.\nDelectus adipisci cumque id doloribus dolorem corrupti natus sed.", new DateTime(2024, 5, 10, 13, 59, 16, 812, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Voluptatem iure delectus saepe incidunt enim ut nihil iste amet.\nExpedita eos dolor temporibus dolorum.\nSunt facilis eaque rem nobis aut sint voluptates.", new DateTime(2024, 5, 18, 6, 59, 16, 812, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Asperiores totam officiis quibusdam. Culpa aspernatur inventore facere voluptas blanditiis. Qui est nemo ut commodi odio sint odio doloribus sit. Tempore enim alias cupiditate veniam. Enim et minima voluptatem adipisci inventore ad qui assumenda.", new DateTime(2024, 5, 25, 16, 59, 16, 812, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 9, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 1, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 12, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 17, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 27, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 28, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 2, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 15, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 26, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 25, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 28, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 8, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 13, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 3, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 29, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 4, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 19, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 7, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 6, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 19, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 1, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 27, 23, 59, 16, 812, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "531", "Heather Friesen", "6388-6748-5587-3924", new DateTime(2027, 6, 10, 23, 59, 16, 816, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "137", "Leif Ebert", "6386-6095-4209-3058", new DateTime(2031, 6, 10, 23, 59, 16, 816, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "337", "Frida Jaskolski", "4014777131712", new DateTime(2026, 6, 10, 23, 59, 16, 816, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "380", "Donato McKenzie", "6759-8796-8223-1595-974", new DateTime(2028, 6, 10, 23, 59, 16, 816, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "759", "Kaylin Barrows", "3714-926308-50394", new DateTime(2027, 6, 10, 23, 59, 16, 816, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "352", "Brycen Pollich", "3528-4406-0456-7821", new DateTime(2026, 6, 10, 23, 59, 16, 816, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "453", "Holly Schultz", "6371-5156-6445-2419", new DateTime(2033, 6, 10, 23, 59, 16, 816, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "084", "Crawford Rath", "6759-4372-3550-1875-439", new DateTime(2026, 6, 10, 23, 59, 16, 816, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "293", "Domenic Ruecker", "63044850847363094", new DateTime(2027, 6, 10, 23, 59, 16, 816, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "023", "Spencer McLaughlin", "6526-5568-5012-6072", new DateTime(2026, 6, 10, 23, 59, 16, 816, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "728", "Johnson Witting", "6391-2155-4141-3348", new DateTime(2026, 6, 10, 23, 59, 16, 816, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "577", "Ashlee Lang", "6767-4750-0634-1760-842", new DateTime(2029, 6, 10, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "877", "Rusty Lesch", "6767-3224-4826-4023-433", new DateTime(2033, 6, 10, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "991", "Kavon Pfeffer", "5258-1092-3346-6579", new DateTime(2027, 6, 10, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "055", "Camylle Weimann", "3653-473253-1245", new DateTime(2028, 6, 10, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "527", "Larissa Walker", "3607-492718-1605", new DateTime(2028, 6, 10, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "868", "Adrian Okuneva", "5543-8469-1239-7725", new DateTime(2033, 6, 10, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "146", "Rudy Gulgowski", "6767-0251-6616-4288-662", new DateTime(2033, 6, 10, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "434", "Lydia Oberbrunner", "3773-136426-65337", new DateTime(2027, 6, 10, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "613", "Monica Considine", "3028-503744-5609", new DateTime(2026, 6, 10, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "361", "Mona Kuhic", "5491-2560-8771-2520", new DateTime(2033, 6, 10, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "332", "Nicklaus Wilkinson", "6011-6212-2282-0340-1403", new DateTime(2026, 6, 10, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 262m, new DateTime(2024, 5, 28, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 806m, new DateTime(2024, 5, 22, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 151m, new DateTime(2024, 5, 22, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 543m, new DateTime(2024, 5, 26, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 192m, new DateTime(2024, 5, 23, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 897m, new DateTime(2024, 6, 6, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 102m, new DateTime(2024, 5, 21, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 106m, new DateTime(2024, 5, 12, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 883m, new DateTime(2024, 5, 31, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 684m, new DateTime(2024, 6, 5, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 802m, new DateTime(2024, 5, 17, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 382m, new DateTime(2024, 5, 18, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 114m, new DateTime(2024, 5, 22, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 161m, new DateTime(2024, 5, 27, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 889m, new DateTime(2024, 6, 2, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 309m, new DateTime(2024, 6, 6, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 438m, new DateTime(2024, 5, 18, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 511m, new DateTime(2024, 6, 1, 23, 59, 16, 817, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CategoryName",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CategoryName",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CategoryName",
                value: "Music");

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
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CategoryName",
                value: "Games");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CategoryName",
                value: "Sports");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CategoryName",
                value: "Computers");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CategoryName",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CategoryName",
                value: "Computers");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CategoryName",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CategoryName",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CategoryName",
                value: "Kids");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CategoryName",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CategoryName",
                value: "Music");

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
                value: "Sports");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CategoryName",
                value: "Automotive");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 130.26m, "Handmade Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 639.93m, "Tasty Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 581.70m, "Generic Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 608.21m, "Practical Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 714.66m, "Generic Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 961.90m, "Fantastic Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 21.71m, "Unbranded Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 190.03m, "Awesome Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 480.12m, "Practical Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 906.44m, "Gorgeous Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 264.56m, "Awesome Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 857.16m, "Generic Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 685.34m, "Rustic Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 816.63m, "Gorgeous Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 641.28m, "Handcrafted Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 265.72m, "Handcrafted Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 112.05m, "Unbranded Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 602.59m, "Generic Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 220.56m, "Awesome Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 800.95m, "Intelligent Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 174.55m, "Intelligent Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 850.60m, "Small Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 197.43m, "Handmade Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 917.11m, "Unbranded Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 736.39m, "Rustic Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 560.29m, "Intelligent Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 745.17m, "Fantastic Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 86.08m, "Incredible Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 181.60m, "Tasty Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 588.06m, "Awesome Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 218.89m, "Rustic Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 359.97m, "Intelligent Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 827.43m, "Handmade Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 865.48m, "Generic Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 450.60m, "Intelligent Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 914.69m, "Intelligent Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 74.96m, "Generic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 222.00m, "Incredible Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 115.41m, "Intelligent Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 349.98m, "Tasty Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 907.69m, "Gorgeous Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 690.31m, "Small Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 100.44m, "Licensed Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 875.07m, "Small Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 785.19m, "Refined Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 501.94m, "Sleek Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 962.30m, "Small Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 302.49m, "Fantastic Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 961.44m, "Handmade Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 840.73m, "Refined Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 672.03m, "Licensed Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 621.27m, "Licensed Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 897.83m, "Small Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 66.35m, "Handmade Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 937.33m, "Gorgeous Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 719.26m, "Ergonomic Granite Table" });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 1L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 116m, 65, 82.57m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 5L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 836m, 62, 398.61m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 11L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 685m, 16, 225.16m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 15L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 217m, 50, 124.66m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 720m, 27, 996.70m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 648m, 71, 415.02m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 877m, 30, 364.56m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 516m, 62, 940.66m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 259m, 97, 386.84m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 520m, 33, 530.48m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 192m, 34, 364.44m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 514m, 32, 498.35m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 140m, 43, 342.51m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 756m, 42, 963.80m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 10L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 562m, 75, 837.12m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 484m, 81, 219.73m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 961m, 64, 945.74m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 4L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 324m, 22, 90.26m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 809m, 44, 104.45m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 14L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 518m, 38, 141.09m });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "fugiat", new DateTime(2024, 5, 11, 23, 59, 16, 831, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Cumque sequi suscipit enim similique consequatur voluptas. Minima mollitia eligendi est. Error sunt doloremque incidunt et fugiat.", new DateTime(2024, 3, 2, 23, 59, 16, 831, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Sunt qui excepturi minima.", new DateTime(2024, 5, 21, 23, 59, 16, 831, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "nam", new DateTime(2024, 5, 11, 23, 59, 16, 831, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "dolorum", new DateTime(2024, 3, 2, 23, 59, 16, 831, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Quam quos nemo earum maiores id enim qui.", new DateTime(2024, 5, 21, 23, 59, 16, 831, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 26, 23, 59, 16, 835, DateTimeKind.Local).AddTicks(848), "eum" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 17, 23, 59, 16, 835, DateTimeKind.Local).AddTicks(902), "ad" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 18, 23, 59, 16, 835, DateTimeKind.Local).AddTicks(912), "Dolor velit magnam hic.\nIn praesentium sint veniam quasi neque commodi doloribus similique.\nAb autem ab quisquam fugit est nam animi." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 59, 16, 835, DateTimeKind.Local).AddTicks(1136), "Culpa fugit fugit excepturi velit voluptate molestias ut. Aut non quod tempore cupiditate ipsa sit sit veniam adipisci. Et enim deserunt illum sit ullam aut aut odit. Libero nemo ea sapiente non aliquam sint velit vitae rem. Non sint aut quas unde." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 7, 23, 59, 16, 835, DateTimeKind.Local).AddTicks(1407), "Quam exercitationem quaerat doloribus. Repellendus et corporis impedit ut nisi et reprehenderit reiciendis dolor. Hic molestiae molestiae minima nihil. Et doloremque magnam unde beatae omnis officia. Quis voluptatem et." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 6, 23, 59, 16, 835, DateTimeKind.Local).AddTicks(1571), "Ratione consectetur ut consequuntur aut. Mollitia aut temporibus impedit sint. Non qui corporis ipsam cumque pariatur recusandae ut eius. Ea rerum rem commodi et." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 26, 23, 59, 16, 835, DateTimeKind.Local).AddTicks(1756), "dolor" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 17, 23, 59, 16, 835, DateTimeKind.Local).AddTicks(1766), "Labore quidem aliquam repellat esse.\nAtque autem voluptatem culpa magnam expedita quod quos.\nPorro eos dolores fugiat impedit voluptatem natus molestiae inventore.\nSapiente et et corrupti voluptatem labore nobis aliquam." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 18, 23, 59, 16, 835, DateTimeKind.Local).AddTicks(1918), "Sit iure nam nulla id sapiente excepturi laborum.\nPerferendis esse ut asperiores aliquam et ad enim." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 59, 16, 835, DateTimeKind.Local).AddTicks(2034), "Quibusdam perspiciatis quo est excepturi omnis saepe at." });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3EYgXcZKoDL3yUxe4A5wRBr8sFtdWGp", new DateTime(2024, 6, 6, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(1364), "OBZICUL1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "34uLdNnH8XS3YKr9EFZhVpkfCjzGQbqy", new DateTime(2024, 6, 5, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(1504), "YYREERZ1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3e5cXBnmLEyj2FHxUoviVub7dJMztwDKgPS", new DateTime(2024, 4, 26, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(1590), "CLQIERG1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1HGz4auAL8fYKtgXdpUnvwoMWEeB", new DateTime(2024, 4, 26, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(1643), "AVVATMH1083" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3JRgKdx9nUXuSDcmYsBptky7ZrN", new DateTime(2024, 6, 7, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(1701), "UFRIGNR1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3895Aw4htjLrQYZGpzdnmMk72NV", new DateTime(2024, 5, 30, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(1742), "JHSAAWW1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1mNCS4sY2hdiXKPBnftwpa7qW5H", new DateTime(2024, 4, 15, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(1783), "IEPUSTI1814" });

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 4L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 5L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 6L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 23, 59, 16, 838, DateTimeKind.Local).AddTicks(2244));
        }
    }
}
