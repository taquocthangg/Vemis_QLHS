﻿using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsKetQuaThiLaiMonTinhDiemTieuHoc
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public int? DiemThiLai { get; set; }

    public string? TongKetCaNamLan1 { get; set; }

    public string? TongKetCaNamLan2 { get; set; }
}
