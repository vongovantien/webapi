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
        public int MaDonhang { get; set; }
        public DateTime NgayDatHang { get; set; }
        public DateTime? NgayGiaoHang { get; set; }
        public TinhTrangDonHang TinhTrangDonHang { get; set; }
        public string NguoiNhan { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public string SoDienThoai { get; set; }
        public IList<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DonHang()
        {
            ChiTietDonHangs = new List<ChiTietDonHang>();
        }
    }
}
