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
    public class HsChuyenCansController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsChuyenCansController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsChuyenCans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsChuyenCan>>> GetHsChuyenCans()
        {
            return await _context.HsChuyenCans.ToListAsync();
        }

        // GET: api/HsChuyenCans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsChuyenCan>> GetHsChuyenCan(string id)
        {
            var hsChuyenCan = await _context.HsChuyenCans.FindAsync(id);

            if (hsChuyenCan == null)
            {
                return NotFound();
            }

            return hsChuyenCan;
        }

        // PUT: api/HsChuyenCans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsChuyenCan(string id, HsChuyenCan hsChuyenCan)
        {
            if (id != hsChuyenCan.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsChuyenCan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsChuyenCanExists(id))
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

        // POST: api/HsChuyenCans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsChuyenCan>> PostHsChuyenCan(HsChuyenCan hsChuyenCan)
        {
            _context.HsChuyenCans.Add(hsChuyenCan);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsChuyenCanExists(hsChuyenCan.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsChuyenCan", new { id = hsChuyenCan.FkHocSinhId }, hsChuyenCan);
        }

        // DELETE: api/HsChuyenCans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsChuyenCan(string id)
        {
            var hsChuyenCan = await _context.HsChuyenCans.FindAsync(id);
            if (hsChuyenCan == null)
            {
                return NotFound();
            }

            _context.HsChuyenCans.Remove(hsChuyenCan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsChuyenCanExists(string id)
        {
            return _context.HsChuyenCans.Any(e => e.FkHocSinhId == id);
        }
    }
}
