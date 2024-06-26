using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwLopHoc
{
    public string LopHocId { get; set; } = null!;

    public string TenLopHoc { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string? FkHocKyId { get; set; }

    public int Active { get; set; }

    public bool IsLocked { get; set; }
}
