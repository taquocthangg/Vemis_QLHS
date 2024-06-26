using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsHienTai
{
    public string FkHocSinhId { get; set; } = null!;

    public string? FkNguonTuyenId { get; set; }

    public string? FkLuaHocSinhId { get; set; }

    public string? FkChucVuLopId { get; set; }

    public string? FkChucVuDoanTheId { get; set; }

    public string? FkMonHocNghePhoThongId { get; set; }

    public string? FkChungChiNgheDaCoId { get; set; }

    public string? FkNgoaiNguId { get; set; }

    public string? FkNgoaiNguThu2Id { get; set; }

    public string? FkTinhTrangId { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public bool IsLocked { get; set; }

    public virtual HsHoSoHocSinh FkHocSinh { get; set; } = null!;
}
