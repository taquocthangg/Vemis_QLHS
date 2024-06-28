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
    public class HsHocSinhNhomThisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHocSinhNhomThisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHocSinhNhomThis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHocSinhNhomThi>>> GetHsHocSinhNhomThis()
        {
            return await _context.HsHocSinhNhomThis.ToListAsync();
        }

        // GET: api/HsHocSinhNhomThis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHocSinhNhomThi>> GetHsHocSinhNhomThi(string id)
        {
            var hsHocSinhNhomThi = await _context.HsHocSinhNhomThis.FindAsync(id);

            if (hsHocSinhNhomThi == null)
            {
                return NotFound();
            }

            return hsHocSinhNhomThi;
        }

        // PUT: api/HsHocSinhNhomThis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHocSinhNhomThi(string id, HsHocSinhNhomThi hsHocSinhNhomThi)
        {
            if (id != hsHocSinhNhomThi.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHocSinhNhomThi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHocSinhNhomThiExists(id))
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

        // POST: api/HsHocSinhNhomThis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHocSinhNhomThi>> PostHsHocSinhNhomThi(HsHocSinhNhomThi hsHocSinhNhomThi)
        {
            _context.HsHocSinhNhomThis.Add(hsHocSinhNhomThi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHocSinhNhomThiExists(hsHocSinhNhomThi.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHocSinhNhomThi", new { id = hsHocSinhNhomThi.FkHocSinhId }, hsHocSinhNhomThi);
        }

        // DELETE: api/HsHocSinhNhomThis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHocSinhNhomThi(string id)
        {
            var hsHocSinhNhomThi = await _context.HsHocSinhNhomThis.FindAsync(id);
            if (hsHocSinhNhomThi == null)
            {
                return NotFound();
            }

            _context.HsHocSinhNhomThis.Remove(hsHocSinhNhomThi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHocSinhNhomThiExists(string id)
        {
            return _context.HsHocSinhNhomThis.Any(e => e.FkHocSinhId == id);
        }
    }
}
