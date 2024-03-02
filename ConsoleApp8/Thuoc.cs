using System;
using System.Collections.Generic;

class Thuoc
{
    public string TenThuoc { get; set; }
    public int SoLuong { get; set; }
    public decimal GiaBan { get; set; }
    public string DanhMuc { get; set; }
    public List<DuocPham> DuocPhams { get; set; }

    public Thuoc(string tenThuoc, int soLuong, decimal giaBan, string danhMuc, List<DuocPham> duocPhams)
    {
        TenThuoc = tenThuoc;
        SoLuong = soLuong;
        GiaBan = giaBan;
        DanhMuc = danhMuc;
        DuocPhams = duocPhams;
    }
}
