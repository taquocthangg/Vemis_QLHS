using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwKyluathocsinh
{
    public string HocSinhId { get; set; } = null!;

    public string? FkHinhThucKyLuatId { get; set; }

    public string? NgayKyLuat { get; set; }

    public string? NgayKetThuc { get; set; }

    public string? GhiChu { get; set; }

    public string KyLuat { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string? NguoiQuyetDinh { get; set; }
}
