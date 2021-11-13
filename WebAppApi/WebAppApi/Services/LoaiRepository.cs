using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppApi.Data;
using WebAppApi.Models;

namespace WebAppApi.Services
{
    public class LoaiRepository : ILoaiRepository
    {
        private readonly MyBDContext _context;

        public LoaiRepository(MyBDContext context)
        {
            _context = context;
        }
        public LoaiVM Add(LoaiModel loai)
        {
            var loaiHangHoa = new Loai
            {
                TenLoai = loai.tenLoai
            };
            _context.Add(loaiHangHoa);
            _context.SaveChanges();
            return new LoaiVM {
                maLoai = loai.maLoai,
                tenLoai = loai.tenLoai
            };
        }

        public void Delete(int id)
        {
            var loai = _context.Loais.SingleOrDefault(l => l.MaLoai == id);
            if(loai != null)
            {
                _context.Remove(loai);
                _context.SaveChanges();
            }
        }

        public List<LoaiVM> GetAll()
        {
            var loais = _context.Loais.Select(l => new LoaiVM
            {
                maLoai = l.MaLoai,
                tenLoai = l.TenLoai
            });
            return loais.ToList();
        }

        public LoaiVM GetById(int id)
        {
            var loai = _context.Loais.SingleOrDefault(l => l.MaLoai == id);
            if (loai != null)
            {
                return new LoaiVM
                {
                    tenLoai = loai.TenLoai,
                    maLoai = loai.MaLoai
                };
            }
            else
            {
                return null;
            }    
        }

        public void Update(LoaiVM loai)
        {
            var _loai = _context.Loais.SingleOrDefault(l => l.MaLoai == loai.maLoai);
            if(_loai != null)
            {
                _loai.TenLoai = loai.tenLoai;
                _context.Update(_loai);
                _context.SaveChanges();
            }
        }
    }
}
