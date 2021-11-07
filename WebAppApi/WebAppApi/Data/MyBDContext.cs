using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppApi.Data
{
    public class MyBDContext : DbContext
    {
        public MyBDContext(DbContextOptions options) : base(options)
        {

        }
        #region DbSet
        public DbSet<Hanghoa> Hanghoas { get; set; }
        public DbSet<DonHang> donHangs { get; set; }
        public DbSet<Loai> loais { get; set; }
        public DbSet<ChiTietDonHang> chiTietDonHangs { get; set; }
     
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<DonHang>(e => { 
                e.ToTable("DonHang");
                e.HasKey(s => s.maDonhang);
                e.HasIndex(s => s.maDonhang).IsUnique();
                e.Property(s => s.maDonhang).IsRequired();
                e.Property(s => s.ngayDatHang).HasDefaultValueSql("getutcdate()");
                e.Property(e => e.maDonhang).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Hanghoa>(e => { 
                e.Property(s => s.tenHangHoa).IsRequired().HasMaxLength(50); 
            });

            modelBuilder.Entity<ChiTietDonHang>(e => {
                e.ToTable("ChiTietDonHang");
                e.HasKey(s => new { s.maDonhang, s.maHangHoa });

                e.HasOne(s => s.donHang)
                .WithMany(s => s.chiTietDonHangs)
                .HasForeignKey(s => s.maDonhang)
                .HasConstraintName("FK_CTDH_DonHang");

                e.HasOne(s => s.hangHoa)
                   .WithMany(s => s.chiTietDonHangs)
                   .HasForeignKey(s => s.maHangHoa)
                   .HasConstraintName("FK_CTDH_HangHoa");
            });
        }
    }
}
