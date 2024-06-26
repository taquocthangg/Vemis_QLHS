using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDiemThiLoadPhongThi
{
    public string FkNhomThiId { get; set; } = null!;

    public string PhongThiId { get; set; } = null!;

    public string TenPhongThi { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsActived { get; set; }
}
