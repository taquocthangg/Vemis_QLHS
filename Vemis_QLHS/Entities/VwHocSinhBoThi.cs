using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwHocSinhBoThi
{
    public string FkKyThiId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public int Active { get; set; }

    public string FkHocSinhId { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public string FkMonHocId { get; set; } = null!;

    public DateTime? NgaySinh { get; set; }

    public string? GioiTinh { get; set; }

    public string? TenMonHoc { get; set; }

    public string? HoTen { get; set; }
}
