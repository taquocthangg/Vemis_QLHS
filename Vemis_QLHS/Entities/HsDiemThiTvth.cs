using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDiemThiTvth
{
    public string FkHocSinhId { get; set; } = null!;

    public string? HoTen { get; set; }

    public string FkMaKyThiId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public int DiemThi { get; set; }

    public bool DiemDocHoacDiemViet { get; set; }

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public string? FkKieuHienThiId { get; set; }

    public DateTime? NgaySinh { get; set; }

    public bool? IsDelete { get; set; }

    public string TenGioiTinh { get; set; } = null!;

    public string FkLopHocId { get; set; } = null!;
}
