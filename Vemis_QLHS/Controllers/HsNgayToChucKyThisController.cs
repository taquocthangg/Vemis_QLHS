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
    public class HsNgayToChucKyThisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsNgayToChucKyThisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsNgayToChucKyThis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsNgayToChucKyThi>>> GetHsNgayToChucKyThis()
        {
            return await _context.HsNgayToChucKyThis.ToListAsync();
        }

        // GET: api/HsNgayToChucKyThis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsNgayToChucKyThi>> GetHsNgayToChucKyThi(string id)
        {
            var hsNgayToChucKyThi = await _context.HsNgayToChucKyThis.FindAsync(id);

            if (hsNgayToChucKyThi == null)
            {
                return NotFound();
            }

            return hsNgayToChucKyThi;
        }

        // PUT: api/HsNgayToChucKyThis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsNgayToChucKyThi(string id, HsNgayToChucKyThi hsNgayToChucKyThi)
        {
            if (id != hsNgayToChucKyThi.FkKyThiId)
            {
                return BadRequest();
            }

            _context.Entry(hsNgayToChucKyThi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsNgayToChucKyThiExists(id))
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

        // POST: api/HsNgayToChucKyThis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsNgayToChucKyThi>> PostHsNgayToChucKyThi(HsNgayToChucKyThi hsNgayToChucKyThi)
        {
            _context.HsNgayToChucKyThis.Add(hsNgayToChucKyThi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsNgayToChucKyThiExists(hsNgayToChucKyThi.FkKyThiId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsNgayToChucKyThi", new { id = hsNgayToChucKyThi.FkKyThiId }, hsNgayToChucKyThi);
        }

        // DELETE: api/HsNgayToChucKyThis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsNgayToChucKyThi(string id)
        {
            var hsNgayToChucKyThi = await _context.HsNgayToChucKyThis.FindAsync(id);
            if (hsNgayToChucKyThi == null)
            {
                return NotFound();
            }

            _context.HsNgayToChucKyThis.Remove(hsNgayToChucKyThi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsNgayToChucKyThiExists(string id)
        {
            return _context.HsNgayToChucKyThis.Any(e => e.FkKyThiId == id);
        }
    }
}
