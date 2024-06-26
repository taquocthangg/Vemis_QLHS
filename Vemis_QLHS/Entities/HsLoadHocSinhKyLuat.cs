using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsLoadHocSinhKyLuat
{
    public string MaHs { get; set; } = null!;

    public string HinhThuc { get; set; } = null!;

    public DateTime? NgayBatDau { get; set; }

    public DateTime? NgayKetThuc { get; set; }

    public string? GhiChu { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? HoTen { get; set; }

    public bool IsLocked { get; set; }

    public string GioiTinh { get; set; } = null!;

    public string LopHocId { get; set; } = null!;

    public string LopHoc { get; set; } = null!;

    public bool? IsDelete { get; set; }
}
