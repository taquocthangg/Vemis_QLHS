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
    public class HsHoatDongHesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHoatDongHesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHoatDongHes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHoatDongHe>>> GetHsHoatDongHes()
        {
            return await _context.HsHoatDongHes.ToListAsync();
        }

        // GET: api/HsHoatDongHes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHoatDongHe>> GetHsHoatDongHe(string id)
        {
            var hsHoatDongHe = await _context.HsHoatDongHes.FindAsync(id);

            if (hsHoatDongHe == null)
            {
                return NotFound();
            }

            return hsHoatDongHe;
        }

        // PUT: api/HsHoatDongHes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHoatDongHe(string id, HsHoatDongHe hsHoatDongHe)
        {
            if (id != hsHoatDongHe.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHoatDongHe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHoatDongHeExists(id))
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

        // POST: api/HsHoatDongHes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHoatDongHe>> PostHsHoatDongHe(HsHoatDongHe hsHoatDongHe)
        {
            _context.HsHoatDongHes.Add(hsHoatDongHe);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHoatDongHeExists(hsHoatDongHe.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHoatDongHe", new { id = hsHoatDongHe.FkHocSinhId }, hsHoatDongHe);
        }

        // DELETE: api/HsHoatDongHes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHoatDongHe(string id)
        {
            var hsHoatDongHe = await _context.HsHoatDongHes.FindAsync(id);
            if (hsHoatDongHe == null)
            {
                return NotFound();
            }

            _context.HsHoatDongHes.Remove(hsHoatDongHe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHoatDongHeExists(string id)
        {
            return _context.HsHoatDongHes.Any(e => e.FkHocSinhId == id);
        }
    }
}
