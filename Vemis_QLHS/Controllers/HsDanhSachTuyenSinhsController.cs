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
    public class HsDanhSachTuyenSinhsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDanhSachTuyenSinhsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDanhSachTuyenSinhs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDanhSachTuyenSinh>>> GetHsDanhSachTuyenSinhs()
        {
            return await _context.HsDanhSachTuyenSinhs.ToListAsync();
        }

        // GET: api/HsDanhSachTuyenSinhs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDanhSachTuyenSinh>> GetHsDanhSachTuyenSinh(string id)
        {
            var hsDanhSachTuyenSinh = await _context.HsDanhSachTuyenSinhs.FindAsync(id);

            if (hsDanhSachTuyenSinh == null)
            {
                return NotFound();
            }

            return hsDanhSachTuyenSinh;
        }

        // PUT: api/HsDanhSachTuyenSinhs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDanhSachTuyenSinh(string id, HsDanhSachTuyenSinh hsDanhSachTuyenSinh)
        {
            if (id != hsDanhSachTuyenSinh.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDanhSachTuyenSinh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDanhSachTuyenSinhExists(id))
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

        // POST: api/HsDanhSachTuyenSinhs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDanhSachTuyenSinh>> PostHsDanhSachTuyenSinh(HsDanhSachTuyenSinh hsDanhSachTuyenSinh)
        {
            _context.HsDanhSachTuyenSinhs.Add(hsDanhSachTuyenSinh);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDanhSachTuyenSinhExists(hsDanhSachTuyenSinh.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDanhSachTuyenSinh", new { id = hsDanhSachTuyenSinh.FkHocSinhId }, hsDanhSachTuyenSinh);
        }

        // DELETE: api/HsDanhSachTuyenSinhs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDanhSachTuyenSinh(string id)
        {
            var hsDanhSachTuyenSinh = await _context.HsDanhSachTuyenSinhs.FindAsync(id);
            if (hsDanhSachTuyenSinh == null)
            {
                return NotFound();
            }

            _context.HsDanhSachTuyenSinhs.Remove(hsDanhSachTuyenSinh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDanhSachTuyenSinhExists(string id)
        {
            return _context.HsDanhSachTuyenSinhs.Any(e => e.FkHocSinhId == id);
        }
    }
}
