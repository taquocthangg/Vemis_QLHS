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
    public class HsKetQuaThiLaiMonDanhGiasController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKetQuaThiLaiMonDanhGiasController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKetQuaThiLaiMonDanhGias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKetQuaThiLaiMonDanhGium>>> GetHsKetQuaThiLaiMonDanhGia()
        {
            return await _context.HsKetQuaThiLaiMonDanhGia.ToListAsync();
        }

        // GET: api/HsKetQuaThiLaiMonDanhGias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKetQuaThiLaiMonDanhGium>> GetHsKetQuaThiLaiMonDanhGium(string id)
        {
            var hsKetQuaThiLaiMonDanhGium = await _context.HsKetQuaThiLaiMonDanhGia.FindAsync(id);

            if (hsKetQuaThiLaiMonDanhGium == null)
            {
                return NotFound();
            }

            return hsKetQuaThiLaiMonDanhGium;
        }

        // PUT: api/HsKetQuaThiLaiMonDanhGias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKetQuaThiLaiMonDanhGium(string id, HsKetQuaThiLaiMonDanhGium hsKetQuaThiLaiMonDanhGium)
        {
            if (id != hsKetQuaThiLaiMonDanhGium.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsKetQuaThiLaiMonDanhGium).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKetQuaThiLaiMonDanhGiumExists(id))
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

        // POST: api/HsKetQuaThiLaiMonDanhGias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKetQuaThiLaiMonDanhGium>> PostHsKetQuaThiLaiMonDanhGium(HsKetQuaThiLaiMonDanhGium hsKetQuaThiLaiMonDanhGium)
        {
            _context.HsKetQuaThiLaiMonDanhGia.Add(hsKetQuaThiLaiMonDanhGium);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsKetQuaThiLaiMonDanhGiumExists(hsKetQuaThiLaiMonDanhGium.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsKetQuaThiLaiMonDanhGium", new { id = hsKetQuaThiLaiMonDanhGium.FkHocSinhId }, hsKetQuaThiLaiMonDanhGium);
        }

        // DELETE: api/HsKetQuaThiLaiMonDanhGias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKetQuaThiLaiMonDanhGium(string id)
        {
            var hsKetQuaThiLaiMonDanhGium = await _context.HsKetQuaThiLaiMonDanhGia.FindAsync(id);
            if (hsKetQuaThiLaiMonDanhGium == null)
            {
                return NotFound();
            }

            _context.HsKetQuaThiLaiMonDanhGia.Remove(hsKetQuaThiLaiMonDanhGium);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKetQuaThiLaiMonDanhGiumExists(string id)
        {
            return _context.HsKetQuaThiLaiMonDanhGia.Any(e => e.FkHocSinhId == id);
        }
    }
}
