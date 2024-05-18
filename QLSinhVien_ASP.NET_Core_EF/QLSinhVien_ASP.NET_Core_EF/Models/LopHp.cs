using System;
using System.Collections.Generic;

#nullable disable

namespace QLSinhVien_ASP.NET_Core_EF.Models
{
    public partial class LopHp
    {
        public LopHp()
        {
            LopHpSinhViens = new HashSet<LopHpSinhVien>();
        }

        public int IdLopHp { get; set; }
        public string TenLopHp { get; set; }
        public string MoTa { get; set; }
        public int? IdGiaoVien { get; set; }

        public virtual GiaoVien IdGiaoVienNavigation { get; set; }
        public virtual ICollection<LopHpSinhVien> LopHpSinhViens { get; set; }
    }
}
