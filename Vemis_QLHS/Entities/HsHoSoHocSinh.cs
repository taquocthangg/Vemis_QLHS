using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class HsHoSoHocSinh
{
    public string HocSinhId { get; set; } = null!;

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

    public bool? IsDelete { get; set; }

    public virtual HsAnhHocSinh? HsAnhHocSinh { get; set; }

    public virtual ICollection<HsBangDiemChiTietHocKy> HsBangDiemChiTietHocKies { get; set; } = new List<HsBangDiemChiTietHocKy>();

    public virtual ICollection<HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc> HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHocs { get; set; } = new List<HsBangDiemChiTietHocKyMonDanhGiaBacTrenTieuHoc>();

    public virtual ICollection<HsBangDiemDanhGiaThuongXuyen> HsBangDiemDanhGiaThuongXuyens { get; set; } = new List<HsBangDiemDanhGiaThuongXuyen>();

    public virtual ICollection<HsBangDiemKiemTraThuongXuyenApDungChoTieuHoc> HsBangDiemKiemTraThuongXuyenApDungChoTieuHocs { get; set; } = new List<HsBangDiemKiemTraThuongXuyenApDungChoTieuHoc>();

    public virtual ICollection<HsDanhHieu> HsDanhHieus { get; set; } = new List<HsDanhHieu>();

    public virtual ICollection<HsDiemThiMonDanhGiaBacTrenTieuHoc> HsDiemThiMonDanhGiaBacTrenTieuHocs { get; set; } = new List<HsDiemThiMonDanhGiaBacTrenTieuHoc>();

    public virtual ICollection<HsDiemThiMonLichSuVaDiaLyBacTieuHoc> HsDiemThiMonLichSuVaDiaLyBacTieuHocs { get; set; } = new List<HsDiemThiMonLichSuVaDiaLyBacTieuHoc>();

    public virtual ICollection<HsDiemThiMonTiengVietCuaTieuHoc> HsDiemThiMonTiengVietCuaTieuHocs { get; set; } = new List<HsDiemThiMonTiengVietCuaTieuHoc>();

    public virtual ICollection<HsDiemThi> HsDiemThis { get; set; } = new List<HsDiemThi>();

    public virtual ICollection<HsDiemTongKetHocKy> HsDiemTongKetHocKies { get; set; } = new List<HsDiemTongKetHocKy>();

    public virtual ICollection<HsDiemTrungBinhMonDanhGiaTieuHoc> HsDiemTrungBinhMonDanhGiaTieuHocs { get; set; } = new List<HsDiemTrungBinhMonDanhGiaTieuHoc>();

    public virtual ICollection<HsDiemTrungBinhMonDanhGiaTrenTieuHoc> HsDiemTrungBinhMonDanhGiaTrenTieuHocs { get; set; } = new List<HsDiemTrungBinhMonDanhGiaTrenTieuHoc>();

    public virtual ICollection<HsDiemTrungBinhMonHocKy> HsDiemTrungBinhMonHocKies { get; set; } = new List<HsDiemTrungBinhMonHocKy>();

    public virtual ICollection<HsHanhKiem> HsHanhKiems { get; set; } = new List<HsHanhKiem>();

    public virtual ICollection<HsHienTai> HsHienTais { get; set; } = new List<HsHienTai>();

    public virtual ICollection<HsHocLucMon> HsHocLucMons { get; set; } = new List<HsHocLucMon>();

    public virtual ICollection<HsHocSinhBanHoc> HsHocSinhBanHocs { get; set; } = new List<HsHocSinhBanHoc>();

    public virtual ICollection<HsHocSinhHocLuc> HsHocSinhHocLucs { get; set; } = new List<HsHocSinhHocLuc>();

    public virtual ICollection<HsHocSinhMonKhuyenKhich> HsHocSinhMonKhuyenKhiches { get; set; } = new List<HsHocSinhMonKhuyenKhich>();

    public virtual ICollection<HsHocSinhMonMienGiam> HsHocSinhMonMienGiams { get; set; } = new List<HsHocSinhMonMienGiam>();

    public virtual ICollection<HsPhanLop> HsPhanLops { get; set; } = new List<HsPhanLop>();

    public virtual ICollection<HsSucKhoe> HsSucKhoes { get; set; } = new List<HsSucKhoe>();
}
