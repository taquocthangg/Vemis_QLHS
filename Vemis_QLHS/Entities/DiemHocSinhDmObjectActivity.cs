using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmObjectActivity
{
    public string? Students { get; set; }

    public string? Teacher { get; set; }

    public string? Subject { get; set; }

    public int FkTimetableId { get; set; }
}
