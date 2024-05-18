using System;
using System.Collections.Generic;

#nullable disable

namespace QLSinhVien_ASP.NET_Core_EF.Models
{
    public partial class ChuyenNganh
    {
        public ChuyenNganh()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        public int IdChuyenNganh { get; set; }
        public string TenNganh { get; set; }
        public string MoTa { get; set; }
        public int? IdKhoa { get; set; }

        public virtual Khoa IdKhoaNavigation { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
