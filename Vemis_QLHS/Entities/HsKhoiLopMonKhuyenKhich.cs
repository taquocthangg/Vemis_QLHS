﻿using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsKhoiLopMonKhuyenKhich
{
    public string FkKhoiLopId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}