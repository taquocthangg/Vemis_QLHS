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
    public class HsKiemTraMucPhiDongGopsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKiemTraMucPhiDongGopsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKiemTraMucPhiDongGops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKiemTraMucPhiDongGop>>> GetHsKiemTraMucPhiDongGops()
        {
            return await _context.HsKiemTraMucPhiDongGops.ToListAsync();
        }

        // GET: api/HsKiemTraMucPhiDongGops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKiemTraMucPhiDongGop>> GetHsKiemTraMucPhiDongGop(string id)
        {
            var hsKiemTraMucPhiDongGop = await _context.HsKiemTraMucPhiDongGops.FindAsync(id);

            if (hsKiemTraMucPhiDongGop == null)
            {
                return NotFound();
            }

            return hsKiemTraMucPhiDongGop;
        }

        // PUT: api/HsKiemTraMucPhiDongGops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKiemTraMucPhiDongGop(string id, HsKiemTraMucPhiDongGop hsKiemTraMucPhiDongGop)
        {
            if (id != hsKiemTraMucPhiDongGop.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsKiemTraMucPhiDongGop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKiemTraMucPhiDongGopExists(id))
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

        // POST: api/HsKiemTraMucPhiDongGops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKiemTraMucPhiDongGop>> PostHsKiemTraMucPhiDongGop(HsKiemTraMucPhiDongGop hsKiemTraMucPhiDongGop)
        {
            _context.HsKiemTraMucPhiDongGops.Add(hsKiemTraMucPhiDongGop);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsKiemTraMucPhiDongGopExists(hsKiemTraMucPhiDongGop.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsKiemTraMucPhiDongGop", new { id = hsKiemTraMucPhiDongGop.FkHocSinhId }, hsKiemTraMucPhiDongGop);
        }

        // DELETE: api/HsKiemTraMucPhiDongGops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKiemTraMucPhiDongGop(string id)
        {
            var hsKiemTraMucPhiDongGop = await _context.HsKiemTraMucPhiDongGops.FindAsync(id);
            if (hsKiemTraMucPhiDongGop == null)
            {
                return NotFound();
            }

            _context.HsKiemTraMucPhiDongGops.Remove(hsKiemTraMucPhiDongGop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKiemTraMucPhiDongGopExists(string id)
        {
            return _context.HsKiemTraMucPhiDongGops.Any(e => e.FkHocSinhId == id);
        }
    }
}
