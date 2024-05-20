using System;
using System.Collections.Generic;

#nullable disable

namespace QLSinhVien_ASP.NET_Core_EF.Models
{
    public partial class TheSinhVien
    {
        public int IdTheSv { get; set; }
        public string HoTenSv { get; set; }
        public string TenLopSv { get; set; }
        public DateTime? FromDay { get; set; }
        public DateTime? ToDay { get; set; }
        public int? IdSinhVien { get; set; }
        public string HinhAnh { get; set; }
    }
}
