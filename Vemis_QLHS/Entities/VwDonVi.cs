using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwDonVi
{
    public string Ma { get; set; } = null!;

    public string? Ten { get; set; }

    public string? MaCha { get; set; }

    public int Active { get; set; }
}
