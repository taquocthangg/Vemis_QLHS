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
    public class HsLopHocMonKhuyenKhichesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsLopHocMonKhuyenKhichesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsLopHocMonKhuyenKhiches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsLopHocMonKhuyenKhich>>> GetHsLopHocMonKhuyenKhiches()
        {
            return await _context.HsLopHocMonKhuyenKhiches.ToListAsync();
        }

        // GET: api/HsLopHocMonKhuyenKhiches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsLopHocMonKhuyenKhich>> GetHsLopHocMonKhuyenKhich(string id)
        {
            var hsLopHocMonKhuyenKhich = await _context.HsLopHocMonKhuyenKhiches.FindAsync(id);

            if (hsLopHocMonKhuyenKhich == null)
            {
                return NotFound();
            }

            return hsLopHocMonKhuyenKhich;
        }

        // PUT: api/HsLopHocMonKhuyenKhiches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsLopHocMonKhuyenKhich(string id, HsLopHocMonKhuyenKhich hsLopHocMonKhuyenKhich)
        {
            if (id != hsLopHocMonKhuyenKhich.FkLopHocId)
            {
                return BadRequest();
            }

            _context.Entry(hsLopHocMonKhuyenKhich).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsLopHocMonKhuyenKhichExists(id))
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

        // POST: api/HsLopHocMonKhuyenKhiches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsLopHocMonKhuyenKhich>> PostHsLopHocMonKhuyenKhich(HsLopHocMonKhuyenKhich hsLopHocMonKhuyenKhich)
        {
            _context.HsLopHocMonKhuyenKhiches.Add(hsLopHocMonKhuyenKhich);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsLopHocMonKhuyenKhichExists(hsLopHocMonKhuyenKhich.FkLopHocId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsLopHocMonKhuyenKhich", new { id = hsLopHocMonKhuyenKhich.FkLopHocId }, hsLopHocMonKhuyenKhich);
        }

        // DELETE: api/HsLopHocMonKhuyenKhiches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsLopHocMonKhuyenKhich(string id)
        {
            var hsLopHocMonKhuyenKhich = await _context.HsLopHocMonKhuyenKhiches.FindAsync(id);
            if (hsLopHocMonKhuyenKhich == null)
            {
                return NotFound();
            }

            _context.HsLopHocMonKhuyenKhiches.Remove(hsLopHocMonKhuyenKhich);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsLopHocMonKhuyenKhichExists(string id)
        {
            return _context.HsLopHocMonKhuyenKhiches.Any(e => e.FkLopHocId == id);
        }
    }
}
