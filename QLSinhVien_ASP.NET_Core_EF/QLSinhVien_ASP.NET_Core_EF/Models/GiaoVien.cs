using System;
using System.Collections.Generic;


#nullable disable

namespace QLSinhVien_ASP.NET_Core_EF.Models
{
    public partial class GiaoVien
    {
        public GiaoVien()
        {
            LopHps = new HashSet<LopHp>();
            LopShes = new HashSet<LopSh>();
        }
       
        public int IdGiaoVien { get; set; }
        public string TenGv { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public int? IdKhoa { get; set; }

        public virtual Khoa IdKhoaNavigation { get; set; }
        public virtual ICollection<LopHp> LopHps { get; set; }
        public virtual ICollection<LopSh> LopShes { get; set; }
    }
}
