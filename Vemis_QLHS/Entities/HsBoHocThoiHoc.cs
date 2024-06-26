using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsBoHocThoiHoc
{
    public string FkHocSinhId { get; set; } = null!;

    public DateTime? NgayBoHoc { get; set; }

    public string? NguoiQuyetDinh { get; set; }

    public string FkLoaiBoHoc { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
