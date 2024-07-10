using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;
using Microsoft.EntityFrameworkCore;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiemHocSinhThamSoHeThongController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public DiemHocSinhThamSoHeThongController(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.DiemHocSinhThamSoHeThongs.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{DonViSuDungId}/{HocKyId}/{NamHocId}")]
        public IActionResult GetById(string DonViSuDungId, string HocKyId , string NamHocId)
        {
            try
            {
                var ChiTietBanHoc = _context.DiemHocSinhThamSoHeThongs.FirstOrDefault(d => d.DonViSuDungId == DonViSuDungId && d.HocKyId==  HocKyId && d.NamHocId == NamHocId);
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
