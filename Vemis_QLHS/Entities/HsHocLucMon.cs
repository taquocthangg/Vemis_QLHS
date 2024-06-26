using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsHocLucMon
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkHocLucId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;
}
