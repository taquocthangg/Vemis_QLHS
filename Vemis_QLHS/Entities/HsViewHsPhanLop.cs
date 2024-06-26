using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsViewHsPhanLop
{
    public string FkHocSinhId { get; set; } = null!;

    public string? FkLopHocId { get; set; }

    public int? Stt { get; set; }

    public string? FkHocKyId { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public string IsChuyenLop { get; set; } = null!;

    public string HocKyChuyen { get; set; } = null!;
}
