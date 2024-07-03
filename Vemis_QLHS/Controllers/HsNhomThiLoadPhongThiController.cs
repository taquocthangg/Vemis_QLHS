using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;
using Microsoft.EntityFrameworkCore;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HsNhomThiLoadPhongThiController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public HsNhomThiLoadPhongThiController(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.HsNhomThiLoadPhongThis.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{FkNhomThiId}/{PhongThiId}")]
        public IActionResult GetById(string FkNhomThiId, string PhongThiId)
        {
            try
            {
                var ChiTietBanHoc = _context.HsNhomThiLoadPhongThis.FirstOrDefault(d => d.FkNhomThiId == FkNhomThiId && d.PhongThiId == PhongThiId);
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
