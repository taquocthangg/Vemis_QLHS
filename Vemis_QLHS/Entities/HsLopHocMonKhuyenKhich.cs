﻿using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsLopHocMonKhuyenKhich
{
    public string FkLopHocId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
