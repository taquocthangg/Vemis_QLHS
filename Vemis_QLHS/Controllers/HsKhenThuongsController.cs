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
    public class HsKhenThuongsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKhenThuongsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKhenThuongs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKhenThuong>>> GetHsKhenThuongs()
        {
            return await _context.HsKhenThuongs.ToListAsync();
        }

        // GET: api/HsKhenThuongs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKhenThuong>> GetHsKhenThuong(int id)
        {
            var hsKhenThuong = await _context.HsKhenThuongs.FindAsync(id);

            if (hsKhenThuong == null)
            {
                return NotFound();
            }

            return hsKhenThuong;
        }

        // PUT: api/HsKhenThuongs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKhenThuong(int id, HsKhenThuong hsKhenThuong)
        {
            if (id != hsKhenThuong.Matang)
            {
                return BadRequest();
            }

            _context.Entry(hsKhenThuong).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKhenThuongExists(id))
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

        // POST: api/HsKhenThuongs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKhenThuong>> PostHsKhenThuong(HsKhenThuong hsKhenThuong)
        {
            _context.HsKhenThuongs.Add(hsKhenThuong);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHsKhenThuong", new { id = hsKhenThuong.Matang }, hsKhenThuong);
        }

        // DELETE: api/HsKhenThuongs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKhenThuong(int id)
        {
            var hsKhenThuong = await _context.HsKhenThuongs.FindAsync(id);
            if (hsKhenThuong == null)
            {
                return NotFound();
            }

            _context.HsKhenThuongs.Remove(hsKhenThuong);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKhenThuongExists(int id)
        {
            return _context.HsKhenThuongs.Any(e => e.Matang == id);
        }
    }
}
