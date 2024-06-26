using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmNghiCoPhepCaNam
{
    public string HocSinhId { get; set; } = null!;

    public int? NghiCoPhep { get; set; }

    public string FkNamHocId { get; set; } = null!;
}
