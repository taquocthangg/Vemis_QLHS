using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsChuyenLop
{
    public string FkHocSinhId { get; set; } = null!;

    public string? FkLopCuId { get; set; }

    public string? FkLopMoiId { get; set; }

    public DateTime? NgayChuyenLop { get; set; }

    public string? NguoiQuyetDinh { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public int MaTang { get; set; }

    public int? Stt { get; set; }

    public string? HocKyCu { get; set; }
}
