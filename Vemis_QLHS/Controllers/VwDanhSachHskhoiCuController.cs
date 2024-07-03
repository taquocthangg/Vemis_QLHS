using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VwDanhSachHskhoiCuController : Controller
    {
        private readonly VemisStudentContext _context;

        public VwDanhSachHskhoiCuController(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.VwDanhSachHskhoiCus.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{FkNamHocId}/{FkLopHocId}")]
        public IActionResult GetById(string FkNamHocId , string FkLopHocId)
        {
            try
            {
                var ChiTietBanHoc = _context.VwDanhSachHskhoiCus.FirstOrDefault(d => d.FkNamHocId == FkNamHocId && d.FkLopHocId == FkLopHocId);
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
