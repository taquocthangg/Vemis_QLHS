using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsThongBaoNhapDiemChiTietMonHoc
{
    public string FkLopHocId { get; set; } = null!;

    public string FkMonHocId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string FkHocKyId { get; set; } = null!;

    public string FkLoaiDiemId { get; set; } = null!;

    public int ThuTuDauDiemNhap { get; set; }

    public DateTime? NgayHetHanNhapDiem { get; set; }
}
