using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsKiemTraMucPhiDongGop
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkLoaiMucPhiId { get; set; } = null!;

    public bool? T1 { get; set; }

    public bool? T2 { get; set; }

    public bool? T3 { get; set; }

    public bool? T4 { get; set; }

    public bool? T5 { get; set; }

    public bool? T6 { get; set; }

    public bool? T7 { get; set; }

    public bool? T8 { get; set; }

    public bool? T9 { get; set; }

    public bool? T10 { get; set; }

    public bool? T11 { get; set; }

    public bool? T12 { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
