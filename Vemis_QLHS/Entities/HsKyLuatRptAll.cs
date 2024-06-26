using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsKyLuatRptAll
{
    public string MaHs { get; set; } = null!;

    public string? Ten { get; set; }

    public string? TenDem { get; set; }

    public string? HoDem { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string Lop { get; set; } = null!;

    public string? TenHocSinh { get; set; }

    public DateTime? NgayBd { get; set; }

    public DateTime? NgayKt { get; set; }

    public bool IsLocked { get; set; }

    public string GioiTinh { get; set; } = null!;

    public string? NguoiQd { get; set; }

    public string FkLopHocId { get; set; } = null!;

    public string HinhThuc { get; set; } = null!;

    public bool? IsDelete { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;
}
