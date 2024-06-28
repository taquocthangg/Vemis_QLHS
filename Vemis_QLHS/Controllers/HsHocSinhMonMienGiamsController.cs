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
    public class HsHocSinhMonMienGiamsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHocSinhMonMienGiamsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHocSinhMonMienGiams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHocSinhMonMienGiam>>> GetHsHocSinhMonMienGiams()
        {
            return await _context.HsHocSinhMonMienGiams.ToListAsync();
        }

        // GET: api/HsHocSinhMonMienGiams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHocSinhMonMienGiam>> GetHsHocSinhMonMienGiam(string id)
        {
            var hsHocSinhMonMienGiam = await _context.HsHocSinhMonMienGiams.FindAsync(id);

            if (hsHocSinhMonMienGiam == null)
            {
                return NotFound();
            }

            return hsHocSinhMonMienGiam;
        }

        // PUT: api/HsHocSinhMonMienGiams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHocSinhMonMienGiam(string id, HsHocSinhMonMienGiam hsHocSinhMonMienGiam)
        {
            if (id != hsHocSinhMonMienGiam.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHocSinhMonMienGiam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHocSinhMonMienGiamExists(id))
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

        // POST: api/HsHocSinhMonMienGiams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHocSinhMonMienGiam>> PostHsHocSinhMonMienGiam(HsHocSinhMonMienGiam hsHocSinhMonMienGiam)
        {
            _context.HsHocSinhMonMienGiams.Add(hsHocSinhMonMienGiam);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHocSinhMonMienGiamExists(hsHocSinhMonMienGiam.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHocSinhMonMienGiam", new { id = hsHocSinhMonMienGiam.FkHocSinhId }, hsHocSinhMonMienGiam);
        }

        // DELETE: api/HsHocSinhMonMienGiams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHocSinhMonMienGiam(string id)
        {
            var hsHocSinhMonMienGiam = await _context.HsHocSinhMonMienGiams.FindAsync(id);
            if (hsHocSinhMonMienGiam == null)
            {
                return NotFound();
            }

            _context.HsHocSinhMonMienGiams.Remove(hsHocSinhMonMienGiam);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHocSinhMonMienGiamExists(string id)
        {
            return _context.HsHocSinhMonMienGiams.Any(e => e.FkHocSinhId == id);
        }
    }
}
