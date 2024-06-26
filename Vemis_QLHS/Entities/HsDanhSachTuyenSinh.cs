using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDanhSachTuyenSinh
{
    public string FkHocSinhId { get; set; } = null!;

    public string Sbd { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string KhoiHoc { get; set; } = null!;

    public string? FkBanHocId { get; set; }

    public string FkMonHocId { get; set; } = null!;

    public double? Diem { get; set; }

    public bool IsMonChuyen { get; set; }
}
