using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwBuoiHoc
{
    public string BuoiHocId { get; set; } = null!;

    public string TenBuoiHoc { get; set; } = null!;

    public string? GhiChu { get; set; }

    public int Active { get; set; }
}
