using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsChiTietNghiHoc
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkChuyenCanId { get; set; } = null!;

    public DateTime NgayNghi { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
