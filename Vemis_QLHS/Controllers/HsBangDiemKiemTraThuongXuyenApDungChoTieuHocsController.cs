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
    public class HsBangDiemKiemTraThuongXuyenApDungChoTieuHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsBangDiemKiemTraThuongXuyenApDungChoTieuHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsBangDiemKiemTraThuongXuyenApDungChoTieuHoc>>> GetHsBangDiemKiemTraThuongXuyenApDungChoTieuHocs()
        {
            return await _context.HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs.ToListAsync();
        }

        // GET: api/HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsBangDiemKiemTraThuongXuyenApDungChoTieuHoc>> GetHsBangDiemKiemTraThuongXuyenApDungChoTieuHoc(string id)
        {
            var hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc = await _context.HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs.FindAsync(id);

            if (hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc == null)
            {
                return NotFound();
            }

            return hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc;
        }

        // PUT: api/HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsBangDiemKiemTraThuongXuyenApDungChoTieuHoc(string id, HsBangDiemKiemTraThuongXuyenApDungChoTieuHoc hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc)
        {
            if (id != hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsBangDiemKiemTraThuongXuyenApDungChoTieuHocExists(id))
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

        // POST: api/HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsBangDiemKiemTraThuongXuyenApDungChoTieuHoc>> PostHsBangDiemKiemTraThuongXuyenApDungChoTieuHoc(HsBangDiemKiemTraThuongXuyenApDungChoTieuHoc hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc)
        {
            _context.HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs.Add(hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsBangDiemKiemTraThuongXuyenApDungChoTieuHocExists(hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsBangDiemKiemTraThuongXuyenApDungChoTieuHoc", new { id = hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc.FkHocSinhId }, hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc);
        }

        // DELETE: api/HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsBangDiemKiemTraThuongXuyenApDungChoTieuHoc(string id)
        {
            var hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc = await _context.HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs.FindAsync(id);
            if (hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc == null)
            {
                return NotFound();
            }

            _context.HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs.Remove(hsBangDiemKiemTraThuongXuyenApDungChoTieuHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsBangDiemKiemTraThuongXuyenApDungChoTieuHocExists(string id)
        {
            return _context.HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
