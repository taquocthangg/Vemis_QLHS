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
    public class HsHocSinhPhongThisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHocSinhPhongThisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHocSinhPhongThis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHocSinhPhongThi>>> GetHsHocSinhPhongThis()
        {
            return await _context.HsHocSinhPhongThis.ToListAsync();
        }

        // GET: api/HsHocSinhPhongThis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHocSinhPhongThi>> GetHsHocSinhPhongThi(string id)
        {
            var hsHocSinhPhongThi = await _context.HsHocSinhPhongThis.FindAsync(id);

            if (hsHocSinhPhongThi == null)
            {
                return NotFound();
            }

            return hsHocSinhPhongThi;
        }

        // PUT: api/HsHocSinhPhongThis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHocSinhPhongThi(string id, HsHocSinhPhongThi hsHocSinhPhongThi)
        {
            if (id != hsHocSinhPhongThi.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHocSinhPhongThi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHocSinhPhongThiExists(id))
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

        // POST: api/HsHocSinhPhongThis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHocSinhPhongThi>> PostHsHocSinhPhongThi(HsHocSinhPhongThi hsHocSinhPhongThi)
        {
            _context.HsHocSinhPhongThis.Add(hsHocSinhPhongThi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHocSinhPhongThiExists(hsHocSinhPhongThi.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHocSinhPhongThi", new { id = hsHocSinhPhongThi.FkHocSinhId }, hsHocSinhPhongThi);
        }

        // DELETE: api/HsHocSinhPhongThis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHocSinhPhongThi(string id)
        {
            var hsHocSinhPhongThi = await _context.HsHocSinhPhongThis.FindAsync(id);
            if (hsHocSinhPhongThi == null)
            {
                return NotFound();
            }

            _context.HsHocSinhPhongThis.Remove(hsHocSinhPhongThi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHocSinhPhongThiExists(string id)
        {
            return _context.HsHocSinhPhongThis.Any(e => e.FkHocSinhId == id);
        }
    }
}
