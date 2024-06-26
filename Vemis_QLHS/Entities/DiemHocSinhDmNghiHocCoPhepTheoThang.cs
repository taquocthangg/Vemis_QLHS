using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmNghiHocCoPhepTheoThang
{
    public string HocSinhId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public int? Ngaynghi { get; set; }

    public int? ThangNghi { get; set; }

    public int? NamNghi { get; set; }
}
