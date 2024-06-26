using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsNgayToChucKyThi
{
    public string FkKyThiId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsActived { get; set; }

    public virtual ICollection<HsNhomThi> HsNhomThis { get; set; } = new List<HsNhomThi>();
}
