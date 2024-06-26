using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsBoHocLoadDatum
{
    public string FkHocSinhId { get; set; } = null!;

    public DateTime? NgayBoHoc { get; set; }

    public string? NguoiQuyetDinh { get; set; }

    public string LyDoThoiHocId { get; set; } = null!;

    public string LyDoBoHoc { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public string TenLopHoc { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string TenGioiTinh { get; set; } = null!;

    public string? HoTen { get; set; }

    public bool? IsDelete { get; set; }

    public int Active { get; set; }

    public string LopHocId { get; set; } = null!;
}
