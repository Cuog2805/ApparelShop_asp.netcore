﻿// <auto-generated />
using System;
using ApparelShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApparelShop.Migrations
{
    [DbContext(typeof(ApparelDBContext))]
    partial class ApparelDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApparelShop.Models.Properties.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressID"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.HasKey("AddressID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminID"), 1L, 1);

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.AdminCustomer", b =>
                {
                    b.Property<int>("AdminID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ActionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("AdminID", "CustomerID");

                    b.HasIndex("CustomerID");

                    b.ToTable("AdminCustomers");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.AdminProduct", b =>
                {
                    b.Property<int>("AdminID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ActionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("AdminID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("AdminProducts");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"), 1L, 1);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("CartID");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.CartItem", b =>
                {
                    b.Property<int>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemID"), 1L, 1);

                    b.Property<int?>("CartID")
                        .HasColumnType("int");

                    b.Property<int?>("HistoryID")
                        .HasColumnType("int");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("CartItemID");

                    b.HasIndex("CartID");

                    b.HasIndex("HistoryID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserOjectID")
                        .HasColumnType("int");

                    b.HasKey("CategoryID");

                    b.HasIndex("UserOjectID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.CategoryItem", b =>
                {
                    b.Property<int>("CategoryItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryItemID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryItemID");

                    b.HasIndex("CategoryID");

                    b.ToTable("CategoryItems");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Color", b =>
                {
                    b.Property<int>("ColorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorID"), 1L, 1);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"), 1L, 1);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Discount", b =>
                {
                    b.Property<int>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiscountID"), 1L, 1);

                    b.Property<DateTime?>("Expiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("DiscountID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.History", b =>
                {
                    b.Property<int>("HistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoryID"), 1L, 1);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("HistoryID");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("History");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"), 1L, 1);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Orderdate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<float?>("PriceDecreased")
                        .HasColumnType("real");

                    b.Property<DateTime?>("Published")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.ProductImage", b =>
                {
                    b.Property<int>("ProductImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductImageID"), 1L, 1);

                    b.Property<bool>("IsAvatar")
                        .HasColumnType("bit");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductImageID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Review", b =>
                {
                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Size", b =>
                {
                    b.Property<int>("SizeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SizeID"), 1L, 1);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeID");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Type", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserObjectID")
                        .HasColumnType("int");

                    b.HasKey("TypeID");

                    b.HasIndex("UserObjectID");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.UserObject", b =>
                {
                    b.Property<int>("UserOjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserOjectID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserOjectID");

                    b.ToTable("UserObjects");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Wishlist", b =>
                {
                    b.Property<int>("WishlistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WishlistID"), 1L, 1);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WishlistID");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("CustomerDiscount", b =>
                {
                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("DiscountID")
                        .HasColumnType("int");

                    b.HasKey("CustomerID", "DiscountID");

                    b.HasIndex("DiscountID");

                    b.ToTable("CustomerDiscount");
                });

            modelBuilder.Entity("ProductColor", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("ColorID")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "ColorID");

                    b.HasIndex("ColorID");

                    b.ToTable("ProductColor");
                });

            modelBuilder.Entity("ProductSize", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryItemID")
                        .HasColumnType("int");

                    b.Property<int>("SizeID")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "CategoryItemID");

                    b.HasIndex("CategoryItemID");

                    b.HasIndex("SizeID");

                    b.ToTable("ProductSize");
                });

            modelBuilder.Entity("ProductType", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "TypeID");

                    b.HasIndex("TypeID");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("ProductWishlist", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("WishlistID")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "WishlistID");

                    b.HasIndex("WishlistID");

                    b.ToTable("ProductWishlist");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Address", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Customer", "Customer")
                        .WithMany("AddressList")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.AdminCustomer", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Admin", "Admins")
                        .WithMany("AdminCustomers")
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApparelShop.Models.Properties.Customer", "Customers")
                        .WithMany("AdminCustomers")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admins");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.AdminProduct", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Admin", "Admins")
                        .WithMany("AdminProducts")
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApparelShop.Models.Properties.Product", "Products")
                        .WithMany("AdminProducts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admins");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Cart", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Customer", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("ApparelShop.Models.Properties.Cart", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.CartItem", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID");

                    b.HasOne("ApparelShop.Models.Properties.History", "History")
                        .WithMany("CartItems")
                        .HasForeignKey("HistoryID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ApparelShop.Models.Properties.Order", "Order")
                        .WithMany("CartItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ApparelShop.Models.Properties.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("History");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Category", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.UserObject", "UserObject")
                        .WithMany("Categories")
                        .HasForeignKey("UserOjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserObject");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.CategoryItem", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Category", "Category")
                        .WithMany("CategorieItems")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.History", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Customer", "Customer")
                        .WithOne("History")
                        .HasForeignKey("ApparelShop.Models.Properties.History", "CustomerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Order", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.ProductImage", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Review", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Customer", "Customers")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApparelShop.Models.Properties.Product", "Products")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Type", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.UserObject", "UserObject")
                        .WithMany("Types")
                        .HasForeignKey("UserObjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserObject");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Wishlist", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Customer", "Customer")
                        .WithOne("Wishlist")
                        .HasForeignKey("ApparelShop.Models.Properties.Wishlist", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CustomerDiscount", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApparelShop.Models.Properties.Discount", null)
                        .WithMany()
                        .HasForeignKey("DiscountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductColor", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Color", null)
                        .WithMany()
                        .HasForeignKey("ColorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApparelShop.Models.Properties.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductSize", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.CategoryItem", null)
                        .WithMany()
                        .HasForeignKey("CategoryItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApparelShop.Models.Properties.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApparelShop.Models.Properties.Size", null)
                        .WithMany()
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductType", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApparelShop.Models.Properties.Type", null)
                        .WithMany()
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductWishlist", b =>
                {
                    b.HasOne("ApparelShop.Models.Properties.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApparelShop.Models.Properties.Wishlist", null)
                        .WithMany()
                        .HasForeignKey("WishlistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Admin", b =>
                {
                    b.Navigation("AdminCustomers");

                    b.Navigation("AdminProducts");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Category", b =>
                {
                    b.Navigation("CategorieItems");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Customer", b =>
                {
                    b.Navigation("AddressList");

                    b.Navigation("AdminCustomers");

                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("History")
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Reviews");

                    b.Navigation("Wishlist")
                        .IsRequired();
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.History", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Order", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.Product", b =>
                {
                    b.Navigation("AdminProducts");

                    b.Navigation("CartItems");

                    b.Navigation("ProductImages");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("ApparelShop.Models.Properties.UserObject", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Types");
                });
#pragma warning restore 612, 618
        }
    }
}
