using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;
using Microsoft.EntityFrameworkCore;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VwHocSinhLopHoc01Controller : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public VwHocSinhLopHoc01Controller(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.VwHocSinhLopHoc01s.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{FkHocSinhId}/{FkLopHocId}")]
        public IActionResult GetById(string FkHocSinhId , string FkLopHocId)
        {
            try
            {
                var ChiTietBanHoc = _context.VwHocSinhLopHoc01s.FirstOrDefault(d => d.FkHocSinhId == FkHocSinhId && d.FkLopHocId == FkLopHocId);
                if (ChiTietBanHoc == null)
                {
                    return NotFound();
                }
                return Ok(ChiTietBanHoc);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
    }
}
