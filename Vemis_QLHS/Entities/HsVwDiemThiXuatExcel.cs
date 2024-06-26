using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsVwDiemThiXuatExcel
{
    public string TenMonHoc { get; set; } = null!;

    public string FkPhongThiId { get; set; } = null!;

    public string TenPhongThi { get; set; } = null!;

    public string FkNhomThiId { get; set; } = null!;

    public string TenNhomThi { get; set; } = null!;

    public bool IsActived { get; set; }

    public string FkMonHocId { get; set; } = null!;

    public int Active { get; set; }

    public string FkKyThiId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;
}
