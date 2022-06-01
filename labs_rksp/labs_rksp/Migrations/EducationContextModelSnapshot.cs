﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace labs_rksp.Migrations
{
    [DbContext(typeof(EducationContext))]
    partial class EducationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AddressOrder", b =>
                {
                    b.Property<int>("AddressesId")
                        .HasColumnType("integer")
                        .HasColumnName("addresses_id");

                    b.Property<int>("OrdersId")
                        .HasColumnType("integer")
                        .HasColumnName("orders_id");

                    b.HasKey("AddressesId", "OrdersId")
                        .HasName("pk_address_order");

                    b.HasIndex("OrdersId")
                        .HasDatabaseName("ix_address_order_orders_id");

                    b.ToTable("address_order", (string)null);
                });

            modelBuilder.Entity("labs_rksp.Data.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<int>("HomeNumber")
                        .HasColumnType("integer")
                        .HasColumnName("home_number");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("street");

                    b.HasKey("Id")
                        .HasName("pk_addresses");

                    b.ToTable("addresses", (string)null);
                });

            modelBuilder.Entity("labs_rksp.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasColumnOrder(1);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer")
                        .HasColumnName("amount");

                    b.Property<int>("Cost")
                        .HasColumnType("integer")
                        .HasColumnName("cost");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("date");

                    b.HasKey("Id")
                        .HasName("pk_orders");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("labs_rksp.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasColumnOrder(1);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("material");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Price")
                        .HasColumnType("integer")
                        .HasColumnName("price");

                    b.HasKey("Id")
                        .HasName("pk_products");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("labs_rksp.Data.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasColumnOrder(1);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Cost")
                        .HasColumnType("integer")
                        .HasColumnName("cost");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_services");

                    b.ToTable("services", (string)null);
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("integer")
                        .HasColumnName("orders_id");

                    b.Property<int>("ProductsId")
                        .HasColumnType("integer")
                        .HasColumnName("products_id");

                    b.HasKey("OrdersId", "ProductsId")
                        .HasName("pk_order_product");

                    b.HasIndex("ProductsId")
                        .HasDatabaseName("ix_order_product_products_id");

                    b.ToTable("order_product", (string)null);
                });

            modelBuilder.Entity("OrderService", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("integer")
                        .HasColumnName("orders_id");

                    b.Property<int>("ServicesId")
                        .HasColumnType("integer")
                        .HasColumnName("services_id");

                    b.HasKey("OrdersId", "ServicesId")
                        .HasName("pk_order_service");

                    b.HasIndex("ServicesId")
                        .HasDatabaseName("ix_order_service_services_id");

                    b.ToTable("order_service", (string)null);
                });

            modelBuilder.Entity("AddressOrder", b =>
                {
                    b.HasOne("labs_rksp.Data.Models.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_address_order_addresses_addresses_id");

                    b.HasOne("labs_rksp.Data.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_address_order_orders_orders_id");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("labs_rksp.Data.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_product_orders_orders_id");

                    b.HasOne("labs_rksp.Data.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_product_products_products_id");
                });

            modelBuilder.Entity("OrderService", b =>
                {
                    b.HasOne("labs_rksp.Data.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_service_orders_orders_id");

                    b.HasOne("labs_rksp.Data.Models.Service", null)
                        .WithMany()
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_service_services_services_id");
                });
#pragma warning restore 612, 618
        }
    }
}
