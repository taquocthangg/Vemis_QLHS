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
    public class HsXetLenLopsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsXetLenLopsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsXetLenLops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsXetLenLop>>> GetHsXetLenLops()
        {
            return await _context.HsXetLenLops.ToListAsync();
        }

        // GET: api/HsXetLenLops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsXetLenLop>> GetHsXetLenLop(string id)
        {
            var hsXetLenLop = await _context.HsXetLenLops.FindAsync(id);

            if (hsXetLenLop == null)
            {
                return NotFound();
            }

            return hsXetLenLop;
        }

        // PUT: api/HsXetLenLops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsXetLenLop(string id, HsXetLenLop hsXetLenLop)
        {
            if (id != hsXetLenLop.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsXetLenLop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsXetLenLopExists(id))
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

        // POST: api/HsXetLenLops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsXetLenLop>> PostHsXetLenLop(HsXetLenLop hsXetLenLop)
        {
            _context.HsXetLenLops.Add(hsXetLenLop);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsXetLenLopExists(hsXetLenLop.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsXetLenLop", new { id = hsXetLenLop.FkHocSinhId }, hsXetLenLop);
        }

        // DELETE: api/HsXetLenLops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsXetLenLop(string id)
        {
            var hsXetLenLop = await _context.HsXetLenLops.FindAsync(id);
            if (hsXetLenLop == null)
            {
                return NotFound();
            }

            _context.HsXetLenLops.Remove(hsXetLenLop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsXetLenLopExists(string id)
        {
            return _context.HsXetLenLops.Any(e => e.FkHocSinhId == id);
        }
    }
}
