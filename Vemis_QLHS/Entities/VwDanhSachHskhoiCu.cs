using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwDanhSachHskhoiCu
{
    public bool XetLenLop { get; set; }

    public string FkHocSinhId { get; set; } = null!;

    public string FkLopHocId { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgaySinh { get; set; }

    public bool? GioiTinh { get; set; }

    public string? FkDanTocId { get; set; }

    public string? FkTonGiaoId { get; set; }

    public string? FkMaXaId { get; set; }

    public string? FkMaHuyenId { get; set; }

    public string FkNamHocId { get; set; } = null!;
}
