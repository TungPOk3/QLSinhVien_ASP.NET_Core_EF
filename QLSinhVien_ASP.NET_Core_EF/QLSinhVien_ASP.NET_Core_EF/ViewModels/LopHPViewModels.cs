using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.ViewModels
{
    public class LopHPViewModels
    {
        public int IdLopHp { get; set; }
        public string TenLopHp { get; set; }
        public string MoTa { get; set; }
        public int? IdGiaoVien { get; set; }
        public string TenGV { get; set; }
    }
}
