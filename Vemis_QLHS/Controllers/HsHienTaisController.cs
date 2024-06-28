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
    public class HsHienTaisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHienTaisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHienTais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHienTai>>> GetHsHienTais()
        {
            return await _context.HsHienTais.ToListAsync();
        }

        // GET: api/HsHienTais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHienTai>> GetHsHienTai(string id)
        {
            var hsHienTai = await _context.HsHienTais.FindAsync(id);

            if (hsHienTai == null)
            {
                return NotFound();
            }

            return hsHienTai;
        }

        // PUT: api/HsHienTais/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHienTai(string id, HsHienTai hsHienTai)
        {
            if (id != hsHienTai.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHienTai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHienTaiExists(id))
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

        // POST: api/HsHienTais
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHienTai>> PostHsHienTai(HsHienTai hsHienTai)
        {
            _context.HsHienTais.Add(hsHienTai);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHienTaiExists(hsHienTai.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHienTai", new { id = hsHienTai.FkHocSinhId }, hsHienTai);
        }

        // DELETE: api/HsHienTais/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHienTai(string id)
        {
            var hsHienTai = await _context.HsHienTais.FindAsync(id);
            if (hsHienTai == null)
            {
                return NotFound();
            }

            _context.HsHienTais.Remove(hsHienTai);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHienTaiExists(string id)
        {
            return _context.HsHienTais.Any(e => e.FkHocSinhId == id);
        }
    }
}
