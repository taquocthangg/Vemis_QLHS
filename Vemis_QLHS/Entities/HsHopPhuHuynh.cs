﻿using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsHopPhuHuynh
{
    public string FkHocSinhId { get; set; } = null!;

    public bool? DaKiemTra { get; set; }

    public bool? GhiChuChoPhuHuynh { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
