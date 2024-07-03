using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VwDmhocSinhTuyenSinhController : Controller
    {
        private readonly VemisStudentContext _context;

        public VwDmhocSinhTuyenSinhController(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.VwDmhocSinhTuyenSinhs.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{FkNamHocId}/{FkHocSinhId}")]
        public IActionResult GetById(string FkNamHocId, string FkHocSinhId)
        {
            try
            {
                var ChiTietBanHoc = _context.VwDmhocSinhTuyenSinhs.FirstOrDefault(d => d.FkNamHocId == FkNamHocId && d.FkHocSinhId == FkHocSinhId);
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
