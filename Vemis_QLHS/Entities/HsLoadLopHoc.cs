using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsLoadLopHoc
{
    public string LopHocId { get; set; } = null!;

    public string TenLopHoc { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
