using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsGiaDinhHocSinh
{
    public string FkHocSinhId { get; set; } = null!;

    public int Macabiet { get; set; }

    public string? HoVaTen { get; set; }

    public string? NamSinh { get; set; }

    public string FkQuanHeGiaDinhId { get; set; } = null!;

    public string? FkNgheNghiepId { get; set; }

    public string? GdDienThoai { get; set; }

    public string? DonViCongTac { get; set; }

    public bool IsLocked { get; set; }
}
