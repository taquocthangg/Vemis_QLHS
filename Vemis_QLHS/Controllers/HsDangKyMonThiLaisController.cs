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
    public class HsDangKyMonThiLaisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDangKyMonThiLaisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDangKyMonThiLais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDangKyMonThiLai>>> GetHsDangKyMonThiLais()
        {
            return await _context.HsDangKyMonThiLais.ToListAsync();
        }

        // GET: api/HsDangKyMonThiLais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDangKyMonThiLai>> GetHsDangKyMonThiLai(string id)
        {
            var hsDangKyMonThiLai = await _context.HsDangKyMonThiLais.FindAsync(id);

            if (hsDangKyMonThiLai == null)
            {
                return NotFound();
            }

            return hsDangKyMonThiLai;
        }

        // PUT: api/HsDangKyMonThiLais/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDangKyMonThiLai(string id, HsDangKyMonThiLai hsDangKyMonThiLai)
        {
            if (id != hsDangKyMonThiLai.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDangKyMonThiLai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDangKyMonThiLaiExists(id))
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

        // POST: api/HsDangKyMonThiLais
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDangKyMonThiLai>> PostHsDangKyMonThiLai(HsDangKyMonThiLai hsDangKyMonThiLai)
        {
            _context.HsDangKyMonThiLais.Add(hsDangKyMonThiLai);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDangKyMonThiLaiExists(hsDangKyMonThiLai.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDangKyMonThiLai", new { id = hsDangKyMonThiLai.FkHocSinhId }, hsDangKyMonThiLai);
        }

        // DELETE: api/HsDangKyMonThiLais/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDangKyMonThiLai(string id)
        {
            var hsDangKyMonThiLai = await _context.HsDangKyMonThiLais.FindAsync(id);
            if (hsDangKyMonThiLai == null)
            {
                return NotFound();
            }

            _context.HsDangKyMonThiLais.Remove(hsDangKyMonThiLai);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDangKyMonThiLaiExists(string id)
        {
            return _context.HsDangKyMonThiLais.Any(e => e.FkHocSinhId == id);
        }
    }
}
