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
    public class ThietBiController : ControllerBase
    {
        public static List<ThietBi> thietBis = new List<ThietBi>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(thietBis);
        }

        [HttpPost]
        public IActionResult Create(ThietBiVM thietBiVM)
        {
            var thietbi = new ThietBi
            {
                NhietDo = thietBiVM.NhietDo,
                DoAm = thietBiVM.DoAm,
                AnhSang = thietBiVM.AnhSang
            };
            thietBis.Add(thietbi);
            return Ok(new {
                Success = true, Data = thietbi
            });
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, ThietBi thietBiEdit)
        {
            try
            {
                var thietBi = thietBis.SingleOrDefault(tb => tb.MaThietBi == id);
                if (thietBi == null)
                {
                    return NotFound();
                }
                if(id != thietBi.MaThietBi)
                {
                    return BadRequest();
                }
                //Update
                thietBi.AnhSang = thietBiEdit.AnhSang;
                thietBi.DoAm = thietBiEdit.DoAm;
                thietBi.NhietDo = thietBiEdit.NhietDo;

                return Ok();
            }
            
            catch
            {
                return BadRequest();
            }
            
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            try
            {
                var thietBi = thietBis.SingleOrDefault(tb => tb.MaThietBi == id);
                if (thietBi == null)
                {
                    return NotFound();
                }
                if (id != thietBi.MaThietBi)
                {
                    return BadRequest();
                }
                //Update
                thietBis.Remove(thietBi);

                return Ok();
            }

            catch
            {
                return BadRequest();
            }
        }
    }
}
