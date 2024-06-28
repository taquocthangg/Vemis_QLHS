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
    public class HsBangDiemChiTietHocKiesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsBangDiemChiTietHocKiesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsBangDiemChiTietHocKies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsBangDiemChiTietHocKy>>> GetHsBangDiemChiTietHocKies()
        {
            return await _context.HsBangDiemChiTietHocKies.ToListAsync();
        }

        // GET: api/HsBangDiemChiTietHocKies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsBangDiemChiTietHocKy>> GetHsBangDiemChiTietHocKy(string id)
        {
            var hsBangDiemChiTietHocKy = await _context.HsBangDiemChiTietHocKies.FindAsync(id);

            if (hsBangDiemChiTietHocKy == null)
            {
                return NotFound();
            }

            return hsBangDiemChiTietHocKy;
        }

        // PUT: api/HsBangDiemChiTietHocKies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsBangDiemChiTietHocKy(string id, HsBangDiemChiTietHocKy hsBangDiemChiTietHocKy)
        {
            if (id != hsBangDiemChiTietHocKy.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsBangDiemChiTietHocKy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsBangDiemChiTietHocKyExists(id))
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

        // POST: api/HsBangDiemChiTietHocKies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsBangDiemChiTietHocKy>> PostHsBangDiemChiTietHocKy(HsBangDiemChiTietHocKy hsBangDiemChiTietHocKy)
        {
            _context.HsBangDiemChiTietHocKies.Add(hsBangDiemChiTietHocKy);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsBangDiemChiTietHocKyExists(hsBangDiemChiTietHocKy.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsBangDiemChiTietHocKy", new { id = hsBangDiemChiTietHocKy.FkHocSinhId }, hsBangDiemChiTietHocKy);
        }

        // DELETE: api/HsBangDiemChiTietHocKies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsBangDiemChiTietHocKy(string id)
        {
            var hsBangDiemChiTietHocKy = await _context.HsBangDiemChiTietHocKies.FindAsync(id);
            if (hsBangDiemChiTietHocKy == null)
            {
                return NotFound();
            }

            _context.HsBangDiemChiTietHocKies.Remove(hsBangDiemChiTietHocKy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsBangDiemChiTietHocKyExists(string id)
        {
            return _context.HsBangDiemChiTietHocKies.Any(e => e.FkHocSinhId == id);
        }
    }
}
