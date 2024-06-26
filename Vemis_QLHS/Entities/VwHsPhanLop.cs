using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwHsPhanLop
{
    public string FkNamHocId { get; set; } = null!;

    public string FkLopHocId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkHocSinhId { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? Ten { get; set; }

    public bool IsLocked { get; set; }

    public string? TenDem { get; set; }

    public string? HoTen { get; set; }

    public int Active { get; set; }

    public bool? IsDelete { get; set; }
}
