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
        public Guid maHangHoa { get; set; }
        [Required]
        [MaxLength(100)]
        
        public string tenHangHoa { get; set; }
        public string moTa { get; set; }
        [Range(0, double.MaxValue)]
        public double donGia { get; set; }
        public byte giamGia { get; set; }
        public Guid? maLoai { get; set; }
        [ForeignKey("maLoai")]
        public Loai loai { get; set; }

        public IList<ChiTietDonHang> chiTietDonHangs { get; set; }

        public Hanghoa()
        {
            chiTietDonHangs = new List<ChiTietDonHang>();
        }
    }
}
