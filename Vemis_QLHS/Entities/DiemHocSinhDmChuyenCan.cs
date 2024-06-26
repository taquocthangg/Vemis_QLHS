using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmChuyenCan
{
    public string ChuyenCanId { get; set; } = null!;

    public string TenChuyenCan { get; set; } = null!;

    public string? GhiChu { get; set; }
}
