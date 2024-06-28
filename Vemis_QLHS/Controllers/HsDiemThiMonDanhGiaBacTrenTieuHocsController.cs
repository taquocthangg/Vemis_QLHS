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
    public class HsDiemThiMonDanhGiaBacTrenTieuHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDiemThiMonDanhGiaBacTrenTieuHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDiemThiMonDanhGiaBacTrenTieuHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDiemThiMonDanhGiaBacTrenTieuHoc>>> GetHsDiemThiMonDanhGiaBacTrenTieuHocs()
        {
            return await _context.HsDiemThiMonDanhGiaBacTrenTieuHocs.ToListAsync();
        }

        // GET: api/HsDiemThiMonDanhGiaBacTrenTieuHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDiemThiMonDanhGiaBacTrenTieuHoc>> GetHsDiemThiMonDanhGiaBacTrenTieuHoc(string id)
        {
            var hsDiemThiMonDanhGiaBacTrenTieuHoc = await _context.HsDiemThiMonDanhGiaBacTrenTieuHocs.FindAsync(id);

            if (hsDiemThiMonDanhGiaBacTrenTieuHoc == null)
            {
                return NotFound();
            }

            return hsDiemThiMonDanhGiaBacTrenTieuHoc;
        }

        // PUT: api/HsDiemThiMonDanhGiaBacTrenTieuHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDiemThiMonDanhGiaBacTrenTieuHoc(string id, HsDiemThiMonDanhGiaBacTrenTieuHoc hsDiemThiMonDanhGiaBacTrenTieuHoc)
        {
            if (id != hsDiemThiMonDanhGiaBacTrenTieuHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDiemThiMonDanhGiaBacTrenTieuHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDiemThiMonDanhGiaBacTrenTieuHocExists(id))
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

        // POST: api/HsDiemThiMonDanhGiaBacTrenTieuHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDiemThiMonDanhGiaBacTrenTieuHoc>> PostHsDiemThiMonDanhGiaBacTrenTieuHoc(HsDiemThiMonDanhGiaBacTrenTieuHoc hsDiemThiMonDanhGiaBacTrenTieuHoc)
        {
            _context.HsDiemThiMonDanhGiaBacTrenTieuHocs.Add(hsDiemThiMonDanhGiaBacTrenTieuHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDiemThiMonDanhGiaBacTrenTieuHocExists(hsDiemThiMonDanhGiaBacTrenTieuHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDiemThiMonDanhGiaBacTrenTieuHoc", new { id = hsDiemThiMonDanhGiaBacTrenTieuHoc.FkHocSinhId }, hsDiemThiMonDanhGiaBacTrenTieuHoc);
        }

        // DELETE: api/HsDiemThiMonDanhGiaBacTrenTieuHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDiemThiMonDanhGiaBacTrenTieuHoc(string id)
        {
            var hsDiemThiMonDanhGiaBacTrenTieuHoc = await _context.HsDiemThiMonDanhGiaBacTrenTieuHocs.FindAsync(id);
            if (hsDiemThiMonDanhGiaBacTrenTieuHoc == null)
            {
                return NotFound();
            }

            _context.HsDiemThiMonDanhGiaBacTrenTieuHocs.Remove(hsDiemThiMonDanhGiaBacTrenTieuHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDiemThiMonDanhGiaBacTrenTieuHocExists(string id)
        {
            return _context.HsDiemThiMonDanhGiaBacTrenTieuHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
