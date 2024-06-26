using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsNhomThiLoad
{
    public string FkNhomThiId { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public string? HoTen { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string TenLopHoc { get; set; } = null!;

    public bool? IsDelete { get; set; }

    public bool IsActived { get; set; }

    public string FkKyThiId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public bool? NhapNam { get; set; }

    public bool? NhapThangNam { get; set; }

    public string? GioiTinh { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public string FkHocSinhId { get; set; } = null!;
}
