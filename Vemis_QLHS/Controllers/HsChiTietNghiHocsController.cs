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
    public class HsChiTietNghiHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsChiTietNghiHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsChiTietNghiHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsChiTietNghiHoc>>> GetHsChiTietNghiHocs()
        {
            return await _context.HsChiTietNghiHocs.ToListAsync();
        }

        // GET: api/HsChiTietNghiHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsChiTietNghiHoc>> GetHsChiTietNghiHoc(string id)
        {
            var hsChiTietNghiHoc = await _context.HsChiTietNghiHocs.FindAsync(id);

            if (hsChiTietNghiHoc == null)
            {
                return NotFound();
            }

            return hsChiTietNghiHoc;
        }

        // PUT: api/HsChiTietNghiHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsChiTietNghiHoc(string id, HsChiTietNghiHoc hsChiTietNghiHoc)
        {
            if (id != hsChiTietNghiHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsChiTietNghiHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsChiTietNghiHocExists(id))
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

        // POST: api/HsChiTietNghiHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsChiTietNghiHoc>> PostHsChiTietNghiHoc(HsChiTietNghiHoc hsChiTietNghiHoc)
        {
            _context.HsChiTietNghiHocs.Add(hsChiTietNghiHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsChiTietNghiHocExists(hsChiTietNghiHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsChiTietNghiHoc", new { id = hsChiTietNghiHoc.FkHocSinhId }, hsChiTietNghiHoc);
        }

        // DELETE: api/HsChiTietNghiHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsChiTietNghiHoc(string id)
        {
            var hsChiTietNghiHoc = await _context.HsChiTietNghiHocs.FindAsync(id);
            if (hsChiTietNghiHoc == null)
            {
                return NotFound();
            }

            _context.HsChiTietNghiHocs.Remove(hsChiTietNghiHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsChiTietNghiHocExists(string id)
        {
            return _context.HsChiTietNghiHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
