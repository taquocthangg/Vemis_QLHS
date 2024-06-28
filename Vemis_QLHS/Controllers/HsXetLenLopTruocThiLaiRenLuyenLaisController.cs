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
    public class HsXetLenLopTruocThiLaiRenLuyenLaisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsXetLenLopTruocThiLaiRenLuyenLaisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsXetLenLopTruocThiLaiRenLuyenLais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsXetLenLopTruocThiLaiRenLuyenLai>>> GetHsXetLenLopTruocThiLaiRenLuyenLais()
        {
            return await _context.HsXetLenLopTruocThiLaiRenLuyenLais.ToListAsync();
        }

        // GET: api/HsXetLenLopTruocThiLaiRenLuyenLais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsXetLenLopTruocThiLaiRenLuyenLai>> GetHsXetLenLopTruocThiLaiRenLuyenLai(string id)
        {
            var hsXetLenLopTruocThiLaiRenLuyenLai = await _context.HsXetLenLopTruocThiLaiRenLuyenLais.FindAsync(id);

            if (hsXetLenLopTruocThiLaiRenLuyenLai == null)
            {
                return NotFound();
            }

            return hsXetLenLopTruocThiLaiRenLuyenLai;
        }

        // PUT: api/HsXetLenLopTruocThiLaiRenLuyenLais/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsXetLenLopTruocThiLaiRenLuyenLai(string id, HsXetLenLopTruocThiLaiRenLuyenLai hsXetLenLopTruocThiLaiRenLuyenLai)
        {
            if (id != hsXetLenLopTruocThiLaiRenLuyenLai.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsXetLenLopTruocThiLaiRenLuyenLai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsXetLenLopTruocThiLaiRenLuyenLaiExists(id))
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

        // POST: api/HsXetLenLopTruocThiLaiRenLuyenLais
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsXetLenLopTruocThiLaiRenLuyenLai>> PostHsXetLenLopTruocThiLaiRenLuyenLai(HsXetLenLopTruocThiLaiRenLuyenLai hsXetLenLopTruocThiLaiRenLuyenLai)
        {
            _context.HsXetLenLopTruocThiLaiRenLuyenLais.Add(hsXetLenLopTruocThiLaiRenLuyenLai);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsXetLenLopTruocThiLaiRenLuyenLaiExists(hsXetLenLopTruocThiLaiRenLuyenLai.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsXetLenLopTruocThiLaiRenLuyenLai", new { id = hsXetLenLopTruocThiLaiRenLuyenLai.FkHocSinhId }, hsXetLenLopTruocThiLaiRenLuyenLai);
        }

        // DELETE: api/HsXetLenLopTruocThiLaiRenLuyenLais/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsXetLenLopTruocThiLaiRenLuyenLai(string id)
        {
            var hsXetLenLopTruocThiLaiRenLuyenLai = await _context.HsXetLenLopTruocThiLaiRenLuyenLais.FindAsync(id);
            if (hsXetLenLopTruocThiLaiRenLuyenLai == null)
            {
                return NotFound();
            }

            _context.HsXetLenLopTruocThiLaiRenLuyenLais.Remove(hsXetLenLopTruocThiLaiRenLuyenLai);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsXetLenLopTruocThiLaiRenLuyenLaiExists(string id)
        {
            return _context.HsXetLenLopTruocThiLaiRenLuyenLais.Any(e => e.FkHocSinhId == id);
        }
    }
}
