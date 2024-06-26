using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmKhoiLop
{
    public string MaKhoiLop { get; set; } = null!;

    public string TenKhoiLop { get; set; } = null!;

    public bool IsChangeable { get; set; }
}
