using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmDiemDanhGiaTrenTieuHoc
{
    public string DiemDanhGiaTrenTieuHocId { get; set; } = null!;

    public string TenDiemDanhGiaTrenTieuHoc { get; set; } = null!;

    public string? GhiChu { get; set; }

    public bool IsChangeable { get; set; }
}
