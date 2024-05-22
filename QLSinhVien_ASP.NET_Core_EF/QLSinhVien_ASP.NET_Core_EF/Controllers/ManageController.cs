using Microsoft.AspNetCore.Mvc;
using QLSinhVien_ASP.NET_Core_EF.Models;
using QLSinhVien_ASP.NET_Core_EF.Services;
using QLSinhVien_ASP.NET_Core_EF.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        
        //Khoa manage
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

        //Giáo viên manage
        public IActionResult GVManage()
        {
            List<GVViewModels> data = gvServices.getAllInfo();
            return View(data);
        }
        [HttpGet]
        public IActionResult AddGV()
        {
            List<Khoa> dskhoa = khoaServices.getAll();
            return View(dskhoa);
        }

        [HttpPost]
        public IActionResult AddGV(GiaoVien gv)
        {
            
            if (ModelState.IsValid)
            {
                gvServices.Add(gv);
                return RedirectToAction("GVManage");
            }
            return View(gv);
        }

        [HttpGet]
        public IActionResult EditGV(int id)
        {
            List<Khoa> kh = khoaServices.getAll();
            GiaoVien gv = gvServices.getById(id);
            var data = new Tuple<GiaoVien, List<Khoa>>(gv, kh);
            return View(data);
        }
        [HttpPost]
        public IActionResult EditGV(GiaoVien gv)
        {

            gvServices.Edit(gv);
            return RedirectToAction("GVManage");
        }

        public IActionResult DeleteGV(int id)
        {
            gvServices.Delete(id);
            return RedirectToAction("GVManage");
        }
    }
}
