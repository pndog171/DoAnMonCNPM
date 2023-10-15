using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ChiTietThue> ChiTietThues { get; set; }
        public virtual DbSet<GioiTinh> GioiTinhs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiXe> LoaiXes { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietThue>()
                .Property(e => e.MaCTThue)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietThue>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietThue>()
                .Property(e => e.MaXe)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietThue>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<GioiTinh>()
                .Property(e => e.MaGioiTinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaXe)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDTKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.ChiTietThues)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiXe>()
                .Property(e => e.MaLoai)
                .IsFixedLength();

            modelBuilder.Entity<LoaiXe>()
                .HasMany(e => e.Xes)
                .WithRequired(e => e.LoaiXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MaGioiTinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.ChiTietThues)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Xe>()
                .Property(e => e.MaXe)
                .IsFixedLength();

            modelBuilder.Entity<Xe>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Xe>()
                .Property(e => e.MaLoai)
                .IsFixedLength();

            modelBuilder.Entity<Xe>()
                .HasMany(e => e.ChiTietThues)
                .WithRequired(e => e.Xe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Xe>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.Xe)
                .WillCascadeOnDelete(false);
        }
    }
}
