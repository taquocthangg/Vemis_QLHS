using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwPhanLopXetLenLop
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string FkLopHocId { get; set; } = null!;

    public int? Stt { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public string XetLenLop { get; set; } = null!;
}
