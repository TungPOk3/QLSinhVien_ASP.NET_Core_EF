using System;
using System.Collections.Generic;

#nullable disable

namespace QLSinhVien_ASP.NET_Core_EF.Models
{
    public partial class LopHpSinhVien
    {
        public int IdLopHp { get; set; }
        public int IdSinhVien { get; set; }

        public virtual LopHp IdLopHpNavigation { get; set; }
        public virtual SinhVien IdSinhVienNavigation { get; set; }
    }
}
