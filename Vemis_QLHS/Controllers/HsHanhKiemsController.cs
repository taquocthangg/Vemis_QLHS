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
    public class HsHanhKiemsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHanhKiemsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHanhKiems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHanhKiem>>> GetHsHanhKiems()
        {
            return await _context.HsHanhKiems.ToListAsync();
        }

        // GET: api/HsHanhKiems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHanhKiem>> GetHsHanhKiem(string id)
        {
            var hsHanhKiem = await _context.HsHanhKiems.FindAsync(id);

            if (hsHanhKiem == null)
            {
                return NotFound();
            }

            return hsHanhKiem;
        }

        // PUT: api/HsHanhKiems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHanhKiem(string id, HsHanhKiem hsHanhKiem)
        {
            if (id != hsHanhKiem.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHanhKiem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHanhKiemExists(id))
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

        // POST: api/HsHanhKiems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHanhKiem>> PostHsHanhKiem(HsHanhKiem hsHanhKiem)
        {
            _context.HsHanhKiems.Add(hsHanhKiem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHanhKiemExists(hsHanhKiem.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHanhKiem", new { id = hsHanhKiem.FkHocSinhId }, hsHanhKiem);
        }

        // DELETE: api/HsHanhKiems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHanhKiem(string id)
        {
            var hsHanhKiem = await _context.HsHanhKiems.FindAsync(id);
            if (hsHanhKiem == null)
            {
                return NotFound();
            }

            _context.HsHanhKiems.Remove(hsHanhKiem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHanhKiemExists(string id)
        {
            return _context.HsHanhKiems.Any(e => e.FkHocSinhId == id);
        }
    }
}
