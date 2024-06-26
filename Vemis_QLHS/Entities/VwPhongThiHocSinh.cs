using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwPhongThiHocSinh
{
    public string FkMonHocId { get; set; } = null!;

    public string FkPhongThiId { get; set; } = null!;

    public string? HoVaTen { get; set; }

    public int Active { get; set; }

    public string? SoBaoDanh { get; set; }

    public string FkNhomThiId { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public string FkHocSinhId { get; set; } = null!;

    public string? TenLopHoc { get; set; }

    public string? FkLopHocId { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? HoDemTenDem { get; set; }

    public string? GioiTinh { get; set; }

    public string FkKyThiId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
