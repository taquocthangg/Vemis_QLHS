using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDiemThiMonDanhGiaBacTrenTieuHoc
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string? FkDiemDanhGiaTrenTieuHocId { get; set; }

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;
}
