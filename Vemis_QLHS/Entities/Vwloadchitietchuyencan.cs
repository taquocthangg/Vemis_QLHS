using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class Vwloadchitietchuyencan
{
    public string HocSinhId { get; set; } = null!;

    public string? HoTen { get; set; }

    public string? Ngaysinh { get; set; }

    public string? GioiTinh { get; set; }

    public string LopId { get; set; } = null!;

    public string TenLop { get; set; } = null!;

    public string ChuyencanId { get; set; } = null!;

    public string TenChuyenCan { get; set; } = null!;

    public string? NgayNghiHoc { get; set; }
}
