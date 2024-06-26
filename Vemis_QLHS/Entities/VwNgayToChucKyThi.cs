using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwNgayToChucKyThi
{
    public int Active { get; set; }

    public bool IsActived { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;

    public string TenKyThi { get; set; } = null!;

    public string TenNamHoc { get; set; } = null!;
}
