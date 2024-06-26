using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwHocSinhChuyenTruongRpt
{
    public string FkHocSinhId { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgayQuyetDinh { get; set; }

    public string? NguoiQuyetDinh { get; set; }

    public string? LyDoChuyenTruong { get; set; }

    public bool LoaiChuyen { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public string? TenTruong { get; set; }

    public string? FkTruongDiDenId { get; set; }

    public string TenLopHoc { get; set; } = null!;

    public string? FkLopHocId { get; set; }

    public string? HoTen { get; set; }

    public int Active { get; set; }

    public DateTime? NgaySinh { get; set; }
}
