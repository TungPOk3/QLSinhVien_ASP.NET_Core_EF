using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.ViewModels
{
    public class LopHPDetailViewModels
    {
        public int IdLopHp { get; set; }
        public string TenLopHP { get; set; }
        public int IdSinhVien { get; set; }
        public string TenSv { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public int IdLopSh { get; set; }
        public string TenLopSH { get; set; }
        public int IdKhoa { get; set; }
        public string TenKhoa { get; set; }
    }
}
