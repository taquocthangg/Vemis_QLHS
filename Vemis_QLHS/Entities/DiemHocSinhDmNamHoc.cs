using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmNamHoc
{
    public string NamHocId { get; set; } = null!;

    public string TenNamHoc { get; set; } = null!;

    public string? GhiChu { get; set; }

    public bool IsChangeable { get; set; }
}
