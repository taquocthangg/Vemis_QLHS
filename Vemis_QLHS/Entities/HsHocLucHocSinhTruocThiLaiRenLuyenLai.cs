using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsHocLucHocSinhTruocThiLaiRenLuyenLai
{
    public string FkHocSinhId { get; set; } = null!;

    public string? FkHocLucId { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
