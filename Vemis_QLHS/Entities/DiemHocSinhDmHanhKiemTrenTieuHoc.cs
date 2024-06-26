using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmHanhKiemTrenTieuHoc
{
    public string HanhKiemTrenTieuHocId { get; set; } = null!;

    public string TenHanhKiemTrenTieuHoc { get; set; } = null!;

    public string? GhiChu { get; set; }
}
