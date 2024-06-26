using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwChiTietDanToc
{
    public string TenChiTietDanToc { get; set; } = null!;

    public string ChiTietDanTocId { get; set; } = null!;

    public string DanTocId { get; set; } = null!;

    public int Active { get; set; }
}
