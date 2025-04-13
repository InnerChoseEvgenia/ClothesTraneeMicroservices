using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clothes.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class addProductAndSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Quisque vel lacus ac mangna. <br/> Vestr", "https://placehold.co/603x403", 15.0, "Samosa" },
                    { 2, "Appetizer", "Quisque vel lacus ac mangna. <br/> Vestr", "https://placehold.co/603x403", 13.99, "Paneer Tikka" },
                    { 3, "Dessert", "Quisque vel lacus ac mangna. <br/> Vestr", "https://placehold.co/603x403", 10.0, "Sweet Pie" },
                    { 4, "Dessert", "Quisque vel lacus ac mangna. <br/> Vestr", "https://placehold.co/603x403", 25.0, "Clothes" },
                    { 5, "Entree", "Quisque vel lacus ac mangna. <br/> Vestr", "https://placehold.co/603x403", 15.99, "Pav Bhaji" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
