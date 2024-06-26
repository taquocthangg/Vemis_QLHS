using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsLoadDataH
{
    public string? HocSinhId { get; set; }

    public string? HoDem { get; set; }

    public string? TenDem { get; set; }

    public string? Ten { get; set; }

    public string? FkKieuHienThiId { get; set; }

    public bool? NhapThangNam { get; set; }

    public bool? NhapNam { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? NoiSinh { get; set; }

    public string? GioiTinh { get; set; }

    public string? QueQuan { get; set; }

    public string? FkQuocTichId { get; set; }

    public string? FkDanTocId { get; set; }

    public string? FkDanTocThuongDungId { get; set; }

    public bool? DanTocCheck { get; set; }

    public string? FkTonGiaoId { get; set; }

    public string? NoiOhienNay { get; set; }

    public string? FkMaXaId { get; set; }

    public string? FkMaHuyenId { get; set; }

    public string? FkMaTinhId { get; set; }

    public string? FkMaXaDangKyHoKhauId { get; set; }

    public string? FkMaHuyenDangKyHoKhauId { get; set; }

    public string? FkMaTinhDangKyHoKhauId { get; set; }

    public string? FkUuTienId { get; set; }

    public string? FkUuDaiId { get; set; }

    public bool? HuongDanTocNoiTru { get; set; }

    public string? FkKhuyetTatId { get; set; }

    public string? FkDangDoanDoiId { get; set; }

    public bool? DangVien { get; set; }

    public string? FkHonNhanId { get; set; }

    public string? FkNangKhieuId { get; set; }

    public bool? IsDelete { get; set; }

    public string? TenLopHoc { get; set; }

    public bool? IsLockedLop { get; set; }

    public string? FkLopHocId { get; set; }

    public string? FkHocKyId { get; set; }

    public string FkNamHocId { get; set; } = null!;

    public string IsChuyenLop { get; set; } = null!;

    public string HocKyChuyen { get; set; } = null!;

    public bool IsKbctk { get; set; }
}
