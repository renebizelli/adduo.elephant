﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using adduo.elephant.repositories;

namespace adduo.elephant.repositories.Migrations
{
    [DbContext(typeof(ElephantContext))]
    [Migration("20220307032505_change_relatinship_category")]
    partial class change_relatinship_category
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("adduo.elephant.domain.entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.InCome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.ToTable("incomes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Salário"
                        },
                        new
                        {
                            Id = 2,
                            Name = "VR"
                        });
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.SpreadSheet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Year", "Month")
                        .IsUnique();

                    b.ToTable("spreadsheets");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.SpreadSheetItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("CurrentAmount")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<Guid>("DebtId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("PayedAmount")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<Guid>("SpreadSheetId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DebtId");

                    b.HasIndex("SpreadSheetId");

                    b.ToTable("spreadsheet_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.Debt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DateTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<sbyte>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("debts");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.RecurrentBundlerValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DateTime");

                    b.Property<string>("Description")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<Guid>("RecurrentId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RecurrentId");

                    b.ToTable("debt_bundler_recurrent_values");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.ItemBundler", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.Debt");

                    b.Property<Guid>("BundlerMonthlyId")
                        .HasColumnType("char(36)");

                    b.HasIndex("BundlerMonthlyId");

                    b.ToTable("debt_bundler_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.Item", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.Debt");

                    b.Property<int>("DueDay")
                        .HasColumnType("int");

                    b.Property<int>("InComeId")
                        .HasColumnType("int");

                    b.HasIndex("InComeId");

                    b.ToTable("debt_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.ItemAmountBundler", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.bundler_items.ItemBundler");

                    b.Property<decimal>("Amount")
                        .HasColumnType("Decimal(18,2)");

                    b.ToTable("debt_bundler_amount_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.RecurrentBundler", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.bundler_items.ItemBundler");

                    b.ToTable("debt_bundler_recurrent_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.BundlerMonthly", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.items.Item");

                    b.ToTable("debt_monthly_bundlers");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.ItemAmount", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.items.Item");

                    b.Property<decimal>("Amount")
                        .HasColumnType("Decimal(18,2)");

                    b.ToTable("debt_amount_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.InstallmentBundler", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.bundler_items.ItemAmountBundler");

                    b.Property<int>("Installments")
                        .HasColumnType("int");

                    b.Property<int>("StartMonth")
                        .HasColumnType("int");

                    b.Property<int>("StartYear")
                        .HasColumnType("int");

                    b.ToTable("debt_bundler_installment_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.MonthlyBundler", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.bundler_items.ItemAmountBundler");

                    b.ToTable("debt_bundler_monthly_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.PontualBundler", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.bundler_items.ItemAmountBundler");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.ToTable("debt_bundler_pontual_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.YearlyBundler", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.bundler_items.ItemAmountBundler");

                    b.Property<int>("DueMonth")
                        .HasColumnType("int");

                    b.ToTable("debt_bundler_yearly_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.Installment", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.items.ItemAmount");

                    b.Property<int>("Installments")
                        .HasColumnType("int");

                    b.Property<int>("StartMonth")
                        .HasColumnType("int");

                    b.Property<int>("StartYear")
                        .HasColumnType("int");

                    b.ToTable("debt_installment_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.Monthly", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.items.ItemAmount");

                    b.ToTable("debt_monthly_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.Pontual", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.items.ItemAmount");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.ToTable("debt_pontual_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.Yearly", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts.items.ItemAmount");

                    b.Property<int>("DueMonth")
                        .HasColumnType("int");

                    b.ToTable("debt_yearly_items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.SpreadSheetItem", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.Debt", "Debt")
                        .WithMany("SpreadSheetItems")
                        .HasForeignKey("DebtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("adduo.elephant.domain.entities.SpreadSheet", "SpreadSheet")
                        .WithMany("Items")
                        .HasForeignKey("SpreadSheetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Debt");

                    b.Navigation("SpreadSheet");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.Debt", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.RecurrentBundlerValue", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.bundler_items.RecurrentBundler", "Recurrent")
                        .WithMany("Values")
                        .HasForeignKey("RecurrentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recurrent");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.ItemBundler", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.items.BundlerMonthly", "BundlerMonthly")
                        .WithMany("Items")
                        .HasForeignKey("BundlerMonthlyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("adduo.elephant.domain.entities.debts.Debt", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.bundler_items.ItemBundler", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BundlerMonthly");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.Item", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.Debt", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.items.Item", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("adduo.elephant.domain.entities.InCome", "InCome")
                        .WithMany("ItemDebts")
                        .HasForeignKey("InComeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InCome");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.ItemAmountBundler", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.bundler_items.ItemBundler", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.bundler_items.ItemAmountBundler", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.RecurrentBundler", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.bundler_items.ItemBundler", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.bundler_items.RecurrentBundler", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.BundlerMonthly", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.items.Item", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.items.BundlerMonthly", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.ItemAmount", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.items.Item", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.items.ItemAmount", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.InstallmentBundler", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.bundler_items.ItemAmountBundler", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.bundler_items.InstallmentBundler", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.MonthlyBundler", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.bundler_items.ItemAmountBundler", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.bundler_items.MonthlyBundler", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.PontualBundler", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.bundler_items.ItemAmountBundler", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.bundler_items.PontualBundler", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.YearlyBundler", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.bundler_items.ItemAmountBundler", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.bundler_items.YearlyBundler", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.Installment", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.items.ItemAmount", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.items.Installment", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.Monthly", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.items.ItemAmount", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.items.Monthly", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.Pontual", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.items.ItemAmount", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.items.Pontual", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.Yearly", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts.items.ItemAmount", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts.items.Yearly", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.InCome", b =>
                {
                    b.Navigation("ItemDebts");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.SpreadSheet", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.Debt", b =>
                {
                    b.Navigation("SpreadSheetItems");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.bundler_items.RecurrentBundler", b =>
                {
                    b.Navigation("Values");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts.items.BundlerMonthly", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}