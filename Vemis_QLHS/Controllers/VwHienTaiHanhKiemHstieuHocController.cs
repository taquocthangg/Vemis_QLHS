using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VwHienTaiHanhKiemHstieuHocController : Controller
    {
        private readonly VemisStudentContext _context;

        public VwHienTaiHanhKiemHstieuHocController(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.VwHienTaiHanhKiemHstieuHocs.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{FkHocKyId}/{FkNamHocId}")]
        public IActionResult GetById(string FkHocKyId , string FkNamHocId)
        {
            try
            {
                var ChiTietBanHoc = _context.VwHienTaiHanhKiemHstieuHocs.FirstOrDefault(d => d.FkHocKyId == FkHocKyId && d.FkNamHocId == FkNamHocId);
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
