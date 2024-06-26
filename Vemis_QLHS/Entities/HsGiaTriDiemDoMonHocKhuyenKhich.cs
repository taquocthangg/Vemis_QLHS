using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsGiaTriDiemDoMonHocKhuyenKhich
{
    public string FkMonHocKhuyenKhich { get; set; } = null!;

    public string FkDiemDanhGiaId { get; set; } = null!;

    public double? GiaTriDiem { get; set; }

    public string? GhiChu { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
