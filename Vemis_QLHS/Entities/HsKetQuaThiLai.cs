using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsKetQuaThiLai
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public double? DiemThiLai { get; set; }

    public double? TongKetCaNamLan1 { get; set; }

    public double? TongKetCaNamLan2 { get; set; }

    public string? FkLopHocId { get; set; }
}
