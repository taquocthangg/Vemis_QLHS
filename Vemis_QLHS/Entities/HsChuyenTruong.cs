using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsChuyenTruong
{
    public string FkHocSinhId { get; set; } = null!;

    public string? FkLopHocId { get; set; }

    public DateTime? NgayQuyetDinh { get; set; }

    public string? NguoiQuyetDinh { get; set; }

    public string? LyDoChuyenTruong { get; set; }

    public bool LoaiChuyen { get; set; }

    public string? FkTruongDiDenId { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
