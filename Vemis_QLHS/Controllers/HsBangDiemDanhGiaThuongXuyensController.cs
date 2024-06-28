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
    public class HsBangDiemDanhGiaThuongXuyensController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsBangDiemDanhGiaThuongXuyensController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsBangDiemDanhGiaThuongXuyens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsBangDiemDanhGiaThuongXuyen>>> GetHsBangDiemDanhGiaThuongXuyens()
        {
            return await _context.HsBangDiemDanhGiaThuongXuyens.ToListAsync();
        }

        // GET: api/HsBangDiemDanhGiaThuongXuyens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsBangDiemDanhGiaThuongXuyen>> GetHsBangDiemDanhGiaThuongXuyen(string id)
        {
            var hsBangDiemDanhGiaThuongXuyen = await _context.HsBangDiemDanhGiaThuongXuyens.FindAsync(id);

            if (hsBangDiemDanhGiaThuongXuyen == null)
            {
                return NotFound();
            }

            return hsBangDiemDanhGiaThuongXuyen;
        }

        // PUT: api/HsBangDiemDanhGiaThuongXuyens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsBangDiemDanhGiaThuongXuyen(string id, HsBangDiemDanhGiaThuongXuyen hsBangDiemDanhGiaThuongXuyen)
        {
            if (id != hsBangDiemDanhGiaThuongXuyen.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsBangDiemDanhGiaThuongXuyen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsBangDiemDanhGiaThuongXuyenExists(id))
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

        // POST: api/HsBangDiemDanhGiaThuongXuyens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsBangDiemDanhGiaThuongXuyen>> PostHsBangDiemDanhGiaThuongXuyen(HsBangDiemDanhGiaThuongXuyen hsBangDiemDanhGiaThuongXuyen)
        {
            _context.HsBangDiemDanhGiaThuongXuyens.Add(hsBangDiemDanhGiaThuongXuyen);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsBangDiemDanhGiaThuongXuyenExists(hsBangDiemDanhGiaThuongXuyen.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsBangDiemDanhGiaThuongXuyen", new { id = hsBangDiemDanhGiaThuongXuyen.FkHocSinhId }, hsBangDiemDanhGiaThuongXuyen);
        }

        // DELETE: api/HsBangDiemDanhGiaThuongXuyens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsBangDiemDanhGiaThuongXuyen(string id)
        {
            var hsBangDiemDanhGiaThuongXuyen = await _context.HsBangDiemDanhGiaThuongXuyens.FindAsync(id);
            if (hsBangDiemDanhGiaThuongXuyen == null)
            {
                return NotFound();
            }

            _context.HsBangDiemDanhGiaThuongXuyens.Remove(hsBangDiemDanhGiaThuongXuyen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsBangDiemDanhGiaThuongXuyenExists(string id)
        {
            return _context.HsBangDiemDanhGiaThuongXuyens.Any(e => e.FkHocSinhId == id);
        }
    }
}
