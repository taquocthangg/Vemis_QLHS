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
    public class HsPhongThisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsPhongThisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsPhongThis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsPhongThi>>> GetHsPhongThis()
        {
            return await _context.HsPhongThis.ToListAsync();
        }

        // GET: api/HsPhongThis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsPhongThi>> GetHsPhongThi(string id)
        {
            var hsPhongThi = await _context.HsPhongThis.FindAsync(id);

            if (hsPhongThi == null)
            {
                return NotFound();
            }

            return hsPhongThi;
        }

        // PUT: api/HsPhongThis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsPhongThi(string id, HsPhongThi hsPhongThi)
        {
            if (id != hsPhongThi.FkNhomThiId)
            {
                return BadRequest();
            }

            _context.Entry(hsPhongThi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsPhongThiExists(id))
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

        // POST: api/HsPhongThis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsPhongThi>> PostHsPhongThi(HsPhongThi hsPhongThi)
        {
            _context.HsPhongThis.Add(hsPhongThi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsPhongThiExists(hsPhongThi.FkNhomThiId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsPhongThi", new { id = hsPhongThi.FkNhomThiId }, hsPhongThi);
        }

        // DELETE: api/HsPhongThis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsPhongThi(string id)
        {
            var hsPhongThi = await _context.HsPhongThis.FindAsync(id);
            if (hsPhongThi == null)
            {
                return NotFound();
            }

            _context.HsPhongThis.Remove(hsPhongThi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsPhongThiExists(string id)
        {
            return _context.HsPhongThis.Any(e => e.FkNhomThiId == id);
        }
    }
}
