using Microsoft.EntityFrameworkCore.Migrations;

namespace SellerApp.Migrations
{
    public partial class ChangeManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Transactions_Products",
                table: "Products_Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Transactions_Transactions",
                table: "Products_Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products_Transactions",
                table: "Products_Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Products_Transactions_Product_ID",
                table: "Products_Transactions");

            migrationBuilder.RenameTable(
                name: "Products_Transactions",
                newName: "ProductsTransactions");

            migrationBuilder.RenameColumn(
                name: "Transaction_ID",
                table: "ProductsTransactions",
                newName: "TransactionId");

            migrationBuilder.RenameColumn(
                name: "Product_ID",
                table: "ProductsTransactions",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Product_Transaction_ID",
                table: "ProductsTransactions",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Transactions_Transaction_ID",
                table: "ProductsTransactions",
                newName: "IX_ProductsTransactions_TransactionId");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionId",
                table: "ProductsTransactions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductsTransactions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsTransactions",
                table: "ProductsTransactions",
                columns: new[] { "ProductId", "TransactionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsTransactions_Products_ProductId",
                table: "ProductsTransactions",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsTransactions_Transactions_TransactionId",
                table: "ProductsTransactions",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsTransactions_Products_ProductId",
                table: "ProductsTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsTransactions_Transactions_TransactionId",
                table: "ProductsTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsTransactions",
                table: "ProductsTransactions");

            migrationBuilder.RenameTable(
                name: "ProductsTransactions",
                newName: "Products_Transactions");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products_Transactions",
                newName: "Product_Transaction_ID");

            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "Products_Transactions",
                newName: "Transaction_ID");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products_Transactions",
                newName: "Product_ID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsTransactions_TransactionId",
                table: "Products_Transactions",
                newName: "IX_Products_Transactions_Transaction_ID");

            migrationBuilder.AlterColumn<int>(
                name: "Transaction_ID",
                table: "Products_Transactions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Product_ID",
                table: "Products_Transactions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products_Transactions",
                table: "Products_Transactions",
                column: "Product_Transaction_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Transactions_Product_ID",
                table: "Products_Transactions",
                column: "Product_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Transactions_Products",
                table: "Products_Transactions",
                column: "Product_ID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Transactions_Transactions",
                table: "Products_Transactions",
                column: "Transaction_ID",
                principalTable: "Transactions",
                principalColumn: "TransactionID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
