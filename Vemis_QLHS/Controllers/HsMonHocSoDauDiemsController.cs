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
    public class HsMonHocSoDauDiemsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsMonHocSoDauDiemsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsMonHocSoDauDiems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsMonHocSoDauDiem>>> GetHsMonHocSoDauDiems()
        {
            return await _context.HsMonHocSoDauDiems.ToListAsync();
        }

        // GET: api/HsMonHocSoDauDiems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsMonHocSoDauDiem>> GetHsMonHocSoDauDiem(string id)
        {
            var hsMonHocSoDauDiem = await _context.HsMonHocSoDauDiems.FindAsync(id);

            if (hsMonHocSoDauDiem == null)
            {
                return NotFound();
            }

            return hsMonHocSoDauDiem;
        }

        // PUT: api/HsMonHocSoDauDiems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsMonHocSoDauDiem(string id, HsMonHocSoDauDiem hsMonHocSoDauDiem)
        {
            if (id != hsMonHocSoDauDiem.FkMonHocId)
            {
                return BadRequest();
            }

            _context.Entry(hsMonHocSoDauDiem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsMonHocSoDauDiemExists(id))
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

        // POST: api/HsMonHocSoDauDiems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsMonHocSoDauDiem>> PostHsMonHocSoDauDiem(HsMonHocSoDauDiem hsMonHocSoDauDiem)
        {
            _context.HsMonHocSoDauDiems.Add(hsMonHocSoDauDiem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsMonHocSoDauDiemExists(hsMonHocSoDauDiem.FkMonHocId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsMonHocSoDauDiem", new { id = hsMonHocSoDauDiem.FkMonHocId }, hsMonHocSoDauDiem);
        }

        // DELETE: api/HsMonHocSoDauDiems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsMonHocSoDauDiem(string id)
        {
            var hsMonHocSoDauDiem = await _context.HsMonHocSoDauDiems.FindAsync(id);
            if (hsMonHocSoDauDiem == null)
            {
                return NotFound();
            }

            _context.HsMonHocSoDauDiems.Remove(hsMonHocSoDauDiem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsMonHocSoDauDiemExists(string id)
        {
            return _context.HsMonHocSoDauDiems.Any(e => e.FkMonHocId == id);
        }
    }
}
