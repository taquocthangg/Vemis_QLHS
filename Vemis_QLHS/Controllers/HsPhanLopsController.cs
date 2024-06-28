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
    public class HsPhanLopsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsPhanLopsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsPhanLops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsPhanLop>>> GetHsPhanLops()
        {
            return await _context.HsPhanLops.ToListAsync();
        }

        // GET: api/HsPhanLops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsPhanLop>> GetHsPhanLop(string id)
        {
            var hsPhanLop = await _context.HsPhanLops.FindAsync(id);

            if (hsPhanLop == null)
            {
                return NotFound();
            }

            return hsPhanLop;
        }

        // PUT: api/HsPhanLops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsPhanLop(string id, HsPhanLop hsPhanLop)
        {
            if (id != hsPhanLop.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsPhanLop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsPhanLopExists(id))
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

        // POST: api/HsPhanLops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsPhanLop>> PostHsPhanLop(HsPhanLop hsPhanLop)
        {
            _context.HsPhanLops.Add(hsPhanLop);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsPhanLopExists(hsPhanLop.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsPhanLop", new { id = hsPhanLop.FkHocSinhId }, hsPhanLop);
        }

        // DELETE: api/HsPhanLops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsPhanLop(string id)
        {
            var hsPhanLop = await _context.HsPhanLops.FindAsync(id);
            if (hsPhanLop == null)
            {
                return NotFound();
            }

            _context.HsPhanLops.Remove(hsPhanLop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsPhanLopExists(string id)
        {
            return _context.HsPhanLops.Any(e => e.FkHocSinhId == id);
        }
    }
}
