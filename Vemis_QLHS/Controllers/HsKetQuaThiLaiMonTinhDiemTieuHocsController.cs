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
    public class HsKetQuaThiLaiMonTinhDiemTieuHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKetQuaThiLaiMonTinhDiemTieuHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKetQuaThiLaiMonTinhDiemTieuHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKetQuaThiLaiMonTinhDiemTieuHoc>>> GetHsKetQuaThiLaiMonTinhDiemTieuHocs()
        {
            return await _context.HsKetQuaThiLaiMonTinhDiemTieuHocs.ToListAsync();
        }

        // GET: api/HsKetQuaThiLaiMonTinhDiemTieuHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKetQuaThiLaiMonTinhDiemTieuHoc>> GetHsKetQuaThiLaiMonTinhDiemTieuHoc(string id)
        {
            var hsKetQuaThiLaiMonTinhDiemTieuHoc = await _context.HsKetQuaThiLaiMonTinhDiemTieuHocs.FindAsync(id);

            if (hsKetQuaThiLaiMonTinhDiemTieuHoc == null)
            {
                return NotFound();
            }

            return hsKetQuaThiLaiMonTinhDiemTieuHoc;
        }

        // PUT: api/HsKetQuaThiLaiMonTinhDiemTieuHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKetQuaThiLaiMonTinhDiemTieuHoc(string id, HsKetQuaThiLaiMonTinhDiemTieuHoc hsKetQuaThiLaiMonTinhDiemTieuHoc)
        {
            if (id != hsKetQuaThiLaiMonTinhDiemTieuHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsKetQuaThiLaiMonTinhDiemTieuHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKetQuaThiLaiMonTinhDiemTieuHocExists(id))
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

        // POST: api/HsKetQuaThiLaiMonTinhDiemTieuHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKetQuaThiLaiMonTinhDiemTieuHoc>> PostHsKetQuaThiLaiMonTinhDiemTieuHoc(HsKetQuaThiLaiMonTinhDiemTieuHoc hsKetQuaThiLaiMonTinhDiemTieuHoc)
        {
            _context.HsKetQuaThiLaiMonTinhDiemTieuHocs.Add(hsKetQuaThiLaiMonTinhDiemTieuHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsKetQuaThiLaiMonTinhDiemTieuHocExists(hsKetQuaThiLaiMonTinhDiemTieuHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsKetQuaThiLaiMonTinhDiemTieuHoc", new { id = hsKetQuaThiLaiMonTinhDiemTieuHoc.FkHocSinhId }, hsKetQuaThiLaiMonTinhDiemTieuHoc);
        }

        // DELETE: api/HsKetQuaThiLaiMonTinhDiemTieuHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKetQuaThiLaiMonTinhDiemTieuHoc(string id)
        {
            var hsKetQuaThiLaiMonTinhDiemTieuHoc = await _context.HsKetQuaThiLaiMonTinhDiemTieuHocs.FindAsync(id);
            if (hsKetQuaThiLaiMonTinhDiemTieuHoc == null)
            {
                return NotFound();
            }

            _context.HsKetQuaThiLaiMonTinhDiemTieuHocs.Remove(hsKetQuaThiLaiMonTinhDiemTieuHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKetQuaThiLaiMonTinhDiemTieuHocExists(string id)
        {
            return _context.HsKetQuaThiLaiMonTinhDiemTieuHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
