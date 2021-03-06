﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductCart.Models;

namespace ProductCart.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20200906181319_ChangesInRequiredFields")]
    partial class ChangesInRequiredFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductCart.Models.Product", b =>
                {
                    b.Property<int>("ProdID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProdImagePath");

                    b.Property<string>("ProdName")
                        .IsRequired();

                    b.Property<double>("ProdPrice");

                    b.HasKey("ProdID");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
