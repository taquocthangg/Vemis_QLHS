using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDataDiemThi
{
    public string FkLopHocId { get; set; } = null!;

    public string? HoTen { get; set; }

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgaySinh { get; set; }

    public bool? IsDelete { get; set; }

    public double? Diem { get; set; }

    public bool IsUp { get; set; }

    public string FkMonHocId { get; set; } = null!;

    public string TenMonHoc { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;

    public bool IsActived { get; set; }

    public string TenGioiTinh { get; set; } = null!;

    public bool IsLocked { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public string FkHocSinhId { get; set; } = null!;
}
