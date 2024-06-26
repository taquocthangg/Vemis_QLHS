using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsKetQuaRenLuyenLaiTrongHe
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string? FkHanhKiemIdLan1 { get; set; }

    public string? FkHanhKiemIdLan2 { get; set; }
}
