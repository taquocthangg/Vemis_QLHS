using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwPhongThi
{
    public string PhongThiId { get; set; } = null!;

    public string TenPhongThi { get; set; } = null!;

    public int Active { get; set; }

    public string FkNhomThiId { get; set; } = null!;

    public string TenNhomThi { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
