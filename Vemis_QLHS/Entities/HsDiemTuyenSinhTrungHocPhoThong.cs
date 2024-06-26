using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDiemTuyenSinhTrungHocPhoThong
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public double? GiaTriDiem { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
