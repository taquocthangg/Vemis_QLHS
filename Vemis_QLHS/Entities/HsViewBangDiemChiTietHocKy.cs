using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsViewBangDiemChiTietHocKy
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkLoaiDiemId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public int HeSo { get; set; }

    public double? Dtb { get; set; }
}
