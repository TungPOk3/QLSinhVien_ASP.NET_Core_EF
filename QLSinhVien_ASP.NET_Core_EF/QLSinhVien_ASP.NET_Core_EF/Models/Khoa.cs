using System;
using System.Collections.Generic;

#nullable disable

namespace QLSinhVien_ASP.NET_Core_EF.Models
{
    public partial class Khoa
    {

        public Khoa()
        {
            GiaoViens = new HashSet<GiaoVien>();
            SinhViens = new HashSet<SinhVien>();
        }

        public Khoa(string tenKhoa, string moTa)
        {
            TenKhoa = tenKhoa;
            MoTa = moTa;
        }

        public int IdKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string MoTa { get; set; }

        public virtual ICollection<GiaoVien> GiaoViens { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
