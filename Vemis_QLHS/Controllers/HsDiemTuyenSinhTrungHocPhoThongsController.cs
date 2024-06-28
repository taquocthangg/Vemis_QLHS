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
    public class HsDiemTuyenSinhTrungHocPhoThongsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDiemTuyenSinhTrungHocPhoThongsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDiemTuyenSinhTrungHocPhoThongs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDiemTuyenSinhTrungHocPhoThong>>> GetHsDiemTuyenSinhTrungHocPhoThongs()
        {
            return await _context.HsDiemTuyenSinhTrungHocPhoThongs.ToListAsync();
        }

        // GET: api/HsDiemTuyenSinhTrungHocPhoThongs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDiemTuyenSinhTrungHocPhoThong>> GetHsDiemTuyenSinhTrungHocPhoThong(string id)
        {
            var hsDiemTuyenSinhTrungHocPhoThong = await _context.HsDiemTuyenSinhTrungHocPhoThongs.FindAsync(id);

            if (hsDiemTuyenSinhTrungHocPhoThong == null)
            {
                return NotFound();
            }

            return hsDiemTuyenSinhTrungHocPhoThong;
        }

        // PUT: api/HsDiemTuyenSinhTrungHocPhoThongs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDiemTuyenSinhTrungHocPhoThong(string id, HsDiemTuyenSinhTrungHocPhoThong hsDiemTuyenSinhTrungHocPhoThong)
        {
            if (id != hsDiemTuyenSinhTrungHocPhoThong.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDiemTuyenSinhTrungHocPhoThong).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDiemTuyenSinhTrungHocPhoThongExists(id))
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

        // POST: api/HsDiemTuyenSinhTrungHocPhoThongs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDiemTuyenSinhTrungHocPhoThong>> PostHsDiemTuyenSinhTrungHocPhoThong(HsDiemTuyenSinhTrungHocPhoThong hsDiemTuyenSinhTrungHocPhoThong)
        {
            _context.HsDiemTuyenSinhTrungHocPhoThongs.Add(hsDiemTuyenSinhTrungHocPhoThong);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDiemTuyenSinhTrungHocPhoThongExists(hsDiemTuyenSinhTrungHocPhoThong.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDiemTuyenSinhTrungHocPhoThong", new { id = hsDiemTuyenSinhTrungHocPhoThong.FkHocSinhId }, hsDiemTuyenSinhTrungHocPhoThong);
        }

        // DELETE: api/HsDiemTuyenSinhTrungHocPhoThongs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDiemTuyenSinhTrungHocPhoThong(string id)
        {
            var hsDiemTuyenSinhTrungHocPhoThong = await _context.HsDiemTuyenSinhTrungHocPhoThongs.FindAsync(id);
            if (hsDiemTuyenSinhTrungHocPhoThong == null)
            {
                return NotFound();
            }

            _context.HsDiemTuyenSinhTrungHocPhoThongs.Remove(hsDiemTuyenSinhTrungHocPhoThong);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDiemTuyenSinhTrungHocPhoThongExists(string id)
        {
            return _context.HsDiemTuyenSinhTrungHocPhoThongs.Any(e => e.FkHocSinhId == id);
        }
    }
}
