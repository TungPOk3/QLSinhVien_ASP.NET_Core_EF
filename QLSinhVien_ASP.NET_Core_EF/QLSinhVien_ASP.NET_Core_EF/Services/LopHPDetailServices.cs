using QLSinhVien_ASP.NET_Core_EF.Models;
using QLSinhVien_ASP.NET_Core_EF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.Services
{
    public class LopHPDetailServices
    {
        private readonly QLSV_DOTNET_CoreContext mydb;

        public LopHPDetailServices(QLSV_DOTNET_CoreContext dbContext)
        {
            mydb = dbContext;
        }

        public LopHpSinhVien getById(int idlophp)
        {
            var data = mydb.LopHpSinhViens.Where(n => n.IdLopHp == idlophp).FirstOrDefault();
            return data;
        }

        public List<LopHPDetailViewModels> getByIdLopHP(int idlophp)
        {
            var listhpsv = (from lhp in mydb.LopHpSinhViens 
                            where lhp.IdLopHp == idlophp
                            select new 
                            { 
                                lhp.IdLopHp,
                                lhp.IdSinhVien
                            }).ToList();
            List<LopHPDetailViewModels> listhpsvfull = new List<LopHPDetailViewModels>();
            LopHPDetailViewModels hpsvfull;

            foreach (var item in listhpsv)
            {
                hpsvfull = new LopHPDetailViewModels();
                hpsvfull.IdLopHp = item.IdLopHp;
                var hp = mydb.LopHps.FirstOrDefault(t => t.IdLopHp == item.IdLopHp);
                hpsvfull.TenLopSH = hp.TenLopHp;
                hpsvfull.IdSinhVien = item.IdSinhVien;
                var sv = mydb.SinhViens.FirstOrDefault(t => t.IdSinhVien == item.IdSinhVien);
                hpsvfull.TenSv = sv.TenSv;
                hpsvfull.NgaySinh = (DateTime)sv.NgaySinh;
                hpsvfull.Sdt = sv.Sdt;
                hpsvfull.Email = sv.Email;
                var lopsh = mydb.LopShes.FirstOrDefault(l => l.IdLopSh == sv.IdLopSh);
                hpsvfull.TenLopSH = lopsh.TenLopSh;
                listhpsvfull.Add(hpsvfull);
            }
            return listhpsvfull;
        }

        public void Add(LopHpSinhVien sv)
        {

            mydb.LopHpSinhViens.Add(sv);
            mydb.SaveChanges();
        }

        public void Delete(int id)
        {
            LopHpSinhVien l = mydb.LopHpSinhViens.Find(id);
            mydb.LopHpSinhViens.Remove(l);
            mydb.SaveChanges();
        }
    }
}
