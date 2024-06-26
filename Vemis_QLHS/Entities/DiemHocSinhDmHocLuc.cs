using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmHocLuc
{
    public string HocLucId { get; set; } = null!;

    public string TenHocLuc { get; set; } = null!;

    public string? GhiChu { get; set; }

    public bool IsChangeable { get; set; }
}
