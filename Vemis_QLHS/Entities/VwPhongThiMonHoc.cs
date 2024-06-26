using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwPhongThiMonHoc
{
    public int Active { get; set; }

    public string FkPhongThiId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkNhomThiId { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;

    public DateTime? NgayThi { get; set; }

    public bool IsLocked { get; set; }

    public string TenMonHoc { get; set; } = null!;
}
