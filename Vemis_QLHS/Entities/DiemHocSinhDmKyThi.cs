using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmKyThi
{
    public string KyThiId { get; set; } = null!;

    public string TenKyThi { get; set; } = null!;

    public string? GhiChu { get; set; }

    public bool IsChangeable { get; set; }
}
