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
    public class HsSucKhoesController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsSucKhoesController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsSucKhoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsSucKhoe>>> GetHsSucKhoes()
        {
            return await _context.HsSucKhoes.ToListAsync();
        }

        // GET: api/HsSucKhoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsSucKhoe>> GetHsSucKhoe(string id)
        {
            var hsSucKhoe = await _context.HsSucKhoes.FindAsync(id);

            if (hsSucKhoe == null)
            {
                return NotFound();
            }

            return hsSucKhoe;
        }

        // PUT: api/HsSucKhoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsSucKhoe(string id, HsSucKhoe hsSucKhoe)
        {
            if (id != hsSucKhoe.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsSucKhoe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsSucKhoeExists(id))
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

        // POST: api/HsSucKhoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsSucKhoe>> PostHsSucKhoe(HsSucKhoe hsSucKhoe)
        {
            _context.HsSucKhoes.Add(hsSucKhoe);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsSucKhoeExists(hsSucKhoe.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsSucKhoe", new { id = hsSucKhoe.FkHocSinhId }, hsSucKhoe);
        }

        // DELETE: api/HsSucKhoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsSucKhoe(string id)
        {
            var hsSucKhoe = await _context.HsSucKhoes.FindAsync(id);
            if (hsSucKhoe == null)
            {
                return NotFound();
            }

            _context.HsSucKhoes.Remove(hsSucKhoe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsSucKhoeExists(string id)
        {
            return _context.HsSucKhoes.Any(e => e.FkHocSinhId == id);
        }
    }
}
