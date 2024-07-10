using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vemis_QLHS.Entities;

public partial class VemisStudentContext : DbContext
{
    public VemisStudentContext()
    {
    }

    public VemisStudentContext(DbContextOptions<VemisStudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DiemHocSinhDmBanHoc> DiemHocSinhDmBanHocs { get; set; }

    public virtual DbSet<DiemHocSinhDmChiTietBanHoc> DiemHocSinhDmChiTietBanHocs { get; set; }

    public virtual DbSet<DiemHocSinhDmChuyenCan> DiemHocSinhDmChuyenCans { get; set; }

    public virtual DbSet<DiemHocSinhDmDanToc> DiemHocSinhDmDanTocs { get; set; }

    public virtual DbSet<DiemHocSinhDmDanhHieu> DiemHocSinhDmDanhHieus { get; set; }

    public virtual DbSet<DiemHocSinhDmDiemDanhGiaTieuHoc> DiemHocSinhDmDiemDanhGiaTieuHocs { get; set; }

    public virtual DbSet<DiemHocSinhDmDiemDanhGiaTrenTieuHoc> DiemHocSinhDmDiemDanhGiaTrenTieuHocs { get; set; }

    public virtual DbSet<DiemHocSinhDmGioiTinh> DiemHocSinhDmGioiTinhs { get; set; }

    public virtual DbSet<DiemHocSinhDmHanhKiemTieuHoc> DiemHocSinhDmHanhKiemTieuHocs { get; set; }

    public virtual DbSet<DiemHocSinhDmHanhKiemTrenTieuHoc> DiemHocSinhDmHanhKiemTrenTieuHocs { get; set; }

    public virtual DbSet<DiemHocSinhDmHocKy> DiemHocSinhDmHocKies { get; set; }

    public virtual DbSet<DiemHocSinhDmHocLuc> DiemHocSinhDmHocLucs { get; set; }

    public virtual DbSet<DiemHocSinhDmKhoiLop> DiemHocSinhDmKhoiLops { get; set; }

    public virtual DbSet<DiemHocSinhDmKyThi> DiemHocSinhDmKyThis { get; set; }

    public virtual DbSet<DiemHocSinhDmLoaiDiem> DiemHocSinhDmLoaiDiems { get; set; }

    public virtual DbSet<DiemHocSinhDmMonHoc> DiemHocSinhDmMonHocs { get; set; }

    public virtual DbSet<DiemHocSinhDmMonHocKhoiLop> DiemHocSinhDmMonHocKhoiLops { get; set; }

    public virtual DbSet<DiemHocSinhDmNamHoc> DiemHocSinhDmNamHocs { get; set; }

    public virtual DbSet<DiemHocSinhDmNgheNghiep> DiemHocSinhDmNgheNghieps { get; set; }

    public virtual DbSet<DiemHocSinhDmNghiCoPhepCaNam> DiemHocSinhDmNghiCoPhepCaNams { get; set; }

    public virtual DbSet<DiemHocSinhDmNghiHocCoPhep> DiemHocSinhDmNghiHocCoPheps { get; set; }

    public virtual DbSet<DiemHocSinhDmNghiHocCoPhepTheoThang> DiemHocSinhDmNghiHocCoPhepTheoThangs { get; set; }

    public virtual DbSet<DiemHocSinhDmNghiHocKhongPhepCaNam> DiemHocSinhDmNghiHocKhongPhepCaNams { get; set; }

    public virtual DbSet<DiemHocSinhDmNghiHocKhongPhepTheoThang> DiemHocSinhDmNghiHocKhongPhepTheoThangs { get; set; }

    public virtual DbSet<DiemHocSinhDmNghiKhongPhep> DiemHocSinhDmNghiKhongPheps { get; set; }

    public virtual DbSet<DiemHocSinhDmNhomCapHoc> DiemHocSinhDmNhomCapHocs { get; set; }

    public virtual DbSet<DiemHocSinhDmObjectActivity> DiemHocSinhDmObjectActivities { get; set; }

    public virtual DbSet<DiemHocSinhDmTimetableList> DiemHocSinhDmTimetableLists { get; set; }

    public virtual DbSet<DiemHocSinhDmTongSoNgayNghiTrongThang> DiemHocSinhDmTongSoNgayNghiTrongThangs { get; set; }

    public virtual DbSet<DiemHocSinhDmTruong> DiemHocSinhDmTruongs { get; set; }

    public virtual DbSet<DiemHocSinhDmXetLenLop> DiemHocSinhDmXetLenLops { get; set; }

    public virtual DbSet<DiemHocSinhThamSoHeThong> DiemHocSinhThamSoHeThongs { get; set; }

    public virtual DbSet<DiemHocSinhThamSoHeThongTruongHocSuDung> DiemHocSinhThamSoHeThongTruongHocSuDungs { get; set; }

    public virtual DbSet<DiemHocSinhThongBaoNhapDiemChiTietMonHoc> DiemHocSinhThongBaoNhapDiemChiTietMonHocs { get; set; }

    public virtual DbSet<DmDiemDanhGiaTrenTieuHocTt58> DmDiemDanhGiaTrenTieuHocTt58s { get; set; }

    public virtual DbSet<HsAnhHocSinh> HsAnhHocSinhs { get; set; }

    public virtual DbSet<HsBangDiemChiTietHocKy> HsBangDiemChiTietHocKies { get; set; }

    public virtual DbSet<HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc> HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs { get; set; }

    public virtual DbSet<HsBangDiemDanhGiaThuongXuyen> HsBangDiemDanhGiaThuongXuyens { get; set; }

    public virtual DbSet<HsBangDiemKiemTraThuongXuyenApDungChoTieuHoc> HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs { get; set; }

    public virtual DbSet<HsBoHocLoadDatum> HsBoHocLoadData { get; set; }

    public virtual DbSet<HsBoHocRptDatum> HsBoHocRptData { get; set; }

    public virtual DbSet<HsBoHocThoiHoc> HsBoHocThoiHocs { get; set; }

    public virtual DbSet<HsChiTietNghiHoc> HsChiTietNghiHocs { get; set; }

    public virtual DbSet<HsChuyenCan> HsChuyenCans { get; set; }

    public virtual DbSet<HsChuyenLop> HsChuyenLops { get; set; }

    public virtual DbSet<HsChuyenLopLoadDatum> HsChuyenLopLoadData { get; set; }

    public virtual DbSet<HsChuyenLopRptAll> HsChuyenLopRptAlls { get; set; }

    public virtual DbSet<HsChuyenLopVwPhanLop> HsChuyenLopVwPhanLops { get; set; }

    public virtual DbSet<HsChuyenTruong> HsChuyenTruongs { get; set; }

    public virtual DbSet<HsDanTocThuongDung> HsDanTocThuongDungs { get; set; }

    public virtual DbSet<HsDangKyLopChuyen> HsDangKyLopChuyens { get; set; }

    public virtual DbSet<HsDangKyLopChuyenBan> HsDangKyLopChuyenBans { get; set; }

    public virtual DbSet<HsDangKyMonThiLai> HsDangKyMonThiLais { get; set; }

    public virtual DbSet<HsDangKyOnoiTru> HsDangKyOnoiTrus { get; set; }

    public virtual DbSet<HsDanhGiaHanhKiemThuongXuyenBacTieuHoc> HsDanhGiaHanhKiemThuongXuyenBacTieuHocs { get; set; }

    public virtual DbSet<HsDanhHieu> HsDanhHieus { get; set; }

    public virtual DbSet<HsDanhSachTuyenSinh> HsDanhSachTuyenSinhs { get; set; }

    public virtual DbSet<HsDataDiemThi> HsDataDiemThis { get; set; }

    public virtual DbSet<HsDiemThi> HsDiemThis { get; set; }

    public virtual DbSet<HsDiemThiLoadMonHocNhomThi> HsDiemThiLoadMonHocNhomThis { get; set; }

    public virtual DbSet<HsDiemThiLoadPhongThi> HsDiemThiLoadPhongThis { get; set; }

    public virtual DbSet<HsDiemThiLoaiDiem> HsDiemThiLoaiDiems { get; set; }

    public virtual DbSet<HsDiemThiMonDanhGiaBacTrenTieuHoc> HsDiemThiMonDanhGiaBacTrenTieuHocs { get; set; }

    public virtual DbSet<HsDiemThiMonLichSuVaDiaLyBacTieuHoc> HsDiemThiMonLichSuVaDiaLyBacTieuHocs { get; set; }

    public virtual DbSet<HsDiemThiMonTiengVietCuaTieuHoc> HsDiemThiMonTiengVietCuaTieuHocs { get; set; }

    public virtual DbSet<HsDiemThiNghe> HsDiemThiNghes { get; set; }

    public virtual DbSet<HsDiemThiTvth> HsDiemThiTvths { get; set; }

    public virtual DbSet<HsDiemTongKetHocKy> HsDiemTongKetHocKies { get; set; }

    public virtual DbSet<HsDiemTrungBinhMonDanhGiaTieuHoc> HsDiemTrungBinhMonDanhGiaTieuHocs { get; set; }

    public virtual DbSet<HsDiemTrungBinhMonDanhGiaTrenTieuHoc> HsDiemTrungBinhMonDanhGiaTrenTieuHocs { get; set; }

    public virtual DbSet<HsDiemTrungBinhMonHocKy> HsDiemTrungBinhMonHocKies { get; set; }

    public virtual DbSet<HsDiemTuyenSinhTrungHocPhoThong> HsDiemTuyenSinhTrungHocPhoThongs { get; set; }

    public virtual DbSet<HsDmkieuHienThiTen> HsDmkieuHienThiTens { get; set; }

    public virtual DbSet<HsDuLieuDiemThi> HsDuLieuDiemThis { get; set; }

    public virtual DbSet<HsGiaDinhHocSinh> HsGiaDinhHocSinhs { get; set; }

    public virtual DbSet<HsGiaTriDiemDoMonHocKhuyenKhich> HsGiaTriDiemDoMonHocKhuyenKhiches { get; set; }

    public virtual DbSet<HsHanhKiem> HsHanhKiems { get; set; }

    public virtual DbSet<HsHanhKiemTruocRenLuyenLai> HsHanhKiemTruocRenLuyenLais { get; set; }

    public virtual DbSet<HsHienTai> HsHienTais { get; set; }

    public virtual DbSet<HsHoSoHocSinh> HsHoSoHocSinhs { get; set; }

    public virtual DbSet<HsHoSoSuKien> HsHoSoSuKiens { get; set; }

    public virtual DbSet<HsHoatDongHe> HsHoatDongHes { get; set; }

    public virtual DbSet<HsHocLucHocSinhTruocThiLaiRenLuyenLai> HsHocLucHocSinhTruocThiLaiRenLuyenLais { get; set; }

    public virtual DbSet<HsHocLucMon> HsHocLucMons { get; set; }

    public virtual DbSet<HsHocSinhBanHoc> HsHocSinhBanHocs { get; set; }

    public virtual DbSet<HsHocSinhBoThi> HsHocSinhBoThis { get; set; }

    public virtual DbSet<HsHocSinhHocLuc> HsHocSinhHocLucs { get; set; }

    public virtual DbSet<HsHocSinhMonKhuyenKhich> HsHocSinhMonKhuyenKhiches { get; set; }

    public virtual DbSet<HsHocSinhMonMienGiam> HsHocSinhMonMienGiams { get; set; }

    public virtual DbSet<HsHocSinhNhomThi> HsHocSinhNhomThis { get; set; }

    public virtual DbSet<HsHocSinhPhongThi> HsHocSinhPhongThis { get; set; }

    public virtual DbSet<HsHocSinhPhongThiRpt> HsHocSinhPhongThiRpts { get; set; }

    public virtual DbSet<HsHocSinhSbd> HsHocSinhSbds { get; set; }

    public virtual DbSet<HsHopPhuHuynh> HsHopPhuHuynhs { get; set; }

    public virtual DbSet<HsKetQuaMonKhuyenKhich> HsKetQuaMonKhuyenKhiches { get; set; }

    public virtual DbSet<HsKetQuaRenLuyenLaiTrongHe> HsKetQuaRenLuyenLaiTrongHes { get; set; }

    public virtual DbSet<HsKetQuaThiHocSinhGioi> HsKetQuaThiHocSinhGiois { get; set; }

    public virtual DbSet<HsKetQuaThiKhaoSat> HsKetQuaThiKhaoSats { get; set; }

    public virtual DbSet<HsKetQuaThiLai> HsKetQuaThiLais { get; set; }

    public virtual DbSet<HsKetQuaThiLaiMonDanhGiaTieuHoc> HsKetQuaThiLaiMonDanhGiaTieuHocs { get; set; }

    public virtual DbSet<HsKetQuaThiLaiMonDanhGium> HsKetQuaThiLaiMonDanhGia { get; set; }

    public virtual DbSet<HsKetQuaThiLaiMonTinhDiemTieuHoc> HsKetQuaThiLaiMonTinhDiemTieuHocs { get; set; }

    public virtual DbSet<HsKhenThuong> HsKhenThuongs { get; set; }

    public virtual DbSet<HsKhoiLopMonKhuyenKhich> HsKhoiLopMonKhuyenKhiches { get; set; }

    public virtual DbSet<HsKhoiLopMonMienGiam> HsKhoiLopMonMienGiams { get; set; }

    public virtual DbSet<HsKiemTraMucPhiDongGop> HsKiemTraMucPhiDongGops { get; set; }

    public virtual DbSet<HsKyLuatHocSinh> HsKyLuatHocSinhs { get; set; }

    public virtual DbSet<HsKyLuatRptAll> HsKyLuatRptAlls { get; set; }

    public virtual DbSet<HsLoadDanhHieu> HsLoadDanhHieus { get; set; }

    public virtual DbSet<HsLoadDataH> HsLoadDataHs { get; set; }

    public virtual DbSet<HsLoadHocSinhKhenThuong> HsLoadHocSinhKhenThuongs { get; set; }

    public virtual DbSet<HsLoadHocSinhKyLuat> HsLoadHocSinhKyLuats { get; set; }

    public virtual DbSet<HsLoadLopHoc> HsLoadLopHocs { get; set; }

    public virtual DbSet<HsLoadNhomThi> HsLoadNhomThis { get; set; }

    public virtual DbSet<HsLopHoc> HsLopHocs { get; set; }

    public virtual DbSet<HsLopHocMonChuyen> HsLopHocMonChuyens { get; set; }

    public virtual DbSet<HsLopHocMonKhuyenKhich> HsLopHocMonKhuyenKhiches { get; set; }

    public virtual DbSet<HsLopHocMonMienGiam> HsLopHocMonMienGiams { get; set; }

    public virtual DbSet<HsLopHocMonNgoaiNgu> HsLopHocMonNgoaiNgus { get; set; }

    public virtual DbSet<HsLopHocTinHoc> HsLopHocTinHocs { get; set; }

    public virtual DbSet<HsMonHocNhomThi> HsMonHocNhomThis { get; set; }

    public virtual DbSet<HsMonHocSoDauDiem> HsMonHocSoDauDiems { get; set; }

    public virtual DbSet<HsMucPhiDongGop> HsMucPhiDongGops { get; set; }

    public virtual DbSet<HsNgayToChucKyThi> HsNgayToChucKyThis { get; set; }

    public virtual DbSet<HsNghiHocDaiHan> HsNghiHocDaiHans { get; set; }

    public virtual DbSet<HsNhapDiemPhongThi> HsNhapDiemPhongThis { get; set; }

    public virtual DbSet<HsNhomThi> HsNhomThis { get; set; }

    public virtual DbSet<HsNhomThiLoad> HsNhomThiLoads { get; set; }

    public virtual DbSet<HsNhomThiLoadMonThi> HsNhomThiLoadMonThis { get; set; }

    public virtual DbSet<HsNhomThiLoadPhongThi> HsNhomThiLoadPhongThis { get; set; }

    public virtual DbSet<HsNhomThiLopHocBanHoc> HsNhomThiLopHocBanHocs { get; set; }

    public virtual DbSet<HsNhomThiVwHocSinhLopHoc> HsNhomThiVwHocSinhLopHocs { get; set; }

    public virtual DbSet<HsNhomThiVwPhanLop> HsNhomThiVwPhanLops { get; set; }

    public virtual DbSet<HsPhanLop> HsPhanLops { get; set; }

    public virtual DbSet<HsPhongThi> HsPhongThis { get; set; }

    public virtual DbSet<HsSucKhoe> HsSucKhoes { get; set; }

    public virtual DbSet<HsThiDuaTapThe> HsThiDuaTapThes { get; set; }

    public virtual DbSet<HsThongBaoNhapDiemChiTietMonHoc> HsThongBaoNhapDiemChiTietMonHocs { get; set; }

    public virtual DbSet<HsTinhThuongDung> HsTinhThuongDungs { get; set; }

    public virtual DbSet<HsViewBangDiemChiTietHocKy> HsViewBangDiemChiTietHocKies { get; set; }

    public virtual DbSet<HsViewHsPhanLop> HsViewHsPhanLops { get; set; }

    public virtual DbSet<HsVwDiemThiXuatExcel> HsVwDiemThiXuatExcels { get; set; }

    public virtual DbSet<HsVwKhoiLopMonKk> HsVwKhoiLopMonKks { get; set; }

    public virtual DbSet<HsVwXemLyDoThoiHoc> HsVwXemLyDoThoiHocs { get; set; }

    public virtual DbSet<HsXetLenLop> HsXetLenLops { get; set; }

    public virtual DbSet<HsXetLenLopTruocThiLaiRenLuyenLai> HsXetLenLopTruocThiLaiRenLuyenLais { get; set; }

    public virtual DbSet<Selectalluutienchinhsachkhuyettattheokhoi> Selectalluutienchinhsachkhuyettattheokhois { get; set; }

    public virtual DbSet<Selectalluutienchinhsachkhuyettattheolop> Selectalluutienchinhsachkhuyettattheolops { get; set; }

    public virtual DbSet<SobuoinghitheoH> SobuoinghitheoHs { get; set; }

    public virtual DbSet<ThongTinSxdsh> ThongTinSxdshs { get; set; }

    public virtual DbSet<Version> Versions { get; set; }

    public virtual DbSet<VwBanHoc> VwBanHocs { get; set; }

    public virtual DbSet<VwBanHocMonHoc> VwBanHocMonHocs { get; set; }

    public virtual DbSet<VwBuoiHoc> VwBuoiHocs { get; set; }

    public virtual DbSet<VwChiTietDanToc> VwChiTietDanTocs { get; set; }

    public virtual DbSet<VwChucVuDoanThe> VwChucVuDoanThes { get; set; }

    public virtual DbSet<VwChucVuLop> VwChucVuLops { get; set; }

    public virtual DbSet<VwDanToc> VwDanTocs { get; set; }

    public virtual DbSet<VwDangKyNghiHocDaiHan> VwDangKyNghiHocDaiHans { get; set; }

    public virtual DbSet<VwDanhSachHocSinh> VwDanhSachHocSinhs { get; set; }

    public virtual DbSet<VwDanhSachHocSinhP> VwDanhSachHocSinhPs { get; set; }

    public virtual DbSet<VwDanhSachHocSinhPhongThi> VwDanhSachHocSinhPhongThis { get; set; }

    public virtual DbSet<VwDanhSachHocSinhXuatExcel> VwDanhSachHocSinhXuatExcels { get; set; }

    public virtual DbSet<VwDanhSachHskhoiCu> VwDanhSachHskhoiCus { get; set; }

    public virtual DbSet<VwDienUuDai> VwDienUuDais { get; set; }

    public virtual DbSet<VwDienUuTien> VwDienUuTiens { get; set; }

    public virtual DbSet<VwDmLoaiDiem> VwDmLoaiDiems { get; set; }

    public virtual DbSet<VwDmhocSinh> VwDmhocSinhs { get; set; }

    public virtual DbSet<VwDmhocSinhTuyenSinh> VwDmhocSinhTuyenSinhs { get; set; }

    public virtual DbSet<VwDoanDoi> VwDoanDois { get; set; }

    public virtual DbSet<VwDonVi> VwDonVis { get; set; }

    public virtual DbSet<VwDsnamHoc> VwDsnamHocs { get; set; }

    public virtual DbSet<VwGiaDinhHocSinh> VwGiaDinhHocSinhs { get; set; }

    public virtual DbSet<VwGioiTinh> VwGioiTinhs { get; set; }

    public virtual DbSet<VwHanhKiem> VwHanhKiems { get; set; }

    public virtual DbSet<VwHanhKiemHocSinhTieuHoc> VwHanhKiemHocSinhTieuHocs { get; set; }

    public virtual DbSet<VwHanhKiemHocSinhTrenTieuHoc> VwHanhKiemHocSinhTrenTieuHocs { get; set; }

    public virtual DbSet<VwHanhKiemTieuHoc> VwHanhKiemTieuHocs { get; set; }

    public virtual DbSet<VwHanhKiemTrenTieuHoc> VwHanhKiemTrenTieuHocs { get; set; }

    public virtual DbSet<VwHienTaiHanhKiemH> VwHienTaiHanhKiemHs { get; set; }

    public virtual DbSet<VwHienTaiHanhKiemHstieuHoc> VwHienTaiHanhKiemHstieuHocs { get; set; }

    public virtual DbSet<VwHocLuc> VwHocLucs { get; set; }

    public virtual DbSet<VwHocLucHocSinh> VwHocLucHocSinhs { get; set; }

    public virtual DbSet<VwHocSinhBanHoc> VwHocSinhBanHocs { get; set; }

    public virtual DbSet<VwHocSinhBoThi> VwHocSinhBoThis { get; set; }

    public virtual DbSet<VwHocSinhBoThiRpt> VwHocSinhBoThiRpts { get; set; }

    public virtual DbSet<VwHocSinhChuyenTruong> VwHocSinhChuyenTruongs { get; set; }

    public virtual DbSet<VwHocSinhChuyenTruongRpt> VwHocSinhChuyenTruongRpts { get; set; }

    public virtual DbSet<VwHocSinhLopHoc> VwHocSinhLopHocs { get; set; }

    public virtual DbSet<VwHocSinhLopHoc01> VwHocSinhLopHoc01s { get; set; }

    public virtual DbSet<VwHocSinhMonHoc> VwHocSinhMonHocs { get; set; }

    public virtual DbSet<VwHocSinhMonKhuyenKhich> VwHocSinhMonKhuyenKhiches { get; set; }

    public virtual DbSet<VwHocSinhNhomThi> VwHocSinhNhomThis { get; set; }

    public virtual DbSet<VwHocSinhNhomThiSbd> VwHocSinhNhomThiSbds { get; set; }

    public virtual DbSet<VwHonNhan> VwHonNhans { get; set; }

    public virtual DbSet<VwHsLoadgridhocsinh> VwHsLoadgridhocsinhs { get; set; }

    public virtual DbSet<VwHsPhanLop> VwHsPhanLops { get; set; }

    public virtual DbSet<VwKhoiLopMonMienGiam> VwKhoiLopMonMienGiams { get; set; }

    public virtual DbSet<VwKhuyetTat> VwKhuyetTats { get; set; }

    public virtual DbSet<VwKyThi> VwKyThis { get; set; }

    public virtual DbSet<VwKyluathocsinh> VwKyluathocsinhs { get; set; }

    public virtual DbSet<VwLayKyLuatTungHocSinh> VwLayKyLuatTungHocSinhs { get; set; }

    public virtual DbSet<VwLaykhenthuong> VwLaykhenthuongs { get; set; }

    public virtual DbSet<VwLoaiBanHocMonHoc> VwLoaiBanHocMonHocs { get; set; }

    public virtual DbSet<VwLopHoc> VwLopHocs { get; set; }

    public virtual DbSet<VwLopHocBanHoc> VwLopHocBanHocs { get; set; }

    public virtual DbSet<VwLopHocMonChuyen> VwLopHocMonChuyens { get; set; }

    public virtual DbSet<VwLopHocMonMienGiam> VwLopHocMonMienGiams { get; set; }

    public virtual DbSet<VwLopHocMonNgoaiNgu> VwLopHocMonNgoaiNgus { get; set; }

    public virtual DbSet<VwLopHocTinHoc> VwLopHocTinHocs { get; set; }

    public virtual DbSet<VwLuaHocSinh> VwLuaHocSinhs { get; set; }

    public virtual DbSet<VwMocHocNgoaiNguKhoiLop> VwMocHocNgoaiNguKhoiLops { get; set; }

    public virtual DbSet<VwMonChuyen> VwMonChuyens { get; set; }

    public virtual DbSet<VwMonHocKhoiLop> VwMonHocKhoiLops { get; set; }

    public virtual DbSet<VwMonHocNghe> VwMonHocNghes { get; set; }

    public virtual DbSet<VwMonHocNhomThi> VwMonHocNhomThis { get; set; }

    public virtual DbSet<VwMonNgoaiNgu> VwMonNgoaiNgus { get; set; }

    public virtual DbSet<VwNangKhieu> VwNangKhieus { get; set; }

    public virtual DbSet<VwNgayToChucKyThi> VwNgayToChucKyThis { get; set; }

    public virtual DbSet<VwNgheNghiep> VwNgheNghieps { get; set; }

    public virtual DbSet<VwNghiHocDaiHanTheoKhoi> VwNghiHocDaiHanTheoKhois { get; set; }

    public virtual DbSet<VwNgoaiNgu> VwNgoaiNgus { get; set; }

    public virtual DbSet<VwNguonTuyen> VwNguonTuyens { get; set; }

    public virtual DbSet<VwNhomMau> VwNhomMaus { get; set; }

    public virtual DbSet<VwNhomThi> VwNhomThis { get; set; }

    public virtual DbSet<VwPhanLopH> VwPhanLopHs { get; set; }

    public virtual DbSet<VwPhanLopXetLenLop> VwPhanLopXetLenLops { get; set; }

    public virtual DbSet<VwPhongThi> VwPhongThis { get; set; }

    public virtual DbSet<VwPhongThiHocSinh> VwPhongThiHocSinhs { get; set; }

    public virtual DbSet<VwPhongThiMonHoc> VwPhongThiMonHocs { get; set; }

    public virtual DbSet<VwPhuong> VwPhuongs { get; set; }

    public virtual DbSet<VwQuan> VwQuans { get; set; }

    public virtual DbSet<VwQuanHeGiaDinh> VwQuanHeGiaDinhs { get; set; }

    public virtual DbSet<VwQuocTich> VwQuocTiches { get; set; }

    public virtual DbSet<VwSapXepDsh> VwSapXepDshs { get; set; }

    public virtual DbSet<VwSucKhoe> VwSucKhoes { get; set; }

    public virtual DbSet<VwThamSoHeThong> VwThamSoHeThongs { get; set; }

    public virtual DbSet<VwThiLuc> VwThiLucs { get; set; }

    public virtual DbSet<VwTimKiem> VwTimKiems { get; set; }

    public virtual DbSet<VwTimKiemHienTai> VwTimKiemHienTais { get; set; }

    public virtual DbSet<VwTinh> VwTinhs { get; set; }

    public virtual DbSet<VwTinhTrang> VwTinhTrangs { get; set; }

    public virtual DbSet<VwTonGiao> VwTonGiaos { get; set; }

    public virtual DbSet<VwTruong> VwTruongs { get; set; }

    public virtual DbSet<VwXemHocKy> VwXemHocKies { get; set; }

    public virtual DbSet<VwXemLopHoc> VwXemLopHocs { get; set; }

    public virtual DbSet<VwXemNamHoc> VwXemNamHocs { get; set; }

    public virtual DbSet<VwXemNghiCoPhep> VwXemNghiCoPheps { get; set; }

    public virtual DbSet<VwXemNghiKhongPhep> VwXemNghiKhongPheps { get; set; }

    public virtual DbSet<Vwloadchitietchuyencan> Vwloadchitietchuyencans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-4TEFLSM\\SQLEXPRESS;Initial Catalog=VEMIS_Student;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DiemHocSinhDmBanHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_BanHoc");

            entity.Property(e => e.BanHocId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BanHocID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.TenBanHoc).HasMaxLength(30);
        });

        modelBuilder.Entity<DiemHocSinhDmChiTietBanHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_ChiTietBanHoc");

            entity.Property(e => e.FkBanHocId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_BanHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
        });

        modelBuilder.Entity<DiemHocSinhDmChuyenCan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_ChuyenCan");

            entity.Property(e => e.ChuyenCanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ChuyenCanID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.TenChuyenCan).HasMaxLength(30);
        });

        modelBuilder.Entity<DiemHocSinhDmDanToc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_DanToc");

            entity.Property(e => e.DanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DanTocID");
            entity.Property(e => e.TenDanToc).HasMaxLength(30);
        });

        modelBuilder.Entity<DiemHocSinhDmDanhHieu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_DanhHieu");

            entity.Property(e => e.DanhHieuId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DanhHieuID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.TenDanhHieu).HasMaxLength(30);
        });

        modelBuilder.Entity<DiemHocSinhDmDiemDanhGiaTieuHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_DiemDanhGiaTieuHoc");

            entity.Property(e => e.DiemDanhGiaTieuHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DiemDanhGiaTieuHocID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.TenDiemDanhGiaTieuHoc).HasMaxLength(20);
        });

        modelBuilder.Entity<DiemHocSinhDmDiemDanhGiaTrenTieuHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_DiemDanhGiaTrenTieuHoc");

            entity.Property(e => e.DiemDanhGiaTrenTieuHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DiemDanhGiaTrenTieuHocID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.TenDiemDanhGiaTrenTieuHoc).HasMaxLength(30);
        });

        modelBuilder.Entity<DiemHocSinhDmGioiTinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_GioiTinh");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.GioiTinhId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GioiTinhID");
            entity.Property(e => e.TenGioiTinh).HasMaxLength(50);
        });

        modelBuilder.Entity<DiemHocSinhDmHanhKiemTieuHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_HanhKiemTieuHoc");

            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.HanhKiemTieuHocId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("HanhKiemTieuHocID");
            entity.Property(e => e.TenHanhKiemTieuHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<DiemHocSinhDmHanhKiemTrenTieuHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_HanhKiemTrenTieuHoc");

            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.HanhKiemTrenTieuHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("HanhKiemTrenTieuHocID");
            entity.Property(e => e.TenHanhKiemTrenTieuHoc).HasMaxLength(20);
        });

        modelBuilder.Entity<DiemHocSinhDmHocKy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_HocKy");

            entity.Property(e => e.Ghichu).HasMaxLength(50);
            entity.Property(e => e.HocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("HocKyID");
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.TenHocKy).HasMaxLength(50);
        });

        modelBuilder.Entity<DiemHocSinhDmHocLuc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_HocLuc");

            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.HocLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("HocLucID");
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.TenHocLuc).HasMaxLength(20);
        });

        modelBuilder.Entity<DiemHocSinhDmKhoiLop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_KhoiLop");

            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.MaKhoiLop)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TenKhoiLop).HasMaxLength(50);
        });

        modelBuilder.Entity<DiemHocSinhDmKyThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_KyThi");

            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.KyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KyThiID");
            entity.Property(e => e.TenKyThi).HasMaxLength(30);
        });

        modelBuilder.Entity<DiemHocSinhDmLoaiDiem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_LoaiDiem");

            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.LoaiDiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("LoaiDiemID");
            entity.Property(e => e.TenLoaiDiem).HasMaxLength(30);
        });

        modelBuilder.Entity<DiemHocSinhDmMonHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_MonHoc");

            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.MonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MonHocID");
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<DiemHocSinhDmMonHocKhoiLop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_MonHocKhoiLop");

            entity.Property(e => e.FkKhoiLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhoiLopID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.HocKyHoc)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.IsLopHocHocSinh).HasColumnName("isLopHocHocSinh");
            entity.Property(e => e.IsTongKet).HasColumnName("isTongKet");
        });

        modelBuilder.Entity<DiemHocSinhDmNamHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_NamHoc");

            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.NamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("NamHocID");
            entity.Property(e => e.TenNamHoc).HasMaxLength(20);
        });

        modelBuilder.Entity<DiemHocSinhDmNgheNghiep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_NgheNghiep");

            entity.Property(e => e.NgheNghiepId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("NgheNghiepID");
            entity.Property(e => e.TenNgheNghiep).HasMaxLength(30);
        });

        modelBuilder.Entity<DiemHocSinhDmNghiCoPhepCaNam>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_NghiCoPhepCaNam");

            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
        });

        modelBuilder.Entity<DiemHocSinhDmNghiHocCoPhep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_NghiHocCoPhep");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
        });

        modelBuilder.Entity<DiemHocSinhDmNghiHocCoPhepTheoThang>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_NghiHocCoPhepTheoThang");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
        });

        modelBuilder.Entity<DiemHocSinhDmNghiHocKhongPhepCaNam>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_NghiHocKhongPhepCaNam");

            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
        });

        modelBuilder.Entity<DiemHocSinhDmNghiHocKhongPhepTheoThang>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_NghiHocKhongPhepTheoThang");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
        });

        modelBuilder.Entity<DiemHocSinhDmNghiKhongPhep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_NghiKhongPhep");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
        });

        modelBuilder.Entity<DiemHocSinhDmNhomCapHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_NhomCapHoc");

            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.NhomCapHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("NhomCapHocID");
            entity.Property(e => e.TenNhomCapHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<DiemHocSinhDmObjectActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_Object_Activity");

            entity.Property(e => e.FkTimetableId).HasColumnName("FK_TimetableID");
            entity.Property(e => e.Students).HasMaxLength(20);
            entity.Property(e => e.Subject).HasMaxLength(25);
            entity.Property(e => e.Teacher).HasMaxLength(50);
        });

        modelBuilder.Entity<DiemHocSinhDmTimetableList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_Timetable_List");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.NgayApDung).HasColumnType("smalldatetime");
            entity.Property(e => e.TimetableId).HasColumnName("TimetableID");
        });

        modelBuilder.Entity<DiemHocSinhDmTongSoNgayNghiTrongThang>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_TongSoNgayNghiTrongThang");

            entity.Property(e => e.FkChuyenCanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChuyenCanID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
        });

        modelBuilder.Entity<DiemHocSinhDmTruong>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_Truong");

            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.DienThoai)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FkDonViId)
                .HasMaxLength(8)
                .HasColumnName("FK_DonViID");
            entity.Property(e => e.FkHeThongGiaoDucId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_HeThongGiaoDucID");
            entity.Property(e => e.FkLoaiHinhTruongId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_LoaiHinhTruongID");
            entity.Property(e => e.FkNhomCapHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NhomCapHocID");
            entity.Property(e => e.TenTruong).HasMaxLength(100);
            entity.Property(e => e.TruongChuyenBietId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TruongChuyenBietID");
            entity.Property(e => e.TruongId)
                .HasMaxLength(8)
                .HasColumnName("TruongID");
        });

        modelBuilder.Entity<DiemHocSinhDmXetLenLop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_DM_XetLenLop");

            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.MaXetLenLop)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TenXetLenLop).HasMaxLength(40);
        });

        modelBuilder.Entity<DiemHocSinhThamSoHeThong>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_ThamSoHeThong");

            entity.Property(e => e.DonViSuDungId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DonViSuDungID");
            entity.Property(e => e.HocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("HocKyID");
            entity.Property(e => e.MayChu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("NamHocID");
            entity.Property(e => e.TenDonViSuDung).HasMaxLength(100);
        });

        modelBuilder.Entity<DiemHocSinhThamSoHeThongTruongHocSuDung>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_ThamSoHeThongTruongHocSuDung");

            entity.Property(e => e.MaHocKy)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MaNamHoc)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.MaNhomCapHoc)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MaTruongHoc)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.TenHocKy).HasMaxLength(50);
            entity.Property(e => e.TenNamHoc).HasMaxLength(20);
            entity.Property(e => e.TenTruongHoc).HasMaxLength(100);
        });

        modelBuilder.Entity<DiemHocSinhThongBaoNhapDiemChiTietMonHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DiemHocSinh_ThongBaoNhapDiemChiTietMonHoc");

            entity.Property(e => e.NgayHetHanNhapDiem).HasColumnType("smalldatetime");
            entity.Property(e => e.TenLoaiDiem).HasMaxLength(30);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<DmDiemDanhGiaTrenTieuHocTt58>(entity =>
        {
            entity.HasKey(e => e.DiemDanhGiaId).HasName("PK_DM_DiemDanhGia_TrenTieuHoc");

            entity.ToTable("DM_DiemDanhGia_TrenTieuHoc_TT58");

            entity.Property(e => e.DiemDanhGiaId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DiemDanhGiaID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.TenDiemDanhGia).HasMaxLength(50);
        });

        modelBuilder.Entity<HsAnhHocSinh>(entity =>
        {
            entity.HasKey(e => e.FkHocSinhId);

            entity.ToTable("HS_AnhHocSinh");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.DuongDanToiTepAnh).HasMaxLength(256);

            entity.HasOne(d => d.FkHocSinh).WithOne(p => p.HsAnhHocSinh)
                .HasForeignKey<HsAnhHocSinh>(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_AnhHocSinh_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsBangDiemChiTietHocKy>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkLoaiDiemId, e.ThuTuDauDiemNhap, e.FkHocKyId, e.FkNamHocId, e.HeSo });

            entity.ToTable("HS_BangDiemChiTietHocKy", tb => tb.HasTrigger("RulesInsert"));

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkLoaiDiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_LoaiDiemID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked)
                .HasDefaultValue(false)
                .HasColumnName("isLocked");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsBangDiemChiTietHocKies)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_BangDiemChiTietHocKy_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkLoaiDiemId, e.ThuTuDauDiemNhap, e.FkHocKyId, e.FkNamHocId, e.HeSo });

            entity.ToTable("HS_BangDiemChiTietHocKy_MonDanhGia_BacTrenTieuHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkLoaiDiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_LoaiDiemID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkDiemDanhGiaTrenTieuHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DiemDanhGiaTrenTieuHocID");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_BangDiemChiTietHocKy_MonDanhGia_BacTrenTieuHoc_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsBangDiemDanhGiaThuongXuyen>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkNamHocId, e.ThangHoc }).HasName("PK_HS_BangDiemDanhGiaThuongXuyen_1");

            entity.ToTable("HS_BangDiemDanhGiaThuongXuyen");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsBangDiemDanhGiaThuongXuyens)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_BangDiemDanhGiaThuongXuyen_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsBangDiemKiemTraThuongXuyenApDungChoTieuHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkNamHocId, e.FkMonHocId, e.LanChoDiem, e.ThangId });

            entity.ToTable("HS_BangDiemKiemTraThuongXuyen_ApDungChoTieuHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.ThangId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((99))")
                .HasColumnName("ThangID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_BangDiemKiemTraThuongXuyen_ApDungChoTieuHoc_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsBoHocLoadDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_BoHoc_LoadData");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.LopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LopHocID");
            entity.Property(e => e.LyDoBoHoc).HasMaxLength(50);
            entity.Property(e => e.LyDoThoiHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("LyDoThoiHocID");
            entity.Property(e => e.NgayBoHoc).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQuyetDinh).HasMaxLength(50);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenGioiTinh).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<HsBoHocRptDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_BoHoc_RptData");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.HinhThuc).HasMaxLength(50);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.Lop).HasMaxLength(50);
            entity.Property(e => e.LyDoThoiHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("LyDoThoiHocID");
            entity.Property(e => e.MaHs)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("MaHS");
            entity.Property(e => e.NgayBd)
                .HasColumnType("smalldatetime")
                .HasColumnName("NgayBD");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQd)
                .HasMaxLength(50)
                .HasColumnName("NguoiQD");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenHocSinh).HasMaxLength(142);
        });

        modelBuilder.Entity<HsBoHocThoiHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_BoHocThoiHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkLoaiBoHoc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_LoaiBoHoc");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgayBoHoc).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQuyetDinh).HasMaxLength(50);
        });

        modelBuilder.Entity<HsChiTietNghiHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.NgayNghi, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_ChiTietNghiHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.NgayNghi).HasColumnType("smalldatetime");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkChuyenCanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChuyenCanID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsChuyenCan>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_ChuyenCan");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkChuyenCanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChuyenCanID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgayTongKetChuyenCan).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<HsChuyenLop>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkNamHocId, e.MaTang });

            entity.ToTable("HS_ChuyenLop");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.MaTang).ValueGeneratedOnAdd();
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkLopCuId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopCuID");
            entity.Property(e => e.FkLopMoiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopMoiID");
            entity.Property(e => e.HocKyCu)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgayChuyenLop).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQuyetDinh).HasMaxLength(50);
        });

        modelBuilder.Entity<HsChuyenLopLoadDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_ChuyenLop_LoadData");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.LopCu).HasMaxLength(50);
            entity.Property(e => e.LopCuId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LopCuID");
            entity.Property(e => e.LopMoi).HasMaxLength(50);
            entity.Property(e => e.LopMoiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LopMoiID");
            entity.Property(e => e.MaHs)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("MaHS");
            entity.Property(e => e.NamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("NamHocID");
            entity.Property(e => e.NgayChuyen).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQd)
                .HasMaxLength(50)
                .HasColumnName("NguoiQD");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenHocKy).HasMaxLength(50);
        });

        modelBuilder.Entity<HsChuyenLopRptAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_ChuyenLop_RptAll");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.LopCu).HasMaxLength(50);
            entity.Property(e => e.LopCuId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LopCuID");
            entity.Property(e => e.LopMoi).HasMaxLength(50);
            entity.Property(e => e.MaHs)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("MaHS");
            entity.Property(e => e.NgayChuyen).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQd)
                .HasMaxLength(50)
                .HasColumnName("NguoiQD");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
        });

        modelBuilder.Entity<HsChuyenLopVwPhanLop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_ChuyenLop_vwPhanLop");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
        });

        modelBuilder.Entity<HsChuyenTruong>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.LoaiChuyen, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_ChuyenTruong");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkTruongDiDenId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FK_TruongDiDenID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.LyDoChuyenTruong).HasMaxLength(500);
            entity.Property(e => e.NgayQuyetDinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQuyetDinh).HasMaxLength(50);
        });

        modelBuilder.Entity<HsDanTocThuongDung>(entity =>
        {
            entity.HasKey(e => e.DanTocThuongDungId);

            entity.ToTable("HS_DanTocThuongDung");

            entity.Property(e => e.DanTocThuongDungId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("DanTocThuongDungID");
            entity.Property(e => e.TenDanTocThuongDung).HasMaxLength(50);
        });

        modelBuilder.Entity<HsDangKyLopChuyen>(entity =>
        {
            entity.HasKey(e => new { e.FkLopHocId, e.FkNamHocId });

            entity.ToTable("HS_DangKyLopChuyen");

            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsDangKyLopChuyenBan>(entity =>
        {
            entity.HasKey(e => e.FkLopHocId).HasName("PK_HS_DangKyLopChuyenBan_1");

            entity.ToTable("HS_DangKyLopChuyenBan");

            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkBanHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_BanHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");

            entity.HasOne(d => d.FkLopHoc).WithOne(p => p.HsDangKyLopChuyenBan)
                .HasForeignKey<HsDangKyLopChuyenBan>(d => d.FkLopHocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_DangKyLopChuyenBan_HS_LopHoc");
        });

        modelBuilder.Entity<HsDangKyMonThiLai>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_DangKyMonThiLai");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsDangKyOnoiTru>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_DangKyONoiTru");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgayBatDauOnoiTru)
                .HasColumnType("smalldatetime")
                .HasColumnName("NgayBatDauONoiTru");
            entity.Property(e => e.PhongO).HasMaxLength(50);
        });

        modelBuilder.Entity<HsDanhGiaHanhKiemThuongXuyenBacTieuHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkNamHocId }).HasName("PK_HS_DanhGiaHanhKiem_ThuongXuyen_BacTieuHoc_1");

            entity.ToTable("HS_DanhGiaHanhKiem_ThuongXuyen_BacTieuHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.Lan1).HasDefaultValue(false);
            entity.Property(e => e.Lan10).HasDefaultValue(false);
            entity.Property(e => e.Lan11).HasDefaultValue(false);
            entity.Property(e => e.Lan12).HasDefaultValue(false);
            entity.Property(e => e.Lan13).HasDefaultValue(false);
            entity.Property(e => e.Lan14).HasDefaultValue(false);
            entity.Property(e => e.Lan15).HasDefaultValue(false);
            entity.Property(e => e.Lan16).HasDefaultValue(false);
            entity.Property(e => e.Lan17).HasDefaultValue(false);
            entity.Property(e => e.Lan19).HasDefaultValue(false);
            entity.Property(e => e.Lan2).HasDefaultValue(false);
            entity.Property(e => e.Lan20).HasDefaultValue(false);
            entity.Property(e => e.Lan3).HasDefaultValue(false);
            entity.Property(e => e.Lan4).HasDefaultValue(false);
            entity.Property(e => e.Lan5).HasDefaultValue(false);
            entity.Property(e => e.Lan6).HasDefaultValue(false);
            entity.Property(e => e.Lan7).HasDefaultValue(false);
            entity.Property(e => e.Lan8).HasDefaultValue(false);
            entity.Property(e => e.Lan9).HasDefaultValue(false);
        });

        modelBuilder.Entity<HsDanhHieu>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_DanhHieu");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkDanhHieuId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FK_DanhHieuID");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsDanhHieus)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_DanhHieu_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsDanhSachTuyenSinh>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkNamHocId, e.FkMonHocId, e.IsMonChuyen }).HasName("PK_HS_DanhSachTuyenSinh_1");

            entity.ToTable("HS_DanhSachTuyenSinh");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.IsMonChuyen).HasColumnName("isMonChuyen");
            entity.Property(e => e.FkBanHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_BanHocID");
            entity.Property(e => e.KhoiHoc)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Sbd)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SBD");
        });

        modelBuilder.Entity<HsDataDiemThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_DataDiemThi");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsActived).HasColumnName("isActived");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.IsUp).HasColumnName("isUp");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenGioiTinh).HasMaxLength(50);
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<HsDiemThi>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonThiId, e.FkMaKyThiId, e.FkNamHocId });

            entity.ToTable("HS_DiemThi");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonThiID");
            entity.Property(e => e.FkMaKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FK_MaKyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsDiemThis)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_DiemThi_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsDiemThiLoadMonHocNhomThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_DiemThi_LoadMonHocNhomThi");

            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.IsActived).HasColumnName("isActived");
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<HsDiemThiLoadPhongThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_DiemThi_LoadPhongThi");

            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.IsActived).HasColumnName("isActived");
            entity.Property(e => e.PhongThiId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PhongThiID");
            entity.Property(e => e.TenPhongThi).HasMaxLength(50);
        });

        modelBuilder.Entity<HsDiemThiLoaiDiem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_DiemThi_LoaiDiem");

            entity.Property(e => e.LoaiDiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("LoaiDiemID");
            entity.Property(e => e.TenLoaiDiem).HasMaxLength(30);
        });

        modelBuilder.Entity<HsDiemThiMonDanhGiaBacTrenTieuHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkKyThiId, e.FkNamHocId }).HasName("PK_HS_DiemThi_MonDanhGia_TrenTieuHoc");

            entity.ToTable("HS_DiemThi_MonDanhGia_BacTrenTieuHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkDiemDanhGiaTrenTieuHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DiemDanhGiaTrenTieuHocID");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsDiemThiMonDanhGiaBacTrenTieuHocs)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_DiemThi_MonDanhGia_BacTrenTieuHoc_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsDiemThiMonLichSuVaDiaLyBacTieuHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMaKyThiId, e.FkNamHocId, e.LichSuHoacDiaLy }).HasName("PK__HS_DiemThiMonLic__4D6A6A69");

            entity.ToTable("HS_DiemThiMonLichSuVaDiaLyBacTieuHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMaKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaKyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsDiemThiMonLichSuVaDiaLyBacTieuHocs)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_DiemThiMonLichSuVaDiaLyBacTieuHoc_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsDiemThiMonTiengVietCuaTieuHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMaKyThiId, e.FkNamHocId, e.DiemDocHoacDiemViet }).HasName("PK__HS_DiemThiMonTie__42ECDBF6");

            entity.ToTable("HS_DiemThiMonTiengVietCuaTieuHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMaKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaKyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsDiemThiMonTiengVietCuaTieuHocs)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_DiemThiMonTiengVietCuaTieuHoc_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsDiemThiNghe>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_DiemThiNghe");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkMonHocNgheId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocNgheID");
            entity.Property(e => e.FkXepLoaiNgheId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_XepLoaiNgheID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsDiemThiTvth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_DiemThiTVTH");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KieuHienThiID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMaKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaKyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenGioiTinh).HasMaxLength(50);
        });

        modelBuilder.Entity<HsDiemTongKetHocKy>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_DiemTongKetHocKy");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsDiemTongKetHocKies)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_DiemTongKetHocKy_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsDiemTrungBinhMonDanhGiaTieuHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_DiemTrungBinhMonDanhGiaTieuHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkDiemDanhGiaTieuHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DiemDanhGiaTieuHocID");
            entity.Property(e => e.NhanXet).HasMaxLength(50);

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsDiemTrungBinhMonDanhGiaTieuHocs)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_DiemTrungBinhMonDanhGiaTieuHoc_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsDiemTrungBinhMonDanhGiaTrenTieuHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_DiemTrungBinhMonDanhGiaTrenTieuHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkDiemDanhGiaTrenTieuHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DiemDanhGiaTrenTieuHocID");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsDiemTrungBinhMonDanhGiaTrenTieuHocs)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_DiemTrungBinhMonDanhGiaKyTrenTieuHoc_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsDiemTrungBinhMonHocKy>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_DiemTrungBinhMonHocKy");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsDiemTrungBinhMonHocKies)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_DiemTrungBinhMonHocKy_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsDiemTuyenSinhTrungHocPhoThong>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_DiemTuyenSinhTrungHocPhoThong");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsDmkieuHienThiTen>(entity =>
        {
            entity.HasKey(e => e.KieuHienThiId);

            entity.ToTable("HS_DMKieuHienThiTen");

            entity.Property(e => e.KieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KieuHienThiID");
            entity.Property(e => e.TenKieuHienThi).HasMaxLength(50);
        });

        modelBuilder.Entity<HsDuLieuDiemThi>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkKyThiId, e.FkNamHocId });

            entity.ToTable("HS_DuLieuDiemThi");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsUp).HasColumnName("isUp");
        });

        modelBuilder.Entity<HsGiaDinhHocSinh>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.Macabiet, e.FkQuanHeGiaDinhId });

            entity.ToTable("HS_GiaDinhHocSinh", tb => tb.HasTrigger("Add_InfoGDHS"));

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.Macabiet)
                .HasDefaultValue(1)
                .HasColumnName("macabiet");
            entity.Property(e => e.FkQuanHeGiaDinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("XX")
                .HasColumnName("FK_QuanHeGiaDinhID");
            entity.Property(e => e.DonViCongTac).HasMaxLength(50);
            entity.Property(e => e.FkNgheNghiepId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgheNghiepID");
            entity.Property(e => e.GdDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("GD_DienThoai");
            entity.Property(e => e.HoVaTen).HasMaxLength(50);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NamSinh)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HsGiaTriDiemDoMonHocKhuyenKhich>(entity =>
        {
            entity.HasKey(e => new { e.FkMonHocKhuyenKhich, e.FkDiemDanhGiaId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_GiaTriDiemDoMonHocKhuyenKhich");

            entity.Property(e => e.FkMonHocKhuyenKhich)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocKhuyenKhich");
            entity.Property(e => e.FkDiemDanhGiaId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DiemDanhGiaID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsHanhKiem>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_HanhKiem");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHanhKiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HanhKiemID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsHanhKiems)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_HanhKiem_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsHanhKiemTruocRenLuyenLai>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_HanhKiem_TruocRenLuyenLai");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHanhKiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HanhKiemID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsHienTai>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_HienTai", tb => tb.HasTrigger("addInfoHienTai"));

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkChucVuDoanTheId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChucVuDoanTheID");
            entity.Property(e => e.FkChucVuLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChucVuLopID");
            entity.Property(e => e.FkChungChiNgheDaCoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChungChiNgheDaCoID");
            entity.Property(e => e.FkLuaHocSinhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_LuaHocSinhID");
            entity.Property(e => e.FkMonHocNghePhoThongId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocNghePhoThongID");
            entity.Property(e => e.FkNgoaiNguId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgoaiNguID");
            entity.Property(e => e.FkNgoaiNguThu2Id)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgoaiNguThu2ID");
            entity.Property(e => e.FkNguonTuyenId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NguonTuyenID");
            entity.Property(e => e.FkTinhTrangId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TinhTrangID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsHienTais)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_HienTai_HS_HoSoHocSinh1");
        });

        modelBuilder.Entity<HsHoSoHocSinh>(entity =>
        {
            entity.HasKey(e => e.HocSinhId);

            entity.ToTable("HS_HoSoHocSinh", tb => tb.HasTrigger("Add_InfoHSHS"));

            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
            entity.Property(e => e.DienThoai)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FkDanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((99))")
                .HasColumnName("FK_DanTocID");
            entity.Property(e => e.FkDanTocThuongDungId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocThuongDungID");
            entity.Property(e => e.FkDangDoanDoiId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((9))")
                .HasColumnName("FK_DangDoanDoiID");
            entity.Property(e => e.FkHonNhanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((99))")
                .HasColumnName("FK_HonNhanID");
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((99))")
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkKieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KieuHienThiID");
            entity.Property(e => e.FkMaHuyenDangKyHoKhauId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenDangKyHoKhauID");
            entity.Property(e => e.FkMaHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenID");
            entity.Property(e => e.FkMaTinhDangKyHoKhauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhDangKyHoKhauID");
            entity.Property(e => e.FkMaTinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhID");
            entity.Property(e => e.FkMaXaDangKyHoKhauId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaDangKyHoKhauID");
            entity.Property(e => e.FkMaXaId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaID");
            entity.Property(e => e.FkNangKhieuId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((99))")
                .HasColumnName("FK_NangKhieuID");
            entity.Property(e => e.FkQuocTichId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_QuocTichID");
            entity.Property(e => e.FkTonGiaoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TonGiaoID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.NgayChinhThucKetNapDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNap).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNapVaoDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiOhienNay)
                .HasMaxLength(200)
                .HasColumnName("NoiOHienNay");
            entity.Property(e => e.NoiSinh).HasMaxLength(200);
            entity.Property(e => e.Otro).HasColumnName("OTro");
            entity.Property(e => e.QueQuan).HasMaxLength(200);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
        });

        modelBuilder.Entity<HsHoSoSuKien>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.Macabiet });

            entity.ToTable("HS_HoSoSuKien", tb => tb.HasTrigger("TestHSSK"));

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.Macabiet)
                .ValueGeneratedOnAdd()
                .HasColumnName("macabiet");
            entity.Property(e => e.GhiChu).HasMaxLength(300);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgayThang).HasColumnType("smalldatetime");
            entity.Property(e => e.SuKien).HasMaxLength(300);
        });

        modelBuilder.Entity<HsHoatDongHe>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_HoatDongHe");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkKetQuaId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KetQuaID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsHocLucHocSinhTruocThiLaiRenLuyenLai>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_HocLucHocSinh_TruocThiLaiRenLuyenLai");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHocLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocLucID");
        });

        modelBuilder.Entity<HsHocLucMon>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_HocLucMon");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHocLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocLucID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsHocLucMons)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_HocLucMon_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsHocSinhBanHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkNamHocId }).HasName("PK_HS_HocSinhBanHoc_1");

            entity.ToTable("HS_HocSinhBanHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkBanHocId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_BanHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsHocSinhBanHocs)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_HocSinhBanHoc_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsHocSinhBoThi>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkKyThiId, e.FkNamHocId });

            entity.ToTable("HS_HocSinhBoThi");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");

            entity.HasOne(d => d.HsHocSinhNhomThi).WithMany(p => p.HsHocSinhBoThis)
                .HasForeignKey(d => new { d.FkHocSinhId, d.FkKyThiId, d.FkNamHocId })
                .HasConstraintName("FK_HS_HocSinhBoThi_HS_HocSinhNhomThi");
        });

        modelBuilder.Entity<HsHocSinhHocLuc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_HocSinhHocLuc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHocLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocLucID");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsHocSinhHocLucs)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_HocSinhHocLuc_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsHocSinhMonKhuyenKhich>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_HocSinhMonKhuyenKhich");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsHocSinhMonKhuyenKhiches)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_HocSinhMonKhuyenKhich_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsHocSinhMonMienGiam>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_HocSinhMonMienGiam");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsHocSinhMonMienGiams)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_HocSinhMonMienGiam_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsHocSinhNhomThi>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkKyThiId, e.FkNamHocId }).HasName("PK_HS_HocSinhNhomThi_1");

            entity.ToTable("HS_HocSinhNhomThi");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");

            entity.HasOne(d => d.HsNhomThi).WithMany(p => p.HsHocSinhNhomThis)
                .HasForeignKey(d => new { d.FkNhomThiId, d.FkKyThiId, d.FkNamHocId })
                .HasConstraintName("FK_HS_HocSinhNhomThi_HS_NhomThi");
        });

        modelBuilder.Entity<HsHocSinhPhongThi>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkKyThiId, e.FkNamHocId }).HasName("PK_HS_HocSinhPhongThi_1");

            entity.ToTable("HS_HocSinhPhongThi");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkPhongThiId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FK_PhongThiID");

            entity.HasOne(d => d.HsHocSinhNhomThi).WithMany(p => p.HsHocSinhPhongThis)
                .HasForeignKey(d => new { d.FkHocSinhId, d.FkKyThiId, d.FkNamHocId })
                .HasConstraintName("FK_HS_HocSinhPhongThi_HS_HocSinhNhomThi");
        });

        modelBuilder.Entity<HsHocSinhPhongThiRpt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_HocSinhPhongThi_Rpt");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoVaTen).HasMaxLength(142);
            entity.Property(e => e.IsActived).HasColumnName("isActived");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.PhongThi)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.SoBaoDanh)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
            entity.Property(e => e.TenPhongThi).HasMaxLength(50);
        });

        modelBuilder.Entity<HsHocSinhSbd>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkKyThiId, e.FkNamHocId }).HasName("PK_HS_HocSinhSBD_1");

            entity.ToTable("HS_HocSinhSBD");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.SoBaoDanh)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.HsHocSinhNhomThi).WithOne(p => p.HsHocSinhSbd)
                .HasForeignKey<HsHocSinhSbd>(d => new { d.FkHocSinhId, d.FkKyThiId, d.FkNamHocId })
                .HasConstraintName("FK_HS_HocSinhSBD_HS_HocSinhNhomThi");
        });

        modelBuilder.Entity<HsHopPhuHuynh>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_HopPhuHuynh");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsKetQuaMonKhuyenKhich>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_KetQuaMonKhuyenKhich");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkDiemDanhGiaId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DiemDanhGiaID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsKetQuaRenLuyenLaiTrongHe>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkNamHocId });

            entity.ToTable("HS_KetQuaRenLuyenLaiTrongHe");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHanhKiemIdLan1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HanhKiemID_Lan1");
            entity.Property(e => e.FkHanhKiemIdLan2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HanhKIemID_Lan2");
        });

        modelBuilder.Entity<HsKetQuaThiHocSinhGioi>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_KetQuaThiHocSinhGioi");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkCapKyThiHocSinhGioiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_CapKyThiHocSinhGioiID");
            entity.Property(e => e.FkXepLoaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_XepLoaiID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsKetQuaThiKhaoSat>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_KetQuaThiKhaoSat");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsKetQuaThiLai>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkNamHocId });

            entity.ToTable("HS_KetQuaThiLai");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.TongKetCaNamLan1).HasColumnName("TongKetCaNam_Lan1");
            entity.Property(e => e.TongKetCaNamLan2).HasColumnName("TongKetCaNam_Lan2");
        });

        modelBuilder.Entity<HsKetQuaThiLaiMonDanhGiaTieuHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkNamHocId }).HasName("PK__HS_KetQuaThiLai___49AFB375");

            entity.ToTable("HS_KetQuaThiLai_MonDanhGia_TieuHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.DiemThiLai)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TongKetCaNamLan1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TongKetCaNam_Lan1");
            entity.Property(e => e.TongKetCaNamLan2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TongKetCaNam_Lan2");
        });

        modelBuilder.Entity<HsKetQuaThiLaiMonDanhGium>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkNamHocId }).HasName("PK__HS_KetQuaThiLai___46D346CA");

            entity.ToTable("HS_KetQuaThiLai_MonDanhGia");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.DiemThiLai)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.TongKetCaNamLan1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TongKetCaNam_Lan1");
            entity.Property(e => e.TongKetCaNamLan2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TongKetCaNam_Lan2");
        });

        modelBuilder.Entity<HsKetQuaThiLaiMonTinhDiemTieuHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkMonHocId, e.FkNamHocId }).HasName("PK__HS_KetQuaThiLai___4D804459");

            entity.ToTable("HS_KetQuaThiLai_MonTinhDiem_TieuHoc");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.TongKetCaNamLan1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TongKetCaNam_Lan1");
            entity.Property(e => e.TongKetCaNamLan2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TongKetCaNam_Lan2");
        });

        modelBuilder.Entity<HsKhenThuong>(entity =>
        {
            entity.HasKey(e => new { e.Matang, e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_KhenThuong");

            entity.Property(e => e.Matang)
                .ValueGeneratedOnAdd()
                .HasColumnName("matang");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.GhiChu).HasMaxLength(100);
            entity.Property(e => e.HinhThucKhenThuong).HasMaxLength(50);
            entity.Property(e => e.NgayKhenThuong).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<HsKhoiLopMonKhuyenKhich>(entity =>
        {
            entity.HasKey(e => new { e.FkKhoiLopId, e.FkMonHocId, e.FkNamHocId });

            entity.ToTable("HS_KhoiLopMonKhuyenKhich");

            entity.Property(e => e.FkKhoiLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhoiLopID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsKhoiLopMonMienGiam>(entity =>
        {
            entity.HasKey(e => new { e.FkKhoiLopId, e.FkMonHocId, e.FkNamHocId });

            entity.ToTable("HS_KhoiLopMonMienGiam");

            entity.Property(e => e.FkKhoiLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhoiLopID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsKiemTraMucPhiDongGop>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkLoaiMucPhiId, e.FkNamHocId });

            entity.ToTable("HS_KiemTraMucPhiDongGop");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLoaiMucPhiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_LoaiMucPhiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsKyLuatHocSinh>(entity =>
        {
            entity.HasKey(e => new { e.Matang, e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId }).HasName("PK_HS_KyLuatHocSinh_1");

            entity.ToTable("HS_KyLuatHocSinh");

            entity.Property(e => e.Matang)
                .ValueGeneratedOnAdd()
                .HasColumnName("matang");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHinhThucKyLuatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HinhThucKyLuatID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgayKetThuc).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKyLuat).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQuyetDinh).HasMaxLength(50);
        });

        modelBuilder.Entity<HsKyLuatRptAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_KyLuat_RptAll");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.HinhThuc).HasMaxLength(50);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.Lop).HasMaxLength(50);
            entity.Property(e => e.MaHs)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("MaHS");
            entity.Property(e => e.NgayBd)
                .HasColumnType("smalldatetime")
                .HasColumnName("NgayBD");
            entity.Property(e => e.NgayKt)
                .HasColumnType("smalldatetime")
                .HasColumnName("NgayKT");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQd)
                .HasMaxLength(50)
                .HasColumnName("NguoiQD");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenHocSinh).HasMaxLength(142);
        });

        modelBuilder.Entity<HsLoadDanhHieu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_LoadDanhHieu");

            entity.Property(e => e.FkDanhHieuId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_DanhHieuID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.HinhThuc).HasMaxLength(30);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.Lop).HasMaxLength(50);
            entity.Property(e => e.LopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LopHocID");
            entity.Property(e => e.MaHs)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("MaHS");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenHocSinh).HasMaxLength(142);
        });

        modelBuilder.Entity<HsLoadDataH>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_LoadDataHS");

            entity.Property(e => e.FkDanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocID");
            entity.Property(e => e.FkDanTocThuongDungId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocThuongDungID");
            entity.Property(e => e.FkDangDoanDoiId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_DangDoanDoiID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHonNhanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HonNhanID");
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkKieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KieuHienThiID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMaHuyenDangKyHoKhauId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenDangKyHoKhauID");
            entity.Property(e => e.FkMaHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenID");
            entity.Property(e => e.FkMaTinhDangKyHoKhauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhDangKyHoKhauID");
            entity.Property(e => e.FkMaTinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhID");
            entity.Property(e => e.FkMaXaDangKyHoKhauId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaDangKyHoKhauID");
            entity.Property(e => e.FkMaXaId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNangKhieuId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NangKhieuID");
            entity.Property(e => e.FkQuocTichId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_QuocTichID");
            entity.Property(e => e.FkTonGiaoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TonGiaoID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HocKyChuyen)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
            entity.Property(e => e.IsChuyenLop)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("isChuyenLop");
            entity.Property(e => e.IsKbctk).HasColumnName("isKBCTK");
            entity.Property(e => e.IsLockedLop).HasColumnName("isLockedLop");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiOhienNay)
                .HasMaxLength(200)
                .HasColumnName("NoiOHienNay");
            entity.Property(e => e.NoiSinh).HasMaxLength(200);
            entity.Property(e => e.QueQuan).HasMaxLength(200);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<HsLoadHocSinhKhenThuong>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_LoadHocSinhKhenThuong");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.GhiChu).HasMaxLength(100);
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.HinhThuc).HasMaxLength(50);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.Lop).HasMaxLength(50);
            entity.Property(e => e.LopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LopHocID");
            entity.Property(e => e.MaHs)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("MaHS");
            entity.Property(e => e.NgayBd)
                .HasColumnType("smalldatetime")
                .HasColumnName("NgayBD");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenHocSinh).HasMaxLength(142);
        });

        modelBuilder.Entity<HsLoadHocSinhKyLuat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_LoadHocSinhKyLuat");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.HinhThuc).HasMaxLength(50);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.LopHoc).HasMaxLength(50);
            entity.Property(e => e.LopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LopHocID");
            entity.Property(e => e.MaHs)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("MaHS");
            entity.Property(e => e.NgayBatDau).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
        });

        modelBuilder.Entity<HsLoadLopHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_LoadLopHoc");

            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.LopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LopHocID");
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<HsLoadNhomThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_LoadNhomThi");

            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsActived).HasColumnName("isActived");
            entity.Property(e => e.NhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("NhomThiID");
            entity.Property(e => e.TenNhomThi).HasMaxLength(50);
        });

        modelBuilder.Entity<HsLopHoc>(entity =>
        {
            entity.HasKey(e => e.LopHocId);

            entity.ToTable("HS_LopHoc");

            entity.Property(e => e.LopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LopHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<HsLopHocMonChuyen>(entity =>
        {
            entity.HasKey(e => new { e.FkLopHocId, e.FkMonHocId });

            entity.ToTable("HS_LopHocMonChuyen");

            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
        });

        modelBuilder.Entity<HsLopHocMonKhuyenKhich>(entity =>
        {
            entity.HasKey(e => new { e.FkLopHocId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_LopHocMonKhuyenKhich");

            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
        });

        modelBuilder.Entity<HsLopHocMonMienGiam>(entity =>
        {
            entity.HasKey(e => new { e.FkLopHocId, e.FkMonHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_LopHocMonMienGiam");

            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");

            entity.HasOne(d => d.FkLopHoc).WithMany(p => p.HsLopHocMonMienGiams)
                .HasForeignKey(d => d.FkLopHocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_LopHocMonMienGiam_HS_LopHoc");
        });

        modelBuilder.Entity<HsLopHocMonNgoaiNgu>(entity =>
        {
            entity.HasKey(e => new { e.FkLopHocId, e.FkNamHocId });

            entity.ToTable("HS_LopHocMonNgoaiNgu");

            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkMonNgoaiNguId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonNgoaiNguID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsLopHocTinHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkLopHocId, e.FkNamHocId });

            entity.ToTable("HS_LopHocTinHoc");

            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsHocTin).HasColumnName("isHocTin");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsMonHocNhomThi>(entity =>
        {
            entity.HasKey(e => new { e.FkNhomThiId, e.FkMonHocId, e.FkKyThiId, e.FkNamHocId });

            entity.ToTable("HS_MonHocNhomThi");

            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");

            entity.HasOne(d => d.HsNhomThi).WithMany(p => p.HsMonHocNhomThis)
                .HasForeignKey(d => new { d.FkNhomThiId, d.FkKyThiId, d.FkNamHocId })
                .HasConstraintName("FK_HS_MonHocNhomThi_HS_NhomThi");
        });

        modelBuilder.Entity<HsMonHocSoDauDiem>(entity =>
        {
            entity.HasKey(e => new { e.FkMonHocId, e.FkKhoiLopId, e.FkLoaiDiemId, e.FkNamHocId, e.FkHocKyId, e.HeSo });

            entity.ToTable("HS_MonHocSoDauDiem");

            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkKhoiLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhoiLopID");
            entity.Property(e => e.FkLoaiDiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_LoaiDiemID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.HeSo).HasDefaultValue(1);
            entity.Property(e => e.SoDauDiemToiDa).HasDefaultValue(1);
            entity.Property(e => e.SoDauDiemToiThieu).HasDefaultValue(1);
        });

        modelBuilder.Entity<HsMucPhiDongGop>(entity =>
        {
            entity.HasKey(e => new { e.FkKhoiLopId, e.FkLoaiMucPhiId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_MucPhiDongGop");

            entity.Property(e => e.FkKhoiLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhoiLopID");
            entity.Property(e => e.FkLoaiMucPhiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_LoaiMucPhiID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsNgayToChucKyThi>(entity =>
        {
            entity.HasKey(e => new { e.FkKyThiId, e.FkNamHocId }).HasName("PK_HS_NgayToChucKyThi_1");

            entity.ToTable("HS_NgayToChucKyThi");

            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsActived).HasColumnName("isActived");
        });

        modelBuilder.Entity<HsNghiHocDaiHan>(entity =>
        {
            entity.HasKey(e => new { e.Ma, e.FkHocsinhId, e.FkHocKyId, e.FkNamHocId }).HasName("PK__Hs_NghiHocDaiHan__024846FC");

            entity.ToTable("Hs_NghiHocDaiHan");

            entity.Property(e => e.Ma).ValueGeneratedOnAdd();
            entity.Property(e => e.FkHocsinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocsinhId");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Fk_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Fk_NamHocID");
            entity.Property(e => e.Islocked).HasColumnName("islocked");
            entity.Property(e => e.LyDo).HasMaxLength(50);
            entity.Property(e => e.NgayBatDauNghi).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayHocLai).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQuyetDinh).HasMaxLength(30);
        });

        modelBuilder.Entity<HsNhapDiemPhongThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_NhapDiemPhongThi");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.FkPhongThiId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FK_PhongThiID");
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsActived).HasColumnName("isActived");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgaySinh)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sbd)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SBD");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
            entity.Property(e => e.TenNhomThi).HasMaxLength(50);
            entity.Property(e => e.TenPhongThi).HasMaxLength(50);
        });

        modelBuilder.Entity<HsNhomThi>(entity =>
        {
            entity.HasKey(e => new { e.NhomThiId, e.FkKyThiId, e.FkNamHocId }).HasName("PK_DM_NhomThi");

            entity.ToTable("HS_NhomThi");

            entity.Property(e => e.NhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("NhomThiID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.TenNhomThi).HasMaxLength(50);

            entity.HasOne(d => d.HsNgayToChucKyThi).WithMany(p => p.HsNhomThis)
                .HasForeignKey(d => new { d.FkKyThiId, d.FkNamHocId })
                .HasConstraintName("FK_HS_NhomThi_HS_NgayToChucKyThi");
        });

        modelBuilder.Entity<HsNhomThiLoad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_NhomThi_Load");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsActived).HasColumnName("isActived");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<HsNhomThiLoadMonThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_NhomThi_LoadMonThi");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.IsActived).HasColumnName("isActived");
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
            entity.Property(e => e.TenNhomThi).HasMaxLength(50);
        });

        modelBuilder.Entity<HsNhomThiLoadPhongThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_NhomThi_LoadPhongThi");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.IsActived).HasColumnName("isActived");
            entity.Property(e => e.PhongThiId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PhongThiID");
            entity.Property(e => e.TenNhomThi).HasMaxLength(50);
            entity.Property(e => e.TenPhongThi).HasMaxLength(50);
        });

        modelBuilder.Entity<HsNhomThiLopHocBanHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_NhomThi_LopHocBanHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkBanHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_BanHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.LopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LopHocID");
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<HsNhomThiVwHocSinhLopHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_NhomThi_vwHocSinhLopHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkBanHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_BanHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<HsNhomThiVwPhanLop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_NhomThi_vwPhanLop");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<HsPhanLop>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkNamHocId })
                .HasName("PK_HS_PhanLop_1")
                .IsClustered(false);

            entity.ToTable("HS_PhanLop", tb => tb.HasTrigger("Add_STT"));

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsPhanLops)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_PhanLop_HS_HoSoHocSinh1");

            entity.HasOne(d => d.FkLopHoc).WithMany(p => p.HsPhanLops)
                .HasForeignKey(d => d.FkLopHocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_PhanLop_HS_LopHoc");
        });

        modelBuilder.Entity<HsPhongThi>(entity =>
        {
            entity.HasKey(e => new { e.FkNhomThiId, e.PhongThiId, e.FkKyThiId, e.FkNamHocId }).HasName("PK_DM_PhongThi");

            entity.ToTable("HS_PhongThi");

            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.PhongThiId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PhongThiID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.TenPhongThi).HasMaxLength(50);

            entity.HasOne(d => d.HsNhomThi).WithMany(p => p.HsPhongThis)
                .HasForeignKey(d => new { d.FkNhomThiId, d.FkKyThiId, d.FkNamHocId })
                .HasConstraintName("FK_HS_PhongThi_HS_NhomThi");
        });

        modelBuilder.Entity<HsSucKhoe>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkHocKyId, e.FkNamHocId }).HasName("PK_HS_SucKhoe_1");

            entity.ToTable("HS_SucKhoe", tb => tb.HasTrigger("addInfoSucKhoe"));

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkNhomMauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NhomMauID");
            entity.Property(e => e.FkThiLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ThiLucID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");

            entity.HasOne(d => d.FkHocSinh).WithMany(p => p.HsSucKhoes)
                .HasForeignKey(d => d.FkHocSinhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HS_SucKhoe_HS_HoSoHocSinh");
        });

        modelBuilder.Entity<HsThiDuaTapThe>(entity =>
        {
            entity.HasKey(e => new { e.FkLopHocId, e.FkHocKyId, e.FkNamHocId });

            entity.ToTable("HS_ThiDuaTapThe");

            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsThongBaoNhapDiemChiTietMonHoc>(entity =>
        {
            entity.HasKey(e => new { e.FkLopHocId, e.FkMonHocId, e.FkNamHocId, e.FkHocKyId, e.FkLoaiDiemId, e.ThuTuDauDiemNhap }).HasName("PK_HS_KiemXoatNhapDiemMonHoc");

            entity.ToTable("HS_ThongBaoNhapDiemChiTietMonHoc");

            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkLoaiDiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_LoaiDiemID");
            entity.Property(e => e.NgayHetHanNhapDiem).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<HsTinhThuongDung>(entity =>
        {
            entity.HasKey(e => e.TinhThuongDungId);

            entity.ToTable("HS_TinhThuongDung");

            entity.Property(e => e.TinhThuongDungId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TinhThuongDungID");
            entity.Property(e => e.TenTinhThuongDung).HasMaxLength(50);
        });

        modelBuilder.Entity<HsViewBangDiemChiTietHocKy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_ViewBangDiemChiTietHocKy");

            entity.Property(e => e.Dtb).HasColumnName("DTB");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLoaiDiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_LoaiDiemID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
        });

        modelBuilder.Entity<HsViewHsPhanLop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_ViewHS_PhanLop");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HocKyChuyen)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.IsChuyenLop)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("isChuyenLop");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsVwDiemThiXuatExcel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_vwDiemThiXuatExcel");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.FkPhongThiId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FK_PhongThiID");
            entity.Property(e => e.IsActived).HasColumnName("isActived");
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
            entity.Property(e => e.TenNhomThi).HasMaxLength(50);
            entity.Property(e => e.TenPhongThi).HasMaxLength(50);
        });

        modelBuilder.Entity<HsVwKhoiLopMonKk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_vwKhoiLopMonKK");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkKhoiLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhoiLopID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<HsVwXemLyDoThoiHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HS_vwXemLyDoThoiHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<HsXetLenLop>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkNamHocId });

            entity.ToTable("HS_XetLenLop");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.XetLenLop)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HsXetLenLopTruocThiLaiRenLuyenLai>(entity =>
        {
            entity.HasKey(e => new { e.FkHocSinhId, e.FkNamHocId });

            entity.ToTable("HS_XetLenLop_TruocThiLaiRenLuyenLai");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.XetLenLop)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Selectalluutienchinhsachkhuyettattheokhoi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("selectalluutienchinhsachkhuyettattheokhoi");

            entity.Property(e => e.DanToc)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Hocsinhid)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("hocsinhid");
            entity.Property(e => e.Khoi)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Selectalluutienchinhsachkhuyettattheolop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("selectalluutienchinhsachkhuyettattheolop");

            entity.Property(e => e.DanToc)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
        });

        modelBuilder.Entity<SobuoinghitheoH>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sobuoinghitheoHS");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
        });

        modelBuilder.Entity<ThongTinSxdsh>(entity =>
        {
            entity.HasKey(e => new { e.FkLopHocId, e.FkNamHocId });

            entity.ToTable("ThongTinSXDSHS");

            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.SapXepDshs).HasColumnName("SapXepDSHS");
        });

        modelBuilder.Entity<Version>(entity =>
        {
            entity.HasKey(e => e.Version1).HasName("PK__Version__1269A02C");

            entity.ToTable("Version");

            entity.Property(e => e.Version1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Version");
        });

        modelBuilder.Entity<VwBanHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBanHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwBanHocMonHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBanHocMonHoc");

            entity.Property(e => e.FkBanHocId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_BanHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<VwBuoiHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBuoiHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.BuoiHocId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BuoiHocID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.TenBuoiHoc).HasMaxLength(20);
        });

        modelBuilder.Entity<VwChiTietDanToc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwChiTietDanToc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.ChiTietDanTocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ChiTietDanTocID");
            entity.Property(e => e.DanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DanTocID");
            entity.Property(e => e.TenChiTietDanToc).HasMaxLength(30);
        });

        modelBuilder.Entity<VwChucVuDoanThe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwChucVuDoanThe");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwChucVuLop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwChucVuLop");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwDanToc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDanToc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(20)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwDangKyNghiHocDaiHan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DangKyNghiHocDaiHan");

            entity.Property(e => e.FkHocsinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocsinhId");
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.LyDo).HasMaxLength(50);
            entity.Property(e => e.NgayBatDauNghi).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayHocLai).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQuyetDinh).HasMaxLength(30);
        });

        modelBuilder.Entity<VwDanhSachHocSinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDanhSachHocSinh");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.DienThoai)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.DuongDanToiTepAnh).HasMaxLength(256);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FkChucVuDoanTheId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChucVuDoanTheID");
            entity.Property(e => e.FkChucVuLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChucVuLopID");
            entity.Property(e => e.FkChungChiNgheDaCoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChungChiNgheDaCoID");
            entity.Property(e => e.FkDanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocID");
            entity.Property(e => e.FkDanTocThuongDungId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocThuongDungID");
            entity.Property(e => e.FkDangDoanDoiId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_DangDoanDoiID");
            entity.Property(e => e.FkHonNhanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HonNhanID");
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkKieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KieuHienThiID");
            entity.Property(e => e.FkLuaHocSinhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_LuaHocSinhID");
            entity.Property(e => e.FkMaHuyenDangKyHoKhauId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenDangKyHoKhauID");
            entity.Property(e => e.FkMaHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenID");
            entity.Property(e => e.FkMaTinhDangKyHoKhauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhDangKyHoKhauID");
            entity.Property(e => e.FkMaTinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhID");
            entity.Property(e => e.FkMaXaDangKyHoKhauId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaDangKyHoKhauID");
            entity.Property(e => e.FkMaXaId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaID");
            entity.Property(e => e.FkMonHocNghePhoThongId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocNghePhoThongID");
            entity.Property(e => e.FkNangKhieuId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NangKhieuID");
            entity.Property(e => e.FkNgoaiNguId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgoaiNguID");
            entity.Property(e => e.FkNgoaiNguThu2Id)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgoaiNguThu2ID");
            entity.Property(e => e.FkNguonTuyenId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NguonTuyenID");
            entity.Property(e => e.FkNhomMauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NhomMauID");
            entity.Property(e => e.FkQuocTichId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_QuocTichID");
            entity.Property(e => e.FkThiLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ThiLucID");
            entity.Property(e => e.FkTinhTrangId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TinhTrangID");
            entity.Property(e => e.FkTonGiaoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TonGiaoID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoVaTen).HasMaxLength(142);
            entity.Property(e => e.Ma)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.NgayChinhThucKetNapDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNap).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNapVaoDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiOhienNay)
                .HasMaxLength(200)
                .HasColumnName("NoiOHienNay");
            entity.Property(e => e.NoiSinh).HasMaxLength(200);
            entity.Property(e => e.Otro).HasColumnName("OTro");
            entity.Property(e => e.QueQuan).HasMaxLength(200);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
        });

        modelBuilder.Entity<VwDanhSachHocSinhP>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DanhSachHocSinh_P");

            entity.Property(e => e.GioiTinh).HasMaxLength(3);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.Hocsinhid)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("hocsinhid");
            entity.Property(e => e.Ngaysinh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ngaysinh");
            entity.Property(e => e.Noisinh)
                .HasMaxLength(200)
                .HasColumnName("noisinh");
            entity.Property(e => e.Quequan)
                .HasMaxLength(200)
                .HasColumnName("quequan");
        });

        modelBuilder.Entity<VwDanhSachHocSinhPhongThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDanhSachHocSinhPhongThi");

            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkPhongThiId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FK_PhongThiID");
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.SoBaoDanh)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
        });

        modelBuilder.Entity<VwDanhSachHocSinhXuatExcel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDanhSachHocSinhXuatExcel");

            entity.Property(e => e.DienThoai)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FkDanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocID");
            entity.Property(e => e.FkDanTocThuongDungId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocThuongDungID");
            entity.Property(e => e.FkDangDoanDoiId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_DangDoanDoiID");
            entity.Property(e => e.FkHonNhanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HonNhanID");
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkKieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KieuHienThiID");
            entity.Property(e => e.FkMaHuyenDangKyHoKhauId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenDangKyHoKhauID");
            entity.Property(e => e.FkMaHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenID");
            entity.Property(e => e.FkMaTinhDangKyHoKhauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhDangKyHoKhauID");
            entity.Property(e => e.FkMaTinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhID");
            entity.Property(e => e.FkMaXaDangKyHoKhauId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaDangKyHoKhauID");
            entity.Property(e => e.FkMaXaId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaID");
            entity.Property(e => e.FkNangKhieuId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NangKhieuID");
            entity.Property(e => e.FkQuocTichId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_QuocTichID");
            entity.Property(e => e.FkTonGiaoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TonGiaoID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HoVaTenHocSinh).HasMaxLength(142);
            entity.Property(e => e.Ma)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.NgayChinhThucKetNapDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNap).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNapVaoDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiOhienNay)
                .HasMaxLength(200)
                .HasColumnName("NoiOHienNay");
            entity.Property(e => e.NoiSinh).HasMaxLength(200);
            entity.Property(e => e.Otro).HasColumnName("OTro");
            entity.Property(e => e.QueQuan).HasMaxLength(200);
        });

        modelBuilder.Entity<VwDanhSachHskhoiCu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDanhSachHSKhoiCu");

            entity.Property(e => e.FkDanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMaHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenID");
            entity.Property(e => e.FkMaXaId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkTonGiaoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TonGiaoID");
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<VwDienUuDai>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDienUuDai");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwDienUuTien>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDienUuTien");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwDmLoaiDiem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDM_LoaiDiem");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwDmhocSinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDMHocSinh");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoVaTen).HasMaxLength(142);
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<VwDmhocSinhTuyenSinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDMHocSinhTuyenSinh");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.KhoiHoc)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Sbd)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SBD");
        });

        modelBuilder.Entity<VwDoanDoi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDoanDoi");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(20)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwDonVi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDonVi");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(8)
                .HasColumnName("ma");
            entity.Property(e => e.MaCha).HasMaxLength(8);
            entity.Property(e => e.Ten)
                .HasMaxLength(100)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwDsnamHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDSNamHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(20)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwGiaDinhHocSinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGiaDinhHocSinh");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.DonViCongTac).HasMaxLength(50);
            entity.Property(e => e.FkNgheNghiepId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgheNghiepID");
            entity.Property(e => e.FkQuanHeGiaDinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_QuanHeGiaDinhID");
            entity.Property(e => e.GdDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("GD_DienThoai");
            entity.Property(e => e.HoVaTen).HasMaxLength(50);
            entity.Property(e => e.Ma)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.NamSinh)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.TenNgheNghiep).HasMaxLength(30);
            entity.Property(e => e.TenQuanHeGiaDinh).HasMaxLength(30);
        });

        modelBuilder.Entity<VwGioiTinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGioiTinh");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwHanhKiem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHanhKiem");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(20)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwHanhKiemHocSinhTieuHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHanhKiemHocSinhTieuHoc");

            entity.Property(e => e.DienThoai)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FkDanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocID");
            entity.Property(e => e.FkDanTocThuongDungId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocThuongDungID");
            entity.Property(e => e.FkDangDoanDoiId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_DangDoanDoiID");
            entity.Property(e => e.FkHanhKiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HanhKiemID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocLucID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkKieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KieuHienThiID");
            entity.Property(e => e.FkMaHuyenDangKyHoKhauId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenDangKyHoKhauID");
            entity.Property(e => e.FkMaHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenID");
            entity.Property(e => e.FkMaTinhDangKyHoKhauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhDangKyHoKhauID");
            entity.Property(e => e.FkMaTinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhID");
            entity.Property(e => e.FkMaXaDangKyHoKhauId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaDangKyHoKhauID");
            entity.Property(e => e.FkMaXaId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkQuocTichId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_QuocTichID");
            entity.Property(e => e.FkTonGiaoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TonGiaoID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HanhKiem).HasMaxLength(40);
            entity.Property(e => e.HoVaTenHocSinh).HasMaxLength(142);
            entity.Property(e => e.HocLuc).HasMaxLength(20);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.Ma)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.NgayKetNap).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNapVaoDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiOhienNay)
                .HasMaxLength(200)
                .HasColumnName("NoiOHienNay");
            entity.Property(e => e.NoiSinh).HasMaxLength(200);
            entity.Property(e => e.QueQuan).HasMaxLength(200);
        });

        modelBuilder.Entity<VwHanhKiemHocSinhTrenTieuHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHanhKiemHocSinhTrenTieuHoc");

            entity.Property(e => e.DienThoai)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FkDanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocID");
            entity.Property(e => e.FkDanTocThuongDungId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocThuongDungID");
            entity.Property(e => e.FkDangDoanDoiId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_DangDoanDoiID");
            entity.Property(e => e.FkHanhKiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HanhKiemID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocLucID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHonNhanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HonNhanID");
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkKieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KieuHienThiID");
            entity.Property(e => e.FkMaHuyenDangKyHoKhauId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenDangKyHoKhauID");
            entity.Property(e => e.FkMaHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenID");
            entity.Property(e => e.FkMaTinhDangKyHoKhauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhDangKyHoKhauID");
            entity.Property(e => e.FkMaTinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhID");
            entity.Property(e => e.FkMaXaDangKyHoKhauId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaDangKyHoKhauID");
            entity.Property(e => e.FkMaXaId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNangKhieuId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NangKhieuID");
            entity.Property(e => e.FkQuocTichId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_QuocTichID");
            entity.Property(e => e.FkTonGiaoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TonGiaoID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HanhKiem).HasMaxLength(20);
            entity.Property(e => e.HoVaTenHocSinh).HasMaxLength(142);
            entity.Property(e => e.HocLuc).HasMaxLength(20);
            entity.Property(e => e.Ma)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.NgayChinhThucKetNapDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNap).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNapVaoDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiOhienNay)
                .HasMaxLength(200)
                .HasColumnName("NoiOHienNay");
            entity.Property(e => e.NoiSinh).HasMaxLength(200);
            entity.Property(e => e.Otro).HasColumnName("OTro");
            entity.Property(e => e.QueQuan).HasMaxLength(200);
        });

        modelBuilder.Entity<VwHanhKiemTieuHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHanhKiemTieuHoc");

            entity.Property(e => e.Ma)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(40)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwHanhKiemTrenTieuHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHanhKiemTrenTieuHoc");

            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(20)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwHienTaiHanhKiemH>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHienTaiHanhKiemHS");

            entity.Property(e => e.DienThoai)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FkChucVuDoanTheId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChucVuDoanTheID");
            entity.Property(e => e.FkChucVuLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChucVuLopID");
            entity.Property(e => e.FkChungChiNgheDaCoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChungChiNgheDaCoID");
            entity.Property(e => e.FkDanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocID");
            entity.Property(e => e.FkDanTocThuongDungId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocThuongDungID");
            entity.Property(e => e.FkDangDoanDoiId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_DangDoanDoiID");
            entity.Property(e => e.FkHanhKiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HanhKiemID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocLucID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHonNhanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HonNhanID");
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkKieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KieuHienThiID");
            entity.Property(e => e.FkLuaHocSinhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_LuaHocSinhID");
            entity.Property(e => e.FkMaHuyenDangKyHoKhauId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenDangKyHoKhauID");
            entity.Property(e => e.FkMaHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenID");
            entity.Property(e => e.FkMaTinhDangKyHoKhauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhDangKyHoKhauID");
            entity.Property(e => e.FkMaTinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhID");
            entity.Property(e => e.FkMaXaDangKyHoKhauId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaDangKyHoKhauID");
            entity.Property(e => e.FkMaXaId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaID");
            entity.Property(e => e.FkMonHocNghePhoThongId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocNghePhoThongID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNangKhieuId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NangKhieuID");
            entity.Property(e => e.FkNgoaiNguId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgoaiNguID");
            entity.Property(e => e.FkNgoaiNguThu2Id)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgoaiNguThu2ID");
            entity.Property(e => e.FkNguonTuyenId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NguonTuyenID");
            entity.Property(e => e.FkQuocTichId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_QuocTichID");
            entity.Property(e => e.FkTinhTrangId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TinhTrangID");
            entity.Property(e => e.FkTonGiaoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TonGiaoID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HanhKiem).HasMaxLength(20);
            entity.Property(e => e.HanhKiemTieuHoc).HasMaxLength(40);
            entity.Property(e => e.HoVaTenHocSinh).HasMaxLength(142);
            entity.Property(e => e.HocLuc).HasMaxLength(20);
            entity.Property(e => e.HocLucTieuHoc).HasMaxLength(20);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.Ma)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.MaHanhKiemTieuHoc)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MaHocKyHanhKiemTieuHoc)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MaHocLucTieuHoc)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MaNamHocHanhKiemTieuHoc)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.NgayChinhThucKetNapDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNap).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNapVaoDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiOhienNay)
                .HasMaxLength(200)
                .HasColumnName("NoiOHienNay");
            entity.Property(e => e.NoiSinh).HasMaxLength(200);
            entity.Property(e => e.Otro).HasColumnName("OTro");
            entity.Property(e => e.QueQuan).HasMaxLength(200);
        });

        modelBuilder.Entity<VwHienTaiHanhKiemHstieuHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHienTaiHanhKiemHSTieuHoc");

            entity.Property(e => e.DienThoai)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FkChucVuDoanTheId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChucVuDoanTheID");
            entity.Property(e => e.FkChucVuLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChucVuLopID");
            entity.Property(e => e.FkChungChiNgheDaCoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChungChiNgheDaCoID");
            entity.Property(e => e.FkDanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocID");
            entity.Property(e => e.FkDanTocThuongDungId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocThuongDungID");
            entity.Property(e => e.FkDangDoanDoiId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_DangDoanDoiID");
            entity.Property(e => e.FkHanhKiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HanhKiemID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocLucID");
            entity.Property(e => e.FkHonNhanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HonNhanID");
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkKieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KieuHienThiID");
            entity.Property(e => e.FkLuaHocSinhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_LuaHocSinhID");
            entity.Property(e => e.FkMaHuyenDangKyHoKhauId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenDangKyHoKhauID");
            entity.Property(e => e.FkMaHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenID");
            entity.Property(e => e.FkMaTinhDangKyHoKhauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhDangKyHoKhauID");
            entity.Property(e => e.FkMaTinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhID");
            entity.Property(e => e.FkMaXaDangKyHoKhauId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaDangKyHoKhauID");
            entity.Property(e => e.FkMaXaId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaID");
            entity.Property(e => e.FkMonHocNghePhoThongId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocNghePhoThongID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNangKhieuId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NangKhieuID");
            entity.Property(e => e.FkNgoaiNguId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgoaiNguID");
            entity.Property(e => e.FkNgoaiNguThu2Id)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgoaiNguThu2ID");
            entity.Property(e => e.FkNguonTuyenId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NguonTuyenID");
            entity.Property(e => e.FkQuocTichId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_QuocTichID");
            entity.Property(e => e.FkTinhTrangId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TinhTrangID");
            entity.Property(e => e.FkTonGiaoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TonGiaoID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HanhKiem).HasMaxLength(40);
            entity.Property(e => e.HoVaTenHocSinh).HasMaxLength(142);
            entity.Property(e => e.HocLuc).HasMaxLength(20);
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgayChinhThucKetNapDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNap).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNapVaoDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiOhienNay)
                .HasMaxLength(200)
                .HasColumnName("NoiOHienNay");
            entity.Property(e => e.NoiSinh).HasMaxLength(200);
            entity.Property(e => e.Otro).HasColumnName("OTro");
            entity.Property(e => e.QueQuan).HasMaxLength(200);
        });

        modelBuilder.Entity<VwHocLuc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocLuc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(20)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwHocLucHocSinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocLucHocSinh");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocLucID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.TenHocLuc).HasMaxLength(20);
        });

        modelBuilder.Entity<VwHocSinhBanHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocSinhBanHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkBanHocId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_BanHocID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<VwHocSinhBoThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocSinhBoThi");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<VwHocSinhBoThiRpt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocSinhBoThi_rpt");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.FkPhongThiId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FK_PhongThiID");
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.SoBaoDanh)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<VwHocSinhChuyenTruong>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocSinhChuyenTruong");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Expr1)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkTruongDiDenId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FK_TruongDiDenID");
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.LyDoChuyenTruong).HasMaxLength(500);
            entity.Property(e => e.NgayQuyetDinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQuyetDinh).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
            entity.Property(e => e.TenTruong).HasMaxLength(100);
        });

        modelBuilder.Entity<VwHocSinhChuyenTruongRpt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocSinhChuyenTruong_rpt");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkTruongDiDenId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FK_TruongDiDenID");
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.LyDoChuyenTruong).HasMaxLength(500);
            entity.Property(e => e.NgayQuyetDinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQuyetDinh).HasMaxLength(50);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
            entity.Property(e => e.TenTruong).HasMaxLength(100);
        });

        modelBuilder.Entity<VwHocSinhLopHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocSinhLopHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkBanHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_BanHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<VwHocSinhLopHoc01>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocSinhLopHoc01");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<VwHocSinhMonHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocSinhMonHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.IsMienLyThuyet).HasColumnName("isMienLyThuyet");
            entity.Property(e => e.IsMienThucHanh).HasColumnName("isMienThucHanh");
            entity.Property(e => e.IsNangCaoTuNhien).HasColumnName("isNangCaoTuNhien");
            entity.Property(e => e.IsNangCaoXaHoi).HasColumnName("isNangCaoXaHoi");
            entity.Property(e => e.IsTuChon).HasColumnName("isTuChon");
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<VwHocSinhMonKhuyenKhich>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocSinhMonKhuyenKhich");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<VwHocSinhNhomThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocSinhNhomThi");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoDemTenDem).HasMaxLength(91);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.SoBaoDanh)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<VwHocSinhNhomThiSbd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHocSinhNhomThiSBD");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.GioiTinh).HasMaxLength(3);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.SoBaoDanh)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
        });

        modelBuilder.Entity<VwHonNhan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHonNhan");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwHsLoadgridhocsinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Hs_loadgridhocsinh");

            entity.Property(e => e.GioiTinh).HasMaxLength(3);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.Hocsinhid)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("hocsinhid");
            entity.Property(e => e.Ngaysinh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ngaysinh");
        });

        modelBuilder.Entity<VwHsPhanLop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwHS_PhanLop");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
        });

        modelBuilder.Entity<VwKhoiLopMonMienGiam>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwKhoiLopMonMienGiam");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkKhoiLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhoiLopID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<VwKhuyetTat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwKhuyetTat");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwKyThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwKyThi");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.KyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KyThiID");
            entity.Property(e => e.TenKyThi).HasMaxLength(30);
        });

        modelBuilder.Entity<VwKyluathocsinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_kyluathocsinh");

            entity.Property(e => e.FkHinhThucKyLuatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HinhThucKyLuatID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
            entity.Property(e => e.KyLuat).HasMaxLength(50);
            entity.Property(e => e.NgayKetThuc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NgayKyLuat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NguoiQuyetDinh).HasMaxLength(50);
        });

        modelBuilder.Entity<VwLayKyLuatTungHocSinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_LayKyLuatTungHocSinh");

            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
            entity.Property(e => e.KyLuat).HasMaxLength(50);
        });

        modelBuilder.Entity<VwLaykhenthuong>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Laykhenthuong");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.GhiChu).HasMaxLength(100);
            entity.Property(e => e.HinhThucKhenThuong).HasMaxLength(50);
            entity.Property(e => e.NgayKhenThuong)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwLoaiBanHocMonHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLoaiBanHocMonHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkBanHocId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_BanHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.IsChangeable).HasColumnName("isChangeable");
            entity.Property(e => e.IsMienLyThuyet).HasColumnName("isMienLyThuyet");
            entity.Property(e => e.IsMienThucHanh).HasColumnName("isMienThucHanh");
            entity.Property(e => e.IsNangCaoTuNhien).HasColumnName("isNangCaoTuNhien");
            entity.Property(e => e.IsNangCaoXaHoi).HasColumnName("isNangCaoXaHoi");
            entity.Property(e => e.IsTuChon).HasColumnName("isTuChon");
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<VwLopHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLopHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.LopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LopHocID");
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<VwLopHocBanHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLopHocBanHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkBanHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_BanHocID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.LopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("LopHocID");
            entity.Property(e => e.TenBanHoc).HasMaxLength(30);
            entity.Property(e => e.TenHocKy).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
            entity.Property(e => e.TenNamHoc).HasMaxLength(20);
        });

        modelBuilder.Entity<VwLopHocMonChuyen>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLopHocMonChuyen");

            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<VwLopHocMonMienGiam>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLopHocMonMienGiam");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<VwLopHocMonNgoaiNgu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLopHocMonNgoaiNgu");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMonNgoaiNguId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonNgoaiNguID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<VwLopHocTinHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLopHocTinHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsHocTin).HasColumnName("isHocTin");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
        });

        modelBuilder.Entity<VwLuaHocSinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLuaHocSinh");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(20)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwMocHocNgoaiNguKhoiLop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMocHocNgoaiNguKhoiLop");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.MonNgoaiNguId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MonNgoaiNguID");
            entity.Property(e => e.TenMonNgoaiNgu).HasMaxLength(20);
        });

        modelBuilder.Entity<VwMonChuyen>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonChuyen");

            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<VwMonHocKhoiLop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonHocKhoiLop");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkKhoiLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhoiLopID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.HocKyHoc)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.IsLopHocHocSinh).HasColumnName("isLopHocHocSinh");
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<VwMonHocNghe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonHocNghe");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwMonHocNhomThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonHocNhomThi");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
            entity.Property(e => e.TenNhomThi).HasMaxLength(50);
        });

        modelBuilder.Entity<VwMonNgoaiNgu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMonNgoaiNgu");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.MonNgoaiNguId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MonNgoaiNguID");
            entity.Property(e => e.TenMonNgoaiNgu).HasMaxLength(20);
        });

        modelBuilder.Entity<VwNangKhieu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwNangKhieu");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwNgayToChucKyThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwNgayToChucKyThi");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsActived).HasColumnName("isActived");
            entity.Property(e => e.TenKyThi).HasMaxLength(30);
            entity.Property(e => e.TenNamHoc).HasMaxLength(20);
        });

        modelBuilder.Entity<VwNgheNghiep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwNgheNghiep");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwNghiHocDaiHanTheoKhoi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_NghiHocDaiHanTheoKhoi");

            entity.Property(e => e.FkHocsinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocsinhId");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.LyDo).HasMaxLength(50);
            entity.Property(e => e.NgayBatDauNghi).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayHocLai).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NguoiQuyetDinh).HasMaxLength(30);
        });

        modelBuilder.Entity<VwNgoaiNgu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwNgoaiNgu");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(20)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwNguonTuyen>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwNguonTuyen");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwNhomMau>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwNhomMau");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwNhomThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwNhomThi");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.NhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("NhomThiID");
            entity.Property(e => e.TenNhomThi).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPhanLopH>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPhanLopHS");

            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPhanLopXetLenLop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPhanLop_XetLenLop");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.XetLenLop)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwPhongThi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPhongThi");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.PhongThiId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PhongThiID");
            entity.Property(e => e.TenNhomThi).HasMaxLength(50);
            entity.Property(e => e.TenPhongThi).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPhongThiHocSinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPhongThiHocSinh");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.FkPhongThiId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FK_PhongThiID");
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoDemTenDem).HasMaxLength(91);
            entity.Property(e => e.HoVaTen).HasMaxLength(142);
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.SoBaoDanh)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPhongThiMonHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPhongThiMonHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkKyThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KyThiID");
            entity.Property(e => e.FkMonHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocID");
            entity.Property(e => e.FkNhomThiId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FK_NhomThiID");
            entity.Property(e => e.FkPhongThiId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FK_PhongThiID");
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.NgayThi).HasColumnType("smalldatetime");
            entity.Property(e => e.TenMonHoc).HasMaxLength(40);
        });

        modelBuilder.Entity<VwPhuong>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPhuong");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Macha)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("macha");
            entity.Property(e => e.Ten)
                .HasMaxLength(60)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwQuan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwQuan");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Macha)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("macha");
            entity.Property(e => e.Ten)
                .HasMaxLength(60)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwQuanHeGiaDinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwQuanHeGiaDinh");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwQuocTich>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwQuocTich");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma).HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwSapXepDsh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSapXepDSHS");

            entity.Property(e => e.DienThoai)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FkDanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocID");
            entity.Property(e => e.FkDanTocThuongDungId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocThuongDungID");
            entity.Property(e => e.FkDangDoanDoiId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_DangDoanDoiID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkHonNhanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HonNhanID");
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkKieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KieuHienThiID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkMaHuyenDangKyHoKhauId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenDangKyHoKhauID");
            entity.Property(e => e.FkMaHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenID");
            entity.Property(e => e.FkMaTinhDangKyHoKhauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhDangKyHoKhauID");
            entity.Property(e => e.FkMaTinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhID");
            entity.Property(e => e.FkMaXaDangKyHoKhauId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaDangKyHoKhauID");
            entity.Property(e => e.FkMaXaId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNangKhieuId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NangKhieuID");
            entity.Property(e => e.FkQuocTichId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_QuocTichID");
            entity.Property(e => e.FkTonGiaoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TonGiaoID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoVaTen).HasMaxLength(4000);
            entity.Property(e => e.NgayChinhThucKetNapDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNap).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNapVaoDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiOhienNay)
                .HasMaxLength(200)
                .HasColumnName("NoiOHienNay");
            entity.Property(e => e.NoiSinh).HasMaxLength(200);
            entity.Property(e => e.Otro).HasColumnName("OTro");
            entity.Property(e => e.QueQuan).HasMaxLength(200);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
        });

        modelBuilder.Entity<VwSucKhoe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSucKhoe");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("FK_HocSinhID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNhomMauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NhomMauID");
            entity.Property(e => e.FkThiLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ThiLucID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TenNhomMau).HasMaxLength(30);
            entity.Property(e => e.TenThiLuc).HasMaxLength(30);
        });

        modelBuilder.Entity<VwThamSoHeThong>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwThamSoHeThong");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Donvichuquancap2)
                .HasMaxLength(100)
                .HasColumnName("donvichuquancap2");
            entity.Property(e => e.Donvichuquancap3)
                .HasMaxLength(100)
                .HasColumnName("donvichuquancap3");
            entity.Property(e => e.HocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("HocKyID");
            entity.Property(e => e.Ma)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.MayChu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Namhoc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("namhoc");
            entity.Property(e => e.Ten)
                .HasMaxLength(100)
                .HasColumnName("ten");
            entity.Property(e => e.TenHocKy).HasMaxLength(50);
            entity.Property(e => e.TenNamHoc).HasMaxLength(20);
        });

        modelBuilder.Entity<VwThiLuc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwThiLuc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(30)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwTimKiem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTimKiem");

            entity.Property(e => e.DienThoai)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FkChucVuDoanTheId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChucVuDoanTheID");
            entity.Property(e => e.FkChucVuLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChucVuLopID");
            entity.Property(e => e.FkChungChiNgheDaCoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChungChiNgheDaCoID");
            entity.Property(e => e.FkDanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocID");
            entity.Property(e => e.FkDanTocThuongDungId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocThuongDungID");
            entity.Property(e => e.FkDangDoanDoiId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_DangDoanDoiID");
            entity.Property(e => e.FkHanhKiemId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HanhKiemID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHocLucId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocLucID");
            entity.Property(e => e.FkHonNhanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HonNhanID");
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkKieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KieuHienThiID");
            entity.Property(e => e.FkLopHocId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_LopHocID");
            entity.Property(e => e.FkLuaHocSinhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_LuaHocSinhID");
            entity.Property(e => e.FkMaHuyenDangKyHoKhauId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenDangKyHoKhauID");
            entity.Property(e => e.FkMaHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenID");
            entity.Property(e => e.FkMaTinhDangKyHoKhauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhDangKyHoKhauID");
            entity.Property(e => e.FkMaTinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhID");
            entity.Property(e => e.FkMaXaDangKyHoKhauId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaDangKyHoKhauID");
            entity.Property(e => e.FkMaXaId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaID");
            entity.Property(e => e.FkMonHocNghePhoThongId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocNghePhoThongID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNangKhieuId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NangKhieuID");
            entity.Property(e => e.FkNgoaiNguId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgoaiNguID");
            entity.Property(e => e.FkNgoaiNguThu2Id)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgoaiNguThu2ID");
            entity.Property(e => e.FkNguonTuyenId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NguonTuyenID");
            entity.Property(e => e.FkQuocTichId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_QuocTichID");
            entity.Property(e => e.FkTinhTrangId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TinhTrangID");
            entity.Property(e => e.FkTonGiaoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TonGiaoID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.HanhKiem).HasMaxLength(20);
            entity.Property(e => e.HanhKiemTieuHoc).HasMaxLength(40);
            entity.Property(e => e.HoDem).HasMaxLength(40);
            entity.Property(e => e.HoVaTen).HasMaxLength(142);
            entity.Property(e => e.HocKyHanhKiem)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.HocKyHanhKiemTieuHoc)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.HocLuc).HasMaxLength(20);
            entity.Property(e => e.HocLucTieuHoc).HasMaxLength(20);
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
            entity.Property(e => e.MaGioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.MaHanhKiemTieuHoc)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MaHocLucTieuHoc)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.NamHocHanhKiem)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.NamHocHanhKiemTieuHoc)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.NgayChinhThucKetNapDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNap).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNapVaoDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiOhienNay)
                .HasMaxLength(200)
                .HasColumnName("NoiOHienNay");
            entity.Property(e => e.NoiSinh).HasMaxLength(200);
            entity.Property(e => e.Otro).HasColumnName("OTro");
            entity.Property(e => e.QueQuan).HasMaxLength(200);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.TenDem).HasMaxLength(50);
            entity.Property(e => e.TenGioiTinh).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(50);
        });

        modelBuilder.Entity<VwTimKiemHienTai>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTimKiemHienTai");

            entity.Property(e => e.DienThoai)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FkChucVuDoanTheId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChucVuDoanTheID");
            entity.Property(e => e.FkChucVuLopId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChucVuLopID");
            entity.Property(e => e.FkChungChiNgheDaCoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_ChungChiNgheDaCoID");
            entity.Property(e => e.FkDanTocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocID");
            entity.Property(e => e.FkDanTocThuongDungId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_DanTocThuongDungID");
            entity.Property(e => e.FkDangDoanDoiId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_DangDoanDoiID");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkHonNhanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HonNhanID");
            entity.Property(e => e.FkKhuyetTatId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KhuyetTatID");
            entity.Property(e => e.FkKieuHienThiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_KieuHienThiID");
            entity.Property(e => e.FkLuaHocSinhId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_LuaHocSinhID");
            entity.Property(e => e.FkMaHuyenDangKyHoKhauId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenDangKyHoKhauID");
            entity.Property(e => e.FkMaHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_MaHuyenID");
            entity.Property(e => e.FkMaTinhDangKyHoKhauId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhDangKyHoKhauID");
            entity.Property(e => e.FkMaTinhId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MaTinhID");
            entity.Property(e => e.FkMaXaDangKyHoKhauId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaDangKyHoKhauID");
            entity.Property(e => e.FkMaXaId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("FK_MaXaID");
            entity.Property(e => e.FkMonHocNghePhoThongId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_MonHocNghePhoThongID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.FkNangKhieuId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NangKhieuID");
            entity.Property(e => e.FkNgoaiNguId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgoaiNguID");
            entity.Property(e => e.FkNgoaiNguThu2Id)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NgoaiNguThu2ID");
            entity.Property(e => e.FkNguonTuyenId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NguonTuyenID");
            entity.Property(e => e.FkQuocTichId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_QuocTichID");
            entity.Property(e => e.FkTinhTrangId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TinhTrangID");
            entity.Property(e => e.FkTonGiaoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_TonGiaoID");
            entity.Property(e => e.FkUuDaiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuDaiID");
            entity.Property(e => e.FkUuTienId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_UuTienID");
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HoVaTenHocSinh).HasMaxLength(142);
            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.Ma)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.NgayChinhThucKetNapDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNap).HasColumnType("smalldatetime");
            entity.Property(e => e.NgayKetNapVaoDang).HasColumnType("smalldatetime");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiOhienNay)
                .HasMaxLength(200)
                .HasColumnName("NoiOHienNay");
            entity.Property(e => e.NoiSinh).HasMaxLength(200);
            entity.Property(e => e.Otro).HasColumnName("OTro");
            entity.Property(e => e.QueQuan).HasMaxLength(200);
        });

        modelBuilder.Entity<VwTinh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTinh");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(60)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwTinhTrang>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTinhTrang");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwTonGiao>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTonGiao");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwTruong>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTruong");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.DienThoai)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FkDonViId)
                .HasMaxLength(8)
                .HasColumnName("FK_DonViID");
            entity.Property(e => e.FkHeThongGiaoDucId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_HeThongGiaoDucID");
            entity.Property(e => e.FkLoaiHinhTruongId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FK_LoaiHinhTruongID");
            entity.Property(e => e.FkNhomCapHocId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_NhomCapHocID");
            entity.Property(e => e.FkPhuongXaId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_PhuongXaID");
            entity.Property(e => e.FkQuanHuyenId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_QuanHuyenID");
            entity.Property(e => e.FkTinhId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FK_TinhID");
            entity.Property(e => e.TenPhuongXa).HasMaxLength(60);
            entity.Property(e => e.TenQuanHuyen).HasMaxLength(60);
            entity.Property(e => e.TenTinh).HasMaxLength(60);
            entity.Property(e => e.TenTruong).HasMaxLength(100);
            entity.Property(e => e.TruongChuyenBietId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TruongChuyenBietID");
            entity.Property(e => e.TruongId)
                .HasMaxLength(8)
                .HasColumnName("TruongID");
        });

        modelBuilder.Entity<VwXemHocKy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_XemHocKy");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwXemLopHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwXemLopHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.Ma)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwXemNamHoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwXemNamHoc");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Ma)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(20)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<VwXemNghiCoPhep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_XemNghiCoPhep");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
            entity.Property(e => e.Nghicophep).HasColumnName("nghicophep");
        });

        modelBuilder.Entity<VwXemNghiKhongPhep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_XemNghiKhongPhep");

            entity.Property(e => e.FkHocKyId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("FK_HocKyID");
            entity.Property(e => e.FkNamHocId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FK_NamHocID");
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
            entity.Property(e => e.Nghikhongphep).HasColumnName("nghikhongphep");
        });

        modelBuilder.Entity<Vwloadchitietchuyencan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwloadchitietchuyencan");

            entity.Property(e => e.ChuyencanId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ChuyencanID");
            entity.Property(e => e.GioiTinh).HasMaxLength(3);
            entity.Property(e => e.HoTen).HasMaxLength(142);
            entity.Property(e => e.HocSinhId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("HocSinhID");
            entity.Property(e => e.LopId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("lopID");
            entity.Property(e => e.NgayNghiHoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ngaysinh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ngaysinh");
            entity.Property(e => e.TenChuyenCan).HasMaxLength(30);
            entity.Property(e => e.TenLop).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
