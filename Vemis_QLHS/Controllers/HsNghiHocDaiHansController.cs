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
    public class HsNghiHocDaiHansController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsNghiHocDaiHansController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsNghiHocDaiHans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsNghiHocDaiHan>>> GetHsNghiHocDaiHans()
        {
            return await _context.HsNghiHocDaiHans.ToListAsync();
        }

        // GET: api/HsNghiHocDaiHans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsNghiHocDaiHan>> GetHsNghiHocDaiHan(int id)
        {
            var hsNghiHocDaiHan = await _context.HsNghiHocDaiHans.FindAsync(id);

            if (hsNghiHocDaiHan == null)
            {
                return NotFound();
            }

            return hsNghiHocDaiHan;
        }

        // PUT: api/HsNghiHocDaiHans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsNghiHocDaiHan(int id, HsNghiHocDaiHan hsNghiHocDaiHan)
        {
            if (id != hsNghiHocDaiHan.Ma)
            {
                return BadRequest();
            }

            _context.Entry(hsNghiHocDaiHan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsNghiHocDaiHanExists(id))
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

        // POST: api/HsNghiHocDaiHans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsNghiHocDaiHan>> PostHsNghiHocDaiHan(HsNghiHocDaiHan hsNghiHocDaiHan)
        {
            _context.HsNghiHocDaiHans.Add(hsNghiHocDaiHan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHsNghiHocDaiHan", new { id = hsNghiHocDaiHan.Ma }, hsNghiHocDaiHan);
        }

        // DELETE: api/HsNghiHocDaiHans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsNghiHocDaiHan(int id)
        {
            var hsNghiHocDaiHan = await _context.HsNghiHocDaiHans.FindAsync(id);
            if (hsNghiHocDaiHan == null)
            {
                return NotFound();
            }

            _context.HsNghiHocDaiHans.Remove(hsNghiHocDaiHan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsNghiHocDaiHanExists(int id)
        {
            return _context.HsNghiHocDaiHans.Any(e => e.Ma == id);
        }
    }
}
