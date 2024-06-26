using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwBanHocMonHoc
{
    public string FkMonHocId { get; set; } = null!;

    public string FkBanHocId { get; set; } = null!;

    public string TenMonHoc { get; set; } = null!;
}
