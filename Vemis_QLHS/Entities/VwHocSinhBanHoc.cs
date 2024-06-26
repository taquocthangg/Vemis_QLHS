using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwHocSinhBanHoc
{
    public string FkBanHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public int Active { get; set; }

    public string FkHocSinhId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string FkLopHocId { get; set; } = null!;

    public bool? IsDelete { get; set; }
}
