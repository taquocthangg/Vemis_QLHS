using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsLoadNhomThi
{
    public string NhomThiId { get; set; } = null!;

    public string TenNhomThi { get; set; } = null!;

    public bool IsActived { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;
}
