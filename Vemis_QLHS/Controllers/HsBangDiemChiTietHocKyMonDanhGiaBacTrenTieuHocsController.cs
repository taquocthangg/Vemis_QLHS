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
    public class HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc>>> GetHsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs()
        {
            return await _context.HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs.ToListAsync();
        }

        // GET: api/HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc>> GetHsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc(string id)
        {
            var hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc = await _context.HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs.FindAsync(id);

            if (hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc == null)
            {
                return NotFound();
            }

            return hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc;
        }

        // PUT: api/HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc(string id, HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc)
        {
            if (id != hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocExists(id))
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

        // POST: api/HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc>> PostHsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc(HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc)
        {
            _context.HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs.Add(hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocExists(hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc", new { id = hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc.FkHocSinhId }, hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc);
        }

        // DELETE: api/HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc(string id)
        {
            var hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc = await _context.HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs.FindAsync(id);
            if (hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc == null)
            {
                return NotFound();
            }

            _context.HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs.Remove(hsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocExists(string id)
        {
            return _context.HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
