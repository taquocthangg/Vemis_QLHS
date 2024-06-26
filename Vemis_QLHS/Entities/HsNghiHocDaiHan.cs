using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsNghiHocDaiHan
{
    public int Ma { get; set; }

    public string FkHocsinhId { get; set; } = null!;

    public DateTime NgayBatDauNghi { get; set; }

    public DateTime? NgayHocLai { get; set; }

    public string? NguoiQuyetDinh { get; set; }

    public string? LyDo { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool Islocked { get; set; }
}
