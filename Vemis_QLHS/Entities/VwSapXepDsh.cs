using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwSapXepDsh
{
    public string FkHocSinhId { get; set; } = null!;

    public int? Stt { get; set; }

    public string? HoVaTen { get; set; }

    public string FkLopHocId { get; set; } = null!;

    public string? Ten { get; set; }

    public string? TenDem { get; set; }

    public string? HoDem { get; set; }

    public string FkHocKyId { get; set; } = null!;

    public string FkNamHocId { get; set; } = null!;

    public string? FkKieuHienThiId { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? NoiSinh { get; set; }

    public string? GioiTinh { get; set; }

    public bool? NhapThangNam { get; set; }

    public bool? NhapNam { get; set; }

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

    public string? Email { get; set; }

    public string? DienThoai { get; set; }

    public string? FkUuTienId { get; set; }

    public string? FkUuDaiId { get; set; }

    public bool? HuongDanTocNoiTru { get; set; }

    public string? FkKhuyetTatId { get; set; }

    public string? FkDangDoanDoiId { get; set; }

    public DateTime? NgayKetNap { get; set; }

    public bool? DangVien { get; set; }

    public DateTime? NgayKetNapVaoDang { get; set; }

    public DateTime? NgayChinhThucKetNapDang { get; set; }

    public string? FkHonNhanId { get; set; }

    public string? FkNangKhieuId { get; set; }

    public bool? Otro { get; set; }

    public int? KhoangCachDenTruong { get; set; }

    public string? GhiChu { get; set; }

    public bool? QuaMauGiao5Tuoi { get; set; }

    public bool? IsDelete { get; set; }
}
