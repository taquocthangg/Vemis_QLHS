using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwHocSinhNhomThiSbd
{
    public string? SoBaoDanh { get; set; }

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? HoTen { get; set; }

    public int Active { get; set; }

    public string? GioiTinh { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;

    public string FkNhomThiId { get; set; } = null!;

    public string FkHocSinhId { get; set; } = null!;
}
