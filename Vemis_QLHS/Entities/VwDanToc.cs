using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vemis_QLHS.Entities;

public partial class VwDanToc
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int Active { get; set; }
}
