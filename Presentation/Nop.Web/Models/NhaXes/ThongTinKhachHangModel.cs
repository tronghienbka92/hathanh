using Nop.Web.Framework.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nop.Web.Models.NhaXes
{
    public class ThongTinKhachHangModel : BaseNopEntityModel
    {
        public string TenKhachHang { get; set; }
        public string DienThoai { get; set; }
        public string TenDiemDonCuoi { get; set; }
        public string TenDiemTraCuoi { get; set; }

    }
}