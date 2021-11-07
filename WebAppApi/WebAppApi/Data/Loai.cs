
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppApi.Data
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public Guid maLoai { get; set; }
        [Required]
        [MaxLength(50)]
        public string tenLoai { get;set; }
        public virtual ICollection<Hanghoa> Hanghoas { get; set; }
    }
}
