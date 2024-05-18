using System;
using System.Collections.Generic;

#nullable disable

namespace QLSinhVien_ASP.NET_Core_EF.Models
{
    public partial class Khoa
    {
        public Khoa()
        {
            ChuyenNganhs = new HashSet<ChuyenNganh>();
            GiaoViens = new HashSet<GiaoVien>();
        }

        public int IdKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string MoTa { get; set; }
        public int? IdTruong { get; set; }

        public virtual Truong IdTruongNavigation { get; set; }
        public virtual ICollection<ChuyenNganh> ChuyenNganhs { get; set; }
        public virtual ICollection<GiaoVien> GiaoViens { get; set; }
    }
}
