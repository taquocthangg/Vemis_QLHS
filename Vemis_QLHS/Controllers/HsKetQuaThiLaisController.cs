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
    public class HsKetQuaThiLaisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsKetQuaThiLaisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsKetQuaThiLais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsKetQuaThiLai>>> GetHsKetQuaThiLais()
        {
            return await _context.HsKetQuaThiLais.ToListAsync();
        }

        // GET: api/HsKetQuaThiLais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsKetQuaThiLai>> GetHsKetQuaThiLai(string id)
        {
            var hsKetQuaThiLai = await _context.HsKetQuaThiLais.FindAsync(id);

            if (hsKetQuaThiLai == null)
            {
                return NotFound();
            }

            return hsKetQuaThiLai;
        }

        // PUT: api/HsKetQuaThiLais/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsKetQuaThiLai(string id, HsKetQuaThiLai hsKetQuaThiLai)
        {
            if (id != hsKetQuaThiLai.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsKetQuaThiLai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsKetQuaThiLaiExists(id))
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

        // POST: api/HsKetQuaThiLais
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsKetQuaThiLai>> PostHsKetQuaThiLai(HsKetQuaThiLai hsKetQuaThiLai)
        {
            _context.HsKetQuaThiLais.Add(hsKetQuaThiLai);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsKetQuaThiLaiExists(hsKetQuaThiLai.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsKetQuaThiLai", new { id = hsKetQuaThiLai.FkHocSinhId }, hsKetQuaThiLai);
        }

        // DELETE: api/HsKetQuaThiLais/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsKetQuaThiLai(string id)
        {
            var hsKetQuaThiLai = await _context.HsKetQuaThiLais.FindAsync(id);
            if (hsKetQuaThiLai == null)
            {
                return NotFound();
            }

            _context.HsKetQuaThiLais.Remove(hsKetQuaThiLai);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsKetQuaThiLaiExists(string id)
        {
            return _context.HsKetQuaThiLais.Any(e => e.FkHocSinhId == id);
        }
    }
}
