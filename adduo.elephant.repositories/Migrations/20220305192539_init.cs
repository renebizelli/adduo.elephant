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
                name: "spreadsheets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spreadsheets", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<sbyte>(type: "tinyint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debts_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DueDay = table.Column<int>(type: "int", nullable: false),
                    InComeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_items_debts_Id",
                        column: x => x.Id,
                        principalTable: "debts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_debt_items_incomes_InComeId",
                        column: x => x.InComeId,
                        principalTable: "incomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_amount_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Amount = table.Column<decimal>(type: "Decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_amount_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_amount_items_debt_items_Id",
                        column: x => x.Id,
                        principalTable: "debt_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_monthly_bundlers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_monthly_bundlers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_monthly_bundlers_debt_items_Id",
                        column: x => x.Id,
                        principalTable: "debt_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "spreadsheet_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CurrentValue = table.Column<double>(type: "double", nullable: false),
                    PayedValue = table.Column<double>(type: "double", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SpreadSheetId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ItemId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spreadsheet_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_spreadsheet_items_debt_items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "debt_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_spreadsheet_items_spreadsheets_SpreadSheetId",
                        column: x => x.SpreadSheetId,
                        principalTable: "spreadsheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_installment_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StartMonth = table.Column<int>(type: "int", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    Installments = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_installment_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_installment_items_debt_amount_items_Id",
                        column: x => x.Id,
                        principalTable: "debt_amount_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_monthly_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_monthly_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_monthly_items_debt_amount_items_Id",
                        column: x => x.Id,
                        principalTable: "debt_amount_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_pontual_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_pontual_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_pontual_items_debt_amount_items_Id",
                        column: x => x.Id,
                        principalTable: "debt_amount_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_yearly_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DueMonth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_yearly_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_yearly_items_debt_amount_items_Id",
                        column: x => x.Id,
                        principalTable: "debt_amount_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_bundler_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BundlerMonthlyId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_bundler_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_bundler_items_debt_monthly_bundlers_BundlerMonthlyId",
                        column: x => x.BundlerMonthlyId,
                        principalTable: "debt_monthly_bundlers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_debt_bundler_items_debts_Id",
                        column: x => x.Id,
                        principalTable: "debts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_bundler_amount_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Amount = table.Column<decimal>(type: "Decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_bundler_amount_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_bundler_amount_items_debt_bundler_items_Id",
                        column: x => x.Id,
                        principalTable: "debt_bundler_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_bundler_recurrent_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_bundler_recurrent_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_bundler_recurrent_items_debt_bundler_items_Id",
                        column: x => x.Id,
                        principalTable: "debt_bundler_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_bundler_installment_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StartMonth = table.Column<int>(type: "int", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    Installments = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_bundler_installment_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_bundler_installment_items_debt_bundler_amount_items_Id",
                        column: x => x.Id,
                        principalTable: "debt_bundler_amount_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_bundler_monthly_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_bundler_monthly_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_bundler_monthly_items_debt_bundler_amount_items_Id",
                        column: x => x.Id,
                        principalTable: "debt_bundler_amount_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_bundler_pontual_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_bundler_pontual_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_bundler_pontual_items_debt_bundler_amount_items_Id",
                        column: x => x.Id,
                        principalTable: "debt_bundler_amount_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_bundler_yearly_items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DueMonth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_bundler_yearly_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_bundler_yearly_items_debt_bundler_amount_items_Id",
                        column: x => x.Id,
                        principalTable: "debt_bundler_amount_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "debt_bundler_recurrent_values",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Description = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    RecurrentId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_debt_bundler_recurrent_values", x => x.Id);
                    table.ForeignKey(
                        name: "FK_debt_bundler_recurrent_values_debt_bundler_recurrent_items_R~",
                        column: x => x.RecurrentId,
                        principalTable: "debt_bundler_recurrent_items",
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
                name: "IX_debt_bundler_items_BundlerMonthlyId",
                table: "debt_bundler_items",
                column: "BundlerMonthlyId");

            migrationBuilder.CreateIndex(
                name: "IX_debt_bundler_recurrent_values_RecurrentId",
                table: "debt_bundler_recurrent_values",
                column: "RecurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_debt_items_InComeId",
                table: "debt_items",
                column: "InComeId");

            migrationBuilder.CreateIndex(
                name: "IX_debts_CategoryId",
                table: "debts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_spreadsheet_items_ItemId",
                table: "spreadsheet_items",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_spreadsheet_items_SpreadSheetId",
                table: "spreadsheet_items",
                column: "SpreadSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_spreadsheets_Year_Month",
                table: "spreadsheets",
                columns: new[] { "Year", "Month" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "debt_bundler_installment_items");

            migrationBuilder.DropTable(
                name: "debt_bundler_monthly_items");

            migrationBuilder.DropTable(
                name: "debt_bundler_pontual_items");

            migrationBuilder.DropTable(
                name: "debt_bundler_recurrent_values");

            migrationBuilder.DropTable(
                name: "debt_bundler_yearly_items");

            migrationBuilder.DropTable(
                name: "debt_installment_items");

            migrationBuilder.DropTable(
                name: "debt_monthly_items");

            migrationBuilder.DropTable(
                name: "debt_pontual_items");

            migrationBuilder.DropTable(
                name: "debt_yearly_items");

            migrationBuilder.DropTable(
                name: "spreadsheet_items");

            migrationBuilder.DropTable(
                name: "debt_bundler_recurrent_items");

            migrationBuilder.DropTable(
                name: "debt_bundler_amount_items");

            migrationBuilder.DropTable(
                name: "debt_amount_items");

            migrationBuilder.DropTable(
                name: "spreadsheets");

            migrationBuilder.DropTable(
                name: "debt_bundler_items");

            migrationBuilder.DropTable(
                name: "debt_monthly_bundlers");

            migrationBuilder.DropTable(
                name: "debt_items");

            migrationBuilder.DropTable(
                name: "debts");

            migrationBuilder.DropTable(
                name: "incomes");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
