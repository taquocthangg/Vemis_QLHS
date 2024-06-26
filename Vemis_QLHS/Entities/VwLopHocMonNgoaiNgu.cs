using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwLopHocMonNgoaiNgu
{
    public string FkLopHocId { get; set; } = null!;

    public string FkMonNgoaiNguId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public int Active { get; set; }

    public bool HeNgoaiNgu { get; set; }
}
