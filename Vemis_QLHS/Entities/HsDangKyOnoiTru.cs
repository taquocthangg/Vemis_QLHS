using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDangKyOnoiTru
{
    public string FkHocSinhId { get; set; } = null!;

    public DateTime? NgayBatDauOnoiTru { get; set; }

    public string? PhongO { get; set; }

    public int? ChiPhi { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
