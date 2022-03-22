using Microsoft.EntityFrameworkCore.Migrations;

namespace adduo.elephant.repositories.Migrations
{
    public partial class change_bundler_monthly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_debts_templates_bundlers_monthlies_BundlerMo~",
                table: "debts_templates");

            migrationBuilder.RenameColumn(
                name: "BundlerMonthlyTemplateId",
                table: "debts_templates",
                newName: "BundlerTemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_debts_templates_BundlerMonthlyTemplateId",
                table: "debts_templates",
                newName: "IX_debts_templates_BundlerTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_debts_templates_debts_templates_bundlers_monthlies_BundlerTe~",
                table: "debts_templates",
                column: "BundlerTemplateId",
                principalTable: "debts_templates_bundlers_monthlies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_debts_templates_bundlers_monthlies_BundlerTe~",
                table: "debts_templates");

            migrationBuilder.RenameColumn(
                name: "BundlerTemplateId",
                table: "debts_templates",
                newName: "BundlerMonthlyTemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_debts_templates_BundlerTemplateId",
                table: "debts_templates",
                newName: "IX_debts_templates_BundlerMonthlyTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_debts_templates_debts_templates_bundlers_monthlies_BundlerMo~",
                table: "debts_templates",
                column: "BundlerMonthlyTemplateId",
                principalTable: "debts_templates_bundlers_monthlies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
