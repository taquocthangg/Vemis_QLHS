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
    public class HsLopHocMonChuyensController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsLopHocMonChuyensController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsLopHocMonChuyens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsLopHocMonChuyen>>> GetHsLopHocMonChuyens()
        {
            return await _context.HsLopHocMonChuyens.ToListAsync();
        }

        // GET: api/HsLopHocMonChuyens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsLopHocMonChuyen>> GetHsLopHocMonChuyen(string id)
        {
            var hsLopHocMonChuyen = await _context.HsLopHocMonChuyens.FindAsync(id);

            if (hsLopHocMonChuyen == null)
            {
                return NotFound();
            }

            return hsLopHocMonChuyen;
        }

        // PUT: api/HsLopHocMonChuyens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsLopHocMonChuyen(string id, HsLopHocMonChuyen hsLopHocMonChuyen)
        {
            if (id != hsLopHocMonChuyen.FkLopHocId)
            {
                return BadRequest();
            }

            _context.Entry(hsLopHocMonChuyen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsLopHocMonChuyenExists(id))
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

        // POST: api/HsLopHocMonChuyens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsLopHocMonChuyen>> PostHsLopHocMonChuyen(HsLopHocMonChuyen hsLopHocMonChuyen)
        {
            _context.HsLopHocMonChuyens.Add(hsLopHocMonChuyen);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsLopHocMonChuyenExists(hsLopHocMonChuyen.FkLopHocId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsLopHocMonChuyen", new { id = hsLopHocMonChuyen.FkLopHocId }, hsLopHocMonChuyen);
        }

        // DELETE: api/HsLopHocMonChuyens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsLopHocMonChuyen(string id)
        {
            var hsLopHocMonChuyen = await _context.HsLopHocMonChuyens.FindAsync(id);
            if (hsLopHocMonChuyen == null)
            {
                return NotFound();
            }

            _context.HsLopHocMonChuyens.Remove(hsLopHocMonChuyen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsLopHocMonChuyenExists(string id)
        {
            return _context.HsLopHocMonChuyens.Any(e => e.FkLopHocId == id);
        }
    }
}
