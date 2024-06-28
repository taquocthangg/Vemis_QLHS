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
    public class HsDiemTrungBinhMonDanhGiaTieuHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDiemTrungBinhMonDanhGiaTieuHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDiemTrungBinhMonDanhGiaTieuHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDiemTrungBinhMonDanhGiaTieuHoc>>> GetHsDiemTrungBinhMonDanhGiaTieuHocs()
        {
            return await _context.HsDiemTrungBinhMonDanhGiaTieuHocs.ToListAsync();
        }

        // GET: api/HsDiemTrungBinhMonDanhGiaTieuHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDiemTrungBinhMonDanhGiaTieuHoc>> GetHsDiemTrungBinhMonDanhGiaTieuHoc(string id)
        {
            var hsDiemTrungBinhMonDanhGiaTieuHoc = await _context.HsDiemTrungBinhMonDanhGiaTieuHocs.FindAsync(id);

            if (hsDiemTrungBinhMonDanhGiaTieuHoc == null)
            {
                return NotFound();
            }

            return hsDiemTrungBinhMonDanhGiaTieuHoc;
        }

        // PUT: api/HsDiemTrungBinhMonDanhGiaTieuHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDiemTrungBinhMonDanhGiaTieuHoc(string id, HsDiemTrungBinhMonDanhGiaTieuHoc hsDiemTrungBinhMonDanhGiaTieuHoc)
        {
            if (id != hsDiemTrungBinhMonDanhGiaTieuHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDiemTrungBinhMonDanhGiaTieuHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDiemTrungBinhMonDanhGiaTieuHocExists(id))
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

        // POST: api/HsDiemTrungBinhMonDanhGiaTieuHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDiemTrungBinhMonDanhGiaTieuHoc>> PostHsDiemTrungBinhMonDanhGiaTieuHoc(HsDiemTrungBinhMonDanhGiaTieuHoc hsDiemTrungBinhMonDanhGiaTieuHoc)
        {
            _context.HsDiemTrungBinhMonDanhGiaTieuHocs.Add(hsDiemTrungBinhMonDanhGiaTieuHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDiemTrungBinhMonDanhGiaTieuHocExists(hsDiemTrungBinhMonDanhGiaTieuHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDiemTrungBinhMonDanhGiaTieuHoc", new { id = hsDiemTrungBinhMonDanhGiaTieuHoc.FkHocSinhId }, hsDiemTrungBinhMonDanhGiaTieuHoc);
        }

        // DELETE: api/HsDiemTrungBinhMonDanhGiaTieuHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDiemTrungBinhMonDanhGiaTieuHoc(string id)
        {
            var hsDiemTrungBinhMonDanhGiaTieuHoc = await _context.HsDiemTrungBinhMonDanhGiaTieuHocs.FindAsync(id);
            if (hsDiemTrungBinhMonDanhGiaTieuHoc == null)
            {
                return NotFound();
            }

            _context.HsDiemTrungBinhMonDanhGiaTieuHocs.Remove(hsDiemTrungBinhMonDanhGiaTieuHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDiemTrungBinhMonDanhGiaTieuHocExists(string id)
        {
            return _context.HsDiemTrungBinhMonDanhGiaTieuHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
