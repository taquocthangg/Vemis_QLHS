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
    public class HsLopHocMonNgoaiNgusController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsLopHocMonNgoaiNgusController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsLopHocMonNgoaiNgus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsLopHocMonNgoaiNgu>>> GetHsLopHocMonNgoaiNgus()
        {
            return await _context.HsLopHocMonNgoaiNgus.ToListAsync();
        }

        // GET: api/HsLopHocMonNgoaiNgus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsLopHocMonNgoaiNgu>> GetHsLopHocMonNgoaiNgu(string id)
        {
            var hsLopHocMonNgoaiNgu = await _context.HsLopHocMonNgoaiNgus.FindAsync(id);

            if (hsLopHocMonNgoaiNgu == null)
            {
                return NotFound();
            }

            return hsLopHocMonNgoaiNgu;
        }

        // PUT: api/HsLopHocMonNgoaiNgus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsLopHocMonNgoaiNgu(string id, HsLopHocMonNgoaiNgu hsLopHocMonNgoaiNgu)
        {
            if (id != hsLopHocMonNgoaiNgu.FkLopHocId)
            {
                return BadRequest();
            }

            _context.Entry(hsLopHocMonNgoaiNgu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsLopHocMonNgoaiNguExists(id))
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

        // POST: api/HsLopHocMonNgoaiNgus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsLopHocMonNgoaiNgu>> PostHsLopHocMonNgoaiNgu(HsLopHocMonNgoaiNgu hsLopHocMonNgoaiNgu)
        {
            _context.HsLopHocMonNgoaiNgus.Add(hsLopHocMonNgoaiNgu);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsLopHocMonNgoaiNguExists(hsLopHocMonNgoaiNgu.FkLopHocId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsLopHocMonNgoaiNgu", new { id = hsLopHocMonNgoaiNgu.FkLopHocId }, hsLopHocMonNgoaiNgu);
        }

        // DELETE: api/HsLopHocMonNgoaiNgus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsLopHocMonNgoaiNgu(string id)
        {
            var hsLopHocMonNgoaiNgu = await _context.HsLopHocMonNgoaiNgus.FindAsync(id);
            if (hsLopHocMonNgoaiNgu == null)
            {
                return NotFound();
            }

            _context.HsLopHocMonNgoaiNgus.Remove(hsLopHocMonNgoaiNgu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsLopHocMonNgoaiNguExists(string id)
        {
            return _context.HsLopHocMonNgoaiNgus.Any(e => e.FkLopHocId == id);
        }
    }
}
