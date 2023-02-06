﻿// <auto-generated />
using BlazorCRUDApp.Server.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SOMSBlazorApp.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230206065252_FKcreation")]
    partial class FKcreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SOMSBlazorApp.Shared.Element", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ElementType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Element", "dbo");
                });

            modelBuilder.Entity("SOMSBlazorApp.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("OrderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WindowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WindowId");

                    b.ToTable("Order", "dbo");
                });

            modelBuilder.Entity("SOMSBlazorApp.Shared.Window", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ElementId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityOfElement")
                        .HasColumnType("int");

                    b.Property<string>("WindowName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ElementId");

                    b.ToTable("Window", "dbo");
                });

            modelBuilder.Entity("SOMSBlazorApp.Shared.Order", b =>
                {
                    b.HasOne("SOMSBlazorApp.Shared.Window", "Window")
                        .WithMany()
                        .HasForeignKey("WindowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Window");
                });

            modelBuilder.Entity("SOMSBlazorApp.Shared.Window", b =>
                {
                    b.HasOne("SOMSBlazorApp.Shared.Element", "Element")
                        .WithMany()
                        .HasForeignKey("ElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Element");
                });
#pragma warning restore 612, 618
        }
    }
}
