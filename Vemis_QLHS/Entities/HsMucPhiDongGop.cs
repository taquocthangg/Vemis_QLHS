using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsMucPhiDongGop
{
    public string FkKhoiLopId { get; set; } = null!;

    public string FkLoaiMucPhiId { get; set; } = null!;

    public int? KhoanDongGop { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
