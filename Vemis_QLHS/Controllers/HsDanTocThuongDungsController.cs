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
    public class HsDanTocThuongDungsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDanTocThuongDungsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDanTocThuongDungs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDanTocThuongDung>>> GetHsDanTocThuongDungs()
        {
            return await _context.HsDanTocThuongDungs.ToListAsync();
        }

        // GET: api/HsDanTocThuongDungs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDanTocThuongDung>> GetHsDanTocThuongDung(string id)
        {
            var hsDanTocThuongDung = await _context.HsDanTocThuongDungs.FindAsync(id);

            if (hsDanTocThuongDung == null)
            {
                return NotFound();
            }

            return hsDanTocThuongDung;
        }

        // PUT: api/HsDanTocThuongDungs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDanTocThuongDung(string id, HsDanTocThuongDung hsDanTocThuongDung)
        {
            if (id != hsDanTocThuongDung.DanTocThuongDungId)
            {
                return BadRequest();
            }

            _context.Entry(hsDanTocThuongDung).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDanTocThuongDungExists(id))
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

        // POST: api/HsDanTocThuongDungs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDanTocThuongDung>> PostHsDanTocThuongDung(HsDanTocThuongDung hsDanTocThuongDung)
        {
            _context.HsDanTocThuongDungs.Add(hsDanTocThuongDung);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDanTocThuongDungExists(hsDanTocThuongDung.DanTocThuongDungId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDanTocThuongDung", new { id = hsDanTocThuongDung.DanTocThuongDungId }, hsDanTocThuongDung);
        }

        // DELETE: api/HsDanTocThuongDungs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDanTocThuongDung(string id)
        {
            var hsDanTocThuongDung = await _context.HsDanTocThuongDungs.FindAsync(id);
            if (hsDanTocThuongDung == null)
            {
                return NotFound();
            }

            _context.HsDanTocThuongDungs.Remove(hsDanTocThuongDung);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDanTocThuongDungExists(string id)
        {
            return _context.HsDanTocThuongDungs.Any(e => e.DanTocThuongDungId == id);
        }
    }
}
