using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmNghiKhongPhep
{
    public string HocSinhId { get; set; } = null!;

    public int? NghiKhongPhep { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
