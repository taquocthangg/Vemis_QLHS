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
    public class HsKhoiLopMonMienGiamsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKhoiLopMonMienGiamsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKhoiLopMonMienGiams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKhoiLopMonMienGiam>>> GetHsKhoiLopMonMienGiams()
        {
            return await _context.HsKhoiLopMonMienGiams.ToListAsync();
        }

        // GET: api/HsKhoiLopMonMienGiams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKhoiLopMonMienGiam>> GetHsKhoiLopMonMienGiam(string id)
        {
            var hsKhoiLopMonMienGiam = await _context.HsKhoiLopMonMienGiams.FindAsync(id);

            if (hsKhoiLopMonMienGiam == null)
            {
                return NotFound();
            }

            return hsKhoiLopMonMienGiam;
        }

        // PUT: api/HsKhoiLopMonMienGiams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKhoiLopMonMienGiam(string id, HsKhoiLopMonMienGiam hsKhoiLopMonMienGiam)
        {
            if (id != hsKhoiLopMonMienGiam.FkKhoiLopId)
            {
                return BadRequest();
            }

            _context.Entry(hsKhoiLopMonMienGiam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKhoiLopMonMienGiamExists(id))
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

        // POST: api/HsKhoiLopMonMienGiams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKhoiLopMonMienGiam>> PostHsKhoiLopMonMienGiam(HsKhoiLopMonMienGiam hsKhoiLopMonMienGiam)
        {
            _context.HsKhoiLopMonMienGiams.Add(hsKhoiLopMonMienGiam);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsKhoiLopMonMienGiamExists(hsKhoiLopMonMienGiam.FkKhoiLopId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsKhoiLopMonMienGiam", new { id = hsKhoiLopMonMienGiam.FkKhoiLopId }, hsKhoiLopMonMienGiam);
        }

        // DELETE: api/HsKhoiLopMonMienGiams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKhoiLopMonMienGiam(string id)
        {
            var hsKhoiLopMonMienGiam = await _context.HsKhoiLopMonMienGiams.FindAsync(id);
            if (hsKhoiLopMonMienGiam == null)
            {
                return NotFound();
            }

            _context.HsKhoiLopMonMienGiams.Remove(hsKhoiLopMonMienGiam);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKhoiLopMonMienGiamExists(string id)
        {
            return _context.HsKhoiLopMonMienGiams.Any(e => e.FkKhoiLopId == id);
        }
    }
}
