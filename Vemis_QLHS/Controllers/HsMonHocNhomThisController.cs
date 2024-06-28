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
    public class HsMonHocNhomThisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsMonHocNhomThisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsMonHocNhomThis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsMonHocNhomThi>>> GetHsMonHocNhomThis()
        {
            return await _context.HsMonHocNhomThis.ToListAsync();
        }

        // GET: api/HsMonHocNhomThis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsMonHocNhomThi>> GetHsMonHocNhomThi(string id)
        {
            var hsMonHocNhomThi = await _context.HsMonHocNhomThis.FindAsync(id);

            if (hsMonHocNhomThi == null)
            {
                return NotFound();
            }

            return hsMonHocNhomThi;
        }

        // PUT: api/HsMonHocNhomThis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsMonHocNhomThi(string id, HsMonHocNhomThi hsMonHocNhomThi)
        {
            if (id != hsMonHocNhomThi.FkNhomThiId)
            {
                return BadRequest();
            }

            _context.Entry(hsMonHocNhomThi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsMonHocNhomThiExists(id))
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

        // POST: api/HsMonHocNhomThis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsMonHocNhomThi>> PostHsMonHocNhomThi(HsMonHocNhomThi hsMonHocNhomThi)
        {
            _context.HsMonHocNhomThis.Add(hsMonHocNhomThi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsMonHocNhomThiExists(hsMonHocNhomThi.FkNhomThiId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsMonHocNhomThi", new { id = hsMonHocNhomThi.FkNhomThiId }, hsMonHocNhomThi);
        }

        // DELETE: api/HsMonHocNhomThis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsMonHocNhomThi(string id)
        {
            var hsMonHocNhomThi = await _context.HsMonHocNhomThis.FindAsync(id);
            if (hsMonHocNhomThi == null)
            {
                return NotFound();
            }

            _context.HsMonHocNhomThis.Remove(hsMonHocNhomThi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsMonHocNhomThiExists(string id)
        {
            return _context.HsMonHocNhomThis.Any(e => e.FkNhomThiId == id);
        }
    }
}
