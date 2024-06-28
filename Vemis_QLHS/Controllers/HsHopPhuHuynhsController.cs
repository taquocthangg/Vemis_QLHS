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
    public class HsHopPhuHuynhsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHopPhuHuynhsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHopPhuHuynhs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHopPhuHuynh>>> GetHsHopPhuHuynhs()
        {
            return await _context.HsHopPhuHuynhs.ToListAsync();
        }

        // GET: api/HsHopPhuHuynhs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHopPhuHuynh>> GetHsHopPhuHuynh(string id)
        {
            var hsHopPhuHuynh = await _context.HsHopPhuHuynhs.FindAsync(id);

            if (hsHopPhuHuynh == null)
            {
                return NotFound();
            }

            return hsHopPhuHuynh;
        }

        // PUT: api/HsHopPhuHuynhs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHopPhuHuynh(string id, HsHopPhuHuynh hsHopPhuHuynh)
        {
            if (id != hsHopPhuHuynh.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHopPhuHuynh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHopPhuHuynhExists(id))
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

        // POST: api/HsHopPhuHuynhs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHopPhuHuynh>> PostHsHopPhuHuynh(HsHopPhuHuynh hsHopPhuHuynh)
        {
            _context.HsHopPhuHuynhs.Add(hsHopPhuHuynh);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHopPhuHuynhExists(hsHopPhuHuynh.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHopPhuHuynh", new { id = hsHopPhuHuynh.FkHocSinhId }, hsHopPhuHuynh);
        }

        // DELETE: api/HsHopPhuHuynhs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHopPhuHuynh(string id)
        {
            var hsHopPhuHuynh = await _context.HsHopPhuHuynhs.FindAsync(id);
            if (hsHopPhuHuynh == null)
            {
                return NotFound();
            }

            _context.HsHopPhuHuynhs.Remove(hsHopPhuHuynh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHopPhuHuynhExists(string id)
        {
            return _context.HsHopPhuHuynhs.Any(e => e.FkHocSinhId == id);
        }
    }
}
