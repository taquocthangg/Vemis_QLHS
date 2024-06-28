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
    public class HsHoSoSuKiensController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHoSoSuKiensController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHoSoSuKiens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHoSoSuKien>>> GetHsHoSoSuKiens()
        {
            return await _context.HsHoSoSuKiens.ToListAsync();
        }

        // GET: api/HsHoSoSuKiens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHoSoSuKien>> GetHsHoSoSuKien(string id)
        {
            var hsHoSoSuKien = await _context.HsHoSoSuKiens.FindAsync(id);

            if (hsHoSoSuKien == null)
            {
                return NotFound();
            }

            return hsHoSoSuKien;
        }

        // PUT: api/HsHoSoSuKiens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHoSoSuKien(string id, HsHoSoSuKien hsHoSoSuKien)
        {
            if (id != hsHoSoSuKien.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHoSoSuKien).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHoSoSuKienExists(id))
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

        // POST: api/HsHoSoSuKiens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHoSoSuKien>> PostHsHoSoSuKien(HsHoSoSuKien hsHoSoSuKien)
        {
            _context.HsHoSoSuKiens.Add(hsHoSoSuKien);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHoSoSuKienExists(hsHoSoSuKien.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHoSoSuKien", new { id = hsHoSoSuKien.FkHocSinhId }, hsHoSoSuKien);
        }

        // DELETE: api/HsHoSoSuKiens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHoSoSuKien(string id)
        {
            var hsHoSoSuKien = await _context.HsHoSoSuKiens.FindAsync(id);
            if (hsHoSoSuKien == null)
            {
                return NotFound();
            }

            _context.HsHoSoSuKiens.Remove(hsHoSoSuKien);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHoSoSuKienExists(string id)
        {
            return _context.HsHoSoSuKiens.Any(e => e.FkHocSinhId == id);
        }
    }
}
