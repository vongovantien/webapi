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
    [Migration("20211106080051_CreateFluentAPI")]
    partial class CreateFluentAPI
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppApi.Data.ChiTietDonHang", b =>
                {
                    b.Property<Guid>("maDonHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("maHangHoa")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("giamGia")
                        .HasColumnType("float");

                    b.Property<string>("mieuTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("thanhTien")
                        .HasColumnType("float");

                    b.HasKey("maDonHang", "maHangHoa");

                    b.HasIndex("maHangHoa");

                    b.ToTable("chiTietDonHangs");
                });

            modelBuilder.Entity("WebAppApi.Data.DonHang", b =>
                {
                    b.Property<Guid>("maDonhang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("giaTien")
                        .HasColumnType("float");

                    b.Property<double>("giamGia")
                        .HasColumnType("float");

                    b.Property<string>("tenDonHang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("maDonhang");

                    b.ToTable("donHangs");
                });

            modelBuilder.Entity("WebAppApi.Data.Hanghoa", b =>
                {
                    b.Property<Guid>("maHangHoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("donGia")
                        .HasColumnType("float");

                    b.Property<byte>("giamGia")
                        .HasColumnType("tinyint");

                    b.Property<Guid?>("maLoai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("moTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenHangHoa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("maHangHoa");

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

            modelBuilder.Entity("WebAppApi.Data.ChiTietDonHang", b =>
                {
                    b.HasOne("WebAppApi.Data.DonHang", "donHang")
                        .WithMany("chiTietDonHangs")
                        .HasForeignKey("maDonHang")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebAppApi.Data.Hanghoa", "hangHoa")
                        .WithMany("chiTietDonHangs")
                        .HasForeignKey("maHangHoa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("donHang");

                    b.Navigation("hangHoa");
                });

            modelBuilder.Entity("WebAppApi.Data.Hanghoa", b =>
                {
                    b.HasOne("WebAppApi.Data.Loai", "loai")
                        .WithMany("Hanghoas")
                        .HasForeignKey("maLoai");

                    b.Navigation("loai");
                });

            modelBuilder.Entity("WebAppApi.Data.DonHang", b =>
                {
                    b.Navigation("chiTietDonHangs");
                });

            modelBuilder.Entity("WebAppApi.Data.Hanghoa", b =>
                {
                    b.Navigation("chiTietDonHangs");
                });

            modelBuilder.Entity("WebAppApi.Data.Loai", b =>
                {
                    b.Navigation("Hanghoas");
                });
#pragma warning restore 612, 618
        }
    }
}