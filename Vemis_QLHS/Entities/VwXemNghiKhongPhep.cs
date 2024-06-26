using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwXemNghiKhongPhep
{
    public string HocSinhId { get; set; } = null!;

    public int? Nghikhongphep { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
