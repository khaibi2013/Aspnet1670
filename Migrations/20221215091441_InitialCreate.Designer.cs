﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221215091441_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "A",
                            ConcurrencyStamp = "1b24e2e3-0cfc-4bc3-b51e-ff97c21a9775",
                            Name = "Administrator",
                            NormalizedName = "Administrator"
                        },
                        new
                        {
                            Id = "B",
                            ConcurrencyStamp = "b5f9174a-e03c-4355-8b5e-fda043d6f7c0",
                            Name = "Customer",
                            NormalizedName = "Customer"
                        },
                        new
                        {
                            Id = "C",
                            ConcurrencyStamp = "3195879e-7658-4d42-adca-5f9126fee5d3",
                            Name = "Storner",
                            NormalizedName = "Stornner"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fa77e090-ed10-4de6-a132-b64697c422cf",
                            Email = "admin@fpt.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "admin@fpt.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEGWcLj8IxKP93Mdjrcc8evoMFobroNdd0awWS/FbMmeiKGeVMAJI3CN/aFMdEJtw5g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f4dc48c4-4eb4-492d-8312-6bdfff248929",
                            TwoFactorEnabled = false,
                            UserName = "admin@fpt.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6abd3b17-caaf-431d-8310-a4ceee6384ea",
                            Email = "customer@fpt.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "customer@fpt.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEB8QOVy6IUoRKZfh9hxGcsm3Kx/fBR6qxRHOBVV20wkQ1+F2QtRdlDwrz0MKv8Rl/g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1ab32989-83c8-42ae-aced-ceb58570d855",
                            TwoFactorEnabled = false,
                            UserName = "customer@fpt.com"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c422e8b4-ce3c-4b58-bafd-5f7622bb3779",
                            Email = "storner@fpt.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "storner@fpt.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEFdKdBHEJhvMKzUhcyjbxu9TotwRJ5o84q6UUtf7O0fGf1HuM2uqi5XKLNTW49qR0w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c9c1a41d-a88a-4611-af20-4b32014b8d1a",
                            TwoFactorEnabled = false,
                            UserName = "storner@fpt.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "A"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "B"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "C"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebApplication1.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("WebApplication1.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BestSaler")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datee")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Smith",
                            BestSaler = false,
                            CategoryId = 1,
                            Datee = new DateTime(2022, 12, 15, 16, 14, 41, 369, DateTimeKind.Local).AddTicks(6957),
                            Image = "https://th.bing.com/th/id/R.246f8ee1936955f5f1fa148c87e338d0?rik=6nmiN8y2BcarAQ&riu=http%3a%2f%2fwww.kroobannok.com%2fnews_pic%2fp37928861815.jpg&ehk=Hz7fNzyb41xHC%2fnEZkqMtkAX2OUAdzSezzeo5AympSQ%3d&risl=&pid=ImgRaw&r=0",
                            Name = "Nữ Hoàng Tuyết",
                            Price = 69999.0,
                            Type = "PDF"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Thomas",
                            BestSaler = false,
                            CategoryId = 1,
                            Datee = new DateTime(2022, 12, 15, 16, 14, 41, 370, DateTimeKind.Local).AddTicks(5838),
                            Image = "https://th.bing.com/th/id/R.246f8ee1936955f5f1fa148c87e338d0?rik=6nmiN8y2BcarAQ&riu=http%3a%2f%2fwww.kroobannok.com%2fnews_pic%2fp37928861815.jpg&ehk=Hz7fNzyb41xHC%2fnEZkqMtkAX2OUAdzSezzeo5AympSQ%3d&risl=&pid=ImgRaw&r=0",
                            Name = "Hoàng Tử Gấu",
                            Price = 69999.0,
                            Type = "PDF"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Thomson",
                            BestSaler = false,
                            CategoryId = 3,
                            Datee = new DateTime(2022, 12, 15, 16, 14, 41, 370, DateTimeKind.Local).AddTicks(5882),
                            Image = "https://th.bing.com/th/id/R.246f8ee1936955f5f1fa148c87e338d0?rik=6nmiN8y2BcarAQ&riu=http%3a%2f%2fwww.kroobannok.com%2fnews_pic%2fp37928861815.jpg&ehk=Hz7fNzyb41xHC%2fnEZkqMtkAX2OUAdzSezzeo5AympSQ%3d&risl=&pid=ImgRaw&r=0",
                            Name = "Thợ Săn Bóng Đêm",
                            Price = 69999.0,
                            Type = "PDF"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Alpha",
                            BestSaler = false,
                            CategoryId = 2,
                            Datee = new DateTime(2022, 12, 15, 16, 14, 41, 370, DateTimeKind.Local).AddTicks(5884),
                            Image = "https://th.bing.com/th/id/R.246f8ee1936955f5f1fa148c87e338d0?rik=6nmiN8y2BcarAQ&riu=http%3a%2f%2fwww.kroobannok.com%2fnews_pic%2fp37928861815.jpg&ehk=Hz7fNzyb41xHC%2fnEZkqMtkAX2OUAdzSezzeo5AympSQ%3d&risl=&pid=ImgRaw&r=0",
                            Name = "Vua Sư Tử",
                            Price = 69999.0,
                            Type = "PDF"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Denta",
                            BestSaler = false,
                            CategoryId = 3,
                            Datee = new DateTime(2022, 12, 15, 16, 14, 41, 370, DateTimeKind.Local).AddTicks(5886),
                            Image = "https://th.bing.com/th/id/R.246f8ee1936955f5f1fa148c87e338d0?rik=6nmiN8y2BcarAQ&riu=http%3a%2f%2fwww.kroobannok.com%2fnews_pic%2fp37928861815.jpg&ehk=Hz7fNzyb41xHC%2fnEZkqMtkAX2OUAdzSezzeo5AympSQ%3d&risl=&pid=ImgRaw&r=0",
                            Name = "Dải Ngân Hà",
                            Price = 69999.0,
                            Type = "PDF"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Catary",
                            BestSaler = false,
                            CategoryId = 1,
                            Datee = new DateTime(2022, 12, 15, 16, 14, 41, 370, DateTimeKind.Local).AddTicks(5887),
                            Image = "https://th.bing.com/th/id/R.246f8ee1936955f5f1fa148c87e338d0?rik=6nmiN8y2BcarAQ&riu=http%3a%2f%2fwww.kroobannok.com%2fnews_pic%2fp37928861815.jpg&ehk=Hz7fNzyb41xHC%2fnEZkqMtkAX2OUAdzSezzeo5AympSQ%3d&risl=&pid=ImgRaw&r=0",
                            Name = "Huyền Thoại Võ Thuật",
                            Price = 69999.0,
                            Type = "PDF"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Trinh Thám"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Thiếu Nhi"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Khoa Học Viễn Tưởng"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("WebApplication1.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<DateTime>("Order_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Payment")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Book", b =>
                {
                    b.HasOne("WebApplication1.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Order", b =>
                {
                    b.HasOne("WebApplication1.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });
#pragma warning restore 612, 618
        }
    }
}
