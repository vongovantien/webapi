using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppApi.Data
{
    public class ChiTietDonHang
    {
        public Guid maHangHoa { get; set; }
        public Guid maDonhang { get; set; }
        public double soLuong { get; set; }
        public double thanhTien {get; set; }
        public double donGia { get; set; }
        public byte giamGia { get; set; }
        public string mieuTa { get; set; }
        public Hanghoa hangHoa { get; set; }
        public DonHang donHang { get; set; }
    }
}
