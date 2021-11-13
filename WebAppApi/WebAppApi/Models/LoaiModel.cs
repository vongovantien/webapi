using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppApi.Models
{
    public class LoaiModel
    {
        [Required]
        [MaxLength(50)]

        public int maLoai { get; set; }
        public string tenLoai { get; set; }
    }
}
