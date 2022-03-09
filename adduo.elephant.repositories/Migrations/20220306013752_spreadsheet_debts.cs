using Microsoft.EntityFrameworkCore.Migrations;

namespace adduo.elephant.repositories.Migrations
{
    public partial class spreadsheet_debts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_spreadsheet_items_debt_items_ItemId",
                table: "spreadsheet_items");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "spreadsheet_items",
                newName: "DebtId");

            migrationBuilder.RenameIndex(
                name: "IX_spreadsheet_items_ItemId",
                table: "spreadsheet_items",
                newName: "IX_spreadsheet_items_DebtId");

            migrationBuilder.AddForeignKey(
                name: "FK_spreadsheet_items_debts_DebtId",
                table: "spreadsheet_items",
                column: "DebtId",
                principalTable: "debts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_spreadsheet_items_debts_DebtId",
                table: "spreadsheet_items");

            migrationBuilder.RenameColumn(
                name: "DebtId",
                table: "spreadsheet_items",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_spreadsheet_items_DebtId",
                table: "spreadsheet_items",
                newName: "IX_spreadsheet_items_ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_spreadsheet_items_debt_items_ItemId",
                table: "spreadsheet_items",
                column: "ItemId",
                principalTable: "debt_items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
