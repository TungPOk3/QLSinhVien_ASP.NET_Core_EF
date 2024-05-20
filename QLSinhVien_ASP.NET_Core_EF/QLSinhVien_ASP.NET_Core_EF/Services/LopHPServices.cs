using QLSinhVien_ASP.NET_Core_EF.Models;
using QLSinhVien_ASP.NET_Core_EF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.Services
{
    public class LopHPServices
    {
        private readonly QLSV_DOTNET_CoreContext mydb;

        public LopHPServices(QLSV_DOTNET_CoreContext dbContext)
        {
            mydb = dbContext;
        }

        public List<LopHPViewModels> getAll()
        {
            var listhp = mydb.LopHps.ToList();
            List<LopHPViewModels> listhpfull = new List<LopHPViewModels>();
            LopHPViewModels hpfull;

            foreach (var item in listhp)
            {
                hpfull = new LopHPViewModels();
                hpfull.IdLopHp = item.IdLopHp;
                hpfull.TenLopHp = item.TenLopHp;
                hpfull.MoTa = item.MoTa;
                var hp = mydb.GiaoViens.FirstOrDefault(t => t.IdGiaoVien == item.IdGiaoVien);
                hpfull.TenGV = hp.TenGv;
                listhpfull.Add(hpfull);
            }
            return listhpfull;
        }
    }
}
