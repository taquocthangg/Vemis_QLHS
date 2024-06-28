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
    public class HsKetQuaThiLaiMonDanhGiaTieuHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKetQuaThiLaiMonDanhGiaTieuHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKetQuaThiLaiMonDanhGiaTieuHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKetQuaThiLaiMonDanhGiaTieuHoc>>> GetHsKetQuaThiLaiMonDanhGiaTieuHocs()
        {
            return await _context.HsKetQuaThiLaiMonDanhGiaTieuHocs.ToListAsync();
        }

        // GET: api/HsKetQuaThiLaiMonDanhGiaTieuHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKetQuaThiLaiMonDanhGiaTieuHoc>> GetHsKetQuaThiLaiMonDanhGiaTieuHoc(string id)
        {
            var hsKetQuaThiLaiMonDanhGiaTieuHoc = await _context.HsKetQuaThiLaiMonDanhGiaTieuHocs.FindAsync(id);

            if (hsKetQuaThiLaiMonDanhGiaTieuHoc == null)
            {
                return NotFound();
            }

            return hsKetQuaThiLaiMonDanhGiaTieuHoc;
        }

        // PUT: api/HsKetQuaThiLaiMonDanhGiaTieuHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKetQuaThiLaiMonDanhGiaTieuHoc(string id, HsKetQuaThiLaiMonDanhGiaTieuHoc hsKetQuaThiLaiMonDanhGiaTieuHoc)
        {
            if (id != hsKetQuaThiLaiMonDanhGiaTieuHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsKetQuaThiLaiMonDanhGiaTieuHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKetQuaThiLaiMonDanhGiaTieuHocExists(id))
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

        // POST: api/HsKetQuaThiLaiMonDanhGiaTieuHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKetQuaThiLaiMonDanhGiaTieuHoc>> PostHsKetQuaThiLaiMonDanhGiaTieuHoc(HsKetQuaThiLaiMonDanhGiaTieuHoc hsKetQuaThiLaiMonDanhGiaTieuHoc)
        {
            _context.HsKetQuaThiLaiMonDanhGiaTieuHocs.Add(hsKetQuaThiLaiMonDanhGiaTieuHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsKetQuaThiLaiMonDanhGiaTieuHocExists(hsKetQuaThiLaiMonDanhGiaTieuHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsKetQuaThiLaiMonDanhGiaTieuHoc", new { id = hsKetQuaThiLaiMonDanhGiaTieuHoc.FkHocSinhId }, hsKetQuaThiLaiMonDanhGiaTieuHoc);
        }

        // DELETE: api/HsKetQuaThiLaiMonDanhGiaTieuHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKetQuaThiLaiMonDanhGiaTieuHoc(string id)
        {
            var hsKetQuaThiLaiMonDanhGiaTieuHoc = await _context.HsKetQuaThiLaiMonDanhGiaTieuHocs.FindAsync(id);
            if (hsKetQuaThiLaiMonDanhGiaTieuHoc == null)
            {
                return NotFound();
            }

            _context.HsKetQuaThiLaiMonDanhGiaTieuHocs.Remove(hsKetQuaThiLaiMonDanhGiaTieuHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKetQuaThiLaiMonDanhGiaTieuHocExists(string id)
        {
            return _context.HsKetQuaThiLaiMonDanhGiaTieuHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
