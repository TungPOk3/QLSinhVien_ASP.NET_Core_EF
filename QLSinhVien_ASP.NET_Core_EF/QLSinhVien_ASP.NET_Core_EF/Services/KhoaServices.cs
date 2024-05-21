using QLSinhVien_ASP.NET_Core_EF.Models;
using QLSinhVien_ASP.NET_Core_EF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.Services
{
    public class KhoaServices
    {
        private readonly QLSV_DOTNET_CoreContext mydb;

        public KhoaServices(QLSV_DOTNET_CoreContext dbContext)
        {
            mydb = dbContext;
        }

        public Khoa getById(int id)
        {
            var kh = mydb.Khoas.Where(n => n.IdKhoa == id).FirstOrDefault();
            return kh;
        }
        public List<Khoa> getAll()
        {
            return mydb.Khoas.ToList();
        }
        public void Add(Khoa khoa)
        {
            
            mydb.Khoas.Add(khoa);
            mydb.SaveChanges();
        }

        public void Edit(Khoa khoa)
        {
            Khoa kh = mydb.Khoas.Find(khoa.IdKhoa);
            kh.TenKhoa = khoa.TenKhoa;
            kh.MoTa = khoa.MoTa;
            mydb.SaveChanges();
        }

        public void Delete(int id)
        {
            Khoa kh = mydb.Khoas.Find(id);
            mydb.Khoas.Remove(kh);
            mydb.SaveChanges();
        }
    }
}
