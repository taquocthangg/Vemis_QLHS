using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwHocSinhMonHoc
{
    public string FkHocSinhId { get; set; } = null!;

    public short HeSoDiem { get; set; }

    public bool IsNangCaoTuNhien { get; set; }

    public bool IsNangCaoXaHoi { get; set; }

    public bool IsTuChon { get; set; }

    public bool IsMienThucHanh { get; set; }

    public bool IsMienLyThuyet { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public int Active { get; set; }

    public string FkMonHocId { get; set; } = null!;

    public string? TenMonHoc { get; set; }
}
