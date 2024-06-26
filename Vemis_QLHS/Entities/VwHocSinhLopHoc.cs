using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwHocSinhLopHoc
{
    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public string FkHocSinhId { get; set; } = null!;

    public string? HoTen { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkLopHocId { get; set; } = null!;

    public string FkBanHocId { get; set; } = null!;

    public int Active { get; set; }

    public bool? IsDelete { get; set; }
}
