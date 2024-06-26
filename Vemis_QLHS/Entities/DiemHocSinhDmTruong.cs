using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhDmTruong
{
    public string TruongId { get; set; } = null!;

    public string? FkNhomCapHocId { get; set; }

    public string? FkHeThongGiaoDucId { get; set; }

    public string? TruongChuyenBietId { get; set; }

    public string? FkLoaiHinhTruongId { get; set; }

    public string? FkDonViId { get; set; }

    public string? TenTruong { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }
}
