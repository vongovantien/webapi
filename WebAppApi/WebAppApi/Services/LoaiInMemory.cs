using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppApi.Models;

namespace WebAppApi.Services
{
    public class LoaiInMemory : ILoaiRepository
    {
        static List<LoaiVM> loais = new List<LoaiVM>
        {
            new LoaiVM{maLoai = 1, tenLoai = "Tivi" },
            new LoaiVM{maLoai = 2, tenLoai = "Tu lanh" },
            new LoaiVM { maLoai = 3, tenLoai = "May giat" },
            new LoaiVM { maLoai = 4, tenLoai = "Lap top" },
            new LoaiVM { maLoai = 5, tenLoai = "PC" }
        };
        public LoaiVM Add(LoaiModel loai)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<LoaiVM> GetAll()
        {
            throw new NotImplementedException();
        }

        public LoaiVM GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(LoaiVM loai)
        {
            throw new NotImplementedException();
        }
    }
}
