﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppApi.Data;

namespace WebAppApi.Migrations
{
    [DbContext(typeof(MyBDContext))]
    [Migration("20211105014828_AddTBLoai")]
    partial class AddTBLoai
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppApi.Data.Hanghoa", b =>
                {
                    b.Property<Guid>("Mahh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<byte>("GiamGia")
                        .HasColumnType("tinyint");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenh")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("maLoai")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Mahh");

                    b.HasIndex("maLoai");

                    b.ToTable("HangHoa");
                });

            modelBuilder.Entity("WebAppApi.Data.Loai", b =>
                {
                    b.Property<Guid>("maLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tenLoai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("maLoai");

                    b.ToTable("Loai");
                });

            modelBuilder.Entity("WebAppApi.Data.Hanghoa", b =>
                {
                    b.HasOne("WebAppApi.Data.Loai", "loai")
                        .WithMany("Hanghoas")
                        .HasForeignKey("maLoai");

                    b.Navigation("loai");
                });

            modelBuilder.Entity("WebAppApi.Data.Loai", b =>
                {
                    b.Navigation("Hanghoas");
                });
#pragma warning restore 612, 618
        }
    }
}