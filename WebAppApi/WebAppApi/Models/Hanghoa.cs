using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppApi.Models
{
    public class Hanghoa
    {
        internal Guid maHangHoa;

        public string name { get; set; }
        public double donGia { get; set; }
    }

    public class Hanghoa1 : Hanghoa
    {
        public Guid maHangHoa { get; set; }

    }
}
