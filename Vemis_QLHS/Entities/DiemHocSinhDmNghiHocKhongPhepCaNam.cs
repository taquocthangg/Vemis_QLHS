using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmNghiHocKhongPhepCaNam
{
    public string HocSinhId { get; set; } = null!;

    public int? NghiKhongPhep { get; set; }

    public string FkNamHocId { get; set; } = null!;
}
