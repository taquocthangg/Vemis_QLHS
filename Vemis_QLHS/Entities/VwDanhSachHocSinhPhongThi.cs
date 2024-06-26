using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwDanhSachHocSinhPhongThi
{
    public string? SoBaoDanh { get; set; }

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgaySinh { get; set; }

    public bool? NhapNam { get; set; }

    public bool? NhapThangNam { get; set; }

    public string FkPhongThiId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public bool? IsDelete { get; set; }
}
