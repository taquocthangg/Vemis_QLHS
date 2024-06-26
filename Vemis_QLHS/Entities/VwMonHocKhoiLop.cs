using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwMonHocKhoiLop
{
    public string FkMonHocId { get; set; } = null!;

    public string FkKhoiLopId { get; set; } = null!;

    public string TenMonHoc { get; set; } = null!;

    public string? GhiChu { get; set; }

    public int Active { get; set; }

    public bool CachChoDiem { get; set; }

    public string? HocKyHoc { get; set; }

    public bool? IsLopHocHocSinh { get; set; }
}
