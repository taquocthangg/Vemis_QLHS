using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwMonNgoaiNgu
{
    public string MonNgoaiNguId { get; set; } = null!;

    public string TenMonNgoaiNgu { get; set; } = null!;

    public int Active { get; set; }
}
