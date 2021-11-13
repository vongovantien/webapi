using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppApi.Data
{
    [Table("HangHoa")]
    public class Hanghoa
    {
        [Key]
        public int MaHangHoa { get; set; }
        [Required]
        [MaxLength(100)]
        
        public string TenHangHoa { get; set; }
        public string MoTa { get; set; }
        [Range(0, double.MaxValue)]
        public double DonGia { get; set; }
        public byte GiamGia { get; set; }
        public int? MaLoai { get; set; }
        [ForeignKey("maLoai")]
        public Loai Loai { get; set; }

        public IList<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public Hanghoa()
        {
            ChiTietDonHangs = new List<ChiTietDonHang>();
        }
    }
}
