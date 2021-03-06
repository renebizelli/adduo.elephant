// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using adduo.elephant.repositories;

namespace adduo.elephant.repositories.Migrations
{
    [DbContext(typeof(ElephantContext))]
    [Migration("20220319211145_change_bundler_monthly")]
    partial class change_bundler_monthly
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

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.DebtTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<Guid?>("BundlerTemplateId")
                        .HasColumnType("char(36)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DateTime");

                    b.Property<int>("DueDay")
                        .HasColumnType("int");

                    b.Property<int?>("InComeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<sbyte>("Status")
                        .HasColumnType("tinyint");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BundlerTemplateId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("InComeId");

                    b.ToTable("debts_templates");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.BundlerMonthlyTemplate", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts_template.DebtTemplate");

                    b.ToTable("debts_templates_bundlers_monthlies");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.InstallmentTemplate", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts_template.DebtTemplate");

                    b.Property<int>("FinishPeriod")
                        .HasColumnType("int");

                    b.Property<int>("Installments")
                        .HasColumnType("int");

                    b.Property<int>("StartMonth")
                        .HasColumnType("int");

                    b.Property<int>("StartPeriod")
                        .HasColumnType("int");

                    b.Property<int>("StartYear")
                        .HasColumnType("int");

                    b.ToTable("debts_templates_installments");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.MonthlyTemplate", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts_template.DebtTemplate");

                    b.ToTable("debts_templates_monthlies");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.PontualTemplate", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts_template.DebtTemplate");

                    b.Property<int>("DueMonth")
                        .HasColumnType("int");

                    b.Property<int>("DueYear")
                        .HasColumnType("int");

                    b.ToTable("debts_templates_pontuals");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.RecurrentTemplate", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts_template.DebtTemplate");

                    b.ToTable("debts_templates_recurrents");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.YearlyTemplate", b =>
                {
                    b.HasBaseType("adduo.elephant.domain.entities.debts_template.DebtTemplate");

                    b.Property<int>("DueMonth")
                        .HasColumnType("int");

                    b.ToTable("debts_templates_yearlies");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.DebtTemplate", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts_template.BundlerMonthlyTemplate", "BundlerMonthlyTemplate")
                        .WithMany("Debts")
                        .HasForeignKey("BundlerTemplateId");

                    b.HasOne("adduo.elephant.domain.entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("adduo.elephant.domain.entities.InCome", "InCome")
                        .WithMany()
                        .HasForeignKey("InComeId");

                    b.Navigation("BundlerMonthlyTemplate");

                    b.Navigation("Category");

                    b.Navigation("InCome");
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.BundlerMonthlyTemplate", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts_template.DebtTemplate", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts_template.BundlerMonthlyTemplate", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.InstallmentTemplate", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts_template.DebtTemplate", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts_template.InstallmentTemplate", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.MonthlyTemplate", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts_template.DebtTemplate", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts_template.MonthlyTemplate", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.PontualTemplate", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts_template.DebtTemplate", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts_template.PontualTemplate", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.RecurrentTemplate", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts_template.DebtTemplate", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts_template.RecurrentTemplate", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.YearlyTemplate", b =>
                {
                    b.HasOne("adduo.elephant.domain.entities.debts_template.DebtTemplate", null)
                        .WithOne()
                        .HasForeignKey("adduo.elephant.domain.entities.debts_template.YearlyTemplate", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("adduo.elephant.domain.entities.debts_template.BundlerMonthlyTemplate", b =>
                {
                    b.Navigation("Debts");
                });
#pragma warning restore 612, 618
        }
    }
}
