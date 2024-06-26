using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDiemThi
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkMonThiId { get; set; } = null!;

    public string FkMaKyThiId { get; set; } = null!;

    public double? DiemThi { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;
}
