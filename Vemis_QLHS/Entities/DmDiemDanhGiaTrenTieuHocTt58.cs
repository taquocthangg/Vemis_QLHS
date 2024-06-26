using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DmDiemDanhGiaTrenTieuHocTt58
{
    public string DiemDanhGiaId { get; set; } = null!;

    public string TenDiemDanhGia { get; set; } = null!;

    public string? GhiChu { get; set; }

    public bool IsChangeable { get; set; }
}
