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
    public class HsChuyenLopsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsChuyenLopsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsChuyenLops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsChuyenLop>>> GetHsChuyenLops()
        {
            return await _context.HsChuyenLops.ToListAsync();
        }

        // GET: api/HsChuyenLops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsChuyenLop>> GetHsChuyenLop(string id)
        {
            var hsChuyenLop = await _context.HsChuyenLops.FindAsync(id);

            if (hsChuyenLop == null)
            {
                return NotFound();
            }

            return hsChuyenLop;
        }

        // PUT: api/HsChuyenLops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsChuyenLop(string id, HsChuyenLop hsChuyenLop)
        {
            if (id != hsChuyenLop.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsChuyenLop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsChuyenLopExists(id))
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

        // POST: api/HsChuyenLops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsChuyenLop>> PostHsChuyenLop(HsChuyenLop hsChuyenLop)
        {
            _context.HsChuyenLops.Add(hsChuyenLop);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsChuyenLopExists(hsChuyenLop.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsChuyenLop", new { id = hsChuyenLop.FkHocSinhId }, hsChuyenLop);
        }

        // DELETE: api/HsChuyenLops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsChuyenLop(string id)
        {
            var hsChuyenLop = await _context.HsChuyenLops.FindAsync(id);
            if (hsChuyenLop == null)
            {
                return NotFound();
            }

            _context.HsChuyenLops.Remove(hsChuyenLop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsChuyenLopExists(string id)
        {
            return _context.HsChuyenLops.Any(e => e.FkHocSinhId == id);
        }
    }
}
