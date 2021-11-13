using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppApi.Models
{
    public class Hanghoa
    {
        internal int maHangHoa;

        public string Name { get; set; }
        public double DonGia { get; set; }
    }

    public class Hanghoa1 : Hanghoa
    {
        public int MaHangHoa { get; set; }

    }
}
