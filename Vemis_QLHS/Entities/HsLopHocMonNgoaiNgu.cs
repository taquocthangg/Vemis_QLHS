using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsLopHocMonNgoaiNgu
{
    public string FkLopHocId { get; set; } = null!;

    public string FkMonNgoaiNguId { get; set; } = null!;

    public bool HeNgoaiNgu { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
