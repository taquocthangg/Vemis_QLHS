using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwQuocTich
{
    public int Ma { get; set; }

    public string Ten { get; set; } = null!;

    public int Active { get; set; }
}
