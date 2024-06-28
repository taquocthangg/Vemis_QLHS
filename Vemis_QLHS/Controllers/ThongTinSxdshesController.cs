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
    public class ThongTinSxdshesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public ThongTinSxdshesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/ThongTinSxdshes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThongTinSxdsh>>> GetThongTinSxdshs()
        {
            return await _context.ThongTinSxdshs.ToListAsync();
        }

        // GET: api/ThongTinSxdshes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ThongTinSxdsh>> GetThongTinSxdsh(string id)
        {
            var thongTinSxdsh = await _context.ThongTinSxdshs.FindAsync(id);

            if (thongTinSxdsh == null)
            {
                return NotFound();
            }

            return thongTinSxdsh;
        }

        // PUT: api/ThongTinSxdshes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThongTinSxdsh(string id, ThongTinSxdsh thongTinSxdsh)
        {
            if (id != thongTinSxdsh.FkLopHocId)
            {
                return BadRequest();
            }

            _context.Entry(thongTinSxdsh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThongTinSxdshExists(id))
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

        // POST: api/ThongTinSxdshes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ThongTinSxdsh>> PostThongTinSxdsh(ThongTinSxdsh thongTinSxdsh)
        {
            _context.ThongTinSxdshs.Add(thongTinSxdsh);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ThongTinSxdshExists(thongTinSxdsh.FkLopHocId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetThongTinSxdsh", new { id = thongTinSxdsh.FkLopHocId }, thongTinSxdsh);
        }

        // DELETE: api/ThongTinSxdshes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThongTinSxdsh(string id)
        {
            var thongTinSxdsh = await _context.ThongTinSxdshs.FindAsync(id);
            if (thongTinSxdsh == null)
            {
                return NotFound();
            }

            _context.ThongTinSxdshs.Remove(thongTinSxdsh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ThongTinSxdshExists(string id)
        {
            return _context.ThongTinSxdshs.Any(e => e.FkLopHocId == id);
        }
    }
}
