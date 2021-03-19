﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Cust__omer.Migrations
{
    [DbContext(typeof(CustomerContext))]
    partial class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Cust__omer.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Cust__omer.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("PhysicalAddress")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Cust__omer.Models.Receipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("AmountDue")
                        .HasColumnType("integer");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<string>("DateOfIssue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Receipt");
                });

            modelBuilder.Entity("Cust__omer.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Cust__omer.Models.Customer", b =>
                {
                    b.HasOne("Cust__omer.Models.Company", "Company")
                        .WithMany("Customers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Cust__omer.Models.Receipt", b =>
                {
                    b.HasOne("Cust__omer.Models.Customer", "Customer")
                        .WithMany("Receipts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Cust__omer.Models.Company", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Cust__omer.Models.Customer", b =>
                {
                    b.Navigation("Receipts");
                });
#pragma warning restore 612, 618
        }
    }
}