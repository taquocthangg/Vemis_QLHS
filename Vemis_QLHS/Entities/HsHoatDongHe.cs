using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsHoatDongHe
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkKetQuaId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
