using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace adduo.elephant.repositories.Migrations
{
    public partial class debt_amount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_incomes_InComeId",
                table: "debts_templates");

            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_installments_debts_templates_Id",
                table: "debts_templates_installments");

            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_monthlies_debts_templates_Id",
                table: "debts_templates_monthlies");

            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_pontuals_debts_templates_Id",
                table: "debts_templates_pontuals");

            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_yearlies_debts_templates_Id",
                table: "debts_templates_yearlies");

            migrationBuilder.DropIndex(
                name: "IX_debts_templates_InComeId",
                table: "debts_templates");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "debts_templates");

            migrationBuilder.DropColumn(
                name: "InComeId",
                table: "debts_templates");

            migrationBuilder.CreateTable(
                name: "debts_templates_amounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Amount = table.Column<decimal>(type: "Decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debts_templates_amounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debts_templates_amounts_debts_templates_Id",
                        column: x => x.Id,
                        principalTable: "debts_templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_debts_templates_installments_debts_templates_amounts_Id",
                table: "debts_templates_installments",
                column: "Id",
                principalTable: "debts_templates_amounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_debts_templates_monthlies_debts_templates_amounts_Id",
                table: "debts_templates_monthlies",
                column: "Id",
                principalTable: "debts_templates_amounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_debts_templates_pontuals_debts_templates_amounts_Id",
                table: "debts_templates_pontuals",
                column: "Id",
                principalTable: "debts_templates_amounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_debts_templates_yearlies_debts_templates_amounts_Id",
                table: "debts_templates_yearlies",
                column: "Id",
                principalTable: "debts_templates_amounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_installments_debts_templates_amounts_Id",
                table: "debts_templates_installments");

            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_monthlies_debts_templates_amounts_Id",
                table: "debts_templates_monthlies");

            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_pontuals_debts_templates_amounts_Id",
                table: "debts_templates_pontuals");

            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_yearlies_debts_templates_amounts_Id",
                table: "debts_templates_yearlies");

            migrationBuilder.DropTable(
                name: "debts_templates_amounts");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "debts_templates",
                type: "Decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "InComeId",
                table: "debts_templates",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_debts_templates_InComeId",
                table: "debts_templates",
                column: "InComeId");

            migrationBuilder.AddForeignKey(
                name: "FK_debts_templates_incomes_InComeId",
                table: "debts_templates",
                column: "InComeId",
                principalTable: "incomes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_debts_templates_installments_debts_templates_Id",
                table: "debts_templates_installments",
                column: "Id",
                principalTable: "debts_templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_debts_templates_monthlies_debts_templates_Id",
                table: "debts_templates_monthlies",
                column: "Id",
                principalTable: "debts_templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_debts_templates_pontuals_debts_templates_Id",
                table: "debts_templates_pontuals",
                column: "Id",
                principalTable: "debts_templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_debts_templates_yearlies_debts_templates_Id",
                table: "debts_templates_yearlies",
                column: "Id",
                principalTable: "debts_templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
