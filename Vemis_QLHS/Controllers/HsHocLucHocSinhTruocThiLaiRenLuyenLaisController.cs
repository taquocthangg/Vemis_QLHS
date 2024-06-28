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
    public class HsHocLucHocSinhTruocThiLaiRenLuyenLaisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHocLucHocSinhTruocThiLaiRenLuyenLaisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHocLucHocSinhTruocThiLaiRenLuyenLais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHocLucHocSinhTruocThiLaiRenLuyenLai>>> GetHsHocLucHocSinhTruocThiLaiRenLuyenLais()
        {
            return await _context.HsHocLucHocSinhTruocThiLaiRenLuyenLais.ToListAsync();
        }

        // GET: api/HsHocLucHocSinhTruocThiLaiRenLuyenLais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHocLucHocSinhTruocThiLaiRenLuyenLai>> GetHsHocLucHocSinhTruocThiLaiRenLuyenLai(string id)
        {
            var hsHocLucHocSinhTruocThiLaiRenLuyenLai = await _context.HsHocLucHocSinhTruocThiLaiRenLuyenLais.FindAsync(id);

            if (hsHocLucHocSinhTruocThiLaiRenLuyenLai == null)
            {
                return NotFound();
            }

            return hsHocLucHocSinhTruocThiLaiRenLuyenLai;
        }

        // PUT: api/HsHocLucHocSinhTruocThiLaiRenLuyenLais/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHocLucHocSinhTruocThiLaiRenLuyenLai(string id, HsHocLucHocSinhTruocThiLaiRenLuyenLai hsHocLucHocSinhTruocThiLaiRenLuyenLai)
        {
            if (id != hsHocLucHocSinhTruocThiLaiRenLuyenLai.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHocLucHocSinhTruocThiLaiRenLuyenLai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHocLucHocSinhTruocThiLaiRenLuyenLaiExists(id))
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

        // POST: api/HsHocLucHocSinhTruocThiLaiRenLuyenLais
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHocLucHocSinhTruocThiLaiRenLuyenLai>> PostHsHocLucHocSinhTruocThiLaiRenLuyenLai(HsHocLucHocSinhTruocThiLaiRenLuyenLai hsHocLucHocSinhTruocThiLaiRenLuyenLai)
        {
            _context.HsHocLucHocSinhTruocThiLaiRenLuyenLais.Add(hsHocLucHocSinhTruocThiLaiRenLuyenLai);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHocLucHocSinhTruocThiLaiRenLuyenLaiExists(hsHocLucHocSinhTruocThiLaiRenLuyenLai.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHocLucHocSinhTruocThiLaiRenLuyenLai", new { id = hsHocLucHocSinhTruocThiLaiRenLuyenLai.FkHocSinhId }, hsHocLucHocSinhTruocThiLaiRenLuyenLai);
        }

        // DELETE: api/HsHocLucHocSinhTruocThiLaiRenLuyenLais/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHocLucHocSinhTruocThiLaiRenLuyenLai(string id)
        {
            var hsHocLucHocSinhTruocThiLaiRenLuyenLai = await _context.HsHocLucHocSinhTruocThiLaiRenLuyenLais.FindAsync(id);
            if (hsHocLucHocSinhTruocThiLaiRenLuyenLai == null)
            {
                return NotFound();
            }

            _context.HsHocLucHocSinhTruocThiLaiRenLuyenLais.Remove(hsHocLucHocSinhTruocThiLaiRenLuyenLai);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHocLucHocSinhTruocThiLaiRenLuyenLaiExists(string id)
        {
            return _context.HsHocLucHocSinhTruocThiLaiRenLuyenLais.Any(e => e.FkHocSinhId == id);
        }
    }
}
