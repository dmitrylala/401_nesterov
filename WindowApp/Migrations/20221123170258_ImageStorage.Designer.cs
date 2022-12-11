﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WindowApp;

#nullable disable

namespace WindowApp.Migrations
{
    [DbContext(typeof(ImagesContext))]
    [Migration("20221123170258_ImageStorage")]
    partial class ImageStorage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("WindowApp.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DetailsId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Embedding")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DetailsId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("WindowApp.ImageDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("WindowApp.Image", b =>
                {
                    b.HasOne("WindowApp.ImageDetails", "Details")
                        .WithMany()
                        .HasForeignKey("DetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}