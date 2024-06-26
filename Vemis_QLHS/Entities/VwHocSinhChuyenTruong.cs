using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwHocSinhChuyenTruong
{
    public string FkHocSinhId { get; set; } = null!;

    public DateTime? NgayQuyetDinh { get; set; }

    public string? NguoiQuyetDinh { get; set; }

    public string? LyDoChuyenTruong { get; set; }

    public bool LoaiChuyen { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public string? HoTen { get; set; }

    public string? FkLopHocId { get; set; }

    public string TenLopHoc { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string Expr1 { get; set; } = null!;

    public int Active { get; set; }

    public string? FkTruongDiDenId { get; set; }

    public string? TenTruong { get; set; }
}
