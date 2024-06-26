using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmHanhKiemTieuHoc
{
    public string HanhKiemTieuHocId { get; set; } = null!;

    public string TenHanhKiemTieuHoc { get; set; } = null!;

    public string? GhiChu { get; set; }
}
