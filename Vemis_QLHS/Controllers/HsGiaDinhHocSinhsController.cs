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
    public class HsGiaDinhHocSinhsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsGiaDinhHocSinhsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsGiaDinhHocSinhs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsGiaDinhHocSinh>>> GetHsGiaDinhHocSinhs()
        {
            return await _context.HsGiaDinhHocSinhs.ToListAsync();
        }

        // GET: api/HsGiaDinhHocSinhs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsGiaDinhHocSinh>> GetHsGiaDinhHocSinh(string id)
        {
            var hsGiaDinhHocSinh = await _context.HsGiaDinhHocSinhs.FindAsync(id);

            if (hsGiaDinhHocSinh == null)
            {
                return NotFound();
            }

            return hsGiaDinhHocSinh;
        }

        // PUT: api/HsGiaDinhHocSinhs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsGiaDinhHocSinh(string id, HsGiaDinhHocSinh hsGiaDinhHocSinh)
        {
            if (id != hsGiaDinhHocSinh.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsGiaDinhHocSinh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsGiaDinhHocSinhExists(id))
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

        // POST: api/HsGiaDinhHocSinhs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsGiaDinhHocSinh>> PostHsGiaDinhHocSinh(HsGiaDinhHocSinh hsGiaDinhHocSinh)
        {
            _context.HsGiaDinhHocSinhs.Add(hsGiaDinhHocSinh);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsGiaDinhHocSinhExists(hsGiaDinhHocSinh.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsGiaDinhHocSinh", new { id = hsGiaDinhHocSinh.FkHocSinhId }, hsGiaDinhHocSinh);
        }

        // DELETE: api/HsGiaDinhHocSinhs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsGiaDinhHocSinh(string id)
        {
            var hsGiaDinhHocSinh = await _context.HsGiaDinhHocSinhs.FindAsync(id);
            if (hsGiaDinhHocSinh == null)
            {
                return NotFound();
            }

            _context.HsGiaDinhHocSinhs.Remove(hsGiaDinhHocSinh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsGiaDinhHocSinhExists(string id)
        {
            return _context.HsGiaDinhHocSinhs.Any(e => e.FkHocSinhId == id);
        }
    }
}
