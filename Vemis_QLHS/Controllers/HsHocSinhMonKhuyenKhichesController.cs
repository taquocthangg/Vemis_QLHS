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
    public class HsHocSinhMonKhuyenKhichesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHocSinhMonKhuyenKhichesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHocSinhMonKhuyenKhiches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHocSinhMonKhuyenKhich>>> GetHsHocSinhMonKhuyenKhiches()
        {
            return await _context.HsHocSinhMonKhuyenKhiches.ToListAsync();
        }

        // GET: api/HsHocSinhMonKhuyenKhiches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHocSinhMonKhuyenKhich>> GetHsHocSinhMonKhuyenKhich(string id)
        {
            var hsHocSinhMonKhuyenKhich = await _context.HsHocSinhMonKhuyenKhiches.FindAsync(id);

            if (hsHocSinhMonKhuyenKhich == null)
            {
                return NotFound();
            }

            return hsHocSinhMonKhuyenKhich;
        }

        // PUT: api/HsHocSinhMonKhuyenKhiches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHocSinhMonKhuyenKhich(string id, HsHocSinhMonKhuyenKhich hsHocSinhMonKhuyenKhich)
        {
            if (id != hsHocSinhMonKhuyenKhich.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHocSinhMonKhuyenKhich).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHocSinhMonKhuyenKhichExists(id))
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

        // POST: api/HsHocSinhMonKhuyenKhiches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHocSinhMonKhuyenKhich>> PostHsHocSinhMonKhuyenKhich(HsHocSinhMonKhuyenKhich hsHocSinhMonKhuyenKhich)
        {
            _context.HsHocSinhMonKhuyenKhiches.Add(hsHocSinhMonKhuyenKhich);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHocSinhMonKhuyenKhichExists(hsHocSinhMonKhuyenKhich.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHocSinhMonKhuyenKhich", new { id = hsHocSinhMonKhuyenKhich.FkHocSinhId }, hsHocSinhMonKhuyenKhich);
        }

        // DELETE: api/HsHocSinhMonKhuyenKhiches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHocSinhMonKhuyenKhich(string id)
        {
            var hsHocSinhMonKhuyenKhich = await _context.HsHocSinhMonKhuyenKhiches.FindAsync(id);
            if (hsHocSinhMonKhuyenKhich == null)
            {
                return NotFound();
            }

            _context.HsHocSinhMonKhuyenKhiches.Remove(hsHocSinhMonKhuyenKhich);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHocSinhMonKhuyenKhichExists(string id)
        {
            return _context.HsHocSinhMonKhuyenKhiches.Any(e => e.FkHocSinhId == id);
        }
    }
}
