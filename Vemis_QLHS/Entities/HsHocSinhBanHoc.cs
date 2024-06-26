﻿using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsHocSinhBanHoc
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkBanHocId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;
}
