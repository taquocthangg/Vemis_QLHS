using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsDangKyMonThiLai
{
    public string FkHocSinhId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }
}
