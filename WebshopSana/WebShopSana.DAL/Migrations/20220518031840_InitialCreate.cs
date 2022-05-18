using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopSana.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CUSTOMERS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LASTNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHONE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMERS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRICE = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ORDERS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ORDERS_CUSTOMERS_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CUSTOMERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTCATEGORIES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTCATEGORIES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PRODUCTCATEGORIES_CATEGORIES_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "CATEGORIES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCTCATEGORIES_PRODUCTS_ProductID",
                        column: x => x.ProductID,
                        principalTable: "PRODUCTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORDERDETAILS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERDETAILS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ORDERDETAILS_ORDERS_OrderID",
                        column: x => x.OrderID,
                        principalTable: "ORDERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDERDETAILS_PRODUCTS_ProductID",
                        column: x => x.ProductID,
                        principalTable: "PRODUCTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ORDERDETAILS_OrderID",
                table: "ORDERDETAILS",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERDETAILS_ProductID",
                table: "ORDERDETAILS",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_CustomerId",
                table: "ORDERS",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTCATEGORIES_CategoryID",
                table: "PRODUCTCATEGORIES",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTCATEGORIES_ProductID",
                table: "PRODUCTCATEGORIES",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ORDERDETAILS");

            migrationBuilder.DropTable(
                name: "PRODUCTCATEGORIES");

            migrationBuilder.DropTable(
                name: "ORDERS");

            migrationBuilder.DropTable(
                name: "CATEGORIES");

            migrationBuilder.DropTable(
                name: "PRODUCTS");

            migrationBuilder.DropTable(
                name: "CUSTOMERS");
        }
    }
}
