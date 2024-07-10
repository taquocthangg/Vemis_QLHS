using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;
using Microsoft.EntityFrameworkCore;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiemHocSinhThongBaoNhapDiemChiTietMonHocController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public DiemHocSinhThongBaoNhapDiemChiTietMonHocController(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.DiemHocSinhThongBaoNhapDiemChiTietMonHocs.ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{TenLopHoc}/{TenMonHoc}")]
        public IActionResult GetById(string TenLopHoc , string TenMonHoc)
        {
            try
            {
                var ChiTietBanHoc = _context.DiemHocSinhThongBaoNhapDiemChiTietMonHocs.FirstOrDefault(d => d.TenLopHoc == TenLopHoc && d.TenMonHoc == TenMonHoc);
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
