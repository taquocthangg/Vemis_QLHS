using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsBangDiemChiTietHocKy
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkLoaiDiemId { get; set; } = null!;

    public int ThuTuDauDiemNhap { get; set; }

    public double DiemSo { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public int HeSo { get; set; }

    public bool? IsLocked { get; set; }

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;
}
