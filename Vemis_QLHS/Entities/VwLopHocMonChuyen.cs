using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwLopHocMonChuyen
{
    public string FkMonHocId { get; set; } = null!;

    public string? TenMonHoc { get; set; }

    public string FkLopHocId { get; set; } = null!;

    public string? TenLopHoc { get; set; }

    public string? FkNamHocId { get; set; }
}
