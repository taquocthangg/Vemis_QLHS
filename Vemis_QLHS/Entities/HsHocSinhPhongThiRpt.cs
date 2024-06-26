using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsHocSinhPhongThiRpt
{
    public string? FkHocSinhId { get; set; }

    public string? SoBaoDanh { get; set; }

    public string? FkMonHocId { get; set; }

    public string? PhongThi { get; set; }

    public string? TenPhongThi { get; set; }

    public string? TenLopHoc { get; set; }

    public string? FkLopHocId { get; set; }

    public string? HoVaTen { get; set; }

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public bool? IsDelete { get; set; }

    public string GioiTinh { get; set; } = null!;

    public bool? IsActived { get; set; }

    public int Active { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? FkKyThiId { get; set; }

    public string? FkNamHocId { get; set; }

    public string? FkNhomThiId { get; set; }
}
