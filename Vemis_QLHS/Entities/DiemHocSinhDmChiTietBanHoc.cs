using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmChiTietBanHoc
{
    public string FkMonHocId { get; set; } = null!;

    public string FkBanHocId { get; set; } = null!;

    public bool IsChangeable { get; set; }
}
