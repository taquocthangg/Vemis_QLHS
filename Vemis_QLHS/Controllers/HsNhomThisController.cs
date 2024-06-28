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
    public class HsNhomThisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsNhomThisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsNhomThis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsNhomThi>>> GetHsNhomThis()
        {
            return await _context.HsNhomThis.ToListAsync();
        }

        // GET: api/HsNhomThis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsNhomThi>> GetHsNhomThi(string id)
        {
            var hsNhomThi = await _context.HsNhomThis.FindAsync(id);

            if (hsNhomThi == null)
            {
                return NotFound();
            }

            return hsNhomThi;
        }

        // PUT: api/HsNhomThis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsNhomThi(string id, HsNhomThi hsNhomThi)
        {
            if (id != hsNhomThi.NhomThiId)
            {
                return BadRequest();
            }

            _context.Entry(hsNhomThi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsNhomThiExists(id))
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

        // POST: api/HsNhomThis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsNhomThi>> PostHsNhomThi(HsNhomThi hsNhomThi)
        {
            _context.HsNhomThis.Add(hsNhomThi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsNhomThiExists(hsNhomThi.NhomThiId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsNhomThi", new { id = hsNhomThi.NhomThiId }, hsNhomThi);
        }

        // DELETE: api/HsNhomThis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsNhomThi(string id)
        {
            var hsNhomThi = await _context.HsNhomThis.FindAsync(id);
            if (hsNhomThi == null)
            {
                return NotFound();
            }

            _context.HsNhomThis.Remove(hsNhomThi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsNhomThiExists(string id)
        {
            return _context.HsNhomThis.Any(e => e.NhomThiId == id);
        }
    }
}
