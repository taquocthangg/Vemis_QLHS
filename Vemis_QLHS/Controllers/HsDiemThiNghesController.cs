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
    public class HsDiemThiNghesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDiemThiNghesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDiemThiNghes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDiemThiNghe>>> GetHsDiemThiNghes()
        {
            return await _context.HsDiemThiNghes.ToListAsync();
        }

        // GET: api/HsDiemThiNghes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDiemThiNghe>> GetHsDiemThiNghe(string id)
        {
            var hsDiemThiNghe = await _context.HsDiemThiNghes.FindAsync(id);

            if (hsDiemThiNghe == null)
            {
                return NotFound();
            }

            return hsDiemThiNghe;
        }

        // PUT: api/HsDiemThiNghes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDiemThiNghe(string id, HsDiemThiNghe hsDiemThiNghe)
        {
            if (id != hsDiemThiNghe.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDiemThiNghe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDiemThiNgheExists(id))
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

        // POST: api/HsDiemThiNghes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDiemThiNghe>> PostHsDiemThiNghe(HsDiemThiNghe hsDiemThiNghe)
        {
            _context.HsDiemThiNghes.Add(hsDiemThiNghe);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDiemThiNgheExists(hsDiemThiNghe.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDiemThiNghe", new { id = hsDiemThiNghe.FkHocSinhId }, hsDiemThiNghe);
        }

        // DELETE: api/HsDiemThiNghes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDiemThiNghe(string id)
        {
            var hsDiemThiNghe = await _context.HsDiemThiNghes.FindAsync(id);
            if (hsDiemThiNghe == null)
            {
                return NotFound();
            }

            _context.HsDiemThiNghes.Remove(hsDiemThiNghe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDiemThiNgheExists(string id)
        {
            return _context.HsDiemThiNghes.Any(e => e.FkHocSinhId == id);
        }
    }
}
