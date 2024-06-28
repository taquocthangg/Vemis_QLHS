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
    public class HsHocSinhSbdsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHocSinhSbdsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHocSinhSbds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHocSinhSbd>>> GetHsHocSinhSbds()
        {
            return await _context.HsHocSinhSbds.ToListAsync();
        }

        // GET: api/HsHocSinhSbds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHocSinhSbd>> GetHsHocSinhSbd(string id)
        {
            var hsHocSinhSbd = await _context.HsHocSinhSbds.FindAsync(id);

            if (hsHocSinhSbd == null)
            {
                return NotFound();
            }

            return hsHocSinhSbd;
        }

        // PUT: api/HsHocSinhSbds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHocSinhSbd(string id, HsHocSinhSbd hsHocSinhSbd)
        {
            if (id != hsHocSinhSbd.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHocSinhSbd).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHocSinhSbdExists(id))
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

        // POST: api/HsHocSinhSbds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHocSinhSbd>> PostHsHocSinhSbd(HsHocSinhSbd hsHocSinhSbd)
        {
            _context.HsHocSinhSbds.Add(hsHocSinhSbd);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHocSinhSbdExists(hsHocSinhSbd.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHocSinhSbd", new { id = hsHocSinhSbd.FkHocSinhId }, hsHocSinhSbd);
        }

        // DELETE: api/HsHocSinhSbds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHocSinhSbd(string id)
        {
            var hsHocSinhSbd = await _context.HsHocSinhSbds.FindAsync(id);
            if (hsHocSinhSbd == null)
            {
                return NotFound();
            }

            _context.HsHocSinhSbds.Remove(hsHocSinhSbd);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHocSinhSbdExists(string id)
        {
            return _context.HsHocSinhSbds.Any(e => e.FkHocSinhId == id);
        }
    }
}
