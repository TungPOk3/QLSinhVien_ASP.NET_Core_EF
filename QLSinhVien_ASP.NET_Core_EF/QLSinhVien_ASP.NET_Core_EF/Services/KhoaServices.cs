using QLSinhVien_ASP.NET_Core_EF.Models;
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
            return mydb.Khoas.Where(n => n.IdKhoa == id).FirstOrDefault();
        }
        public List<Khoa> getAll()
        {
            return mydb.Khoas.ToList();
        }
    }
}
