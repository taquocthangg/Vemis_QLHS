using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsBangDiemKiemTraThuongXuyenApDungChoTieuHoc
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string? FkHocKyId { get; set; }

    public int LanChoDiem { get; set; }

    public int DiemSo { get; set; }

    public string ThangId { get; set; } = null!;

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;
}
