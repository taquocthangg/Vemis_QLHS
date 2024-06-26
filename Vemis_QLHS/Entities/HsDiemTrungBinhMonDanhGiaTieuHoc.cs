using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDiemTrungBinhMonDanhGiaTieuHoc
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkDiemDanhGiaTieuHocId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string? NhanXet { get; set; }

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;
}
