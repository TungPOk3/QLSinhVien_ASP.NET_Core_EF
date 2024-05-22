﻿using Microsoft.EntityFrameworkCore;
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


        /*public GVViewModels getById(int id)
        {
            var gv = mydb.GiaoViens.Where(n => n.IdGiaoVien == id).FirstOrDefault();
            
            return gv;
        }*/
        public List<GVViewModels> getAllInfo()
        {
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

        
        public void Add(GVViewModels gv)
        {
            GiaoVien giaovien = new GiaoVien();
            giaovien.IdGiaoVien = gv.IdGV;
            giaovien.TenGv = gv.TenGV;
            giaovien.NgaySinh = gv.NgaySinh;
            giaovien.Sdt = gv.SDT;
            giaovien.Email = gv.Email;
            giaovien.IdKhoa = gv.IdKhoa;
            mydb.GiaoViens.Add(giaovien);
            mydb.SaveChanges();
        }

        public void Edit(GiaoVien giaovien)
        {
            GiaoVien gv = mydb.GiaoViens.Find(giaovien.IdGiaoVien);
            gv.TenGv = giaovien.TenGv;
            gv.NgaySinh = giaovien.NgaySinh;
            gv.Sdt = giaovien.Sdt;
            gv.Email = giaovien.Email;
            gv.IdKhoa = giaovien.IdKhoa;
            mydb.SaveChanges();
        }

        public void Delete(int id)
        {
            GiaoVien gv = mydb.GiaoViens.Find(id);
            mydb.GiaoViens.Remove(gv);
            mydb.SaveChanges();
        }
    }
}
