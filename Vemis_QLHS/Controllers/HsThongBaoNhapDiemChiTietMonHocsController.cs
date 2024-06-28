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
    public class HsThongBaoNhapDiemChiTietMonHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsThongBaoNhapDiemChiTietMonHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsThongBaoNhapDiemChiTietMonHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsThongBaoNhapDiemChiTietMonHoc>>> GetHsThongBaoNhapDiemChiTietMonHocs()
        {
            return await _context.HsThongBaoNhapDiemChiTietMonHocs.ToListAsync();
        }

        // GET: api/HsThongBaoNhapDiemChiTietMonHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsThongBaoNhapDiemChiTietMonHoc>> GetHsThongBaoNhapDiemChiTietMonHoc(string id)
        {
            var hsThongBaoNhapDiemChiTietMonHoc = await _context.HsThongBaoNhapDiemChiTietMonHocs.FindAsync(id);

            if (hsThongBaoNhapDiemChiTietMonHoc == null)
            {
                return NotFound();
            }

            return hsThongBaoNhapDiemChiTietMonHoc;
        }

        // PUT: api/HsThongBaoNhapDiemChiTietMonHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsThongBaoNhapDiemChiTietMonHoc(string id, HsThongBaoNhapDiemChiTietMonHoc hsThongBaoNhapDiemChiTietMonHoc)
        {
            if (id != hsThongBaoNhapDiemChiTietMonHoc.FkLopHocId)
            {
                return BadRequest();
            }

            _context.Entry(hsThongBaoNhapDiemChiTietMonHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsThongBaoNhapDiemChiTietMonHocExists(id))
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

        // POST: api/HsThongBaoNhapDiemChiTietMonHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsThongBaoNhapDiemChiTietMonHoc>> PostHsThongBaoNhapDiemChiTietMonHoc(HsThongBaoNhapDiemChiTietMonHoc hsThongBaoNhapDiemChiTietMonHoc)
        {
            _context.HsThongBaoNhapDiemChiTietMonHocs.Add(hsThongBaoNhapDiemChiTietMonHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsThongBaoNhapDiemChiTietMonHocExists(hsThongBaoNhapDiemChiTietMonHoc.FkLopHocId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsThongBaoNhapDiemChiTietMonHoc", new { id = hsThongBaoNhapDiemChiTietMonHoc.FkLopHocId }, hsThongBaoNhapDiemChiTietMonHoc);
        }

        // DELETE: api/HsThongBaoNhapDiemChiTietMonHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsThongBaoNhapDiemChiTietMonHoc(string id)
        {
            var hsThongBaoNhapDiemChiTietMonHoc = await _context.HsThongBaoNhapDiemChiTietMonHocs.FindAsync(id);
            if (hsThongBaoNhapDiemChiTietMonHoc == null)
            {
                return NotFound();
            }

            _context.HsThongBaoNhapDiemChiTietMonHocs.Remove(hsThongBaoNhapDiemChiTietMonHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsThongBaoNhapDiemChiTietMonHocExists(string id)
        {
            return _context.HsThongBaoNhapDiemChiTietMonHocs.Any(e => e.FkLopHocId == id);
        }
    }
}
