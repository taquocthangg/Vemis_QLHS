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
    public class HsDmkieuHienThiTensController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDmkieuHienThiTensController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDmkieuHienThiTens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDmkieuHienThiTen>>> GetHsDmkieuHienThiTens()
        {
            return await _context.HsDmkieuHienThiTens.ToListAsync();
        }

        // GET: api/HsDmkieuHienThiTens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDmkieuHienThiTen>> GetHsDmkieuHienThiTen(string id)
        {
            var hsDmkieuHienThiTen = await _context.HsDmkieuHienThiTens.FindAsync(id);

            if (hsDmkieuHienThiTen == null)
            {
                return NotFound();
            }

            return hsDmkieuHienThiTen;
        }

        // PUT: api/HsDmkieuHienThiTens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDmkieuHienThiTen(string id, HsDmkieuHienThiTen hsDmkieuHienThiTen)
        {
            if (id != hsDmkieuHienThiTen.KieuHienThiId)
            {
                return BadRequest();
            }

            _context.Entry(hsDmkieuHienThiTen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDmkieuHienThiTenExists(id))
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

        // POST: api/HsDmkieuHienThiTens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDmkieuHienThiTen>> PostHsDmkieuHienThiTen(HsDmkieuHienThiTen hsDmkieuHienThiTen)
        {
            _context.HsDmkieuHienThiTens.Add(hsDmkieuHienThiTen);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDmkieuHienThiTenExists(hsDmkieuHienThiTen.KieuHienThiId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDmkieuHienThiTen", new { id = hsDmkieuHienThiTen.KieuHienThiId }, hsDmkieuHienThiTen);
        }

        // DELETE: api/HsDmkieuHienThiTens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDmkieuHienThiTen(string id)
        {
            var hsDmkieuHienThiTen = await _context.HsDmkieuHienThiTens.FindAsync(id);
            if (hsDmkieuHienThiTen == null)
            {
                return NotFound();
            }

            _context.HsDmkieuHienThiTens.Remove(hsDmkieuHienThiTen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDmkieuHienThiTenExists(string id)
        {
            return _context.HsDmkieuHienThiTens.Any(e => e.KieuHienThiId == id);
        }
    }
}
