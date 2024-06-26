using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsLoadDanhHieu
{
    public string MaHs { get; set; } = null!;

    public string HinhThuc { get; set; } = null!;

    public string Lop { get; set; } = null!;

    public string LopHocId { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string GioiTinh { get; set; } = null!;

    public bool? IsDelete { get; set; }

    public string? TenHocSinh { get; set; }

    public string FkDanhHieuId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public string FkNamHocId { get; set; } = null!;
}
