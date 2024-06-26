using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsNhomThiVwPhanLop
{
    public string FkHocSinhId { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public string? HoTen { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? TenLopHoc { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public string FkLopHocId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public int Active { get; set; }

    public bool? IsDelete { get; set; }

    public string? GioiTinh { get; set; }

    public bool? IsLocked { get; set; }
}
