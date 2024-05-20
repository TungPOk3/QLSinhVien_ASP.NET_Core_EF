using Microsoft.EntityFrameworkCore;
using QLSinhVien_ASP.NET_Core_EF.Models;

using QLSinhVien_ASP.NET_Core_EF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.Services
{
    public class GiaoVienServices
    {
        private readonly QLSV_DOTNET_CoreContext mydb;

        public GiaoVienServices(QLSV_DOTNET_CoreContext dbContext)
        {
            mydb = dbContext;
        }


        public GiaoVien getById(int id)
        {
            return mydb.GiaoViens.Where(n => n.IdGiaoVien == id).FirstOrDefault();
        }
        public List<GVViewModels> getAllInfo()
        {
            /*var data = (from gv in mydb.GiaoViens
                        join k in mydb.Khoas
                        on gv.IdKhoa equals k.IdKhoa
                        select new GVViewModels
                        {
                            TenGV = gv.TenGv,
                            NgaySinh = (DateTime)gv.NgaySinh,
                            SDT = gv.Sdt,
                            Email = gv.Email,
                            TenKhoa = k.TenKhoa
                        }).ToList();


            List<GVViewModels> list = new List<GVViewModels>();
            foreach (var i in data)
            {
                GVViewModels gv = new GVViewModels();
                gv.TenGV = i.TenGV;
                gv.NgaySinh = i.NgaySinh;
                gv.SDT = i.SDT;
                gv.Email = i.Email;
                gv.TenKhoa = i.TenKhoa;
                list.Add(gv);
            }
            return data;*/
            var listgv = mydb.GiaoViens.ToList();
            List<GVViewModels> listgvfull = new List<GVViewModels>();
            GVViewModels gvfull;

            foreach (var item in listgv)
            {
                gvfull = new GVViewModels();
                gvfull.IdGV = item.IdGiaoVien;
                gvfull.TenGV = item.TenGv;
                gvfull.NgaySinh = (DateTime)item.NgaySinh;
                gvfull.SDT = item.Sdt;
                gvfull.Email = item.Email;
                
                var tk = mydb.Khoas.FirstOrDefault(t => t.IdKhoa == item.IdKhoa);
                gvfull.TenKhoa = tk.TenKhoa;
                listgvfull.Add(gvfull);
            }
            return listgvfull;

        }
    }
}
