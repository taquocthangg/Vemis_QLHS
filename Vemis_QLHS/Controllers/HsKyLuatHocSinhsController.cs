using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vemis_QLHS.Entities;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HsKyLuatHocSinhsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKyLuatHocSinhsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKyLuatHocSinhs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKyLuatHocSinh>>> GetHsKyLuatHocSinhs()
        {
            return await _context.HsKyLuatHocSinhs.ToListAsync();
        }

        // GET: api/HsKyLuatHocSinhs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKyLuatHocSinh>> GetHsKyLuatHocSinh(int id)
        {
            var hsKyLuatHocSinh = await _context.HsKyLuatHocSinhs.FindAsync(id);

            if (hsKyLuatHocSinh == null)
            {
                return NotFound();
            }

            return hsKyLuatHocSinh;
        }

        // PUT: api/HsKyLuatHocSinhs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKyLuatHocSinh(int id, HsKyLuatHocSinh hsKyLuatHocSinh)
        {
            if (id != hsKyLuatHocSinh.Matang)
            {
                return BadRequest();
            }

            _context.Entry(hsKyLuatHocSinh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKyLuatHocSinhExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/HsKyLuatHocSinhs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKyLuatHocSinh>> PostHsKyLuatHocSinh(HsKyLuatHocSinh hsKyLuatHocSinh)
        {
            _context.HsKyLuatHocSinhs.Add(hsKyLuatHocSinh);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHsKyLuatHocSinh", new { id = hsKyLuatHocSinh.Matang }, hsKyLuatHocSinh);
        }

        // DELETE: api/HsKyLuatHocSinhs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKyLuatHocSinh(int id)
        {
            var hsKyLuatHocSinh = await _context.HsKyLuatHocSinhs.FindAsync(id);
            if (hsKyLuatHocSinh == null)
            {
                return NotFound();
            }

            _context.HsKyLuatHocSinhs.Remove(hsKyLuatHocSinh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKyLuatHocSinhExists(int id)
        {
            return _context.HsKyLuatHocSinhs.Any(e => e.Matang == id);
        }
    }
}
