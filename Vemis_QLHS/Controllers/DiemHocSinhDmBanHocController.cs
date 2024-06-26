using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;
using Microsoft.EntityFrameworkCore;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiemHocSinhDmBanHocsController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public DiemHocSinhDmBanHocsController(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.DiemHocSinhDmBanHocs.ToList());
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
                var DmBanHoc = _context.DiemHocSinhDmBanHocs.FirstOrDefault(d => d.BanHocId == id);
                if (DmBanHoc == null)
                {
                    return NotFound();
                }
                return Ok(DmBanHoc);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

      
    }
}
