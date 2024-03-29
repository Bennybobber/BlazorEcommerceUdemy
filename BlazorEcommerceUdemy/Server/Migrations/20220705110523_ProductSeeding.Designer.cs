﻿// <auto-generated />
using BlazorEcommerceUdemy.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerceUdemy.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220705110523_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerceUdemy.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film. ",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Price = 9.99m,
                            Title = "The Hitchhiker's Guide to the Galaxy"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The Restaurant at the End of the Universe is the second book in the Hitchhiker's Guide to the Galaxy comedy science fiction 'trilogy of six books' by Douglas Adams, and is a sequel. It was originally published by Pan Books as a paperback in 1980. The book was inspired by the song 'Grand Hotel' by British rock band Procol Harum.[1] The book title refers to Milliways, the Restaurant at the End of the Universe, one of the settings of the book. ",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/98/RestaurantAtTheEndOfTheUniverse.jpg",
                            Price = 5.99m,
                            Title = "The Restaurant at the End of the Universe"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Life, the Universe and Everything (1982, ISBN 0-345-39182-9) is the third book in the six-volume Hitchhiker's Guide to the Galaxy science fiction 'trilogy of six books'' by British writer Douglas Adams. The title refers to the Answer to Life, the Universe, and Everything. ",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d3/Life%2C_The_Universe_and_Everything_cover.jpg",
                            Price = 4.99m,
                            Title = "Life, the Universe and Everything"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
