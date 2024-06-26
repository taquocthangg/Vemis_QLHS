using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwPhanLopH
{
    public string FkLopHocId { get; set; } = null!;

    public string FkHocSinhId { get; set; } = null!;

    public string TenLopHoc { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
