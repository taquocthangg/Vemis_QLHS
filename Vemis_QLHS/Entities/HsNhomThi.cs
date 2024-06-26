using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsNhomThi
{
    public string NhomThiId { get; set; } = null!;

    public string TenNhomThi { get; set; } = null!;

    public string FkKyThiId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public virtual ICollection<HsHocSinhNhomThi> HsHocSinhNhomThis { get; set; } = new List<HsHocSinhNhomThi>();

    public virtual ICollection<HsMonHocNhomThi> HsMonHocNhomThis { get; set; } = new List<HsMonHocNhomThi>();

    public virtual HsNgayToChucKyThi HsNgayToChucKyThi { get; set; } = null!;

    public virtual ICollection<HsPhongThi> HsPhongThis { get; set; } = new List<HsPhongThi>();
}
