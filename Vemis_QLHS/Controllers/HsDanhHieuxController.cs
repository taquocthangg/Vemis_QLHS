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
    public class HsDanhHieuxController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDanhHieuxController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDanhHieux
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDanhHieu>>> GetHsDanhHieus()
        {
            return await _context.HsDanhHieus.ToListAsync();
        }

        // GET: api/HsDanhHieux/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDanhHieu>> GetHsDanhHieu(string id)
        {
            var hsDanhHieu = await _context.HsDanhHieus.FindAsync(id);

            if (hsDanhHieu == null)
            {
                return NotFound();
            }

            return hsDanhHieu;
        }

        // PUT: api/HsDanhHieux/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDanhHieu(string id, HsDanhHieu hsDanhHieu)
        {
            if (id != hsDanhHieu.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDanhHieu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDanhHieuExists(id))
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

        // POST: api/HsDanhHieux
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDanhHieu>> PostHsDanhHieu(HsDanhHieu hsDanhHieu)
        {
            _context.HsDanhHieus.Add(hsDanhHieu);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDanhHieuExists(hsDanhHieu.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDanhHieu", new { id = hsDanhHieu.FkHocSinhId }, hsDanhHieu);
        }

        // DELETE: api/HsDanhHieux/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDanhHieu(string id)
        {
            var hsDanhHieu = await _context.HsDanhHieus.FindAsync(id);
            if (hsDanhHieu == null)
            {
                return NotFound();
            }

            _context.HsDanhHieus.Remove(hsDanhHieu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDanhHieuExists(string id)
        {
            return _context.HsDanhHieus.Any(e => e.FkHocSinhId == id);
        }
    }
}
