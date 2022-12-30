using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace c_sharp_entity_framework.Migrations
{
    public partial class ProductsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merchandising",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Available = table.Column<bool>(type: "boolean", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    Volume = table.Column<double>(type: "double precision", nullable: false),
                    IsClothing = table.Column<bool>(type: "boolean", nullable: false),
                    IsCollectionable = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchandising", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Merchandising_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentableMovies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentableMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentableMovies_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 2, "One piece T-Shirt", 11m },
                    { 1, "Spider-Man", 5.99m }
                });

            migrationBuilder.InsertData(
                table: "Merchandising",
                columns: new[] { "Id", "Available", "IsClothing", "IsCollectionable", "Volume", "Weight" },
                values: new object[] { 2, true, true, false, 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "RentableMovies",
                columns: new[] { "Id", "MovieId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Merchandising");

            migrationBuilder.DropTable(
                name: "RentableMovies");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
