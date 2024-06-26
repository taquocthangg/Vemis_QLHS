using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsKyLuatHocSinh
{
    public int Matang { get; set; }

    public string FkHocSinhId { get; set; } = null!;

    public string? FkHinhThucKyLuatId { get; set; }

    public DateTime? NgayKyLuat { get; set; }

    public DateTime? NgayKetThuc { get; set; }

    public string? NguoiQuyetDinh { get; set; }

    public string? GhiChu { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
