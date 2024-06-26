using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDiemThiMonTiengVietCuaTieuHoc
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkMaKyThiId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public int DiemThi { get; set; }

    public bool DiemDocHoacDiemViet { get; set; }

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;
}
