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
    public class HsKetQuaThiHocSinhGioisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKetQuaThiHocSinhGioisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKetQuaThiHocSinhGiois
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKetQuaThiHocSinhGioi>>> GetHsKetQuaThiHocSinhGiois()
        {
            return await _context.HsKetQuaThiHocSinhGiois.ToListAsync();
        }

        // GET: api/HsKetQuaThiHocSinhGiois/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKetQuaThiHocSinhGioi>> GetHsKetQuaThiHocSinhGioi(string id)
        {
            var hsKetQuaThiHocSinhGioi = await _context.HsKetQuaThiHocSinhGiois.FindAsync(id);

            if (hsKetQuaThiHocSinhGioi == null)
            {
                return NotFound();
            }

            return hsKetQuaThiHocSinhGioi;
        }

        // PUT: api/HsKetQuaThiHocSinhGiois/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKetQuaThiHocSinhGioi(string id, HsKetQuaThiHocSinhGioi hsKetQuaThiHocSinhGioi)
        {
            if (id != hsKetQuaThiHocSinhGioi.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsKetQuaThiHocSinhGioi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKetQuaThiHocSinhGioiExists(id))
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

        // POST: api/HsKetQuaThiHocSinhGiois
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKetQuaThiHocSinhGioi>> PostHsKetQuaThiHocSinhGioi(HsKetQuaThiHocSinhGioi hsKetQuaThiHocSinhGioi)
        {
            _context.HsKetQuaThiHocSinhGiois.Add(hsKetQuaThiHocSinhGioi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsKetQuaThiHocSinhGioiExists(hsKetQuaThiHocSinhGioi.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsKetQuaThiHocSinhGioi", new { id = hsKetQuaThiHocSinhGioi.FkHocSinhId }, hsKetQuaThiHocSinhGioi);
        }

        // DELETE: api/HsKetQuaThiHocSinhGiois/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKetQuaThiHocSinhGioi(string id)
        {
            var hsKetQuaThiHocSinhGioi = await _context.HsKetQuaThiHocSinhGiois.FindAsync(id);
            if (hsKetQuaThiHocSinhGioi == null)
            {
                return NotFound();
            }

            _context.HsKetQuaThiHocSinhGiois.Remove(hsKetQuaThiHocSinhGioi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKetQuaThiHocSinhGioiExists(string id)
        {
            return _context.HsKetQuaThiHocSinhGiois.Any(e => e.FkHocSinhId == id);
        }
    }
}
