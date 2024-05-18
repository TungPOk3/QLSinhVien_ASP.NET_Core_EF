using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QLSinhVien_ASP.NET_Core_EF.Models
{
    public partial class QLSinhVien_BTCK_CsharpContext : DbContext
    {
        public QLSinhVien_BTCK_CsharpContext()
        {
        }

        public QLSinhVien_BTCK_CsharpContext(DbContextOptions<QLSinhVien_BTCK_CsharpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChuyenNganh> ChuyenNganhs { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<LopHp> LopHps { get; set; }
        public virtual DbSet<LopHpSinhVien> LopHpSinhViens { get; set; }
        public virtual DbSet<LopSh> LopShes { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<TheSinhVien> TheSinhViens { get; set; }
        public virtual DbSet<Truong> Truongs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChuyenNganh>(entity =>
            {
                entity.HasKey(e => e.IdChuyenNganh)
                    .HasName("PK__ChuyenNg__512B7DDC572BCF11");

                entity.ToTable("ChuyenNganh");

                entity.Property(e => e.IdChuyenNganh).HasColumnName("idChuyenNganh");

                entity.Property(e => e.IdKhoa).HasColumnName("idKhoa");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(200)
                    .HasColumnName("moTa");

                entity.Property(e => e.TenNganh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("tenNganh");

                entity.HasOne(d => d.IdKhoaNavigation)
                    .WithMany(p => p.ChuyenNganhs)
                    .HasForeignKey(d => d.IdKhoa)
                    .HasConstraintName("FK__ChuyenNga__idKho__2C3393D0");
            });

            modelBuilder.Entity<GiaoVien>(entity =>
            {
                entity.HasKey(e => e.IdGiaoVien)
                    .HasName("PK__GiaoVien__76E2C018095C5EF8");

                entity.ToTable("GiaoVien");

                entity.HasIndex(e => e.Email, "UQ__GiaoVien__AB6E6164CA9D24DF")
                    .IsUnique();

                entity.Property(e => e.IdGiaoVien).HasColumnName("idGiaoVien");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdKhoa).HasColumnName("idKhoa");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("date")
                    .HasColumnName("ngaySinh");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenGv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenGV");

                entity.HasOne(d => d.IdKhoaNavigation)
                    .WithMany(p => p.GiaoViens)
                    .HasForeignKey(d => d.IdKhoa)
                    .HasConstraintName("FK__GiaoVien__idKhoa__4E88ABD4");
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.IdKhoa)
                    .HasName("PK__Khoa__C30A683DE7B4FE9E");

                entity.ToTable("Khoa");

                entity.Property(e => e.IdKhoa).HasColumnName("idKhoa");

                entity.Property(e => e.IdTruong).HasColumnName("idTruong");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(200)
                    .HasColumnName("moTa");

                entity.Property(e => e.TenKhoa)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("tenKhoa");

                entity.HasOne(d => d.IdTruongNavigation)
                    .WithMany(p => p.Khoas)
                    .HasForeignKey(d => d.IdTruong)
                    .HasConstraintName("FK__Khoa__idTruong__267ABA7A");
            });

            modelBuilder.Entity<LopHp>(entity =>
            {
                entity.HasKey(e => e.IdLopHp)
                    .HasName("PK__LopHP__3D988585DDC338F8");

                entity.ToTable("LopHP");

                entity.Property(e => e.IdLopHp).HasColumnName("idLopHP");

                entity.Property(e => e.IdGiaoVien).HasColumnName("idGiaoVien");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(100)
                    .HasColumnName("moTa");

                entity.Property(e => e.TenLopHp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenLopHP");

                entity.HasOne(d => d.IdGiaoVienNavigation)
                    .WithMany(p => p.LopHps)
                    .HasForeignKey(d => d.IdGiaoVien)
                    .HasConstraintName("FK__LopHP__idGiaoVie__5441852A");
            });

            modelBuilder.Entity<LopHpSinhVien>(entity =>
            {
                entity.HasKey(e => new { e.IdLopHp, e.IdSinhVien })
                    .HasName("PK__LopHP_Si__174A52B16755D36D");

                entity.ToTable("LopHP_SinhVien");

                entity.Property(e => e.IdLopHp).HasColumnName("idLopHP");

                entity.Property(e => e.IdSinhVien).HasColumnName("idSinhVien");

                entity.HasOne(d => d.IdLopHpNavigation)
                    .WithMany(p => p.LopHpSinhViens)
                    .HasForeignKey(d => d.IdLopHp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LopHP_Sin__idLop__6477ECF3");

                entity.HasOne(d => d.IdSinhVienNavigation)
                    .WithMany(p => p.LopHpSinhViens)
                    .HasForeignKey(d => d.IdSinhVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LopHP_Sin__idSin__656C112C");
            });

            modelBuilder.Entity<LopSh>(entity =>
            {
                entity.HasKey(e => e.IdLopSh)
                    .HasName("PK__LopSH__3D9CBDB8C22A0888");

                entity.ToTable("LopSH");

                entity.Property(e => e.IdLopSh).HasColumnName("idLopSH");

                entity.Property(e => e.IdGiaoVien).HasColumnName("idGiaoVien");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(100)
                    .HasColumnName("moTa");

                entity.Property(e => e.TenLopSh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenLopSH");

                entity.HasOne(d => d.IdGiaoVienNavigation)
                    .WithMany(p => p.LopShes)
                    .HasForeignKey(d => d.IdGiaoVien)
                    .HasConstraintName("FK__LopSH__idGiaoVie__5165187F");
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.IdSinhVien)
                    .HasName("PK__SinhVien__AD2D7343A3D0C460");

                entity.ToTable("SinhVien");

                entity.HasIndex(e => e.Email, "UQ__SinhVien__AB6E61642E1030B3")
                    .IsUnique();

                entity.Property(e => e.IdSinhVien).HasColumnName("idSinhVien");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdChuyenNganh).HasColumnName("idChuyenNganh");

                entity.Property(e => e.IdLopSh).HasColumnName("idLopSH");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("date")
                    .HasColumnName("ngaySinh");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenSv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenSV");

                entity.HasOne(d => d.IdChuyenNganhNavigation)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.IdChuyenNganh)
                    .HasConstraintName("FK__SinhVien__idChuy__60A75C0F");

                entity.HasOne(d => d.IdLopShNavigation)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.IdLopSh)
                    .HasConstraintName("FK__SinhVien__idLopS__619B8048");
            });

            modelBuilder.Entity<TheSinhVien>(entity =>
            {
                entity.HasKey(e => e.IdTheSv)
                    .HasName("PK__TheSinhV__34DA1229BD968823");

                entity.ToTable("TheSinhVien");

                entity.Property(e => e.IdTheSv).HasColumnName("idTheSV");

                entity.Property(e => e.FromDay)
                    .HasColumnType("date")
                    .HasColumnName("fromDay");

                entity.Property(e => e.HoTenSv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("hoTenSV");

                entity.Property(e => e.IdSinhVien).HasColumnName("idSinhVien");

                entity.Property(e => e.TenLopSv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tenLopSV");

                entity.Property(e => e.ToDay)
                    .HasColumnType("date")
                    .HasColumnName("toDay");

                entity.HasOne(d => d.IdSinhVienNavigation)
                    .WithMany(p => p.TheSinhViens)
                    .HasForeignKey(d => d.IdSinhVien)
                    .HasConstraintName("FK__TheSinhVi__idSin__693CA210");
            });

            modelBuilder.Entity<Truong>(entity =>
            {
                entity.HasKey(e => e.IdTruong)
                    .HasName("PK__Truong__72A59D24FBFD81E7");

                entity.ToTable("Truong");

                entity.Property(e => e.IdTruong).HasColumnName("idTruong");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(200)
                    .HasColumnName("moTa");

                entity.Property(e => e.TenTruong)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("tenTruong");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
