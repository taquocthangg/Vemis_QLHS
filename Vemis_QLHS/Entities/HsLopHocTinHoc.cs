using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsLopHocTinHoc
{
    public string FkLopHocId { get; set; } = null!;

    public bool IsHocTin { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
