using Microsoft.EntityFrameworkCore;
using QLSinhVien_ASP.NET_Core_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.Services
{
    public class TheSinhVienServices
    {
        private readonly QLSV_DOTNET_CoreContext mydb;

        public TheSinhVienServices(QLSV_DOTNET_CoreContext dbContext)
        {
            mydb = dbContext;
        }
        public List<TheSinhVien> getById(int id)
        {

            var listtsv = (from tsv in mydb.TheSinhViens
                           where tsv.IdSinhVien == id
                           select new
                           {
                               tsv.IdTheSv,
                               tsv.HoTenSv,
                               tsv.TenLopSv,
                               tsv.FromDay,
                               tsv.ToDay,
                               tsv.HinhAnh,
                               tsv.IdSinhVien
                           }).ToList();
            List<TheSinhVien> listtsvfull = new List<TheSinhVien>();
            TheSinhVien tsvfull;

            foreach(var item in listtsv)
            {
                tsvfull = new TheSinhVien();
                tsvfull.IdTheSv = item.IdTheSv;
                tsvfull.HoTenSv = item.HoTenSv;
                tsvfull.TenLopSv = item.TenLopSv;
                tsvfull.FromDay = item.FromDay;
                tsvfull.ToDay = item.ToDay;
                tsvfull.IdSinhVien = item.IdSinhVien;
                tsvfull.HinhAnh = item.HinhAnh;
                listtsvfull.Add(tsvfull);
            }
            return listtsvfull;


        }
    }
}
