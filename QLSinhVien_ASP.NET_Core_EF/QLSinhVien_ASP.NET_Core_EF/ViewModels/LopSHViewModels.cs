using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.ViewModels
{
    public class LopSHViewModels
    {
        public int IdLopSh { get; set; }
        public string TenLopSh { get; set; }
        public string MoTa { get; set; }
        public int IdGiaoVien { get; set; }
        public string TenGiaoVien { get; set; }
        public int SLSinhVien { get; set; }
    }
}
