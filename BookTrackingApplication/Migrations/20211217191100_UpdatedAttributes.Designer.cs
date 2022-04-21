﻿// <auto-generated />
using BookTrackingApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookTrackingApplication.Migrations
{
    [DbContext(typeof(BookTrackingApplicationContext))]
    [Migration("20211217191100_UpdatedAttributes")]
    partial class UpdatedAttributes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("BookTrackingApplication.Models.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ISBN");

                    b.HasIndex("Category");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookTrackingApplication.Models.Category", b =>
                {
                    b.Property<string>("NameToken")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("NameToken");

                    b.HasIndex("Type");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BookTrackingApplication.Models.CategoryType", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Type");

                    b.ToTable("CategoryTypes");
                });

            modelBuilder.Entity("BookTrackingApplication.Models.Book", b =>
                {
                    b.HasOne("BookTrackingApplication.Models.Category", "Categories")
                        .WithMany("Books")
                        .HasForeignKey("Category");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("BookTrackingApplication.Models.Category", b =>
                {
                    b.HasOne("BookTrackingApplication.Models.CategoryType", "CategoryTypes")
                        .WithMany("Categories")
                        .HasForeignKey("Type");

                    b.Navigation("CategoryTypes");
                });

            modelBuilder.Entity("BookTrackingApplication.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookTrackingApplication.Models.CategoryType", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}