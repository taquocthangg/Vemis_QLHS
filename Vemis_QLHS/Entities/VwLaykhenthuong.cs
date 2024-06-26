using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwLaykhenthuong
{
    public string FkHocSinhId { get; set; } = null!;

    public string? HinhThucKhenThuong { get; set; }

    public string? NgayKhenThuong { get; set; }

    public string? GhiChu { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
