using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;
using Microsoft.EntityFrameworkCore;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HsLoadHocSinhKhenThuongController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsLoadHocSinhKhenThuongController(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.HsLoadHocSinhKhenThuongs.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{MaHs}")]
        public IActionResult GetById(string MaHs)
        {
            try
            {
                var ChiTietBanHoc = _context.HsLoadHocSinhKhenThuongs.FirstOrDefault(d => d.MaHs == MaHs);
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
