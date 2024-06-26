using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwSucKhoe
{
    public string FkHocSinhId { get; set; } = null!;

    public double? ChieuCao { get; set; }

    public double? CanNang { get; set; }

    public string? FkNhomMauId { get; set; }

    public string? TenNhomMau { get; set; }

    public string? FkThiLucId { get; set; }

    public string? TenThiLuc { get; set; }

    public bool? ChatDocDaCam { get; set; }

    public bool? TaiNan { get; set; }

    public bool? KhamDinhKy { get; set; }

    public bool? TieuChay { get; set; }

    public bool? HoHap { get; set; }

    public bool? NgoaiDa { get; set; }

    public string? GhiChu { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;
}
