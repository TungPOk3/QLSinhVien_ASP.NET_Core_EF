using System;
using System.Collections.Generic;

#nullable disable

namespace QLSinhVien_ASP.NET_Core_EF.Models
{
    public partial class LopSh
    {
        public LopSh()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        public int IdLopSh { get; set; }
        public string TenLopSh { get; set; }
        public string MoTa { get; set; }
        public int? IdGiaoVien { get; set; }

        public virtual GiaoVien IdGiaoVienNavigation { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
