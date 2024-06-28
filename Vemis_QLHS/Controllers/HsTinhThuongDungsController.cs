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
    public class HsTinhThuongDungsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsTinhThuongDungsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsTinhThuongDungs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsTinhThuongDung>>> GetHsTinhThuongDungs()
        {
            return await _context.HsTinhThuongDungs.ToListAsync();
        }

        // GET: api/HsTinhThuongDungs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsTinhThuongDung>> GetHsTinhThuongDung(string id)
        {
            var hsTinhThuongDung = await _context.HsTinhThuongDungs.FindAsync(id);

            if (hsTinhThuongDung == null)
            {
                return NotFound();
            }

            return hsTinhThuongDung;
        }

        // PUT: api/HsTinhThuongDungs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsTinhThuongDung(string id, HsTinhThuongDung hsTinhThuongDung)
        {
            if (id != hsTinhThuongDung.TinhThuongDungId)
            {
                return BadRequest();
            }

            _context.Entry(hsTinhThuongDung).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsTinhThuongDungExists(id))
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

        // POST: api/HsTinhThuongDungs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsTinhThuongDung>> PostHsTinhThuongDung(HsTinhThuongDung hsTinhThuongDung)
        {
            _context.HsTinhThuongDungs.Add(hsTinhThuongDung);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsTinhThuongDungExists(hsTinhThuongDung.TinhThuongDungId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsTinhThuongDung", new { id = hsTinhThuongDung.TinhThuongDungId }, hsTinhThuongDung);
        }

        // DELETE: api/HsTinhThuongDungs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsTinhThuongDung(string id)
        {
            var hsTinhThuongDung = await _context.HsTinhThuongDungs.FindAsync(id);
            if (hsTinhThuongDung == null)
            {
                return NotFound();
            }

            _context.HsTinhThuongDungs.Remove(hsTinhThuongDung);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsTinhThuongDungExists(string id)
        {
            return _context.HsTinhThuongDungs.Any(e => e.TinhThuongDungId == id);
        }
    }
}
