using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmNhomCapHoc
{
    public string NhomCapHocId { get; set; } = null!;

    public string? TenNhomCapHoc { get; set; }

    public bool IsChangeable { get; set; }
}
