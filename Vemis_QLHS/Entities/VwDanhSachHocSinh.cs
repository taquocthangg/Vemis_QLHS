﻿using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwDanhSachHocSinh
{
    public string? HoDem { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? NoiSinh { get; set; }

    public string? GioiTinh { get; set; }

    public string? QueQuan { get; set; }

    public string? FkQuocTichId { get; set; }

    public string? FkDanTocId { get; set; }

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

    public bool? QuaMauGiao5Tuoi { get; set; }

    public int? KhoangCachDenTruong { get; set; }

    public string? GhiChu { get; set; }

    public int Active { get; set; }

    public string? FkChucVuLopId { get; set; }

    public string? FkChucVuDoanTheId { get; set; }

    public string? FkMonHocNghePhoThongId { get; set; }

    public string? FkChungChiNgheDaCoId { get; set; }

    public string? FkNgoaiNguId { get; set; }

    public string? FkNgoaiNguThu2Id { get; set; }

    public string? FkTinhTrangId { get; set; }

    public string? FkLuaHocSinhId { get; set; }

    public string? FkNguonTuyenId { get; set; }

    public double? ChieuCao { get; set; }

    public double? CanNang { get; set; }

    public bool? ChatDocDaCam { get; set; }

    public bool? TaiNan { get; set; }

    public bool? KhamDinhKy { get; set; }

    public bool? TieuChay { get; set; }

    public bool? HoHap { get; set; }

    public bool? NgoaiDa { get; set; }

    public string? FkNhomMauId { get; set; }

    public string? FkThiLucId { get; set; }

    public string Ma { get; set; } = null!;

    public bool? NhapNam { get; set; }

    public bool? NhapThangNam { get; set; }

    public bool? DanTocCheck { get; set; }

    public string? FkDanTocThuongDungId { get; set; }

    public bool? IsDelete { get; set; }

    public string? HoVaTen { get; set; }

    public string? TenDem { get; set; }

    public string? FkKieuHienThiId { get; set; }

    public string? DuongDanToiTepAnh { get; set; }
}