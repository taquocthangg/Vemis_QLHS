using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwLoaiBanHocMonHoc
{
    public string FkMonHocId { get; set; } = null!;

    public string FkBanHocId { get; set; } = null!;

    public bool? IsNangCaoTuNhien { get; set; }

    public bool? IsNangCaoXaHoi { get; set; }

    public bool? IsTuChon { get; set; }

    public bool? IsMienThucHanh { get; set; }

    public bool? IsMienLyThuyet { get; set; }

    public bool? IsChangeable { get; set; }

    public string? TenMonHoc { get; set; }

    public int Active { get; set; }

    public short? HeSoDiem { get; set; }
}
