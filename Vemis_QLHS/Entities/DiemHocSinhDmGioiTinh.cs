using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmGioiTinh
{
    public string GioiTinhId { get; set; } = null!;

    public string TenGioiTinh { get; set; } = null!;

    public int Active { get; set; }
}
