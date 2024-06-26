using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsThiDuaTapThe
{
    public string FkLopHocId { get; set; } = null!;

    public double? DiemThiDua { get; set; }

    public short? Thang { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
