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
    public class HsLopHocMonMienGiamsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsLopHocMonMienGiamsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsLopHocMonMienGiams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsLopHocMonMienGiam>>> GetHsLopHocMonMienGiams()
        {
            return await _context.HsLopHocMonMienGiams.ToListAsync();
        }

        // GET: api/HsLopHocMonMienGiams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsLopHocMonMienGiam>> GetHsLopHocMonMienGiam(string id)
        {
            var hsLopHocMonMienGiam = await _context.HsLopHocMonMienGiams.FindAsync(id);

            if (hsLopHocMonMienGiam == null)
            {
                return NotFound();
            }

            return hsLopHocMonMienGiam;
        }

        // PUT: api/HsLopHocMonMienGiams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsLopHocMonMienGiam(string id, HsLopHocMonMienGiam hsLopHocMonMienGiam)
        {
            if (id != hsLopHocMonMienGiam.FkLopHocId)
            {
                return BadRequest();
            }

            _context.Entry(hsLopHocMonMienGiam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsLopHocMonMienGiamExists(id))
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

        // POST: api/HsLopHocMonMienGiams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsLopHocMonMienGiam>> PostHsLopHocMonMienGiam(HsLopHocMonMienGiam hsLopHocMonMienGiam)
        {
            _context.HsLopHocMonMienGiams.Add(hsLopHocMonMienGiam);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsLopHocMonMienGiamExists(hsLopHocMonMienGiam.FkLopHocId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsLopHocMonMienGiam", new { id = hsLopHocMonMienGiam.FkLopHocId }, hsLopHocMonMienGiam);
        }

        // DELETE: api/HsLopHocMonMienGiams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsLopHocMonMienGiam(string id)
        {
            var hsLopHocMonMienGiam = await _context.HsLopHocMonMienGiams.FindAsync(id);
            if (hsLopHocMonMienGiam == null)
            {
                return NotFound();
            }

            _context.HsLopHocMonMienGiams.Remove(hsLopHocMonMienGiam);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsLopHocMonMienGiamExists(string id)
        {
            return _context.HsLopHocMonMienGiams.Any(e => e.FkLopHocId == id);
        }
    }
}
