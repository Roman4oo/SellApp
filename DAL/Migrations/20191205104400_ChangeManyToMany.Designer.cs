﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SellerApp;

namespace SellerApp.Migrations
{
    [DbContext(typeof(SellAppContext))]
    [Migration("20191205104400_ChangeManyToMany")]
    partial class ChangeManyToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SellerApp.Product", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ProductID");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<double?>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SellerApp.ProductTransaction", b =>
                {
                    b.Property<int?>("ProductId");

                    b.Property<int?>("TransactionId");

                    b.Property<int>("Id");

                    b.HasKey("ProductId", "TransactionId");

                    b.HasIndex("TransactionId");

                    b.ToTable("ProductsTransactions");
                });

            modelBuilder.Entity("SellerApp.Role", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("RoleID");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SellerApp.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("TransactionID");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnName("UserID");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("SellerApp.User", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("UserID");

                    b.Property<string>("Email")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int?>("RoleId")
                        .HasColumnName("RoleID");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SellerApp.ProductTransaction", b =>
                {
                    b.HasOne("SellerApp.Product", "Product")
                        .WithMany("ProductsTransactions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SellerApp.Transaction", "Transaction")
                        .WithMany("ProductsTransactions")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SellerApp.Transaction", b =>
                {
                    b.HasOne("SellerApp.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Transactions_Users");
                });

            modelBuilder.Entity("SellerApp.User", b =>
                {
                    b.HasOne("SellerApp.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_Users_Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
