using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwXemNghiCoPhep
{
    public string HocSinhId { get; set; } = null!;

    public int? Nghicophep { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
