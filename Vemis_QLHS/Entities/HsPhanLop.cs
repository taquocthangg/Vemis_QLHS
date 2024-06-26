using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsPhanLop
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkLopHocId { get; set; } = null!;

    public int? Stt { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;

    public virtual HsLopHoc FkLopHoc { get; set; } = null!;
}
