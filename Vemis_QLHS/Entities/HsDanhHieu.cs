using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDanhHieu
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkDanhHieuId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;
}
