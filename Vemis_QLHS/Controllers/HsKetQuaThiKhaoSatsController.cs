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
    public class HsKetQuaThiKhaoSatsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKetQuaThiKhaoSatsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKetQuaThiKhaoSats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKetQuaThiKhaoSat>>> GetHsKetQuaThiKhaoSats()
        {
            return await _context.HsKetQuaThiKhaoSats.ToListAsync();
        }

        // GET: api/HsKetQuaThiKhaoSats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKetQuaThiKhaoSat>> GetHsKetQuaThiKhaoSat(string id)
        {
            var hsKetQuaThiKhaoSat = await _context.HsKetQuaThiKhaoSats.FindAsync(id);

            if (hsKetQuaThiKhaoSat == null)
            {
                return NotFound();
            }

            return hsKetQuaThiKhaoSat;
        }

        // PUT: api/HsKetQuaThiKhaoSats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKetQuaThiKhaoSat(string id, HsKetQuaThiKhaoSat hsKetQuaThiKhaoSat)
        {
            if (id != hsKetQuaThiKhaoSat.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsKetQuaThiKhaoSat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKetQuaThiKhaoSatExists(id))
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

        // POST: api/HsKetQuaThiKhaoSats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKetQuaThiKhaoSat>> PostHsKetQuaThiKhaoSat(HsKetQuaThiKhaoSat hsKetQuaThiKhaoSat)
        {
            _context.HsKetQuaThiKhaoSats.Add(hsKetQuaThiKhaoSat);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsKetQuaThiKhaoSatExists(hsKetQuaThiKhaoSat.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsKetQuaThiKhaoSat", new { id = hsKetQuaThiKhaoSat.FkHocSinhId }, hsKetQuaThiKhaoSat);
        }

        // DELETE: api/HsKetQuaThiKhaoSats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKetQuaThiKhaoSat(string id)
        {
            var hsKetQuaThiKhaoSat = await _context.HsKetQuaThiKhaoSats.FindAsync(id);
            if (hsKetQuaThiKhaoSat == null)
            {
                return NotFound();
            }

            _context.HsKetQuaThiKhaoSats.Remove(hsKetQuaThiKhaoSat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKetQuaThiKhaoSatExists(string id)
        {
            return _context.HsKetQuaThiKhaoSats.Any(e => e.FkHocSinhId == id);
        }
    }
}
