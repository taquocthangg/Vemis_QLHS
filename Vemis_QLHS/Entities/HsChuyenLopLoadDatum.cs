using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsChuyenLopLoadDatum
{
    public string MaHs { get; set; } = null!;

    public string LopCu { get; set; } = null!;

    public string LopMoi { get; set; } = null!;

    public string? Ten { get; set; }

    public string? TenDem { get; set; }

    public string? HoDem { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string? NguoiQd { get; set; }

    public DateTime? NgayChuyen { get; set; }

    public bool IsLocked { get; set; }

    public string? HoTen { get; set; }

    public string LopCuId { get; set; } = null!;

    public int Active { get; set; }

    public string LopMoiId { get; set; } = null!;

    public string TenHocKy { get; set; } = null!;

    public bool? IsDelete { get; set; }

    public string NamHocId { get; set; } = null!;
}
