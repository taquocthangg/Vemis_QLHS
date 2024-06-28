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
    public class HsLopHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsLopHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsLopHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsLopHoc>>> GetHsLopHocs()
        {
            return await _context.HsLopHocs.ToListAsync();
        }

        // GET: api/HsLopHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsLopHoc>> GetHsLopHoc(string id)
        {
            var hsLopHoc = await _context.HsLopHocs.FindAsync(id);

            if (hsLopHoc == null)
            {
                return NotFound();
            }

            return hsLopHoc;
        }

        // PUT: api/HsLopHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsLopHoc(string id, HsLopHoc hsLopHoc)
        {
            if (id != hsLopHoc.LopHocId)
            {
                return BadRequest();
            }

            _context.Entry(hsLopHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsLopHocExists(id))
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

        // POST: api/HsLopHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsLopHoc>> PostHsLopHoc(HsLopHoc hsLopHoc)
        {
            _context.HsLopHocs.Add(hsLopHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsLopHocExists(hsLopHoc.LopHocId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsLopHoc", new { id = hsLopHoc.LopHocId }, hsLopHoc);
        }

        // DELETE: api/HsLopHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsLopHoc(string id)
        {
            var hsLopHoc = await _context.HsLopHocs.FindAsync(id);
            if (hsLopHoc == null)
            {
                return NotFound();
            }

            _context.HsLopHocs.Remove(hsLopHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsLopHocExists(string id)
        {
            return _context.HsLopHocs.Any(e => e.LopHocId == id);
        }
    }
}
