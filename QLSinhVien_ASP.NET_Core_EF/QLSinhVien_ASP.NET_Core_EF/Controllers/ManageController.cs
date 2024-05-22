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

        public IActionResult LopSHManage()
        {
            List<LopSHViewModels> data = lopSHServices.getAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult AddLopSH()
        {
            List<GiaoVien> dsgv = gvServices.getAllGV();
            return View(dsgv);
        }

        [HttpPost]
        public IActionResult AddLopSH(LopSh lop)
        {
            if (ModelState.IsValid)
            {
                lopSHServices.Add(lop);
                return RedirectToAction("LopSHManage");
            }
            return View(lop);
        }

        [HttpGet]
        public IActionResult EditLopSH(int id)
        {
            List<GiaoVien> gv = gvServices.getAllGV();
            LopSh l = lopSHServices.getById(id);
            var data = new Tuple<LopSh, List<GiaoVien>>(l, gv);
            return View(data);
        }
        [HttpPost]
        public IActionResult EditLopSH(LopSh l)
        {

            lopSHServices.Edit(l);
            return RedirectToAction("LopSHManage");
        }

        public IActionResult DeleteLopSH(int id)
        {
            lopSHServices.Delete(id);
            return RedirectToAction("LopSHManage");
        }
    }
}
