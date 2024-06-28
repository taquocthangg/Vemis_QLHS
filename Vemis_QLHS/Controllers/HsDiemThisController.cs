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
    public class HsDiemThisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDiemThisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDiemThis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDiemThi>>> GetHsDiemThis()
        {
            return await _context.HsDiemThis.ToListAsync();
        }

        // GET: api/HsDiemThis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDiemThi>> GetHsDiemThi(string id)
        {
            var hsDiemThi = await _context.HsDiemThis.FindAsync(id);

            if (hsDiemThi == null)
            {
                return NotFound();
            }

            return hsDiemThi;
        }

        // PUT: api/HsDiemThis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDiemThi(string id, HsDiemThi hsDiemThi)
        {
            if (id != hsDiemThi.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDiemThi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDiemThiExists(id))
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

        // POST: api/HsDiemThis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDiemThi>> PostHsDiemThi(HsDiemThi hsDiemThi)
        {
            _context.HsDiemThis.Add(hsDiemThi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDiemThiExists(hsDiemThi.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDiemThi", new { id = hsDiemThi.FkHocSinhId }, hsDiemThi);
        }

        // DELETE: api/HsDiemThis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDiemThi(string id)
        {
            var hsDiemThi = await _context.HsDiemThis.FindAsync(id);
            if (hsDiemThi == null)
            {
                return NotFound();
            }

            _context.HsDiemThis.Remove(hsDiemThi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDiemThiExists(string id)
        {
            return _context.HsDiemThis.Any(e => e.FkHocSinhId == id);
        }
    }
}
