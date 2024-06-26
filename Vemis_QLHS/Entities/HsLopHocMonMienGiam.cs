using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsLopHocMonMienGiam
{
    public string FkLopHocId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public virtual HsLopHoc FkLopHoc { get; set; } = null!;
}
