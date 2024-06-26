using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmHocKy
{
    public string HocKyId { get; set; } = null!;

    public string TenHocKy { get; set; } = null!;

    public string? Ghichu { get; set; }

    public bool IsChangeable { get; set; }
}
