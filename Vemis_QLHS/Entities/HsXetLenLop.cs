using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsXetLenLop
{
    public string FkHocSinhId { get; set; } = null!;

    public string XetLenLop { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
