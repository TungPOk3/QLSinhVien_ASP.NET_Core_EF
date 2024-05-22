using Microsoft.EntityFrameworkCore;
using QLSinhVien_ASP.NET_Core_EF.Models;
using QLSinhVien_ASP.NET_Core_EF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.Services
{
    public class LopSHServices
    {
        private readonly QLSV_DOTNET_CoreContext mydb;

        public LopSHServices(QLSV_DOTNET_CoreContext dbContext)
        {
            mydb = dbContext;
        }
        public List<LopSHViewModels> getAll()
        {
            var listlopsh = mydb.LopShes.ToList();
            List<LopSHViewModels> listlopshfull = new List<LopSHViewModels>();
            LopSHViewModels lopshfull;
            
            foreach(var item in listlopsh)
            {
                lopshfull = new LopSHViewModels();
                lopshfull.IdLopSh = item.IdLopSh;
                lopshfull.TenLopSh = item.TenLopSh;
                lopshfull.MoTa = item.MoTa;
                var gv = mydb.GiaoViens.FirstOrDefault(t => t.IdGiaoVien == item.IdGiaoVien);
                lopshfull.TenGiaoVien = gv.TenGv;
                lopshfull.SLSinhVien = mydb.SinhViens.Count(s => s.IdLopSh == item.IdLopSh);
                listlopshfull.Add(lopshfull);
                
            }

            return listlopshfull;
        }
        public LopSh getById(int id)
        {
            var l = mydb.LopShes.Where(n => n.IdLopSh == id).FirstOrDefault();
            return l;
        }
        public void Add(LopSh lop)
        {

            mydb.LopShes.Add(lop);
            mydb.SaveChanges();
        }

        public void Edit(LopSh lop)
        {

            LopSh l = mydb.LopShes.Find(lop.IdLopSh);
            l.TenLopSh = lop.TenLopSh;
            l.MoTa = lop.MoTa;
            l.IdGiaoVien = lop.IdGiaoVien;
            
            mydb.SaveChanges();
        }

        public void Delete(int id)
        {
            LopSh l = mydb.LopShes.Find(id);
            mydb.LopShes.Remove(l);
            mydb.SaveChanges();
        }
    }
}
