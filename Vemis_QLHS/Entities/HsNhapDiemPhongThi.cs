using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsNhapDiemPhongThi
{
    public string Sbd { get; set; } = null!;

    public string? HoTen { get; set; }

    public string? NgaySinh { get; set; }

    public bool? NhapThangNam { get; set; }

    public bool? NhapNam { get; set; }

    public bool? IsDelete { get; set; }

    public string? GioiTinh { get; set; }

    public string? FkMonHocId { get; set; }

    public string? FkPhongThiId { get; set; }

    public string? FkNhomThiId { get; set; }

    public string? TenPhongThi { get; set; }

    public string? TenNhomThi { get; set; }

    public int Active { get; set; }

    public string? TenLopHoc { get; set; }

    public string? FkKyThiId { get; set; }

    public string? FkNamHocId { get; set; }

    public bool? IsActived { get; set; }

    public string? FkHocSinhId { get; set; }

    public bool? IsLocked { get; set; }

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }
}
