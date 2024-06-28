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
    public class HsDangKyLopChuyensController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDangKyLopChuyensController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDangKyLopChuyens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDangKyLopChuyen>>> GetHsDangKyLopChuyens()
        {
            return await _context.HsDangKyLopChuyens.ToListAsync();
        }

        // GET: api/HsDangKyLopChuyens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDangKyLopChuyen>> GetHsDangKyLopChuyen(string id)
        {
            var hsDangKyLopChuyen = await _context.HsDangKyLopChuyens.FindAsync(id);

            if (hsDangKyLopChuyen == null)
            {
                return NotFound();
            }

            return hsDangKyLopChuyen;
        }

        // PUT: api/HsDangKyLopChuyens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDangKyLopChuyen(string id, HsDangKyLopChuyen hsDangKyLopChuyen)
        {
            if (id != hsDangKyLopChuyen.FkLopHocId)
            {
                return BadRequest();
            }

            _context.Entry(hsDangKyLopChuyen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDangKyLopChuyenExists(id))
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

        // POST: api/HsDangKyLopChuyens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDangKyLopChuyen>> PostHsDangKyLopChuyen(HsDangKyLopChuyen hsDangKyLopChuyen)
        {
            _context.HsDangKyLopChuyens.Add(hsDangKyLopChuyen);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDangKyLopChuyenExists(hsDangKyLopChuyen.FkLopHocId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDangKyLopChuyen", new { id = hsDangKyLopChuyen.FkLopHocId }, hsDangKyLopChuyen);
        }

        // DELETE: api/HsDangKyLopChuyens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDangKyLopChuyen(string id)
        {
            var hsDangKyLopChuyen = await _context.HsDangKyLopChuyens.FindAsync(id);
            if (hsDangKyLopChuyen == null)
            {
                return NotFound();
            }

            _context.HsDangKyLopChuyens.Remove(hsDangKyLopChuyen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDangKyLopChuyenExists(string id)
        {
            return _context.HsDangKyLopChuyens.Any(e => e.FkLopHocId == id);
        }
    }
}
