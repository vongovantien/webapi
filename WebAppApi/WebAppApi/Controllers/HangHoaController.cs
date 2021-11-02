using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppApi.Models;

namespace WebAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        public static List<Hanghoa1> hangHoas = new List<Hanghoa1>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(hangHoas);
        }

        [HttpPost]
        public IActionResult Create(Hanghoa1 hanghoa1)
        {
            var hangHoa = new Hanghoa1
            {
                maHangHoa = Guid.NewGuid(),
                name = hanghoa1.name,
                donGia = hanghoa1.donGia
            };
            hangHoas.Add(hangHoa);
            return Ok(new
            {
                Success = true,
                Data = hangHoa,
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try {
                var hangHoa = hangHoas.SingleOrDefault(hh => hh.maHangHoa == Guid.Parse(id));
                if (hangHoa == null)
                {
                    return NotFound();
                }
                return Ok(hangHoa);
            } catch { 
                return BadRequest();
            };
            
        }

        [HttpPut("{id}")]
        public IActionResult Edit(string id, Hanghoa hangHoaEdit)
        {
            try
            {
                var hangHoa = hangHoas.SingleOrDefault(hh => hh.maHangHoa == Guid.Parse(id));
                if (hangHoa == null)
                {
                    return NotFound();
                }
                if(id != hangHoa.maHangHoa.ToString())
                {
                    return BadRequest();
                }
                // Sua hang hoa
                hangHoa.name = hangHoaEdit.name;
                hangHoa.donGia = hangHoaEdit.donGia;
                return Ok(hangHoa);
            }
            catch
            {
                return BadRequest();
            };
        }

        [HttpDelete("{id}")]
        public IActionResult Remove (String id)
        {
            try
            {
                var hangHoa = hangHoas.SingleOrDefault(hh => hh.maHangHoa == Guid.Parse(id));
                if (hangHoa == null)
                {
                    return NotFound();
                }
                // Xoa hang hoa
                hangHoas.Remove(hangHoa);
                return Ok("Xoa thanh cong");
            }
            catch
            {
                return BadRequest();
            };
        }
    }
}
