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
    public class HsKetQuaMonKhuyenKhichesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKetQuaMonKhuyenKhichesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKetQuaMonKhuyenKhiches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKetQuaMonKhuyenKhich>>> GetHsKetQuaMonKhuyenKhiches()
        {
            return await _context.HsKetQuaMonKhuyenKhiches.ToListAsync();
        }

        // GET: api/HsKetQuaMonKhuyenKhiches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKetQuaMonKhuyenKhich>> GetHsKetQuaMonKhuyenKhich(string id)
        {
            var hsKetQuaMonKhuyenKhich = await _context.HsKetQuaMonKhuyenKhiches.FindAsync(id);

            if (hsKetQuaMonKhuyenKhich == null)
            {
                return NotFound();
            }

            return hsKetQuaMonKhuyenKhich;
        }

        // PUT: api/HsKetQuaMonKhuyenKhiches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKetQuaMonKhuyenKhich(string id, HsKetQuaMonKhuyenKhich hsKetQuaMonKhuyenKhich)
        {
            if (id != hsKetQuaMonKhuyenKhich.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsKetQuaMonKhuyenKhich).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKetQuaMonKhuyenKhichExists(id))
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

        // POST: api/HsKetQuaMonKhuyenKhiches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKetQuaMonKhuyenKhich>> PostHsKetQuaMonKhuyenKhich(HsKetQuaMonKhuyenKhich hsKetQuaMonKhuyenKhich)
        {
            _context.HsKetQuaMonKhuyenKhiches.Add(hsKetQuaMonKhuyenKhich);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsKetQuaMonKhuyenKhichExists(hsKetQuaMonKhuyenKhich.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsKetQuaMonKhuyenKhich", new { id = hsKetQuaMonKhuyenKhich.FkHocSinhId }, hsKetQuaMonKhuyenKhich);
        }

        // DELETE: api/HsKetQuaMonKhuyenKhiches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKetQuaMonKhuyenKhich(string id)
        {
            var hsKetQuaMonKhuyenKhich = await _context.HsKetQuaMonKhuyenKhiches.FindAsync(id);
            if (hsKetQuaMonKhuyenKhich == null)
            {
                return NotFound();
            }

            _context.HsKetQuaMonKhuyenKhiches.Remove(hsKetQuaMonKhuyenKhich);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKetQuaMonKhuyenKhichExists(string id)
        {
            return _context.HsKetQuaMonKhuyenKhiches.Any(e => e.FkHocSinhId == id);
        }
    }
}
