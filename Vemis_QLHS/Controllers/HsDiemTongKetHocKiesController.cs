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
    public class HsDiemTongKetHocKiesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDiemTongKetHocKiesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDiemTongKetHocKies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDiemTongKetHocKy>>> GetHsDiemTongKetHocKies()
        {
            return await _context.HsDiemTongKetHocKies.ToListAsync();
        }

        // GET: api/HsDiemTongKetHocKies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDiemTongKetHocKy>> GetHsDiemTongKetHocKy(string id)
        {
            var hsDiemTongKetHocKy = await _context.HsDiemTongKetHocKies.FindAsync(id);

            if (hsDiemTongKetHocKy == null)
            {
                return NotFound();
            }

            return hsDiemTongKetHocKy;
        }

        // PUT: api/HsDiemTongKetHocKies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDiemTongKetHocKy(string id, HsDiemTongKetHocKy hsDiemTongKetHocKy)
        {
            if (id != hsDiemTongKetHocKy.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDiemTongKetHocKy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDiemTongKetHocKyExists(id))
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

        // POST: api/HsDiemTongKetHocKies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDiemTongKetHocKy>> PostHsDiemTongKetHocKy(HsDiemTongKetHocKy hsDiemTongKetHocKy)
        {
            _context.HsDiemTongKetHocKies.Add(hsDiemTongKetHocKy);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDiemTongKetHocKyExists(hsDiemTongKetHocKy.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDiemTongKetHocKy", new { id = hsDiemTongKetHocKy.FkHocSinhId }, hsDiemTongKetHocKy);
        }

        // DELETE: api/HsDiemTongKetHocKies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDiemTongKetHocKy(string id)
        {
            var hsDiemTongKetHocKy = await _context.HsDiemTongKetHocKies.FindAsync(id);
            if (hsDiemTongKetHocKy == null)
            {
                return NotFound();
            }

            _context.HsDiemTongKetHocKies.Remove(hsDiemTongKetHocKy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDiemTongKetHocKyExists(string id)
        {
            return _context.HsDiemTongKetHocKies.Any(e => e.FkHocSinhId == id);
        }
    }
}
