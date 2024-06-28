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
    public class HsDangKyOnoiTrusController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDangKyOnoiTrusController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDangKyOnoiTrus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDangKyOnoiTru>>> GetHsDangKyOnoiTrus()
        {
            return await _context.HsDangKyOnoiTrus.ToListAsync();
        }

        // GET: api/HsDangKyOnoiTrus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDangKyOnoiTru>> GetHsDangKyOnoiTru(string id)
        {
            var hsDangKyOnoiTru = await _context.HsDangKyOnoiTrus.FindAsync(id);

            if (hsDangKyOnoiTru == null)
            {
                return NotFound();
            }

            return hsDangKyOnoiTru;
        }

        // PUT: api/HsDangKyOnoiTrus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDangKyOnoiTru(string id, HsDangKyOnoiTru hsDangKyOnoiTru)
        {
            if (id != hsDangKyOnoiTru.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDangKyOnoiTru).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDangKyOnoiTruExists(id))
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

        // POST: api/HsDangKyOnoiTrus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDangKyOnoiTru>> PostHsDangKyOnoiTru(HsDangKyOnoiTru hsDangKyOnoiTru)
        {
            _context.HsDangKyOnoiTrus.Add(hsDangKyOnoiTru);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDangKyOnoiTruExists(hsDangKyOnoiTru.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDangKyOnoiTru", new { id = hsDangKyOnoiTru.FkHocSinhId }, hsDangKyOnoiTru);
        }

        // DELETE: api/HsDangKyOnoiTrus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDangKyOnoiTru(string id)
        {
            var hsDangKyOnoiTru = await _context.HsDangKyOnoiTrus.FindAsync(id);
            if (hsDangKyOnoiTru == null)
            {
                return NotFound();
            }

            _context.HsDangKyOnoiTrus.Remove(hsDangKyOnoiTru);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDangKyOnoiTruExists(string id)
        {
            return _context.HsDangKyOnoiTrus.Any(e => e.FkHocSinhId == id);
        }
    }
}
