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
    public class HsDiemThiMonLichSuVaDiaLyBacTieuHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDiemThiMonLichSuVaDiaLyBacTieuHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDiemThiMonLichSuVaDiaLyBacTieuHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDiemThiMonLichSuVaDiaLyBacTieuHoc>>> GetHsDiemThiMonLichSuVaDiaLyBacTieuHocs()
        {
            return await _context.HsDiemThiMonLichSuVaDiaLyBacTieuHocs.ToListAsync();
        }

        // GET: api/HsDiemThiMonLichSuVaDiaLyBacTieuHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDiemThiMonLichSuVaDiaLyBacTieuHoc>> GetHsDiemThiMonLichSuVaDiaLyBacTieuHoc(string id)
        {
            var hsDiemThiMonLichSuVaDiaLyBacTieuHoc = await _context.HsDiemThiMonLichSuVaDiaLyBacTieuHocs.FindAsync(id);

            if (hsDiemThiMonLichSuVaDiaLyBacTieuHoc == null)
            {
                return NotFound();
            }

            return hsDiemThiMonLichSuVaDiaLyBacTieuHoc;
        }

        // PUT: api/HsDiemThiMonLichSuVaDiaLyBacTieuHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDiemThiMonLichSuVaDiaLyBacTieuHoc(string id, HsDiemThiMonLichSuVaDiaLyBacTieuHoc hsDiemThiMonLichSuVaDiaLyBacTieuHoc)
        {
            if (id != hsDiemThiMonLichSuVaDiaLyBacTieuHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDiemThiMonLichSuVaDiaLyBacTieuHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDiemThiMonLichSuVaDiaLyBacTieuHocExists(id))
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

        // POST: api/HsDiemThiMonLichSuVaDiaLyBacTieuHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDiemThiMonLichSuVaDiaLyBacTieuHoc>> PostHsDiemThiMonLichSuVaDiaLyBacTieuHoc(HsDiemThiMonLichSuVaDiaLyBacTieuHoc hsDiemThiMonLichSuVaDiaLyBacTieuHoc)
        {
            _context.HsDiemThiMonLichSuVaDiaLyBacTieuHocs.Add(hsDiemThiMonLichSuVaDiaLyBacTieuHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDiemThiMonLichSuVaDiaLyBacTieuHocExists(hsDiemThiMonLichSuVaDiaLyBacTieuHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDiemThiMonLichSuVaDiaLyBacTieuHoc", new { id = hsDiemThiMonLichSuVaDiaLyBacTieuHoc.FkHocSinhId }, hsDiemThiMonLichSuVaDiaLyBacTieuHoc);
        }

        // DELETE: api/HsDiemThiMonLichSuVaDiaLyBacTieuHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDiemThiMonLichSuVaDiaLyBacTieuHoc(string id)
        {
            var hsDiemThiMonLichSuVaDiaLyBacTieuHoc = await _context.HsDiemThiMonLichSuVaDiaLyBacTieuHocs.FindAsync(id);
            if (hsDiemThiMonLichSuVaDiaLyBacTieuHoc == null)
            {
                return NotFound();
            }

            _context.HsDiemThiMonLichSuVaDiaLyBacTieuHocs.Remove(hsDiemThiMonLichSuVaDiaLyBacTieuHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDiemThiMonLichSuVaDiaLyBacTieuHocExists(string id)
        {
            return _context.HsDiemThiMonLichSuVaDiaLyBacTieuHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
