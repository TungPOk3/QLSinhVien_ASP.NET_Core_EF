using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QLSinhVien_ASP.NET_Core_EF.Models
{
    public partial class QLSV_DOTNET_CoreContext : DbContext
    {
        public QLSV_DOTNET_CoreContext()
        {
        }

        public QLSV_DOTNET_CoreContext(DbContextOptions<QLSV_DOTNET_CoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<LopHp> LopHps { get; set; }
        public virtual DbSet<LopHpSinhVien> LopHpSinhViens { get; set; }
        public virtual DbSet<LopSh> LopShes { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<TheSinhVien> TheSinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<GiaoVien>(entity =>
            {
                entity.HasKey(e => e.IdGiaoVien)
                    .HasName("PK__GiaoVien__76E2C0180EBCB1B4");

                entity.ToTable("GiaoVien");

                entity.HasIndex(e => e.Email, "UQ__GiaoVien__AB6E616443411CFB")
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
                    .HasConstraintName("FK__GiaoVien__idKhoa__2B3F6F97");
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.IdKhoa)
                    .HasName("PK__Khoa__C30A683DCD37AFCD");

                entity.ToTable("Khoa");

                entity.Property(e => e.IdKhoa).HasColumnName("idKhoa");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(200)
                    .HasColumnName("moTa");

                entity.Property(e => e.TenKhoa)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("tenKhoa");
            });

            modelBuilder.Entity<LopHp>(entity =>
            {
                entity.HasKey(e => e.IdLopHp)
                    .HasName("PK__LopHP__3D988585EB42AF8A");

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
                    .HasConstraintName("FK__LopHP__idGiaoVie__30F848ED");
            });

            modelBuilder.Entity<LopHpSinhVien>(entity =>
            {
                entity.HasKey(e => new { e.IdLopHp, e.IdSinhVien })
                    .HasName("PK__LopHP_Si__174A52B1B1279668");

                entity.ToTable("LopHP_SinhVien");

                entity.Property(e => e.IdLopHp).HasColumnName("idLopHP");

                entity.Property(e => e.IdSinhVien).HasColumnName("idSinhVien");

                entity.HasOne(d => d.IdLopHpNavigation)
                    .WithMany(p => p.LopHpSinhViens)
                    .HasForeignKey(d => d.IdLopHp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LopHP_Sin__idLop__3C69FB99");

                entity.HasOne(d => d.IdSinhVienNavigation)
                    .WithMany(p => p.LopHpSinhViens)
                    .HasForeignKey(d => d.IdSinhVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LopHP_Sin__idSin__3D5E1FD2");
            });

            modelBuilder.Entity<LopSh>(entity =>
            {
                entity.HasKey(e => e.IdLopSh)
                    .HasName("PK__LopSH__3D9CBDB888C5A424");

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
                    .HasConstraintName("FK__LopSH__idGiaoVie__2E1BDC42");
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.IdSinhVien)
                    .HasName("PK__SinhVien__AD2D7343835059B9");

                entity.ToTable("SinhVien");

                entity.HasIndex(e => e.Email, "UQ__SinhVien__AB6E6164F87E99E3")
                    .IsUnique();

                entity.Property(e => e.IdSinhVien).HasColumnName("idSinhVien");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdKhoa).HasColumnName("idKhoa");

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

                entity.HasOne(d => d.IdKhoaNavigation)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.IdKhoa)
                    .HasConstraintName("FK__SinhVien__idKhoa__38996AB5");

                entity.HasOne(d => d.IdLopShNavigation)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.IdLopSh)
                    .HasConstraintName("FK__SinhVien__idLopS__398D8EEE");
            });

            modelBuilder.Entity<TheSinhVien>(entity =>
            {
                entity.HasKey(e => e.IdTheSv)
                    .HasName("PK__TheSinhV__34DA1229C047FE5F");

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
                    .HasConstraintName("FK__TheSinhVi__idSin__412EB0B6");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
