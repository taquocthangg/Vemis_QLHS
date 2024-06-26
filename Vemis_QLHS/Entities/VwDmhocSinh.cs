using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwDmhocSinh
{
    public string HocSinhId { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? Ten { get; set; }

    public string? HoVaTen { get; set; }

    public int Active { get; set; }

    public bool? IsDelete { get; set; }
}
