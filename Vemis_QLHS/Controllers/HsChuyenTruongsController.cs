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
    public class HsChuyenTruongsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsChuyenTruongsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsChuyenTruongs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsChuyenTruong>>> GetHsChuyenTruongs()
        {
            return await _context.HsChuyenTruongs.ToListAsync();
        }

        // GET: api/HsChuyenTruongs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsChuyenTruong>> GetHsChuyenTruong(string id)
        {
            var hsChuyenTruong = await _context.HsChuyenTruongs.FindAsync(id);

            if (hsChuyenTruong == null)
            {
                return NotFound();
            }

            return hsChuyenTruong;
        }

        // PUT: api/HsChuyenTruongs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsChuyenTruong(string id, HsChuyenTruong hsChuyenTruong)
        {
            if (id != hsChuyenTruong.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsChuyenTruong).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsChuyenTruongExists(id))
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

        // POST: api/HsChuyenTruongs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsChuyenTruong>> PostHsChuyenTruong(HsChuyenTruong hsChuyenTruong)
        {
            _context.HsChuyenTruongs.Add(hsChuyenTruong);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsChuyenTruongExists(hsChuyenTruong.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsChuyenTruong", new { id = hsChuyenTruong.FkHocSinhId }, hsChuyenTruong);
        }

        // DELETE: api/HsChuyenTruongs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsChuyenTruong(string id)
        {
            var hsChuyenTruong = await _context.HsChuyenTruongs.FindAsync(id);
            if (hsChuyenTruong == null)
            {
                return NotFound();
            }

            _context.HsChuyenTruongs.Remove(hsChuyenTruong);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsChuyenTruongExists(string id)
        {
            return _context.HsChuyenTruongs.Any(e => e.FkHocSinhId == id);
        }
    }
}
