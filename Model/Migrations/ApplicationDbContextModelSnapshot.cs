﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model;

namespace Model.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.ExpenseHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApproverId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ExpenseDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RequesterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApproverId");

                    b.HasIndex("RequesterId");

                    b.ToTable("ExpenseHeaders");
                });

            modelBuilder.Entity("Model.ExpenseLine", b =>
                {
                    b.Property<int>("ExpenseLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpenseHeaderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalCost")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("decimal(16,2)")
                        .HasComputedColumnSql("[Quantity] * [UnitCost]");

                    b.Property<decimal>("UnitCost")
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("ExpenseLineId");

                    b.HasIndex("ExpenseHeaderId");

                    b.ToTable("ExpenseLines");
                });

            modelBuilder.Entity("Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Model.ExpenseHeader", b =>
                {
                    b.HasOne("Model.User", "Approver")
                        .WithMany("ApproverExpenseHeaders")
                        .HasForeignKey("ApproverId");

                    b.HasOne("Model.User", "Requester")
                        .WithMany("RequesterExpenseHeaders")
                        .HasForeignKey("RequesterId");

                    b.Navigation("Approver");

                    b.Navigation("Requester");
                });

            modelBuilder.Entity("Model.ExpenseLine", b =>
                {
                    b.HasOne("Model.ExpenseHeader", "ExpenseHeader")
                        .WithMany("ExpenseLines")
                        .HasForeignKey("ExpenseHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpenseHeader");
                });

            modelBuilder.Entity("Model.ExpenseHeader", b =>
                {
                    b.Navigation("ExpenseLines");
                });

            modelBuilder.Entity("Model.User", b =>
                {
                    b.Navigation("ApproverExpenseHeaders");

                    b.Navigation("RequesterExpenseHeaders");
                });
#pragma warning restore 612, 618
        }
    }
}
