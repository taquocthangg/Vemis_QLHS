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
    public class HsKetQuaRenLuyenLaiTrongHesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKetQuaRenLuyenLaiTrongHesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKetQuaRenLuyenLaiTrongHes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKetQuaRenLuyenLaiTrongHe>>> GetHsKetQuaRenLuyenLaiTrongHes()
        {
            return await _context.HsKetQuaRenLuyenLaiTrongHes.ToListAsync();
        }

        // GET: api/HsKetQuaRenLuyenLaiTrongHes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKetQuaRenLuyenLaiTrongHe>> GetHsKetQuaRenLuyenLaiTrongHe(string id)
        {
            var hsKetQuaRenLuyenLaiTrongHe = await _context.HsKetQuaRenLuyenLaiTrongHes.FindAsync(id);

            if (hsKetQuaRenLuyenLaiTrongHe == null)
            {
                return NotFound();
            }

            return hsKetQuaRenLuyenLaiTrongHe;
        }

        // PUT: api/HsKetQuaRenLuyenLaiTrongHes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKetQuaRenLuyenLaiTrongHe(string id, HsKetQuaRenLuyenLaiTrongHe hsKetQuaRenLuyenLaiTrongHe)
        {
            if (id != hsKetQuaRenLuyenLaiTrongHe.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsKetQuaRenLuyenLaiTrongHe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKetQuaRenLuyenLaiTrongHeExists(id))
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

        // POST: api/HsKetQuaRenLuyenLaiTrongHes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKetQuaRenLuyenLaiTrongHe>> PostHsKetQuaRenLuyenLaiTrongHe(HsKetQuaRenLuyenLaiTrongHe hsKetQuaRenLuyenLaiTrongHe)
        {
            _context.HsKetQuaRenLuyenLaiTrongHes.Add(hsKetQuaRenLuyenLaiTrongHe);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsKetQuaRenLuyenLaiTrongHeExists(hsKetQuaRenLuyenLaiTrongHe.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsKetQuaRenLuyenLaiTrongHe", new { id = hsKetQuaRenLuyenLaiTrongHe.FkHocSinhId }, hsKetQuaRenLuyenLaiTrongHe);
        }

        // DELETE: api/HsKetQuaRenLuyenLaiTrongHes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKetQuaRenLuyenLaiTrongHe(string id)
        {
            var hsKetQuaRenLuyenLaiTrongHe = await _context.HsKetQuaRenLuyenLaiTrongHes.FindAsync(id);
            if (hsKetQuaRenLuyenLaiTrongHe == null)
            {
                return NotFound();
            }

            _context.HsKetQuaRenLuyenLaiTrongHes.Remove(hsKetQuaRenLuyenLaiTrongHe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKetQuaRenLuyenLaiTrongHeExists(string id)
        {
            return _context.HsKetQuaRenLuyenLaiTrongHes.Any(e => e.FkHocSinhId == id);
        }
    }
}
