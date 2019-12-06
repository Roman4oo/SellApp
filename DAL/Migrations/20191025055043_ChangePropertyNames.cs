using Microsoft.EntityFrameworkCore.Migrations;

namespace SellerApp.Migrations
{
    public partial class ChangePropertyNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Price = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Password = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    FirstName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    LastName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    RoleID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Roles",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transactions_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products_Transactions",
                columns: table => new
                {
                    Product_Transaction_ID = table.Column<int>(nullable: false),
                    Product_ID = table.Column<int>(nullable: true),
                    Transaction_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products_Transactions", x => x.Product_Transaction_ID);
                    table.ForeignKey(
                        name: "FK_Products_Transactions_Products",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Transactions_Transactions",
                        column: x => x.Transaction_ID,
                        principalTable: "Transactions",
                        principalColumn: "TransactionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Transactions_Product_ID",
                table: "Products_Transactions",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Transactions_Transaction_ID",
                table: "Products_Transactions",
                column: "Transaction_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserID",
                table: "Transactions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products_Transactions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
