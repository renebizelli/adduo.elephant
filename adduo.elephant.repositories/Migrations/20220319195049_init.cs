using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace adduo.elephant.repositories.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "incomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incomes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debts_templates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Amount = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    DueDay = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<sbyte>(type: "tinyint", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    InComeId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BundlerMonthlyTemplateId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debts_templates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debts_templates_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_debts_templates_incomes_InComeId",
                        column: x => x.InComeId,
                        principalTable: "incomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debts_templates_bundlers_monthlies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debts_templates_bundlers_monthlies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debts_templates_bundlers_monthlies_debts_templates_Id",
                        column: x => x.Id,
                        principalTable: "debts_templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debts_templates_installments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StartMonth = table.Column<int>(type: "int", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    Installments = table.Column<int>(type: "int", nullable: false),
                    StartPeriod = table.Column<int>(type: "int", nullable: false),
                    FinishPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debts_templates_installments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debts_templates_installments_debts_templates_Id",
                        column: x => x.Id,
                        principalTable: "debts_templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debts_templates_monthlies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debts_templates_monthlies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debts_templates_monthlies_debts_templates_Id",
                        column: x => x.Id,
                        principalTable: "debts_templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debts_templates_pontuals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DueMonth = table.Column<int>(type: "int", nullable: false),
                    DueYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debts_templates_pontuals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debts_templates_pontuals_debts_templates_Id",
                        column: x => x.Id,
                        principalTable: "debts_templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debts_templates_recurrents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debts_templates_recurrents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debts_templates_recurrents_debts_templates_Id",
                        column: x => x.Id,
                        principalTable: "debts_templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debts_templates_yearlies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DueMonth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debts_templates_yearlies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debts_templates_yearlies_debts_templates_Id",
                        column: x => x.Id,
                        principalTable: "debts_templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "incomes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Salário" });

            migrationBuilder.InsertData(
                table: "incomes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "VR" });

            migrationBuilder.CreateIndex(
                name: "IX_debts_templates_BundlerMonthlyTemplateId",
                table: "debts_templates",
                column: "BundlerMonthlyTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_debts_templates_CategoryId",
                table: "debts_templates",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_debts_templates_InComeId",
                table: "debts_templates",
                column: "InComeId");

            migrationBuilder.AddForeignKey(
                name: "FK_debts_templates_debts_templates_bundlers_monthlies_BundlerMo~",
                table: "debts_templates",
                column: "BundlerMonthlyTemplateId",
                principalTable: "debts_templates_bundlers_monthlies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_categories_CategoryId",
                table: "debts_templates");

            migrationBuilder.DropForeignKey(
                name: "FK_debts_templates_debts_templates_bundlers_monthlies_BundlerMo~",
                table: "debts_templates");

            migrationBuilder.DropTable(
                name: "debts_templates_installments");

            migrationBuilder.DropTable(
                name: "debts_templates_monthlies");

            migrationBuilder.DropTable(
                name: "debts_templates_pontuals");

            migrationBuilder.DropTable(
                name: "debts_templates_recurrents");

            migrationBuilder.DropTable(
                name: "debts_templates_yearlies");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "debts_templates_bundlers_monthlies");

            migrationBuilder.DropTable(
                name: "debts_templates");

            migrationBuilder.DropTable(
                name: "incomes");
        }
    }
}
