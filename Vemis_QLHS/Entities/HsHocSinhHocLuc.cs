using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsHocSinhHocLuc
{
    public string FkHocSinhId { get; set; } = null!;

    public string? FkHocLucId { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;
}
