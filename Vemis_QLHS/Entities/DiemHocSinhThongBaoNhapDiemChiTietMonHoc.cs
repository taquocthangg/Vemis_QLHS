using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class DiemHocSinhThongBaoNhapDiemChiTietMonHoc
{
    public string? TenLopHoc { get; set; }

    public string? TenMonHoc { get; set; }

    public DateTime? NgayHetHanNhapDiem { get; set; }

    public string? TenLoaiDiem { get; set; }

    public int ThuTuDauDiemNhap { get; set; }
}
