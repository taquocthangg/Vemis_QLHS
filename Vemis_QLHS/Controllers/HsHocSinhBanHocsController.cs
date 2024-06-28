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
    public class HsHocSinhBanHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHocSinhBanHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHocSinhBanHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHocSinhBanHoc>>> GetHsHocSinhBanHocs()
        {
            return await _context.HsHocSinhBanHocs.ToListAsync();
        }

        // GET: api/HsHocSinhBanHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHocSinhBanHoc>> GetHsHocSinhBanHoc(string id)
        {
            var hsHocSinhBanHoc = await _context.HsHocSinhBanHocs.FindAsync(id);

            if (hsHocSinhBanHoc == null)
            {
                return NotFound();
            }

            return hsHocSinhBanHoc;
        }

        // PUT: api/HsHocSinhBanHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHocSinhBanHoc(string id, HsHocSinhBanHoc hsHocSinhBanHoc)
        {
            if (id != hsHocSinhBanHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHocSinhBanHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHocSinhBanHocExists(id))
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

        // POST: api/HsHocSinhBanHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHocSinhBanHoc>> PostHsHocSinhBanHoc(HsHocSinhBanHoc hsHocSinhBanHoc)
        {
            _context.HsHocSinhBanHocs.Add(hsHocSinhBanHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHocSinhBanHocExists(hsHocSinhBanHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHocSinhBanHoc", new { id = hsHocSinhBanHoc.FkHocSinhId }, hsHocSinhBanHoc);
        }

        // DELETE: api/HsHocSinhBanHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHocSinhBanHoc(string id)
        {
            var hsHocSinhBanHoc = await _context.HsHocSinhBanHocs.FindAsync(id);
            if (hsHocSinhBanHoc == null)
            {
                return NotFound();
            }

            _context.HsHocSinhBanHocs.Remove(hsHocSinhBanHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHocSinhBanHocExists(string id)
        {
            return _context.HsHocSinhBanHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
