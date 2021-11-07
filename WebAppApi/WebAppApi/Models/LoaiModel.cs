﻿using System;
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
        public string tenLoai { get; set; }
    }
}
