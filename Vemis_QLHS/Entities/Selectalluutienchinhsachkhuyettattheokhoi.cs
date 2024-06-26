using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class Selectalluutienchinhsachkhuyettattheokhoi
{
    public string Hocsinhid { get; set; } = null!;

    public string? Khoi { get; set; }

    public string? GioiTinh { get; set; }

    public string? DanToc { get; set; }

    public string? FkUuTienId { get; set; }

    public string? FkUuDaiId { get; set; }

    public string? FkKhuyetTatId { get; set; }
}
