using System;
using System.Collections.Generic;

namespace Vemis_QLHS.Entities;

public partial class VwGiaDinhHocSinh
{
    public string? HoVaTen { get; set; }

    public string? NamSinh { get; set; }

    public string? TenQuanHeGiaDinh { get; set; }

    public string? DonViCongTac { get; set; }

    public string? TenNgheNghiep { get; set; }

    public int Active { get; set; }

    public string? FkQuanHeGiaDinhId { get; set; }

    public string? FkNgheNghiepId { get; set; }

    public string? Ma { get; set; }

    public string? GdDienThoai { get; set; }
}
