using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VwBanHocController : Controller
    {
        private readonly VemisStudentContext _context;

        public VwBanHocController(VemisStudentContext ctx)
        {
            _context = ctx;
        }
       
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.VwBanHocs.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{ma}")]
        public IActionResult GetById(string ma)
        {
            try
            {
                var ChiTietBanHoc = _context.VwChucVuDoanThes.FirstOrDefault(d => d.Ma == ma);
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
