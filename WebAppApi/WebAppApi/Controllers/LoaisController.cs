using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppApi.Data;
using WebAppApi.Models;

namespace WebAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaisController : ControllerBase
    {
        private readonly MyBDContext _context;

        public LoaisController(MyBDContext context) {
            _context = context;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            var dsLoai = _context.loais.ToList();
            return Ok(dsLoai);
        }
        [HttpGet("{id}")]
        public IActionResult getByID(Guid id)
        {
            var loai = _context.loais.SingleOrDefault(l => l.maLoai == id);
            if(loai != null)
            {
                return Ok(loai);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Create(LoaiModel model)
        {
            try
            {
                var loai = new Loai
                {
                    tenLoai = model.tenLoai
                };
                _context.Add(loai);
                _context.SaveChanges();
                return Ok(loai);
            }
            catch
            {

                return BadRequest();
            }

        }
        [HttpPut("{id}")]
        public IActionResult UpdateByID(Guid id, LoaiModel model)
        {
            var loai = _context.loais.SingleOrDefault(l => l.maLoai == id);
            if (loai != null)
            {
                loai.tenLoai = model.tenLoai;
                _context.SaveChanges();
                return Ok(loai);
            }
            else
            {
                return NotFound();
            }
        }   
    }
}
