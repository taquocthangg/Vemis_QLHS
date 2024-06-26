using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class Selectalluutienchinhsachkhuyettattheolop
{
    public string HocSinhId { get; set; } = null!;

    public string FkLopHocId { get; set; } = null!;

    public string? GioiTinh { get; set; }

    public string? DanToc { get; set; }

    public string? FkUuTienId { get; set; }

    public string? FkUuDaiId { get; set; }

    public string? FkKhuyetTatId { get; set; }
}
