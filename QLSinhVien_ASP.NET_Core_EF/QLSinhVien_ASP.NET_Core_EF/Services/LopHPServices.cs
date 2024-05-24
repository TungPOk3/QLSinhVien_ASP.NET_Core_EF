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
            var listhp = mydb.LopHps.ToList().OrderBy(gv => gv.TenLopHp);
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

        public LopHp getById(int id)
        {
            var l = mydb.LopHps.Where(n => n.IdLopHp == id).FirstOrDefault();
            return l;
        }
        public void Add(LopHp lop)
        {

            mydb.LopHps.Add(lop);
            mydb.SaveChanges();
        }

        public void Edit(LopHp lop)
        {

            LopHp l = mydb.LopHps.Find(lop.IdLopHp);
            l.TenLopHp = lop.TenLopHp;
            l.MoTa = lop.MoTa;
            l.IdGiaoVien = lop.IdGiaoVien;

            mydb.SaveChanges();
        }

        public void Delete(int id)
        {
            LopHp l = mydb.LopHps.Find(id);
            mydb.LopHps.Remove(l);
            mydb.SaveChanges();
        }

        public List<LopHPViewModels> Search(string s)
        {
            var listhp = mydb.LopHps.Where(t => t.TenLopHp.Contains(s)).ToList();
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
