using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwDanhSachHocSinhP
{
    public string Hocsinhid { get; set; } = null!;

    public string? HoTen { get; set; }

    public string? Ngaysinh { get; set; }

    public string? Noisinh { get; set; }

    public string? GioiTinh { get; set; }

    public string? Quequan { get; set; }
}
