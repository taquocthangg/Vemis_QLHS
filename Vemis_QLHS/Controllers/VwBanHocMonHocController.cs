using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vemis_QLHS.Entities;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VwBanHocMonHocController : Controller
    {
        private readonly VemisStudentContext _context;
        public VwBanHocMonHocController(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.VwBanHocMonHocs.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet("{fkMonHocId}/{fkBanHocId}")]
        public IActionResult GetById(string fkMonHocId ,string fkBanHocId)
        {
            try
            {
                var ChiTietBanHoc = _context.VwBanHocMonHocs.FirstOrDefault(d => d.FkMonHocId == fkMonHocId && d.FkBanHocId == fkBanHocId);
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
