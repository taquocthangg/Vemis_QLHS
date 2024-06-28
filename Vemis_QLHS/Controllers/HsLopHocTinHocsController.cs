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
    public class HsLopHocTinHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsLopHocTinHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsLopHocTinHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsLopHocTinHoc>>> GetHsLopHocTinHocs()
        {
            return await _context.HsLopHocTinHocs.ToListAsync();
        }

        // GET: api/HsLopHocTinHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsLopHocTinHoc>> GetHsLopHocTinHoc(string id)
        {
            var hsLopHocTinHoc = await _context.HsLopHocTinHocs.FindAsync(id);

            if (hsLopHocTinHoc == null)
            {
                return NotFound();
            }

            return hsLopHocTinHoc;
        }

        // PUT: api/HsLopHocTinHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsLopHocTinHoc(string id, HsLopHocTinHoc hsLopHocTinHoc)
        {
            if (id != hsLopHocTinHoc.FkLopHocId)
            {
                return BadRequest();
            }

            _context.Entry(hsLopHocTinHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsLopHocTinHocExists(id))
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

        // POST: api/HsLopHocTinHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsLopHocTinHoc>> PostHsLopHocTinHoc(HsLopHocTinHoc hsLopHocTinHoc)
        {
            _context.HsLopHocTinHocs.Add(hsLopHocTinHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsLopHocTinHocExists(hsLopHocTinHoc.FkLopHocId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsLopHocTinHoc", new { id = hsLopHocTinHoc.FkLopHocId }, hsLopHocTinHoc);
        }

        // DELETE: api/HsLopHocTinHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsLopHocTinHoc(string id)
        {
            var hsLopHocTinHoc = await _context.HsLopHocTinHocs.FindAsync(id);
            if (hsLopHocTinHoc == null)
            {
                return NotFound();
            }

            _context.HsLopHocTinHocs.Remove(hsLopHocTinHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsLopHocTinHocExists(string id)
        {
            return _context.HsLopHocTinHocs.Any(e => e.FkLopHocId == id);
        }
    }
}
