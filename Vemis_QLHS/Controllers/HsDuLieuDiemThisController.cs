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
    public class HsDuLieuDiemThisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDuLieuDiemThisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDuLieuDiemThis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDuLieuDiemThi>>> GetHsDuLieuDiemThis()
        {
            return await _context.HsDuLieuDiemThis.ToListAsync();
        }

        // GET: api/HsDuLieuDiemThis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDuLieuDiemThi>> GetHsDuLieuDiemThi(string id)
        {
            var hsDuLieuDiemThi = await _context.HsDuLieuDiemThis.FindAsync(id);

            if (hsDuLieuDiemThi == null)
            {
                return NotFound();
            }

            return hsDuLieuDiemThi;
        }

        // PUT: api/HsDuLieuDiemThis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDuLieuDiemThi(string id, HsDuLieuDiemThi hsDuLieuDiemThi)
        {
            if (id != hsDuLieuDiemThi.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDuLieuDiemThi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDuLieuDiemThiExists(id))
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

        // POST: api/HsDuLieuDiemThis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDuLieuDiemThi>> PostHsDuLieuDiemThi(HsDuLieuDiemThi hsDuLieuDiemThi)
        {
            _context.HsDuLieuDiemThis.Add(hsDuLieuDiemThi);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDuLieuDiemThiExists(hsDuLieuDiemThi.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDuLieuDiemThi", new { id = hsDuLieuDiemThi.FkHocSinhId }, hsDuLieuDiemThi);
        }

        // DELETE: api/HsDuLieuDiemThis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDuLieuDiemThi(string id)
        {
            var hsDuLieuDiemThi = await _context.HsDuLieuDiemThis.FindAsync(id);
            if (hsDuLieuDiemThi == null)
            {
                return NotFound();
            }

            _context.HsDuLieuDiemThis.Remove(hsDuLieuDiemThi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDuLieuDiemThiExists(string id)
        {
            return _context.HsDuLieuDiemThis.Any(e => e.FkHocSinhId == id);
        }
    }
}
