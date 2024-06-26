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
    public class HsAnhHocSinhsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsAnhHocSinhsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsAnhHocSinhs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsAnhHocSinh>>> GetHsAnhHocSinhs()
        {
            return await _context.HsAnhHocSinhs.ToListAsync();
        }

        // GET: api/HsAnhHocSinhs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsAnhHocSinh>> GetHsAnhHocSinh(string id)
        {
            var hsAnhHocSinh = await _context.HsAnhHocSinhs.FindAsync(id);

            if (hsAnhHocSinh == null)
            {
                return NotFound();
            }

            return hsAnhHocSinh;
        }

        // PUT: api/HsAnhHocSinhs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsAnhHocSinh(string id, HsAnhHocSinh hsAnhHocSinh)
        {
            if (id != hsAnhHocSinh.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsAnhHocSinh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsAnhHocSinhExists(id))
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

        // POST: api/HsAnhHocSinhs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsAnhHocSinh>> PostHsAnhHocSinh(HsAnhHocSinh hsAnhHocSinh)
        {
            _context.HsAnhHocSinhs.Add(hsAnhHocSinh);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsAnhHocSinhExists(hsAnhHocSinh.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsAnhHocSinh", new { id = hsAnhHocSinh.FkHocSinhId }, hsAnhHocSinh);
        }

        // DELETE: api/HsAnhHocSinhs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsAnhHocSinh(string id)
        {
            var hsAnhHocSinh = await _context.HsAnhHocSinhs.FindAsync(id);
            if (hsAnhHocSinh == null)
            {
                return NotFound();
            }

            _context.HsAnhHocSinhs.Remove(hsAnhHocSinh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsAnhHocSinhExists(string id)
        {
            return _context.HsAnhHocSinhs.Any(e => e.FkHocSinhId == id);
        }
    }
}
