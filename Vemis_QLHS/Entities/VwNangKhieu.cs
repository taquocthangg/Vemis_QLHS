using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwNangKhieu
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int Active { get; set; }
}
