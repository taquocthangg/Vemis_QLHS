using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwThamSoHeThong
{
    public string? Ten { get; set; }

    public string? MayChu { get; set; }

    public int Active { get; set; }

    public string TenHocKy { get; set; } = null!;

    public string TenNamHoc { get; set; } = null!;

    public string Namhoc { get; set; } = null!;

    public string HocKyId { get; set; } = null!;

    public string Ma { get; set; } = null!;

    public string? Donvichuquancap2 { get; set; }

    public string? Donvichuquancap3 { get; set; }
}
