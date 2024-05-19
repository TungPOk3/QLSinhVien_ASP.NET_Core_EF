using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QLSinhVien_ASP.NET_Core_EF.Models;
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
        private readonly QLSV_DOTNET_CoreContext mydb;
        public HomeController(ILogger<HomeController> logger, QLSV_DOTNET_CoreContext mydb)
        {
            this.mydb = mydb;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var data = mydb.Khoas.ToList();
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
