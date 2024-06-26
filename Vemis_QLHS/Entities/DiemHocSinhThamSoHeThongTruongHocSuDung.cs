using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhThamSoHeThongTruongHocSuDung
{
    public string MaTruongHoc { get; set; } = null!;

    public string? TenTruongHoc { get; set; }

    public string MaHocKy { get; set; } = null!;

    public string? TenHocKy { get; set; }

    public string MaNamHoc { get; set; } = null!;

    public string? TenNamHoc { get; set; }

    public string? MaNhomCapHoc { get; set; }
}
