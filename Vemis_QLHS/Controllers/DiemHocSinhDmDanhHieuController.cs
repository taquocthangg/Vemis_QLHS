using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiemHocSinhDmDanhHieuController : ControllerBase
    {
        private readonly VemisStudentContext _context;
        public DiemHocSinhDmDanhHieuController(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.DiemHocSinhDmDanhHieus.ToList());
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
                var DmBanHoc = _context.DiemHocSinhDmDanhHieus.FirstOrDefault(d => d.DanhHieuId == id);
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
