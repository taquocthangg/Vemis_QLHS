using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwNhomThi
{
    public string NhomThiId { get; set; } = null!;

    public string TenNhomThi { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public int Active { get; set; }
}
