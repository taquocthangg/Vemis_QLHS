using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsHocSinhNhomThi
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkNhomThiId { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public virtual ICollection<HsHocSinhBoThi> HsHocSinhBoThis { get; set; } = new List<HsHocSinhBoThi>();

    public virtual ICollection<HsHocSinhPhongThi> HsHocSinhPhongThis { get; set; } = new List<HsHocSinhPhongThi>();

    public virtual HsHocSinhSbd? HsHocSinhSbd { get; set; }

    public virtual HsNhomThi HsNhomThi { get; set; } = null!;
}
