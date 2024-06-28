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
    public class HsDanhGiaHanhKiemThuongXuyenBacTieuHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDanhGiaHanhKiemThuongXuyenBacTieuHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDanhGiaHanhKiemThuongXuyenBacTieuHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDanhGiaHanhKiemThuongXuyenBacTieuHoc>>> GetHsDanhGiaHanhKiemThuongXuyenBacTieuHocs()
        {
            return await _context.HsDanhGiaHanhKiemThuongXuyenBacTieuHocs.ToListAsync();
        }

        // GET: api/HsDanhGiaHanhKiemThuongXuyenBacTieuHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDanhGiaHanhKiemThuongXuyenBacTieuHoc>> GetHsDanhGiaHanhKiemThuongXuyenBacTieuHoc(string id)
        {
            var hsDanhGiaHanhKiemThuongXuyenBacTieuHoc = await _context.HsDanhGiaHanhKiemThuongXuyenBacTieuHocs.FindAsync(id);

            if (hsDanhGiaHanhKiemThuongXuyenBacTieuHoc == null)
            {
                return NotFound();
            }

            return hsDanhGiaHanhKiemThuongXuyenBacTieuHoc;
        }

        // PUT: api/HsDanhGiaHanhKiemThuongXuyenBacTieuHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDanhGiaHanhKiemThuongXuyenBacTieuHoc(string id, HsDanhGiaHanhKiemThuongXuyenBacTieuHoc hsDanhGiaHanhKiemThuongXuyenBacTieuHoc)
        {
            if (id != hsDanhGiaHanhKiemThuongXuyenBacTieuHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDanhGiaHanhKiemThuongXuyenBacTieuHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDanhGiaHanhKiemThuongXuyenBacTieuHocExists(id))
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

        // POST: api/HsDanhGiaHanhKiemThuongXuyenBacTieuHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDanhGiaHanhKiemThuongXuyenBacTieuHoc>> PostHsDanhGiaHanhKiemThuongXuyenBacTieuHoc(HsDanhGiaHanhKiemThuongXuyenBacTieuHoc hsDanhGiaHanhKiemThuongXuyenBacTieuHoc)
        {
            _context.HsDanhGiaHanhKiemThuongXuyenBacTieuHocs.Add(hsDanhGiaHanhKiemThuongXuyenBacTieuHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDanhGiaHanhKiemThuongXuyenBacTieuHocExists(hsDanhGiaHanhKiemThuongXuyenBacTieuHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDanhGiaHanhKiemThuongXuyenBacTieuHoc", new { id = hsDanhGiaHanhKiemThuongXuyenBacTieuHoc.FkHocSinhId }, hsDanhGiaHanhKiemThuongXuyenBacTieuHoc);
        }

        // DELETE: api/HsDanhGiaHanhKiemThuongXuyenBacTieuHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDanhGiaHanhKiemThuongXuyenBacTieuHoc(string id)
        {
            var hsDanhGiaHanhKiemThuongXuyenBacTieuHoc = await _context.HsDanhGiaHanhKiemThuongXuyenBacTieuHocs.FindAsync(id);
            if (hsDanhGiaHanhKiemThuongXuyenBacTieuHoc == null)
            {
                return NotFound();
            }

            _context.HsDanhGiaHanhKiemThuongXuyenBacTieuHocs.Remove(hsDanhGiaHanhKiemThuongXuyenBacTieuHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDanhGiaHanhKiemThuongXuyenBacTieuHocExists(string id)
        {
            return _context.HsDanhGiaHanhKiemThuongXuyenBacTieuHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
