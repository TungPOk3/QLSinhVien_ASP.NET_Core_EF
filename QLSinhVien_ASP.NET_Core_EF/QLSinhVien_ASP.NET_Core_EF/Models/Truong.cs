using System;
using System.Collections.Generic;

#nullable disable

namespace QLSinhVien_ASP.NET_Core_EF.Models
{
    public partial class Truong
    {
        public Truong()
        {
            Khoas = new HashSet<Khoa>();
        }

        public int IdTruong { get; set; }
        public string TenTruong { get; set; }
        public string MoTa { get; set; }

        public virtual ICollection<Khoa> Khoas { get; set; }
    }
}
