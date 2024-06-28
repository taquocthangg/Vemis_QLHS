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
    public class HsGiaTriDiemDoMonHocKhuyenKhichesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsGiaTriDiemDoMonHocKhuyenKhichesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsGiaTriDiemDoMonHocKhuyenKhiches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsGiaTriDiemDoMonHocKhuyenKhich>>> GetHsGiaTriDiemDoMonHocKhuyenKhiches()
        {
            return await _context.HsGiaTriDiemDoMonHocKhuyenKhiches.ToListAsync();
        }

        // GET: api/HsGiaTriDiemDoMonHocKhuyenKhiches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsGiaTriDiemDoMonHocKhuyenKhich>> GetHsGiaTriDiemDoMonHocKhuyenKhich(string id)
        {
            var hsGiaTriDiemDoMonHocKhuyenKhich = await _context.HsGiaTriDiemDoMonHocKhuyenKhiches.FindAsync(id);

            if (hsGiaTriDiemDoMonHocKhuyenKhich == null)
            {
                return NotFound();
            }

            return hsGiaTriDiemDoMonHocKhuyenKhich;
        }

        // PUT: api/HsGiaTriDiemDoMonHocKhuyenKhiches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsGiaTriDiemDoMonHocKhuyenKhich(string id, HsGiaTriDiemDoMonHocKhuyenKhich hsGiaTriDiemDoMonHocKhuyenKhich)
        {
            if (id != hsGiaTriDiemDoMonHocKhuyenKhich.FkMonHocKhuyenKhich)
            {
                return BadRequest();
            }

            _context.Entry(hsGiaTriDiemDoMonHocKhuyenKhich).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsGiaTriDiemDoMonHocKhuyenKhichExists(id))
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

        // POST: api/HsGiaTriDiemDoMonHocKhuyenKhiches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsGiaTriDiemDoMonHocKhuyenKhich>> PostHsGiaTriDiemDoMonHocKhuyenKhich(HsGiaTriDiemDoMonHocKhuyenKhich hsGiaTriDiemDoMonHocKhuyenKhich)
        {
            _context.HsGiaTriDiemDoMonHocKhuyenKhiches.Add(hsGiaTriDiemDoMonHocKhuyenKhich);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsGiaTriDiemDoMonHocKhuyenKhichExists(hsGiaTriDiemDoMonHocKhuyenKhich.FkMonHocKhuyenKhich))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsGiaTriDiemDoMonHocKhuyenKhich", new { id = hsGiaTriDiemDoMonHocKhuyenKhich.FkMonHocKhuyenKhich }, hsGiaTriDiemDoMonHocKhuyenKhich);
        }

        // DELETE: api/HsGiaTriDiemDoMonHocKhuyenKhiches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsGiaTriDiemDoMonHocKhuyenKhich(string id)
        {
            var hsGiaTriDiemDoMonHocKhuyenKhich = await _context.HsGiaTriDiemDoMonHocKhuyenKhiches.FindAsync(id);
            if (hsGiaTriDiemDoMonHocKhuyenKhich == null)
            {
                return NotFound();
            }

            _context.HsGiaTriDiemDoMonHocKhuyenKhiches.Remove(hsGiaTriDiemDoMonHocKhuyenKhich);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsGiaTriDiemDoMonHocKhuyenKhichExists(string id)
        {
            return _context.HsGiaTriDiemDoMonHocKhuyenKhiches.Any(e => e.FkMonHocKhuyenKhich == id);
        }
    }
}
