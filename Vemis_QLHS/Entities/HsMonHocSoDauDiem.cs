using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsMonHocSoDauDiem
{
    public string FkMonHocId { get; set; } = null!;

    public string FkKhoiLopId { get; set; } = null!;

    public string FkLoaiDiemId { get; set; } = null!;

    public int SoDauDiemToiThieu { get; set; }

    public int SoDauDiemToiDa { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public int HeSo { get; set; }
}
