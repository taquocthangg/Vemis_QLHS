using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsBoHocRptDatum
{
    public string MaHs { get; set; } = null!;

    public DateTime? NgayBd { get; set; }

    public string? NguoiQd { get; set; }

    public string LyDoThoiHocId { get; set; } = null!;

    public string HinhThuc { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public string Lop { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string GioiTinh { get; set; } = null!;

    public string? TenHocSinh { get; set; }

    public bool? IsDelete { get; set; }

    public int Active { get; set; }

    public string FkLopHocId { get; set; } = null!;
}
