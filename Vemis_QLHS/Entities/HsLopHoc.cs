using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsLopHoc
{
    public string LopHocId { get; set; } = null!;

    public string TenLopHoc { get; set; } = null!;

    public string? FkHocKyId { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public virtual HsDangKyLopChuyenBan? HsDangKyLopChuyenBan { get; set; }

    public virtual ICollection<HsLopHocMonMienGiam> HsLopHocMonMienGiams { get; set; } = new List<HsLopHocMonMienGiam>();

    public virtual ICollection<HsPhanLop> HsPhanLops { get; set; } = new List<HsPhanLop>();
}
