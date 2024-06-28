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
    public class HsMucPhiDongGopsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsMucPhiDongGopsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsMucPhiDongGops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsMucPhiDongGop>>> GetHsMucPhiDongGops()
        {
            return await _context.HsMucPhiDongGops.ToListAsync();
        }

        // GET: api/HsMucPhiDongGops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsMucPhiDongGop>> GetHsMucPhiDongGop(string id)
        {
            var hsMucPhiDongGop = await _context.HsMucPhiDongGops.FindAsync(id);

            if (hsMucPhiDongGop == null)
            {
                return NotFound();
            }

            return hsMucPhiDongGop;
        }

        // PUT: api/HsMucPhiDongGops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsMucPhiDongGop(string id, HsMucPhiDongGop hsMucPhiDongGop)
        {
            if (id != hsMucPhiDongGop.FkKhoiLopId)
            {
                return BadRequest();
            }

            _context.Entry(hsMucPhiDongGop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsMucPhiDongGopExists(id))
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

        // POST: api/HsMucPhiDongGops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsMucPhiDongGop>> PostHsMucPhiDongGop(HsMucPhiDongGop hsMucPhiDongGop)
        {
            _context.HsMucPhiDongGops.Add(hsMucPhiDongGop);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsMucPhiDongGopExists(hsMucPhiDongGop.FkKhoiLopId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsMucPhiDongGop", new { id = hsMucPhiDongGop.FkKhoiLopId }, hsMucPhiDongGop);
        }

        // DELETE: api/HsMucPhiDongGops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsMucPhiDongGop(string id)
        {
            var hsMucPhiDongGop = await _context.HsMucPhiDongGops.FindAsync(id);
            if (hsMucPhiDongGop == null)
            {
                return NotFound();
            }

            _context.HsMucPhiDongGops.Remove(hsMucPhiDongGop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsMucPhiDongGopExists(string id)
        {
            return _context.HsMucPhiDongGops.Any(e => e.FkKhoiLopId == id);
        }
    }
}
