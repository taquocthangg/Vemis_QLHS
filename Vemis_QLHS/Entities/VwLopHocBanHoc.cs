using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwLopHocBanHoc
{
    public string LopHocId { get; set; } = null!;

    public string TenLopHoc { get; set; } = null!;

    public int Active { get; set; }

    public bool IsLocked { get; set; }

    public string? FkBanHocId { get; set; }

    public string? TenBanHoc { get; set; }

    public string? TenNamHoc { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public string? FkHocKyId { get; set; }

    public string? TenHocKy { get; set; }
}
