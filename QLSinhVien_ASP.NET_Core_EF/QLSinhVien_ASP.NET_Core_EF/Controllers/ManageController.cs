using Microsoft.AspNetCore.Mvc;
using QLSinhVien_ASP.NET_Core_EF.Models;
using QLSinhVien_ASP.NET_Core_EF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.Controllers
{
    public class ManageController : Controller
    {
        
        private readonly KhoaServices khoaServices;
        private readonly GiaoVienServices gvServices;
        private readonly LopSHServices lopSHServices;
        private readonly SinhVienServices sinhVienServices;
        private readonly LopHPServices lopHPServices;
        private readonly LopHPDetailServices lopHPDetailServices;
        private readonly TheSinhVienServices theSinhVienServices;

        public ManageController(KhoaServices khoaServices,
            GiaoVienServices gvServices, LopSHServices lopSHServices, SinhVienServices sinhVienServices,
            LopHPServices lopHPServices, LopHPDetailServices lopHPDetailServices, TheSinhVienServices theSinhVienServices)
        {
            
            this.khoaServices = khoaServices;
            this.gvServices = gvServices;
            this.lopSHServices = lopSHServices;
            this.sinhVienServices = sinhVienServices;
            this.lopHPServices = lopHPServices;
            this.lopHPDetailServices = lopHPDetailServices;
            this.theSinhVienServices = theSinhVienServices;
        }
        

        public IActionResult KhoaManage()
        {
            List<Khoa> data = khoaServices.getAll();
            return View(data);
        }
        [HttpGet]
        public IActionResult AddKhoa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddKhoa(Khoa khoa)
        {
            if (ModelState.IsValid)
            {
                khoaServices.Add(khoa);
                return RedirectToAction("KhoaManage");
            }
            return View(khoa);
        }
        [HttpGet]
        public IActionResult EditKhoa(int id)
        {
            Khoa khoa = khoaServices.getById(id);
            return View(khoa);
        }
        [HttpPost]
        public IActionResult EditKhoa(Khoa khoa)
        {
            
            khoaServices.Edit(khoa);
            return RedirectToAction("KhoaManage");
        }

        public IActionResult DeleteKhoa(int id)
        {
            khoaServices.Delete(id);
            return RedirectToAction("KhoaManage");
        }
    }
}
