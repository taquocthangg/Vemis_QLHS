using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsHoSoSuKien
{
    public string FkHocSinhId { get; set; } = null!;

    public DateTime? NgayThang { get; set; }

    public int Macabiet { get; set; }

    public string? SuKien { get; set; }

    public string? GhiChu { get; set; }

    public bool IsLocked { get; set; }
}
