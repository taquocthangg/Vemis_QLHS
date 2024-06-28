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
    public class HsHocLucMonsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHocLucMonsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHocLucMons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHocLucMon>>> GetHsHocLucMons()
        {
            return await _context.HsHocLucMons.ToListAsync();
        }

        // GET: api/HsHocLucMons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHocLucMon>> GetHsHocLucMon(string id)
        {
            var hsHocLucMon = await _context.HsHocLucMons.FindAsync(id);

            if (hsHocLucMon == null)
            {
                return NotFound();
            }

            return hsHocLucMon;
        }

        // PUT: api/HsHocLucMons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHocLucMon(string id, HsHocLucMon hsHocLucMon)
        {
            if (id != hsHocLucMon.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHocLucMon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHocLucMonExists(id))
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

        // POST: api/HsHocLucMons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHocLucMon>> PostHsHocLucMon(HsHocLucMon hsHocLucMon)
        {
            _context.HsHocLucMons.Add(hsHocLucMon);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHocLucMonExists(hsHocLucMon.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHocLucMon", new { id = hsHocLucMon.FkHocSinhId }, hsHocLucMon);
        }

        // DELETE: api/HsHocLucMons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHocLucMon(string id)
        {
            var hsHocLucMon = await _context.HsHocLucMons.FindAsync(id);
            if (hsHocLucMon == null)
            {
                return NotFound();
            }

            _context.HsHocLucMons.Remove(hsHocLucMon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHocLucMonExists(string id)
        {
            return _context.HsHocLucMons.Any(e => e.FkHocSinhId == id);
        }
    }
}
