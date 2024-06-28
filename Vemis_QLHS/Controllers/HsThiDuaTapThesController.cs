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
    public class HsThiDuaTapThesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsThiDuaTapThesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsThiDuaTapThes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsThiDuaTapThe>>> GetHsThiDuaTapThes()
        {
            return await _context.HsThiDuaTapThes.ToListAsync();
        }

        // GET: api/HsThiDuaTapThes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsThiDuaTapThe>> GetHsThiDuaTapThe(string id)
        {
            var hsThiDuaTapThe = await _context.HsThiDuaTapThes.FindAsync(id);

            if (hsThiDuaTapThe == null)
            {
                return NotFound();
            }

            return hsThiDuaTapThe;
        }

        // PUT: api/HsThiDuaTapThes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsThiDuaTapThe(string id, HsThiDuaTapThe hsThiDuaTapThe)
        {
            if (id != hsThiDuaTapThe.FkLopHocId)
            {
                return BadRequest();
            }

            _context.Entry(hsThiDuaTapThe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsThiDuaTapTheExists(id))
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

        // POST: api/HsThiDuaTapThes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsThiDuaTapThe>> PostHsThiDuaTapThe(HsThiDuaTapThe hsThiDuaTapThe)
        {
            _context.HsThiDuaTapThes.Add(hsThiDuaTapThe);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsThiDuaTapTheExists(hsThiDuaTapThe.FkLopHocId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsThiDuaTapThe", new { id = hsThiDuaTapThe.FkLopHocId }, hsThiDuaTapThe);
        }

        // DELETE: api/HsThiDuaTapThes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsThiDuaTapThe(string id)
        {
            var hsThiDuaTapThe = await _context.HsThiDuaTapThes.FindAsync(id);
            if (hsThiDuaTapThe == null)
            {
                return NotFound();
            }

            _context.HsThiDuaTapThes.Remove(hsThiDuaTapThe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsThiDuaTapTheExists(string id)
        {
            return _context.HsThiDuaTapThes.Any(e => e.FkLopHocId == id);
        }
    }
}
