using Microsoft.EntityFrameworkCore.Migrations;

namespace adduo.elephant.repositories.Migrations
{
    public partial class add_periods_on_installments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FinishPeriod",
                table: "debt_installment_items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartPeriod",
                table: "debt_installment_items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FinishPeriod",
                table: "debt_bundler_installment_items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartPeriod",
                table: "debt_bundler_installment_items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinishPeriod",
                table: "debt_installment_items");

            migrationBuilder.DropColumn(
                name: "StartPeriod",
                table: "debt_installment_items");

            migrationBuilder.DropColumn(
                name: "FinishPeriod",
                table: "debt_bundler_installment_items");

            migrationBuilder.DropColumn(
                name: "StartPeriod",
                table: "debt_bundler_installment_items");
        }
    }
}
