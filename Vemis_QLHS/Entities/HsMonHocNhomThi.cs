using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsMonHocNhomThi
{
    public string FkNhomThiId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public virtual HsNhomThi HsNhomThi { get; set; } = null!;
}
