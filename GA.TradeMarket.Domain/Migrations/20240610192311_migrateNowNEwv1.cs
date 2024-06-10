using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class migrateNowNEwv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoggMesagge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aae7687-6e74-44a1-abef-7c52a165eb3c", "AQAAAAIAAYagAAAAEGsSUEenJX8E+7DGzc97WzBXUAAQmO2hluI1krGBWm/VqI+wMEN/kPwGp2yYXJsvmw==", "0727eab9-98ef-4e95-9b0f-05ec51b95f8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1979, 6, 10, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(7662), "fd7fb921-154a-4601-a60b-71f3d709f004", "americo.klein@lubowitz.com", "Krajcik", "246.566.2422 x616", "6d293945-ec7f-41fa-8c57-612f4ca3ff4e", "Jewess", "blaze" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2007, 6, 10, 23, 23, 10, 506, DateTimeKind.Local).AddTicks(4894), "330f9dbf-fc0a-4e5b-ae63-237ddf3ae260", "araceli@streich.biz", "Kohler", "(397)965-3831 x205", "c2c7488a-87bb-4a72-bd36-7c6e16528cd6", "O'Hara", "federico" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2012, 6, 10, 23, 23, 10, 507, DateTimeKind.Local).AddTicks(2780), "dcaddf39-57af-4d03-af60-ba3e64635e32", "newton_parker@davisbatz.com", "Boyle", "(074)890-2643", "f89230f4-330a-4f2b-abf6-40cd7a652ef5", "Feeney", "maegan_welch" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2002, 6, 10, 23, 23, 10, 507, DateTimeKind.Local).AddTicks(9287), "c3c99f65-47bc-4374-a36c-0f1cdcaf47e0", "gail@wisoky.info", "Cummerata", "112.304.2649 x93236", "f82abf0a-68cb-4e83-a49b-1abe82587158", "Price", "kelvin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1983, 6, 10, 23, 23, 10, 508, DateTimeKind.Local).AddTicks(8449), "447ad260-881f-46e1-bddb-dec64eed4b88", "jammie@wyman.com", "Crona", "1-053-212-1813", "5d004d48-9d80-4c06-83c3-64470dcf29a2", "Boehm", "yessenia_auer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2011, 6, 10, 23, 23, 10, 509, DateTimeKind.Local).AddTicks(9494), "56d95d01-0166-4c83-90cf-40ee9b916488", "israel.homenick@oreillygraham.uk", "Gislason", "(762)694-9949 x288", "3d740625-90f0-491a-bbc5-b3922fce7f8d", "Nienow", "emelie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(2014, 6, 10, 23, 23, 10, 510, DateTimeKind.Local).AddTicks(6257), "fbc6ee8f-d0e9-4c9b-a9ff-5fb18f8016a2", "dell_hickle@hoegerbraun.info", "Schmidt", "393.034.0624 x867", "1f3498a9-ead9-49ab-8fed-162c7f6bd1f4", "Deckow", "agnes_witting" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "Surname", "UserName" },
                values: new object[] { new DateTime(1997, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(3308), "d1aaaa11-d40c-45ff-9105-d9d98bbe3565", "alec.steuber@kautzer.co.uk", "Wuckert", "954.644.3547 x4326", "466ec290-69fe-4282-95a5-0269ea3254bc", "Connelly", "roslyn_bruen" });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6272), 536 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6276), 514 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6278), 384 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2019, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6279), 725 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2005, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6281), 591 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2012, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6282), 145 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6284), 961 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2020, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6286), 233 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6287), 284 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6289), 420 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2004, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6290), 844 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2016, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6292), 938 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2006, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6293), 845 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1998, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6295), 382 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6296), 162 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2003, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6298), 139 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2004, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6300), 214 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2001, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6301), 877 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2013, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6303), 772 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2002, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6304), 881 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2008, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6306), 386 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6307), 290 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6309), 475 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2001, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6310), 689 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2017, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6312), 586 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2002, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6313), 428 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2018, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6315), 588 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(1999, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6317), 785 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2019, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6318), 949 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2009, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6320), 548 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2023, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6321), 809 });

            migrationBuilder.UpdateData(
                table: "Bonuses",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "EnrollmentDate", "Points" },
                values: new object[] { new DateTime(2001, 6, 10, 23, 23, 10, 511, DateTimeKind.Local).AddTicks(6323), 615 });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1NRBzukVFdxjH1am8DfhbZnyoTG19589", 346m, new DateTime(2024, 10, 23, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "11f4X28piMPB9nrYVW3umKkCvsQN38852", 302m, new DateTime(2025, 7, 27, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3gHot3jAm65JhUr2yVEMXCFYPeNBxLf87n14612", 302m, new DateTime(2024, 8, 2, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1Zp9x7ehyFYGENf5uAXwvaUbT397750", 346m, new DateTime(2024, 9, 1, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1bsFqEjZyLV8nK1Rd4QHvBhwpG9MXN21854", 156m, new DateTime(2025, 10, 12, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1KHtWEoAzV35DFYSuxdRMecXrqBTLfhak473514", 390m, new DateTime(2024, 11, 20, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3iY8JxWvnaPd5ELfDA7wQm69jrzBRK99183", 172m, new DateTime(2025, 3, 27, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1YF6kg5Bnwt2EK7VmXrpoi1cHz69310", 208m, new DateTime(2025, 4, 8, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3B6NHSsTGxF7XvYQprPU8VLCjAki25904", 113m, new DateTime(2025, 3, 19, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3vuAR8XiwT9W6Vcs3SK4NkhoyCG1Z93524", 218m, new DateTime(2024, 7, 10, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1jgbpndSMu1esT8ExcC4XBL9W2qH42583", 106m, new DateTime(2025, 8, 21, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3U2xn1CPGvfjsbYMNuTiQcSzg6R46242", 308m, new DateTime(2024, 7, 11, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1E3ZFkzB2stV9UAbd5p8Reo6inCm1yj84396", 288m, new DateTime(2024, 7, 19, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "13KmN9hCwsSEXbLp2o8JHqRTAuerQy46zf27359", 150m, new DateTime(2024, 9, 7, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "3tdTQrMSUoKNHpPjAaYcw1RFXifEq99498", 222m, new DateTime(2024, 7, 30, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Code", "DiscountValue", "ExpiryDate" },
                values: new object[] { "1EXprv2iURNTHVY4x6tL9g8WBcF68526", 117m, new DateTime(2024, 10, 15, 23, 23, 10, 505, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 897m, new DateTime(2023, 9, 24, 19, 23, 10, 511, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 121m, new DateTime(2024, 2, 4, 12, 23, 10, 511, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 179m, new DateTime(2024, 3, 9, 6, 23, 10, 511, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 569m, new DateTime(2023, 9, 11, 8, 23, 10, 511, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 916m, new DateTime(2023, 10, 12, 13, 23, 10, 511, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 484m, new DateTime(2023, 10, 6, 2, 23, 10, 511, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 397m, new DateTime(2024, 6, 1, 18, 23, 10, 511, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DiscountValue", "OperationDate" },
                values: new object[] { 553m, new DateTime(2024, 4, 23, 1, 23, 10, 511, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LogTime",
                value: new DateTime(2024, 6, 10, 23, 23, 10, 500, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Iusto quis quas rerum quia beatae assumenda modi. Ut placeat sint tenetur omnis ad. Quas officia impedit quis et repellat aut ut voluptates est. Occaecati perspiciatis vel. Recusandae omnis nihil repellat. Recusandae deleniti asperiores eum itaque sit.", new DateTime(2024, 5, 25, 19, 23, 10, 528, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Voluptatem ea provident qui quod sit aut.", new DateTime(2024, 5, 18, 9, 23, 10, 528, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Ad molestias consectetur ex sint ipsam omnis corporis. Maxime culpa laborum dolores in. Autem quo animi repellat reiciendis optio rerum. Natus laboriosam similique ut occaecati deleniti voluptatem quia odio incidunt. Quia rerum dolor. Qui optio veritatis veniam quasi deserunt.", new DateTime(2024, 4, 30, 9, 23, 10, 528, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Sapiente ipsam commodi doloribus et sunt. Ipsum ipsam ab distinctio non. Nemo voluptatem possimus eaque enim illo cupiditate. Placeat minus nam. Commodi vel asperiores sunt beatae sed quo similique.", new DateTime(2024, 6, 3, 13, 23, 10, 528, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Sunt veniam rem dolorem quia et voluptate.\nQui animi laudantium est.\nIpsa architecto laboriosam possimus officiis reprehenderit.\nMagni est cum odit iste doloremque occaecati non quos.", new DateTime(2024, 6, 6, 7, 23, 10, 528, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Qui ab sint est excepturi ut eveniet molestias dolores. Voluptatem odit quo quisquam earum qui rerum aut nostrum delectus. Recusandae dignissimos impedit. Natus perspiciatis neque officia consequatur incidunt molestias.", new DateTime(2024, 5, 31, 18, 23, 10, 528, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "amet", new DateTime(2024, 6, 5, 19, 23, 10, 528, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "In molestias illo.\nRecusandae placeat in minus corrupti.\nQui dolores accusantium ea iste nemo officia quo.\nAliquid iste vitae non ducimus magni sunt hic quis molestiae.", new DateTime(2024, 5, 9, 20, 23, 10, 528, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Aut voluptatem dolorem eum fugiat.", new DateTime(2024, 5, 20, 11, 23, 10, 528, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10L,
                column: "NotificationDate",
                value: new DateTime(2024, 5, 30, 22, 23, 10, 528, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "necessitatibus", new DateTime(2024, 5, 30, 16, 23, 10, 528, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Atque praesentium et excepturi ut nemo. Voluptatum ut incidunt ipsa. Nostrum et rerum ipsum voluptatem. Porro consequatur necessitatibus minima ut omnis voluptas. Molestias sint corporis inventore.", new DateTime(2024, 5, 8, 17, 23, 10, 528, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Numquam eius velit ut mollitia eum aspernatur aut incidunt est.", new DateTime(2024, 5, 1, 17, 23, 10, 528, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "est", new DateTime(2024, 6, 3, 12, 23, 10, 528, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Recusandae qui a aut.", new DateTime(2024, 5, 20, 14, 23, 10, 528, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Voluptatem aut corrupti a repudiandae itaque.\nVoluptate sunt optio iusto assumenda vitae eligendi magnam.\nSed sit quidem est dicta.\nExercitationem nihil qui distinctio non.\nAut quas nihil velit rerum quia libero et.\nId at quae ipsa magnam impedit est id.", new DateTime(2024, 6, 6, 14, 23, 10, 528, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Eligendi autem et culpa.\nVelit esse reiciendis natus beatae exercitationem accusamus non repellat.", new DateTime(2024, 4, 30, 18, 23, 10, 529, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Message", "NotificationDate" },
                values: new object[] { "Eius exercitationem facilis et hic sapiente incidunt necessitatibus placeat aut.\nSit eum et quasi vero dolorem rerum veritatis.\nDolorum voluptatem architecto reprehenderit minima iste asperiores sequi odio modi.\nQuia quo voluptate nemo reprehenderit cumque placeat sit.\nCumque occaecati et neque iusto excepturi et tempora.\nDolor labore quia perferendis quia ab quae.", new DateTime(2024, 5, 17, 20, 23, 10, 529, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 29, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 23, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 17, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 6, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 23, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 1, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 7, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 4, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 2, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 23, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 23, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 13, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 20, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 3, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 18, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 19, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 7, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 20, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 26, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20L,
                column: "OrderDate",
                value: new DateTime(2024, 5, 31, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 4, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22L,
                column: "OrderDate",
                value: new DateTime(2024, 6, 8, 23, 23, 10, 529, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "208", "Sebastian Greenfelder", "6759-6572-3748-4236-12", new DateTime(2032, 6, 10, 23, 23, 10, 534, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "357", "Cyril Dickens", "4600528817730", new DateTime(2033, 6, 10, 23, 23, 10, 534, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "152", "Kristian Gislason", "501857874251167853", new DateTime(2033, 6, 10, 23, 23, 10, 534, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "135", "Conrad Blanda", "6767-7874-5081-5183-15", new DateTime(2027, 6, 10, 23, 23, 10, 534, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "043", "Cade Kuvalis", "5485-5957-8398-4489", new DateTime(2029, 6, 10, 23, 23, 10, 534, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "969", "Branson Kemmer", "4574801983446", new DateTime(2028, 6, 10, 23, 23, 10, 534, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "450", "Norbert Graham", "3010-850094-5956", new DateTime(2031, 6, 10, 23, 23, 10, 534, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "250", "Kathryn Graham", "6391-4303-0186-1418", new DateTime(2029, 6, 10, 23, 23, 10, 534, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "202", "Makenzie Von", "3529-7482-4302-3918", new DateTime(2031, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "953", "Willie Block", "3528-4139-9022-8795", new DateTime(2031, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "463", "Jameson Paucek", "6759-2549-3643-4441", new DateTime(2029, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "581", "Bernhard Hackett", "3646-932004-6159", new DateTime(2033, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "954", "Dallas Berge", "6709862963672518", new DateTime(2031, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "361", "Virginia Collier", "3655-601891-4191", new DateTime(2033, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "940", "Alice Koss", "3638-142369-4191", new DateTime(2028, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "508", "Eloy Sawayn", "5478-5091-7499-8585", new DateTime(2026, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "448", "Taya Willms", "3529-5970-2951-0105", new DateTime(2026, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "804", "Joanny Feeney", "3731-008435-99199", new DateTime(2030, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "154", "Ansley Ankunding", "4839-8605-0966-7362", new DateTime(2032, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "078", "Uriah Padberg", "3471-727429-28723", new DateTime(2030, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "956", "Martina Simonis", "5213-6584-3096-3832", new DateTime(2033, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CVV", "CardHolderName", "CardNumber", "ExpiryDate" },
                values: new object[] { "415", "Emery Fadel", "3411-252017-24807", new DateTime(2029, 6, 10, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 557m, new DateTime(2024, 5, 23, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 393m, new DateTime(2024, 5, 28, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 212m, new DateTime(2024, 6, 7, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 194m, new DateTime(2024, 5, 23, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 923m, new DateTime(2024, 5, 28, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 48m, new DateTime(2024, 6, 6, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 430m, new DateTime(2024, 5, 25, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 794m, new DateTime(2024, 6, 5, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 839m, new DateTime(2024, 5, 14, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 529m, new DateTime(2024, 5, 20, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 772m, new DateTime(2024, 5, 19, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 632m, new DateTime(2024, 5, 24, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 302m, new DateTime(2024, 6, 1, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 617m, new DateTime(2024, 5, 12, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 564m, new DateTime(2024, 5, 16, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 991m, new DateTime(2024, 6, 3, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 873m, new DateTime(2024, 5, 16, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Amount", "PaymentDate" },
                values: new object[] { 695m, new DateTime(2024, 6, 3, 23, 23, 10, 535, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CategoryName",
                value: "Outdoors");

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
                value: "Garden");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CategoryName",
                value: "Industrial");

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
                value: "Movies");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CategoryName",
                value: "Outdoors");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CategoryName",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CategoryName",
                value: "Grocery");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CategoryName",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CategoryName",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CategoryName",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CategoryName",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CategoryName",
                value: "Clothing");

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
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CategoryName",
                value: "Clothing");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CategoryName",
                value: "Kids");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CategoryName",
                value: "Kids");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 136.67m, "Fantastic Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 627.88m, "Incredible Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 323.98m, "Tasty Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 801.12m, "Licensed Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 609.42m, "Incredible Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 9.84m, "Tasty Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 175.43m, "Licensed Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 905.16m, "Refined Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 238.90m, "Ergonomic Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 375.64m, "Practical Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 152.07m, "Unbranded Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 801.02m, "Unbranded Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 331.88m, "Refined Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 99.81m, "Incredible Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 713.27m, "Awesome Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 73.31m, "Handmade Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 782.41m, "Small Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 538.59m, "Sleek Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 383.45m, "Unbranded Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 718.88m, "Handcrafted Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 816.43m, "Rustic Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 880.45m, "Handmade Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 95.65m, "Small Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 946.34m, "Intelligent Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 263.97m, "Incredible Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 491.54m, "Generic Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 955.47m, "Intelligent Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 285.61m, "Practical Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 700.16m, "Generic Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 431.84m, "Intelligent Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 425.51m, "Refined Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 159.44m, "Unbranded Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 401.28m, "Handcrafted Metal Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 369.59m, "Tasty Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 269.60m, "Refined Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 578.95m, "Refined Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 285.91m, "Unbranded Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 538.22m, "Incredible Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 567.76m, "Handcrafted Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 418.78m, "Refined Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 269.52m, "Licensed Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 635.12m, "Intelligent Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 371.58m, "Generic Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 281.75m, "Tasty Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 271.52m, "Tasty Metal Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 124.52m, "Fantastic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 253.66m, "Refined Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 163.73m, "Licensed Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 783.18m, "Incredible Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 906.68m, "Generic Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 256.91m, "Rustic Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 865.76m, "Intelligent Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 542.68m, "Awesome Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 324.41m, "Unbranded Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 951.14m, "Generic Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Price", "ProductName" },
                values: new object[] { 227.93m, "Ergonomic Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 1L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 576m, 76, 270.35m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 5L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 666m, 66, 498.93m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 11L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 462m, 15, 576.93m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 1L, 15L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 571m, 62, 626.59m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 729m, 78, 115.08m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 880m, 75, 621.88m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 562m, 86, 812.15m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 2L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 866m, 79, 382.56m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 836m, 89, 339.67m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 698m, 18, 71.09m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 231m, 44, 932.55m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 3L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 811m, 97, 847.14m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 2L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 171m, 35, 793.07m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 928m, 92, 612.97m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 10L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 482m, 45, 937.13m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 4L, 12L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 412m, 61, 189.36m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 3L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 413m, 60, 275.39m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 4L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 519m, 70, 642.83m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 13L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 156m, 87, 998.02m });

            migrationBuilder.UpdateData(
                table: "ReceiptDetails",
                keyColumns: new[] { "ProductId", "ReceiptId" },
                keyValues: new object[] { 5L, 14L },
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 756m, 32, 32.21m });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "inventore", new DateTime(2024, 5, 11, 23, 23, 10, 552, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Quam animi aut reprehenderit eveniet nam cupiditate ea magni.", new DateTime(2024, 3, 2, 23, 23, 10, 552, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "ut", new DateTime(2024, 5, 21, 23, 23, 10, 552, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Delectus iste ipsam consectetur eaque quia deserunt adipisci. Omnis quo commodi. Rerum tenetur ducimus excepturi laboriosam inventore sit optio sint et. Nemo totam esse iusto illum quod dolore ducimus quia. Velit dicta voluptatum. Est ratione dolorem accusantium fugiat blanditiis pariatur commodi exercitationem.", new DateTime(2024, 5, 11, 23, 23, 10, 552, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "eligendi", new DateTime(2024, 3, 2, 23, 23, 10, 552, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Reason", "RequestDate" },
                values: new object[] { "Placeat error nobis corporis incidunt ab natus totam. Soluta quas ut similique cumque dolores odio. Soluta ipsam odio cum non vero accusantium. Nesciunt porro incidunt culpa provident ea placeat.", new DateTime(2024, 5, 21, 23, 23, 10, 552, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 26, 23, 23, 10, 556, DateTimeKind.Local).AddTicks(2287), "Est illo sed ea eveniet officia molestias omnis in quasi.\nNumquam minus earum aut aliquid aut soluta dolorem suscipit.\nDolor ut voluptatem dolore facere veritatis occaecati alias dolor assumenda.\nEst in vel quia culpa sit omnis.\nDolorum vitae repellat dicta labore repellendus dolorem.\nSint sint quia debitis repudiandae architecto laborum nam in." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 17, 23, 23, 10, 556, DateTimeKind.Local).AddTicks(2724), "Culpa quam nobis et et consectetur. Libero dolores ut sunt est nulla odio id. Quia ut accusamus officiis odit. Dolores voluptas qui quia cupiditate aut vel." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 18, 23, 23, 10, 556, DateTimeKind.Local).AddTicks(2914), "Animi odio molestias.\nHarum quibusdam non aspernatur." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 23, 10, 556, DateTimeKind.Local).AddTicks(2959), "Non quis nihil vel alias.\nVelit aperiam sunt dolores quisquam." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 7, 23, 23, 10, 556, DateTimeKind.Local).AddTicks(3014), "Ex ut vel non." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 6, 23, 23, 10, 556, DateTimeKind.Local).AddTicks(3038), "Excepturi dolorem error corrupti." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 26, 23, 23, 10, 556, DateTimeKind.Local).AddTicks(3075), "Nihil optio et." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 4, 17, 23, 23, 10, 556, DateTimeKind.Local).AddTicks(3154), "Ex ea enim fugiat magni.\nQuibusdam tenetur eveniet totam repudiandae corporis vitae aut.\nVoluptas placeat sunt a." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 5, 18, 23, 23, 10, 556, DateTimeKind.Local).AddTicks(3241), "a" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ReviewDate", "ReviewText" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 23, 10, 556, DateTimeKind.Local).AddTicks(3248), "ducimus" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1Dxk9vrNZ6HfG7UQYRza83EPWqXcK", new DateTime(2024, 6, 6, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(6731), "WXMUEUT1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3azVWXGBP6qfMwv4NKjeJkHcm1EbFx3", new DateTime(2024, 6, 5, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(6914), "PREODMU1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1Q7wsabY8GWu4XzVdEPL3qpoRDgyAe5", new DateTime(2024, 4, 26, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(6987), "NPWIEES1939" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "3nhr2H9MqkVi8DfRZQbAm4tSedcxg", new DateTime(2024, 4, 26, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(7047), "IXAOLYW1482" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "16uXGhLeFNqBSmAy8ivwVZTtQ3", new DateTime(2024, 6, 7, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(7180), "BHWUREE1782" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1yGciofJEFNLC6ZkbthK3HuxM1QgvwqUV", new DateTime(2024, 5, 30, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(7238), "OIAUBOH1" });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Carrier", "ShippingDate", "TrackingNumber" },
                values: new object[] { "1mHJTaKWMdCGig6qPnyVeSr1L3Nu8foD", new DateTime(2024, 4, 15, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(7293), "EGVILAI1738" });

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 4L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 5L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 6L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 23, 23, 10, 559, DateTimeKind.Local).AddTicks(7933));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a9cf213-628a-44d7-87e0-eb718ab2178a", "AQAAAAIAAYagAAAAEIXLjVkK9Ll1DcAKNzIEM5TAU6hBXWplAITXs6lHeUCyECOeQf9yRB6fAO3J+KcYIQ==", "b0dac53e-1440-4f89-8af1-fa8a93bd728a" });

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
                column: "NotificationDate",
                value: new DateTime(2024, 6, 2, 16, 35, 20, 155, DateTimeKind.Local).AddTicks(9174));

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
                columns: new[] { "DiscountUnitPrice", "Quantity", "UnitPrice" },
                values: new object[] { 707m, 12, 483.87m });

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

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 4L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 5L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 6L,
                column: "DateOfLastModification",
                value: new DateTime(2024, 6, 10, 22, 35, 20, 169, DateTimeKind.Local).AddTicks(360));
        }
    }
}
