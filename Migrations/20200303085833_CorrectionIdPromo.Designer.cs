﻿// <auto-generated />
using System;
using API_MSPR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_MSPR.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200303085833_CorrectionIdPromo")]
    partial class CorrectionIdPromo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API_MSPR.Model.InfoQR", b =>
                {
                    b.Property<int>("IdPromo")
                        .HasColumnType("int");

                    b.Property<int>("IdQRCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateScan")
                        .HasColumnType("datetime2");

                    b.Property<string>("Localisation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPromo", "IdQRCode");

                    b.ToTable("InfoQRs");
                });

            modelBuilder.Entity("API_MSPR.Model.Promotion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodePromo")
                        .HasColumnType("int");

                    b.Property<DateTime>("PromoDateDeb")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PromoDateFin")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("API_MSPR.Model.QRCode", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NbScan")
                        .HasColumnType("int");

                    b.Property<int>("PromotionId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("QRCodes");
                });
#pragma warning restore 612, 618
        }
    }
}