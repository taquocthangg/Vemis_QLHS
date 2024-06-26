using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmDiemDanhGiaTieuHoc
{
    public string DiemDanhGiaTieuHocId { get; set; } = null!;

    public string TenDiemDanhGiaTieuHoc { get; set; } = null!;

    public string? GhiChu { get; set; }

    public bool IsChangeable { get; set; }
}
