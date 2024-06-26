using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsKhenThuong
{
    public int Matang { get; set; }

    public string FkHocSinhId { get; set; } = null!;

    public string? HinhThucKhenThuong { get; set; }

    public DateTime? NgayKhenThuong { get; set; }

    public string? GhiChu { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
