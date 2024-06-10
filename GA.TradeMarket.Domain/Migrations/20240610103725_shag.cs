using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class shag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a65e80f-e02f-436d-8e5d-1d4b5d6638ef", "AQAAAAIAAYagAAAAEHIbWqBPVtlCVWUESKZ3iCG8QXX/qme+jnRbTKaU8lLLSpB3vyt/HQUzY8iE3tY9KQ==", "8f541e6f-362a-4515-a4d3-b61cad734428" });

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
                column: "NotificationDate",
                value: new DateTime(2024, 5, 29, 2, 37, 23, 721, DateTimeKind.Local).AddTicks(3186));

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
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 606m, 12, 811.77m });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e018283-84b1-4f71-b357-c83a8d3198e7", "AQAAAAIAAYagAAAAECzJPfeOrrgQ/mEuZCtdk5zzoIJACCRbHv6aqFkzUsVACgsG4KfmT3ka9hgzx0TKfg==", "a50b72b4-a239-40c5-9bec-61963df74908" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1971, 6, 8, 15, 47, 25, 676, DateTimeKind.Local).AddTicks(2052), "812ec7e0-3eff-4675-a11e-5e4857117cef", "asa@upton.com", "Davis", "(486)050-5601 x270", "19f104e8-5aa0-4e5b-8d57-07b90d9b435f", "Grant", "alayna_ryan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1993, 6, 8, 15, 47, 25, 676, DateTimeKind.Local).AddTicks(5325), "073eeba5-964c-4b49-bbe2-87e0ea87211a", "paige@ryanrempel.name", "Heaney", "320.399.9859", "0abfd361-44ee-46a8-93ed-34070f0c8334", "Okuneva", "zoey.wolff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1969, 6, 8, 15, 47, 25, 676, DateTimeKind.Local).AddTicks(8331), "eb3ac95a-46a3-450a-bd5c-99271e2db70d", "gwendolyn@cronasatterfield.info", "Bosco", "(288)976-3076 x160", "e18757fe-4f59-4cbc-a2da-00f974874c14", "Wunsch", "lennie.effertz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2009, 6, 8, 15, 47, 25, 677, DateTimeKind.Local).AddTicks(1899), "0cfb3cb3-93f4-48fe-954e-b02c5c080713", "reed.prosacco@schumm.biz", "Rutherford", "1-880-162-8684", "13638485-aa01-484e-b9bc-a129fb5d64d7", "Pfeffer", "skye.welch" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1994, 6, 8, 15, 47, 25, 677, DateTimeKind.Local).AddTicks(5048), "9fb90562-5de5-40b8-a777-c24d20853e11", "nayeli.hamill@kuphalcorwin.biz", "Lebsack", "(632)680-3635", "1f255fff-4623-40ca-8ef4-bbec6684cf5a", "Parisian", "mia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2003, 6, 8, 15, 47, 25, 677, DateTimeKind.Local).AddTicks(8317), "2ca74fef-c5d6-4498-97a3-b62f7eda431c", "dax@beatty.uk", "Carroll", "354-678-0064 x809", "c1907c7c-bf0e-4190-8971-3a827b0cfb65", "Rath", "lou" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2006, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(1149), "b932f5ed-11f0-4d2e-91d1-2ab8d6f347bf", "minerva@adams.ca", "Rath", "1-568-960-6125 x0345", "982f9ee3-4810-49ee-930d-40055ce02c45", "McCullough", "dovie_ferry" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1976, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(4445), "2a208d77-0439-4d80-8c7b-4db0ec48d108", "wyman.borer@mcglynnkiehn.com", "Homenick", "1-811-494-1863", "7b9ad071-3d44-48d3-b115-306fdade489e", "D'Amore", "meaghan" });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2007, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6167), 980 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1995, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6169), 171 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6171), 392 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2011, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6172), 658 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1997, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6174), 939 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1995, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6176), 338 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6177), 123 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2011, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6179), 849 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2004, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6180), 901 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1996, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6182), 136 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6184), 382 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2002, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6185), 594 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2020, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6187), 637 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2007, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6188), 438 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6191), 514 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6192), 169 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6193), 766 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2021, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6195), 799 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2022, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6197), 873 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6199), 821 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6200), 726 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6201), 217 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2000, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6203), 595 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6205), 172 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6206), 755 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2015, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6208), 714 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2021, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6209), 533 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2014, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6211), 753 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1997, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6212), 432 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1997, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6214), 795 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2002, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6215), 924 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 6, 8, 15, 47, 25, 678, DateTimeKind.Local).AddTicks(6218), 405 });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "32fzWqaXSrEDAbecKJm5VLT6ZnY22489", 148m, new DateTime(2025, 4, 14, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3r1GupTfiymaNFHkgBZbwMUq9zv6R8En99296", 356m, new DateTime(2024, 12, 17, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1Me35tikaqf4BhGN9cPw1yxTjsEZL72025", 204m, new DateTime(2024, 12, 4, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1a5HEwDUi3eSPkcugbrXsJ7zVM948F51572", 208m, new DateTime(2024, 12, 19, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "35znDhY98JTdE3GZVwR6NjvtyAW85120", 196m, new DateTime(2025, 5, 1, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3XMRzrNf7sLtGEKhe4CSowqacBiDZpn171095", 209m, new DateTime(2025, 6, 17, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1HENaTG1gcMYKhsAUnquv79rSXpbCj4Vt83103", 396m, new DateTime(2024, 9, 6, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1yw6ip1Hh7DFZxVzRB9QuqftMA259696", 100m, new DateTime(2025, 8, 5, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1bGYa7hQ8JXSK3io4q6WcszfFjrmwE97066", 123m, new DateTime(2025, 6, 15, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1gN6xMmUupzGaPqi2YhtS8ETCWj5v61176", 380m, new DateTime(2025, 3, 10, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3nYeAcTi9Pbyu1sVJtLB5vGWxq35216", 305m, new DateTime(2025, 1, 13, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3rU64m8dgDN9Cw5T7i2enWMXckBGHbV50928", 100m, new DateTime(2025, 8, 29, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1ZbJV8dpC6tgDosELPUqm4STaHRXW2Fhw61754", 367m, new DateTime(2025, 10, 6, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1imSEocFNekBQt7qwDpHaRJgL48dUZ94159", 203m, new DateTime(2024, 11, 19, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1aUVMC4pBqJ9wj3Z7W1yPdD6hKmk31705", 133m, new DateTime(2025, 8, 14, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3vfJHKzNonbc16C2MwkS3d8jWB7588951", 318m, new DateTime(2025, 4, 24, 15, 47, 25, 675, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 425m, new DateTime(2023, 5, 28, 16, 47, 25, 678, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 763m, new DateTime(2023, 6, 10, 13, 47, 25, 678, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 824m, new DateTime(2024, 5, 15, 2, 47, 25, 678, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 542m, new DateTime(2023, 5, 1, 0, 47, 25, 678, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 103m, new DateTime(2023, 8, 30, 13, 47, 25, 678, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 598m, new DateTime(2023, 10, 17, 0, 47, 25, 678, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 116m, new DateTime(2024, 2, 27, 0, 47, 25, 678, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 770m, new DateTime(2023, 9, 3, 11, 47, 25, 678, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 6, 8, 15, 47, 25, 673, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "laudantium", new DateTime(2024, 5, 3, 20, 47, 25, 680, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "quod", new DateTime(2024, 5, 31, 1, 47, 25, 680, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "perferendis", new DateTime(2024, 6, 2, 6, 47, 25, 680, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Aperiam dolores ipsa sint neque quaerat id deserunt. Nulla sit eveniet voluptatem ut natus consectetur ea corrupti. Ex ut excepturi. Consequuntur distinctio dolore sed voluptatibus quia. Sit nihil a non eum et. Non ipsam praesentium quia adipisci iusto.", new DateTime(2024, 5, 16, 6, 47, 25, 680, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "aliquam", new DateTime(2024, 5, 11, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Odit dicta repellat omnis aut placeat adipisci.", new DateTime(2024, 5, 10, 12, 47, 25, 680, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "iste", new DateTime(2024, 6, 1, 8, 47, 25, 680, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8L,
                column: "NotificationDate",
                value: new DateTime(2024, 5, 6, 20, 47, 25, 680, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Deleniti sunt molestiae perspiciatis dolor nisi pariatur molestiae. Voluptatibus ullam iste cum ipsum dolores. Molestiae incidunt sint facere vitae. Placeat at totam est iste delectus. Ut quaerat voluptate qui quis atque.", new DateTime(2024, 5, 22, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Repellendus dolore explicabo aut aut reiciendis consequuntur.", new DateTime(2024, 5, 28, 10, 47, 25, 680, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "incidunt", new DateTime(2024, 5, 24, 1, 47, 25, 680, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Est aut enim nam illum aut saepe molestias dolorem adipisci.\nIpsum sunt adipisci quia reprehenderit accusamus quaerat sint.\nCorrupti ut et ea.\nQuibusdam quisquam voluptas aut adipisci dicta inventore ipsa delectus ut.", new DateTime(2024, 5, 4, 3, 47, 25, 680, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "blanditiis", new DateTime(2024, 5, 11, 12, 47, 25, 680, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Nihil saepe facilis iure quam autem ut.", new DateTime(2024, 6, 5, 10, 47, 25, 680, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Non numquam minus quia. Laudantium ipsum a alias ea iste perferendis harum voluptates. Provident nihil et aut commodi. Sed asperiores et reiciendis voluptate distinctio ea recusandae ipsa. Dolores rerum et esse deleniti libero sed et.", new DateTime(2024, 6, 6, 6, 47, 25, 680, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Repudiandae ipsa similique in tempore possimus et.", new DateTime(2024, 6, 7, 17, 47, 25, 680, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Nobis magni aspernatur.\nAut inventore maiores culpa dolores et enim deserunt.\nMagnam est aut sit quis et incidunt harum.\nPossimus maiores officia voluptatem et mollitia ut.\nHic omnis culpa cumque qui.", new DateTime(2024, 5, 24, 21, 47, 25, 680, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Deleniti commodi tempora ex unde.\nDicta amet sit est similique et vitae.\nMolestiae quae itaque repudiandae vel tempora.\nNostrum asperiores non omnis et quo molestiae quis.", new DateTime(2024, 5, 15, 11, 47, 25, 680, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 17, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 6, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 23, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 16, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 17, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 16, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 25, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 31, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 22, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 4, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 11, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 22, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 7, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 6, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 29, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 14, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 29, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 5, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 12, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 1, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 5, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 24, 15, 47, 25, 680, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "853", "Mac Ullrich", "4091-0430-1072-9798", new DateTime(2028, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "412", "Candace Emmerich", "6767-2531-7454-9671-399", new DateTime(2030, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "324", "Fausto Klein", "3529-6406-2408-9735", new DateTime(2031, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "892", "Maida Tremblay", "6759-1447-0415-8700-38", new DateTime(2032, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "560", "Clifford Marquardt", "4340467248775", new DateTime(2031, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "874", "Nat Torphy", "6767-3353-6851-9879-37", new DateTime(2031, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "295", "Demetris White", "6399-6981-3821-4637", new DateTime(2033, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "840", "Stefan Beatty", "3787-217336-96319", new DateTime(2033, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "402", "Amparo Connelly", "6480-6245-7808-1022-7970", new DateTime(2033, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "178", "Bud Mann", "3542-9048-0207-4908", new DateTime(2031, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "595", "Sean Christiansen", "6378-7639-1089-6632", new DateTime(2029, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "713", "Clement Hyatt", "6371-7072-8372-2328", new DateTime(2029, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "392", "Mariana Boyle", "6767-2910-2156-8033-15", new DateTime(2030, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "672", "Guadalupe Hahn", "3053-613906-8537", new DateTime(2030, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "643", "Keshawn Prosacco", "6767-0234-7748-9134", new DateTime(2030, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "338", "Antonette O'Kon", "6771-8947-5867-6811", new DateTime(2026, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "602", "Ola Wolff", "3719-814363-60095", new DateTime(2026, 6, 8, 15, 47, 25, 682, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "000", "Cleora Gutmann", "6767-2917-9614-9195-413", new DateTime(2031, 6, 8, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "542", "Anahi Kemmer", "6381-3931-0214-8686", new DateTime(2029, 6, 8, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "437", "Abraham Kling", "5020951754450285", new DateTime(2031, 6, 8, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "254", "Sonia Cummerata", "3529-8199-9607-3432", new DateTime(2029, 6, 8, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "882", "Gerhard Gleason", "3756-980509-55838", new DateTime(2030, 6, 8, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 880m, new DateTime(2024, 5, 25, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 792m, new DateTime(2024, 5, 21, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 189m, new DateTime(2024, 6, 3, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 784m, new DateTime(2024, 5, 21, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 654m, new DateTime(2024, 6, 5, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 651m, new DateTime(2024, 6, 3, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 720m, new DateTime(2024, 5, 18, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 969m, new DateTime(2024, 5, 25, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 393m, new DateTime(2024, 5, 27, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 637m, new DateTime(2024, 5, 18, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 54m, new DateTime(2024, 5, 16, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 326m, new DateTime(2024, 5, 28, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 813m, new DateTime(2024, 5, 23, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 675m, new DateTime(2024, 5, 21, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 951m, new DateTime(2024, 5, 10, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 32m, new DateTime(2024, 5, 28, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 867m, new DateTime(2024, 5, 21, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 562m, new DateTime(2024, 5, 12, 15, 47, 25, 683, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CategoryName",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CategoryName",
                value: "Shoes");

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
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CategoryName",
                value: "Grocery");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CategoryName",
                value: "Books");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CategoryName",
                value: "Health");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CategoryName",
                value: "Home");

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
                value: "Toys");

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
                value: "Games");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CategoryName",
                value: "Toys");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CategoryName",
                value: "Garden");

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
                value: "Health");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CategoryName",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CategoryName",
                value: "Home");

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
                values: new object[] { 764.29m, "Rustic Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 983.33m, "Practical Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 259.88m, "Unbranded Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 237.72m, "Ergonomic Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 803.82m, "Generic Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 651.92m, "Refined Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 616.15m, "Fantastic Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 446.36m, "Awesome Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 25.19m, "Gorgeous Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 261.01m, "Rustic Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 876.04m, "Rustic Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 54.38m, "Fantastic Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 114.35m, "Intelligent Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 21.92m, "Small Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 654.00m, "Intelligent Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 390.39m, "Gorgeous Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 459.20m, "Incredible Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 886.35m, "Rustic Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 158.65m, "Intelligent Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 681.98m, "Sleek Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 381.80m, "Small Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 284.46m, "Awesome Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 128.11m, "Tasty Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 148.46m, "Licensed Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 304.65m, "Incredible Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 505.11m, "Handmade Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 982.04m, "Tasty Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 621.44m, "Incredible Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 810.13m, "Small Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 999.30m, "Handcrafted Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 457.89m, "Unbranded Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 910.37m, "Incredible Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 82.74m, "Licensed Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 648.96m, "Tasty Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 512.78m, "Handcrafted Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 656.64m, "Gorgeous Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 483.74m, "Incredible Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 118.55m, "Tasty Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 392.67m, "Rustic Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 342.32m, "Intelligent Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 160.08m, "Awesome Granite Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 8.46m, "Rustic Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 952.38m, "Practical Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 414.74m, "Refined Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 680.08m, "Ergonomic Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 163.65m, "Generic Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 490.97m, "Licensed Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 195.46m, "Ergonomic Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 608.05m, "Ergonomic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 2.55m, "Fantastic Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 292.47m, "Refined Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 628.21m, "Sleek Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 432.92m, "Intelligent Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 192.06m, "Licensed Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 144.83m, "Small Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 335.16m, "Practical Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 1L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 545m, 75, 556.25m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 5L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 433m, 44, 887.16m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 11L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 975m, 27, 1.85m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 15L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 612m, 56, 92.74m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 247m, 76, 999.32m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 577m, 70, 695.01m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 544m, 53, 672.46m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 562m, 45, 110.06m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 832m, 72, 647.47m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 246m, 15, 49.85m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 121m, 20, 541.97m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 557m, 24, 664.36m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 771m, 17, 170.67m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 67m, 22, 601.39m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 10L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 883m, 87, 83.65m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 242m, 92, 915.86m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 708m, 68, 417.57m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 4L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 538m, 79, 526.76m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 489m, 78, 412.98m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 14L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 147m, 16, 472.91m });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "odio", new DateTime(2024, 5, 9, 15, 47, 25, 689, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "ut", new DateTime(2024, 2, 29, 15, 47, 25, 689, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Laborum odit asperiores omnis.", new DateTime(2024, 5, 19, 15, 47, 25, 689, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Esse recusandae et commodi dolorum officiis.", new DateTime(2024, 5, 9, 15, 47, 25, 689, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Earum ea veritatis non facilis qui qui laudantium.", new DateTime(2024, 2, 29, 15, 47, 25, 689, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "aliquid", new DateTime(2024, 5, 19, 15, 47, 25, 689, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 24, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(2438), "Amet tenetur tempora iure nulla. Ut aut a delectus quis quibusdam eaque. Mollitia molestiae cupiditate maiores autem tempora." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(2624), "Aspernatur et eius quo commodi in deleniti. Reprehenderit dolorem quam. Praesentium tempore possimus qui quia molestiae et sapiente animi ullam." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(2750), "Amet ut explicabo voluptatum ut velit dolorem. Expedita molestiae veritatis sint rerum laboriosam recusandae qui sit nulla. Sit vitae et et magni mollitia nesciunt sed sit atque. Debitis rerum qui odit totam est. Quod voluptate cumque culpa voluptas eos vitae expedita dolorum consequatur." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(2900), "Expedita harum facere dolores qui. Officiis eum optio qui harum voluptatem. Aperiam laudantium voluptatem ut quos dolores fugit illo accusamus consequuntur. Quo asperiores assumenda. Enim possimus libero eaque. Rerum aliquid aut." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 5, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(3039), "Eveniet consequatur non id commodi molestiae molestiae aut. Sapiente incidunt veritatis consequatur voluptas libero dolor. Excepturi est laborum alias ut excepturi minima ex. Est in optio aut nobis aut tenetur voluptas fugiat suscipit. Non odio ut rerum quis laboriosam et eveniet reprehenderit dolores. Nostrum est officia modi voluptatum alias hic." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 4, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(3225), "Molestias atque quis optio facere." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 24, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(3243), "provident" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(3249), "Sint at quod magni pariatur ad excepturi ea omnis labore." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(3279), "quibusdam" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 47, 25, 691, DateTimeKind.Local).AddTicks(3284), "Ut est ipsum voluptatem voluptas eius." });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "33AKbiWwDSNvpq59R82GxuhBcVy7H", new DateTime(2024, 6, 4, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7610), "CKWICII1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "32kS6GtncXQHD3zhmdgTeFYiPMBRvsf", new DateTime(2024, 6, 3, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7764), "ITSOMSY1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "17L2CeS8BaqyzHXnhuEoPgiQjxUMNtw6", new DateTime(2024, 4, 24, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7806), "WJDUBOP1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "39pvAsHNGtri1oxk3TKYCDQBz7W", new DateTime(2024, 4, 24, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7844), "NFBEEAL1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3Nf4bB3ijeHT52AvSJpDXaUGKyWV", new DateTime(2024, 6, 5, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7878), "JXUOBLP1252" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "11VUuTQziBD5eWm3xnGovsYyH42aFSt8ZR", new DateTime(2024, 5, 28, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7916), "WEYOLYE1327" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3YCN1R2sDrS9BTPobUdFLMHnXAhw4v", new DateTime(2024, 4, 13, 15, 47, 25, 692, DateTimeKind.Local).AddTicks(7960), "KQLECAH1" });
        }
    }
}
