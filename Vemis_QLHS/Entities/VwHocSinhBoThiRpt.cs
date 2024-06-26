using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwHocSinhBoThiRpt
{
    public string? SoBaoDanh { get; set; }

    public string FkNhomThiId { get; set; } = null!;

    public string FkLopHocId { get; set; } = null!;

    public string? TenLopHoc { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? HoTen { get; set; }

    public string FkHocSinhId { get; set; } = null!;

    public string FkPhongThiId { get; set; } = null!;

    public string? TenMonHoc { get; set; }

    public string FkMonHocId { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public string FkKyThiId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
