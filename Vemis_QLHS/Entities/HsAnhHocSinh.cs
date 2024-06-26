using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsAnhHocSinh
{
    
    public string FkHocSinhId { get; set; } = null!;

    public string? DuongDanToiTepAnh { get; set; }

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;
}
