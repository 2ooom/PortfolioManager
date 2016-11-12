using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PortfolioManager.Data;

namespace PortfolioManager.Migrations
{
    [DbContext(typeof(PortfolioDb))]
    [Migration("20161112215136_InitialSchema")]
    partial class InitialSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("PortfolioManager.Data.Model.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CoverImagePath")
                        .HasAnnotation("MaxLength", 300);

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 500);

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("PassCode")
                        .HasAnnotation("MaxLength", 20);

                    b.Property<bool>("Published");

                    b.HasKey("Id");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("PortfolioManager.Data.Model.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AlbumId");

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Path")
                        .HasAnnotation("MaxLength", 300);

                    b.Property<bool>("Published");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("PortfolioManager.Data.Model.Photo", b =>
                {
                    b.HasOne("PortfolioManager.Data.Model.Album", "Album")
                        .WithMany("Photos")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
