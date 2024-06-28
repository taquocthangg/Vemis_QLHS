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
    public class HsDiemTrungBinhMonHocKiesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDiemTrungBinhMonHocKiesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDiemTrungBinhMonHocKies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDiemTrungBinhMonHocKy>>> GetHsDiemTrungBinhMonHocKies()
        {
            return await _context.HsDiemTrungBinhMonHocKies.ToListAsync();
        }

        // GET: api/HsDiemTrungBinhMonHocKies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDiemTrungBinhMonHocKy>> GetHsDiemTrungBinhMonHocKy(string id)
        {
            var hsDiemTrungBinhMonHocKy = await _context.HsDiemTrungBinhMonHocKies.FindAsync(id);

            if (hsDiemTrungBinhMonHocKy == null)
            {
                return NotFound();
            }

            return hsDiemTrungBinhMonHocKy;
        }

        // PUT: api/HsDiemTrungBinhMonHocKies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDiemTrungBinhMonHocKy(string id, HsDiemTrungBinhMonHocKy hsDiemTrungBinhMonHocKy)
        {
            if (id != hsDiemTrungBinhMonHocKy.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDiemTrungBinhMonHocKy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDiemTrungBinhMonHocKyExists(id))
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

        // POST: api/HsDiemTrungBinhMonHocKies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDiemTrungBinhMonHocKy>> PostHsDiemTrungBinhMonHocKy(HsDiemTrungBinhMonHocKy hsDiemTrungBinhMonHocKy)
        {
            _context.HsDiemTrungBinhMonHocKies.Add(hsDiemTrungBinhMonHocKy);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDiemTrungBinhMonHocKyExists(hsDiemTrungBinhMonHocKy.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDiemTrungBinhMonHocKy", new { id = hsDiemTrungBinhMonHocKy.FkHocSinhId }, hsDiemTrungBinhMonHocKy);
        }

        // DELETE: api/HsDiemTrungBinhMonHocKies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDiemTrungBinhMonHocKy(string id)
        {
            var hsDiemTrungBinhMonHocKy = await _context.HsDiemTrungBinhMonHocKies.FindAsync(id);
            if (hsDiemTrungBinhMonHocKy == null)
            {
                return NotFound();
            }

            _context.HsDiemTrungBinhMonHocKies.Remove(hsDiemTrungBinhMonHocKy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDiemTrungBinhMonHocKyExists(string id)
        {
            return _context.HsDiemTrungBinhMonHocKies.Any(e => e.FkHocSinhId == id);
        }
    }
}
