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
    public class HsKhoiLopMonKhuyenKhichesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKhoiLopMonKhuyenKhichesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKhoiLopMonKhuyenKhiches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKhoiLopMonKhuyenKhich>>> GetHsKhoiLopMonKhuyenKhiches()
        {
            return await _context.HsKhoiLopMonKhuyenKhiches.ToListAsync();
        }

        // GET: api/HsKhoiLopMonKhuyenKhiches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKhoiLopMonKhuyenKhich>> GetHsKhoiLopMonKhuyenKhich(string id)
        {
            var hsKhoiLopMonKhuyenKhich = await _context.HsKhoiLopMonKhuyenKhiches.FindAsync(id);

            if (hsKhoiLopMonKhuyenKhich == null)
            {
                return NotFound();
            }

            return hsKhoiLopMonKhuyenKhich;
        }

        // PUT: api/HsKhoiLopMonKhuyenKhiches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKhoiLopMonKhuyenKhich(string id, HsKhoiLopMonKhuyenKhich hsKhoiLopMonKhuyenKhich)
        {
            if (id != hsKhoiLopMonKhuyenKhich.FkKhoiLopId)
            {
                return BadRequest();
            }

            _context.Entry(hsKhoiLopMonKhuyenKhich).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKhoiLopMonKhuyenKhichExists(id))
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

        // POST: api/HsKhoiLopMonKhuyenKhiches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKhoiLopMonKhuyenKhich>> PostHsKhoiLopMonKhuyenKhich(HsKhoiLopMonKhuyenKhich hsKhoiLopMonKhuyenKhich)
        {
            _context.HsKhoiLopMonKhuyenKhiches.Add(hsKhoiLopMonKhuyenKhich);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsKhoiLopMonKhuyenKhichExists(hsKhoiLopMonKhuyenKhich.FkKhoiLopId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsKhoiLopMonKhuyenKhich", new { id = hsKhoiLopMonKhuyenKhich.FkKhoiLopId }, hsKhoiLopMonKhuyenKhich);
        }

        // DELETE: api/HsKhoiLopMonKhuyenKhiches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKhoiLopMonKhuyenKhich(string id)
        {
            var hsKhoiLopMonKhuyenKhich = await _context.HsKhoiLopMonKhuyenKhiches.FindAsync(id);
            if (hsKhoiLopMonKhuyenKhich == null)
            {
                return NotFound();
            }

            _context.HsKhoiLopMonKhuyenKhiches.Remove(hsKhoiLopMonKhuyenKhich);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKhoiLopMonKhuyenKhichExists(string id)
        {
            return _context.HsKhoiLopMonKhuyenKhiches.Any(e => e.FkKhoiLopId == id);
        }
    }
}
