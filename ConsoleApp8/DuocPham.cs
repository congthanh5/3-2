class DuocPham
{
    public string TenDuocPham { get; set; }
    public int SoLuong { get; set; }
    public int DonViTinh { get; set; }

    public DuocPham(string tenDuocPham, int soLuong, int donViTinh)
    {
        TenDuocPham = tenDuocPham;
        SoLuong = soLuong;
        DonViTinh = donViTinh;
    }
}
