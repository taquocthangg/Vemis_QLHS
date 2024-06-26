using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmMonHocKhoiLop
{
    public string FkMonHocId { get; set; } = null!;

    public string FkKhoiLopId { get; set; } = null!;

    public bool CachChoDiem { get; set; }

    public string HocKyHoc { get; set; } = null!;

    public bool IsLopHocHocSinh { get; set; }

    public bool IsChangeable { get; set; }

    public bool IsTongKet { get; set; }
}
