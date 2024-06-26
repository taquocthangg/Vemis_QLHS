using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class SobuoinghitheoH
{
    public int? TongSoBuoiNghi { get; set; }

    public string HocSinhId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
