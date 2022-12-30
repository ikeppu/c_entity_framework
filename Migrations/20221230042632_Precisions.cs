using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace c_sharp_entity_framework.Migrations
{
    public partial class Precisions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payments",
                type: "numeric(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "Last4Digits", "PaymentDate", "PaymentType" },
                values: new object[,]
                {
                    { 5, 456.76m, "1234", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, 1233.56m, "4567", new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "EmailAddress", "PaymentDate", "PaymentType" },
                values: new object[,]
                {
                    { 7, 456m, "sofija@sof.com", new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, 123m, "andrew@sof.com", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payments",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "Last4Digits", "PaymentDate", "PaymentType" },
                values: new object[,]
                {
                    { 3, 456.76m, "1234", new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 1233.56m, "4567", new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "EmailAddress", "PaymentDate", "PaymentType" },
                values: new object[,]
                {
                    { 1, 456m, "sofija@sof.com", new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 123m, "andrew@sof.com", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }
    }
}
