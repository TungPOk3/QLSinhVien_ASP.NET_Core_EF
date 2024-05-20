using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QLSinhVien_ASP.NET_Core_EF.Models;
using QLSinhVien_ASP.NET_Core_EF.Services;
using QLSinhVien_ASP.NET_Core_EF.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QLSinhVien_ASP.NET_Core_EF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KhoaServices khoaServices;
        private readonly GiaoVienServices gvServices;
        private readonly LopSHServices lopSHServices;
        private readonly SinhVienServices sinhVienServices;
        private readonly LopHPServices lopHPServices;
        private readonly LopHPDetailServices lopHPDetailServices;


        public HomeController(ILogger<HomeController> logger, KhoaServices khoaServices,
            GiaoVienServices gvServices, LopSHServices lopSHServices, SinhVienServices sinhVienServices, 
            LopHPServices lopHPServices, LopHPDetailServices lopHPDetailServices)
        {
            _logger = logger;
            this.khoaServices = khoaServices;
            this.gvServices = gvServices;
            this.lopSHServices = lopSHServices;
            this.sinhVienServices = sinhVienServices;
            this.lopHPServices = lopHPServices;
            this.lopHPDetailServices = lopHPDetailServices;
        }

        public IActionResult Index()
        {
            List<Khoa> data = khoaServices.getAll();
            return View(data);
        }


        public IActionResult KhoaList()
        {
            List<Khoa> data = khoaServices.getAll();
            return View(data);
        }


        public IActionResult GVList()
        {
            List<GVViewModels> list = gvServices.getAllInfo();
            return View(list);
        }

        public IActionResult LopSHList() 
        {
            List<LopSHViewModels> list = lopSHServices.getAll();
            return View(list);
        }
        public IActionResult SVList()
        {
            List<SVViewModels> list = sinhVienServices.getAll();
            return View(list);
        }

        public IActionResult LopHPList()
        {
            List<LopHPViewModels> list = lopHPServices.getAll();
            return View(list);
        }
        public IActionResult LopHPDetail(int id)
        {
            List<LopHPDetailViewModels> list = lopHPDetailServices.getByIdLopHP(id);
            return View(list);
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
