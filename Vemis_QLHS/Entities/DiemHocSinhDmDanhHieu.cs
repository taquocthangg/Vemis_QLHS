using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmDanhHieu
{
    public string DanhHieuId { get; set; } = null!;

    public string TenDanhHieu { get; set; } = null!;

    public string? GhiChu { get; set; }
}
