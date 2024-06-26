using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwTruong
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

    public int Active { get; set; }

    public string? TenTinh { get; set; }

    public string? FkTinhId { get; set; }

    public string? TenQuanHuyen { get; set; }

    public string? FkQuanHuyenId { get; set; }

    public string? TenPhuongXa { get; set; }

    public string? FkPhuongXaId { get; set; }
}
