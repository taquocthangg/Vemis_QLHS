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
    public class HsHanhKiemTruocRenLuyenLaisController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHanhKiemTruocRenLuyenLaisController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHanhKiemTruocRenLuyenLais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHanhKiemTruocRenLuyenLai>>> GetHsHanhKiemTruocRenLuyenLais()
        {
            return await _context.HsHanhKiemTruocRenLuyenLais.ToListAsync();
        }

        // GET: api/HsHanhKiemTruocRenLuyenLais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHanhKiemTruocRenLuyenLai>> GetHsHanhKiemTruocRenLuyenLai(string id)
        {
            var hsHanhKiemTruocRenLuyenLai = await _context.HsHanhKiemTruocRenLuyenLais.FindAsync(id);

            if (hsHanhKiemTruocRenLuyenLai == null)
            {
                return NotFound();
            }

            return hsHanhKiemTruocRenLuyenLai;
        }

        // PUT: api/HsHanhKiemTruocRenLuyenLais/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHanhKiemTruocRenLuyenLai(string id, HsHanhKiemTruocRenLuyenLai hsHanhKiemTruocRenLuyenLai)
        {
            if (id != hsHanhKiemTruocRenLuyenLai.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHanhKiemTruocRenLuyenLai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHanhKiemTruocRenLuyenLaiExists(id))
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

        // POST: api/HsHanhKiemTruocRenLuyenLais
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHanhKiemTruocRenLuyenLai>> PostHsHanhKiemTruocRenLuyenLai(HsHanhKiemTruocRenLuyenLai hsHanhKiemTruocRenLuyenLai)
        {
            _context.HsHanhKiemTruocRenLuyenLais.Add(hsHanhKiemTruocRenLuyenLai);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHanhKiemTruocRenLuyenLaiExists(hsHanhKiemTruocRenLuyenLai.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHanhKiemTruocRenLuyenLai", new { id = hsHanhKiemTruocRenLuyenLai.FkHocSinhId }, hsHanhKiemTruocRenLuyenLai);
        }

        // DELETE: api/HsHanhKiemTruocRenLuyenLais/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHanhKiemTruocRenLuyenLai(string id)
        {
            var hsHanhKiemTruocRenLuyenLai = await _context.HsHanhKiemTruocRenLuyenLais.FindAsync(id);
            if (hsHanhKiemTruocRenLuyenLai == null)
            {
                return NotFound();
            }

            _context.HsHanhKiemTruocRenLuyenLais.Remove(hsHanhKiemTruocRenLuyenLai);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHanhKiemTruocRenLuyenLaiExists(string id)
        {
            return _context.HsHanhKiemTruocRenLuyenLais.Any(e => e.FkHocSinhId == id);
        }
    }
}
