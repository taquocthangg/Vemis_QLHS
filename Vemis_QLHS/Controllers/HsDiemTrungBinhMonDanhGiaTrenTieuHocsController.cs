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
    public class HsDiemTrungBinhMonDanhGiaTrenTieuHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDiemTrungBinhMonDanhGiaTrenTieuHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDiemTrungBinhMonDanhGiaTrenTieuHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDiemTrungBinhMonDanhGiaTrenTieuHoc>>> GetHsDiemTrungBinhMonDanhGiaTrenTieuHocs()
        {
            return await _context.HsDiemTrungBinhMonDanhGiaTrenTieuHocs.ToListAsync();
        }

        // GET: api/HsDiemTrungBinhMonDanhGiaTrenTieuHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDiemTrungBinhMonDanhGiaTrenTieuHoc>> GetHsDiemTrungBinhMonDanhGiaTrenTieuHoc(string id)
        {
            var hsDiemTrungBinhMonDanhGiaTrenTieuHoc = await _context.HsDiemTrungBinhMonDanhGiaTrenTieuHocs.FindAsync(id);

            if (hsDiemTrungBinhMonDanhGiaTrenTieuHoc == null)
            {
                return NotFound();
            }

            return hsDiemTrungBinhMonDanhGiaTrenTieuHoc;
        }

        // PUT: api/HsDiemTrungBinhMonDanhGiaTrenTieuHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDiemTrungBinhMonDanhGiaTrenTieuHoc(string id, HsDiemTrungBinhMonDanhGiaTrenTieuHoc hsDiemTrungBinhMonDanhGiaTrenTieuHoc)
        {
            if (id != hsDiemTrungBinhMonDanhGiaTrenTieuHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDiemTrungBinhMonDanhGiaTrenTieuHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDiemTrungBinhMonDanhGiaTrenTieuHocExists(id))
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

        // POST: api/HsDiemTrungBinhMonDanhGiaTrenTieuHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDiemTrungBinhMonDanhGiaTrenTieuHoc>> PostHsDiemTrungBinhMonDanhGiaTrenTieuHoc(HsDiemTrungBinhMonDanhGiaTrenTieuHoc hsDiemTrungBinhMonDanhGiaTrenTieuHoc)
        {
            _context.HsDiemTrungBinhMonDanhGiaTrenTieuHocs.Add(hsDiemTrungBinhMonDanhGiaTrenTieuHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDiemTrungBinhMonDanhGiaTrenTieuHocExists(hsDiemTrungBinhMonDanhGiaTrenTieuHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDiemTrungBinhMonDanhGiaTrenTieuHoc", new { id = hsDiemTrungBinhMonDanhGiaTrenTieuHoc.FkHocSinhId }, hsDiemTrungBinhMonDanhGiaTrenTieuHoc);
        }

        // DELETE: api/HsDiemTrungBinhMonDanhGiaTrenTieuHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDiemTrungBinhMonDanhGiaTrenTieuHoc(string id)
        {
            var hsDiemTrungBinhMonDanhGiaTrenTieuHoc = await _context.HsDiemTrungBinhMonDanhGiaTrenTieuHocs.FindAsync(id);
            if (hsDiemTrungBinhMonDanhGiaTrenTieuHoc == null)
            {
                return NotFound();
            }

            _context.HsDiemTrungBinhMonDanhGiaTrenTieuHocs.Remove(hsDiemTrungBinhMonDanhGiaTrenTieuHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDiemTrungBinhMonDanhGiaTrenTieuHocExists(string id)
        {
            return _context.HsDiemTrungBinhMonDanhGiaTrenTieuHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
