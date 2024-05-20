using QLSinhVien_ASP.NET_Core_EF.Models;
using QLSinhVien_ASP.NET_Core_EF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.Services
{
    public class SinhVienServices
    {
        private readonly QLSV_DOTNET_CoreContext mydb;

        public SinhVienServices(QLSV_DOTNET_CoreContext dbContext)
        {
            mydb = dbContext;
        }

        public List<SVViewModels> getAll()
        {
            var listsv = mydb.SinhViens.ToList();
            List<SVViewModels> listsvfull = new List<SVViewModels>();
            SVViewModels svfull;

            foreach (var item in listsv)
            {
                svfull = new SVViewModels();
                svfull.IdSinhVien = item.IdSinhVien;
                svfull.TenSv = item.TenSv;
                svfull.NgaySinh = (DateTime)item.NgaySinh;
                svfull.Sdt = item.Sdt;
                svfull.Email = item.Email;
                var tl = mydb.LopShes.FirstOrDefault(k => k.IdLopSh == item.IdLopSh);
                svfull.TenLopSH = tl.TenLopSh;
                var tk = mydb.Khoas.FirstOrDefault(t => t.IdKhoa == item.IdKhoa);
                svfull.TenKhoa = tk.TenKhoa;
                listsvfull.Add(svfull);
            }
            return listsvfull;
        }

        
    }
}
