﻿using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwDangKyNghiHocDaiHan
{
    public string FkHocsinhId { get; set; } = null!;

    public string? HoTen { get; set; }

    public DateTime? NgaySinh { get; set; }

    public DateTime NgayBatDauNghi { get; set; }

    public string? NguoiQuyetDinh { get; set; }

    public string? LyDo { get; set; }

    public DateTime? NgayHocLai { get; set; }
}