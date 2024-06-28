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
    public class HsHocSinhHocLucsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHocSinhHocLucsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHocSinhHocLucs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHocSinhHocLuc>>> GetHsHocSinhHocLucs()
        {
            return await _context.HsHocSinhHocLucs.ToListAsync();
        }

        // GET: api/HsHocSinhHocLucs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHocSinhHocLuc>> GetHsHocSinhHocLuc(string id)
        {
            var hsHocSinhHocLuc = await _context.HsHocSinhHocLucs.FindAsync(id);

            if (hsHocSinhHocLuc == null)
            {
                return NotFound();
            }

            return hsHocSinhHocLuc;
        }

        // PUT: api/HsHocSinhHocLucs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHocSinhHocLuc(string id, HsHocSinhHocLuc hsHocSinhHocLuc)
        {
            if (id != hsHocSinhHocLuc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHocSinhHocLuc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHocSinhHocLucExists(id))
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

        // POST: api/HsHocSinhHocLucs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHocSinhHocLuc>> PostHsHocSinhHocLuc(HsHocSinhHocLuc hsHocSinhHocLuc)
        {
            _context.HsHocSinhHocLucs.Add(hsHocSinhHocLuc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHocSinhHocLucExists(hsHocSinhHocLuc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHocSinhHocLuc", new { id = hsHocSinhHocLuc.FkHocSinhId }, hsHocSinhHocLuc);
        }

        // DELETE: api/HsHocSinhHocLucs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHocSinhHocLuc(string id)
        {
            var hsHocSinhHocLuc = await _context.HsHocSinhHocLucs.FindAsync(id);
            if (hsHocSinhHocLuc == null)
            {
                return NotFound();
            }

            _context.HsHocSinhHocLucs.Remove(hsHocSinhHocLuc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHocSinhHocLucExists(string id)
        {
            return _context.HsHocSinhHocLucs.Any(e => e.FkHocSinhId == id);
        }
    }
}
