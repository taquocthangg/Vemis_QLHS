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
    public class HsDiemThiMonTiengVietCuaTieuHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsDiemThiMonTiengVietCuaTieuHocsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsDiemThiMonTiengVietCuaTieuHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsDiemThiMonTiengVietCuaTieuHoc>>> GetHsDiemThiMonTiengVietCuaTieuHocs()
        {
            return await _context.HsDiemThiMonTiengVietCuaTieuHocs.ToListAsync();
        }

        // GET: api/HsDiemThiMonTiengVietCuaTieuHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsDiemThiMonTiengVietCuaTieuHoc>> GetHsDiemThiMonTiengVietCuaTieuHoc(string id)
        {
            var hsDiemThiMonTiengVietCuaTieuHoc = await _context.HsDiemThiMonTiengVietCuaTieuHocs.FindAsync(id);

            if (hsDiemThiMonTiengVietCuaTieuHoc == null)
            {
                return NotFound();
            }

            return hsDiemThiMonTiengVietCuaTieuHoc;
        }

        // PUT: api/HsDiemThiMonTiengVietCuaTieuHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsDiemThiMonTiengVietCuaTieuHoc(string id, HsDiemThiMonTiengVietCuaTieuHoc hsDiemThiMonTiengVietCuaTieuHoc)
        {
            if (id != hsDiemThiMonTiengVietCuaTieuHoc.FkHocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsDiemThiMonTiengVietCuaTieuHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsDiemThiMonTiengVietCuaTieuHocExists(id))
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

        // POST: api/HsDiemThiMonTiengVietCuaTieuHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsDiemThiMonTiengVietCuaTieuHoc>> PostHsDiemThiMonTiengVietCuaTieuHoc(HsDiemThiMonTiengVietCuaTieuHoc hsDiemThiMonTiengVietCuaTieuHoc)
        {
            _context.HsDiemThiMonTiengVietCuaTieuHocs.Add(hsDiemThiMonTiengVietCuaTieuHoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsDiemThiMonTiengVietCuaTieuHocExists(hsDiemThiMonTiengVietCuaTieuHoc.FkHocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsDiemThiMonTiengVietCuaTieuHoc", new { id = hsDiemThiMonTiengVietCuaTieuHoc.FkHocSinhId }, hsDiemThiMonTiengVietCuaTieuHoc);
        }

        // DELETE: api/HsDiemThiMonTiengVietCuaTieuHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsDiemThiMonTiengVietCuaTieuHoc(string id)
        {
            var hsDiemThiMonTiengVietCuaTieuHoc = await _context.HsDiemThiMonTiengVietCuaTieuHocs.FindAsync(id);
            if (hsDiemThiMonTiengVietCuaTieuHoc == null)
            {
                return NotFound();
            }

            _context.HsDiemThiMonTiengVietCuaTieuHocs.Remove(hsDiemThiMonTiengVietCuaTieuHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsDiemThiMonTiengVietCuaTieuHocExists(string id)
        {
            return _context.HsDiemThiMonTiengVietCuaTieuHocs.Any(e => e.FkHocSinhId == id);
        }
    }
}
