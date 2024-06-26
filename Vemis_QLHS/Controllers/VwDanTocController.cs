using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;
using Microsoft.EntityFrameworkCore;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VwDanTocController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public VwDanTocController(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.VwDanTocs.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                var danToc = _context.VwDanTocs.FirstOrDefault(d => d.Ma == id);
                if (danToc == null)
                {
                    return NotFound();
                }
                return Ok(danToc);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] VwDanToc danToc)
        {
            try
            {
                if (danToc == null)
                {
                    return BadRequest();
                }

                _context.VwDanTocs.Add(danToc);
                _context.SaveChanges();

                return CreatedAtAction(nameof(GetById), new { id = danToc.Ma }, danToc);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] VwDanToc updatedDanToc)
        {
            try
            {
                if (updatedDanToc == null || updatedDanToc.Ma != id)
                {
                    return BadRequest();
                }

                var danToc = _context.VwDanTocs.FirstOrDefault(d => d.Ma == id);
                if (danToc == null)
                {
                    return NotFound();
                }

                danToc.Ten = updatedDanToc.Ten;
                danToc.Active = updatedDanToc.Active;

                _context.VwDanTocs.Update(danToc);
                _context.SaveChanges();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                var danToc = _context.VwDanTocs.FirstOrDefault(d => d.Ma == id);
                if (danToc == null)
                {
                    return NotFound();
                }

                _context.VwDanTocs.Remove(danToc);
                _context.SaveChanges();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
    }
}
