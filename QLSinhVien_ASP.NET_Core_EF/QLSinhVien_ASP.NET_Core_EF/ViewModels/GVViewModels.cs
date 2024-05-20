using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.ViewModels
{
    public class GVViewModels
    {
        public int IdGV { get; set; }
        public string TenGV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public int IdKhoa { get; set; }
        public string TenKhoa { get; set; }
    }
}
