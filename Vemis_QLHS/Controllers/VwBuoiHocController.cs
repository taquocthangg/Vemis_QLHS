using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VwBuoiHocController : Controller
    {
        private readonly VemisStudentContext _context;
        public VwBuoiHocController(VemisStudentContext ctx)
        {
            _context = ctx;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.VwBuoiHocs.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet("{buoiHocId}")]
        public IActionResult GetById(string buoiHocId)
        {
            try
            {
                var ChiTietBanHoc = _context.VwBuoiHocs.FirstOrDefault(d => d.BuoiHocId == buoiHocId );
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
