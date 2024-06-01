using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GA.TradeMarket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class fghg3j : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343427734435", new DateTime(2025, 3, 7, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343417134435", new DateTime(2025, 8, 16, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE34342734435", new DateTime(2025, 1, 3, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE34344234435", new DateTime(2025, 2, 25, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343419334435", new DateTime(2024, 8, 15, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343452134435", new DateTime(2025, 7, 7, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343419034435", new DateTime(2025, 4, 20, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343410934435", new DateTime(2024, 10, 13, 1, 50, 17, 99, DateTimeKind.Local).AddTicks(5890) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343451634435", new DateTime(2024, 7, 24, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343424934435", new DateTime(2025, 7, 19, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343410734435", new DateTime(2025, 2, 8, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343412934435", new DateTime(2024, 8, 10, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343446534435", new DateTime(2025, 9, 23, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343448234435", new DateTime(2025, 10, 7, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343452734435", new DateTime(2025, 3, 21, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Code", "ExpiryDate" },
                values: new object[] { "GE343439934435", new DateTime(2025, 2, 15, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "Buy", "Currency", "LogTime", "Sell" },
                values: new object[,]
                {
                    { 1L, 2.7m, "USD", new DateTime(2024, 6, 2, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(1854), 2.8m },
                    { 2L, 2.9m, "EUR", new DateTime(2024, 6, 2, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(1870), 2.85m },
                    { 3L, 2.65m, "GBP", new DateTime(2024, 6, 2, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(1871), 2.85m }
                });
        }
    }
}
