﻿using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vemis_QLHS.Entities;
using Microsoft.EntityFrameworkCore;

namespace Vemis_QLHS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VwLopHocMonMienGiamController : ControllerBase
    {
        private readonly VemisStudentContext _context;

        public VwLopHocMonMienGiamController(VemisStudentContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_context.VwLopHocMonMienGiams.ToList());
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
                var ChiTietBanHoc = _context.VwLopHocMonMienGiams.FirstOrDefault(d => d.FkLopHocId == id);
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
