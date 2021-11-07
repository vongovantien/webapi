using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppApi.Data
{
    public enum TinhTrangDonHang
    {
        New =0, Payment = 1, Complete = 2, Cancel = -1
    }
    public class DonHang
    {
        public Guid maDonhang { get; set; }
        public DateTime ngayDatHang { get; set; }
        public DateTime? ngayGiaoHang { get; set; }
        public TinhTrangDonHang tinhTrangDonHang { get; set; }
        public string nguoiNhan { get; set; }
        public string diaChiGiaoHang { get; set; }
        public string soDienThoai { get; set; }
        public IList<ChiTietDonHang> chiTietDonHangs { get; set; }
        public DonHang()
        {
            chiTietDonHangs = new List<ChiTietDonHang>();
        }
    }
}
