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
    public class HsHocSinhBoThisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHocSinhBoThisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHocSinhBoThis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHocSinhBoThi>>> GetHsHocSinhBoThis()
        {
            return await _context.HsHocSinhBoThis.ToListAsync();
        }

        // GET: api/HsHocSinhBoThis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHocSinhBoThi>> GetHsHocSinhBoThi(string id)
        {
            var hsHocSinhBoThi = await _context.HsHocSinhBoThis.FindAsync(id);

            if (hsHocSinhBoThi == null)
            {
                return NotFound();
            }

            return hsHocSinhBoThi;
        }

        // PUT: api/HsHocSinhBoThis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHocSinhBoThi(string id, HsHocSinhBoThi hsHocSinhBoThi)
        {
            if (id != hsHocSinhBoThi.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHocSinhBoThi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHocSinhBoThiExists(id))
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

        // POST: api/HsHocSinhBoThis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHocSinhBoThi>> PostHsHocSinhBoThi(HsHocSinhBoThi hsHocSinhBoThi)
        {
            _context.HsHocSinhBoThis.Add(hsHocSinhBoThi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHocSinhBoThiExists(hsHocSinhBoThi.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHocSinhBoThi", new { id = hsHocSinhBoThi.FkHocSinhId }, hsHocSinhBoThi);
        }

        // DELETE: api/HsHocSinhBoThis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHocSinhBoThi(string id)
        {
            var hsHocSinhBoThi = await _context.HsHocSinhBoThis.FindAsync(id);
            if (hsHocSinhBoThi == null)
            {
                return NotFound();
            }

            _context.HsHocSinhBoThis.Remove(hsHocSinhBoThi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHocSinhBoThiExists(string id)
        {
            return _context.HsHocSinhBoThis.Any(e => e.FkHocSinhId == id);
        }
    }
}
