using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhThamSoHeThong
{
    public string DonViSuDungId { get; set; } = null!;

    public string? TenDonViSuDung { get; set; }

    public string HocKyId { get; set; } = null!;

    public string NamHocId { get; set; } = null!;

    public string? MayChu { get; set; }
}
