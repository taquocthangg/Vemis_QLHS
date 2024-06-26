using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class ThongTinSxdsh
{
    public string FkLopHocId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool? SapXepDshs { get; set; }
}
