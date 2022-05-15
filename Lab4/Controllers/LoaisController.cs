using Lab4.Data;
using Lab4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaisController : ControllerBase
    {
        private readonly MyDbContext _context;

        public LoaisController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var dsLoai = _context.Loais.ToList();
            return Ok(dsLoai);
        }

        [HttpPost]
        public IActionResult CreateNew(LoaiModel model)
        {
            try
            {
                var loai = new Loai
                {
                    TenLoai = model.TenLoai,
                    TrangThai = model.TrangThai
                    
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
        public IActionResult UpdateLoaiById(int id, LoaiModel model)
        {
            try
            {
                var loai = _context.Loais.SingleOrDefault(lo => lo.MaLoai == id);
                if (loai != null)
                {
                    loai.TenLoai = model.TenLoai;
                    _context.SaveChanges();
                    return NoContent();
                }

                else
                {
                    return NotFound();
                }
            }

            catch
            {
                return BadRequest();
            }

        }
    }
}
