using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwDmhocSinhTuyenSinh
{
    public int Active { get; set; }

    public string FkHocSinhId { get; set; } = null!;

    public string Sbd { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string KhoiHoc { get; set; } = null!;
}
