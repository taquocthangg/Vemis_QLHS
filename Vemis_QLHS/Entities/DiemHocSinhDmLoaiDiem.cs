using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmLoaiDiem
{
    public string LoaiDiemId { get; set; } = null!;

    public string TenLoaiDiem { get; set; } = null!;

    public string? GhiChu { get; set; }

    public bool IsChangeable { get; set; }
}
