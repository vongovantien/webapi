using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppApi.Data
{
    public class ChiTietDonHang
    {
        public int MaHangHoa { get; set; }
        public int MaDonhang { get; set; }
        public double SoLuong { get; set; }
        public double ThanhTien {get; set; }
        public double DonGia { get; set; }
        public byte GiamGia { get; set; }
        public string MieuTa { get; set; }
        public Hanghoa HangHoa { get; set; }
        public DonHang DonHang { get; set; }
    }
}
