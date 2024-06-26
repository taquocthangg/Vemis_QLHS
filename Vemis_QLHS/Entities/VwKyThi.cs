using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwKyThi
{
    public string KyThiId { get; set; } = null!;

    public string TenKyThi { get; set; } = null!;

    public bool IsChangeable { get; set; }

    public string? GhiChu { get; set; }

    public int Active { get; set; }
}
