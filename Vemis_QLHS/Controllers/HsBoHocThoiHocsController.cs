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
    public class HsBoHocThoiHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsBoHocThoiHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsBoHocThoiHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsBoHocThoiHoc>>> GetHsBoHocThoiHocs()
        {
            return await _context.HsBoHocThoiHocs.ToListAsync();
        }

        // GET: api/HsBoHocThoiHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsBoHocThoiHoc>> GetHsBoHocThoiHoc(string id)
        {
            var hsBoHocThoiHoc = await _context.HsBoHocThoiHocs.FindAsync(id);

            if (hsBoHocThoiHoc == null)
            {
                return NotFound();
            }

            return hsBoHocThoiHoc;
        }

        // PUT: api/HsBoHocThoiHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsBoHocThoiHoc(string id, HsBoHocThoiHoc hsBoHocThoiHoc)
        {
            if (id != hsBoHocThoiHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsBoHocThoiHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsBoHocThoiHocExists(id))
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

        // POST: api/HsBoHocThoiHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsBoHocThoiHoc>> PostHsBoHocThoiHoc(HsBoHocThoiHoc hsBoHocThoiHoc)
        {
            _context.HsBoHocThoiHocs.Add(hsBoHocThoiHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsBoHocThoiHocExists(hsBoHocThoiHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsBoHocThoiHoc", new { id = hsBoHocThoiHoc.FkHocSinhId }, hsBoHocThoiHoc);
        }

        // DELETE: api/HsBoHocThoiHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsBoHocThoiHoc(string id)
        {
            var hsBoHocThoiHoc = await _context.HsBoHocThoiHocs.FindAsync(id);
            if (hsBoHocThoiHoc == null)
            {
                return NotFound();
            }

            _context.HsBoHocThoiHocs.Remove(hsBoHocThoiHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsBoHocThoiHocExists(string id)
        {
            return _context.HsBoHocThoiHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
