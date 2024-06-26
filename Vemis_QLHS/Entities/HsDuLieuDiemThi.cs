using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDuLieuDiemThi
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public double? Diem { get; set; }

    public bool IsUp { get; set; }
}
