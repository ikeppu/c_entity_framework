using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace c_sharp_entity_framework.Migrations
{
    public partial class PaymentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: false),
                    PaymentType = table.Column<int>(type: "integer", nullable: false),
                    Last4Digits = table.Column<string>(type: "char(4)", nullable: true),
                    EmailAddress = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
