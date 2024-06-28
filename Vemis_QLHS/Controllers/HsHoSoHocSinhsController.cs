﻿using System;
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
    public class HsHoSoHocSinhsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsHoSoHocSinhsController(VemisStudentContext context)
        {
            _context = context;
        }

        // GET: api/HsHoSoHocSinhs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HsHoSoHocSinh>>> GetHsHoSoHocSinhs()
        {
            return await _context.HsHoSoHocSinhs.ToListAsync();
        }

        // GET: api/HsHoSoHocSinhs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HsHoSoHocSinh>> GetHsHoSoHocSinh(string id)
        {
            var hsHoSoHocSinh = await _context.HsHoSoHocSinhs.FindAsync(id);

            if (hsHoSoHocSinh == null)
            {
                return NotFound();
            }

            return hsHoSoHocSinh;
        }

        // PUT: api/HsHoSoHocSinhs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHsHoSoHocSinh(string id, HsHoSoHocSinh hsHoSoHocSinh)
        {
            if (id != hsHoSoHocSinh.HocSinhId)
            {
                return BadRequest();
            }

            _context.Entry(hsHoSoHocSinh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HsHoSoHocSinhExists(id))
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

        // POST: api/HsHoSoHocSinhs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HsHoSoHocSinh>> PostHsHoSoHocSinh(HsHoSoHocSinh hsHoSoHocSinh)
        {
            _context.HsHoSoHocSinhs.Add(hsHoSoHocSinh);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HsHoSoHocSinhExists(hsHoSoHocSinh.HocSinhId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHsHoSoHocSinh", new { id = hsHoSoHocSinh.HocSinhId }, hsHoSoHocSinh);
        }

        // DELETE: api/HsHoSoHocSinhs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHsHoSoHocSinh(string id)
        {
            var hsHoSoHocSinh = await _context.HsHoSoHocSinhs.FindAsync(id);
            if (hsHoSoHocSinh == null)
            {
                return NotFound();
            }

            _context.HsHoSoHocSinhs.Remove(hsHoSoHocSinh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HsHoSoHocSinhExists(string id)
        {
            return _context.HsHoSoHocSinhs.Any(e => e.HocSinhId == id);
        }
    }
}