using Microsoft.EntityFrameworkCore.Migrations;

namespace adduo.elephant.repositories.Migrations
{
    public partial class spreadsheet_item_decimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentValue",
                table: "spreadsheet_items");

            migrationBuilder.DropColumn(
                name: "PayedValue",
                table: "spreadsheet_items");

            migrationBuilder.AddColumn<decimal>(
                name: "CurrentAmount",
                table: "spreadsheet_items",
                type: "Decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PayedAmount",
                table: "spreadsheet_items",
                type: "Decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentAmount",
                table: "spreadsheet_items");

            migrationBuilder.DropColumn(
                name: "PayedAmount",
                table: "spreadsheet_items");

            migrationBuilder.AddColumn<double>(
                name: "CurrentValue",
                table: "spreadsheet_items",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PayedValue",
                table: "spreadsheet_items",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
