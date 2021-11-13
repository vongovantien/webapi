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
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
     
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<DonHang>(e => { 
                e.ToTable("DonHang");
                e.HasKey(s => s.MaDonhang);
                e.HasIndex(s => s.MaDonhang).IsUnique();
                e.Property(s => s.MaDonhang).IsRequired();
                e.Property(s => s.NgayDatHang).HasDefaultValueSql("getutcdate()");
                e.Property(e => e.MaDonhang).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Hanghoa>(e => { 
                e.Property(s => s.TenHangHoa).IsRequired().HasMaxLength(50); 
            });

            modelBuilder.Entity<ChiTietDonHang>(e => {
                e.ToTable("ChiTietDonHang");
                e.HasKey(s => new { s.MaDonhang, s.MaHangHoa });

                e.HasOne(s => s.DonHang)
                .WithMany(s => s.ChiTietDonHangs)
                .HasForeignKey(s => s.MaDonhang)
                .HasConstraintName("FK_CTDH_DonHang");

                e.HasOne(s => s.HangHoa)
                   .WithMany(s => s.ChiTietDonHangs)
                   .HasForeignKey(s => s.MaHangHoa)
                   .HasConstraintName("FK_CTDH_HangHoa");
            });
        }
    }
}
