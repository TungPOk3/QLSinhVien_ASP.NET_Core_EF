using System;
using System.Collections.Generic;

#nullable disable

namespace QLSinhVien_ASP.NET_Core_EF.Models
{
    public partial class SinhVien
    {
        public SinhVien()
        {
            LopHpSinhViens = new HashSet<LopHpSinhVien>();
            TheSinhViens = new HashSet<TheSinhVien>();
        }

        public int IdSinhVien { get; set; }
        public string TenSv { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public int? IdLopSh { get; set; }
        public int? IdKhoa { get; set; }

        public virtual Khoa IdKhoaNavigation { get; set; }
        public virtual LopSh IdLopShNavigation { get; set; }
        public virtual ICollection<LopHpSinhVien> LopHpSinhViens { get; set; }
        public virtual ICollection<TheSinhVien> TheSinhViens { get; set; }
    }
}
