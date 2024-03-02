using System.Collections.Generic;

class Program
{
    static void Main()
    {
        QuanLyThuoc quanLyThuoc = new QuanLyThuoc();

        // Thêm thuốc và dược phẩm
        quanLyThuoc.ThemThuoc(new Thuoc("Paracetamol", 50, 5.5m, "Thuốc đau", new List<DuocPham> { new DuocPham("Acetaminophen", 500, 1) }));
        quanLyThuoc.ThemThuoc(new Thuoc("Amoxicillin", 30, 8.2m, "Thuốc kháng sinh", new List<DuocPham> { new DuocPham("Amoxicillin Trihydrate", 250, 1) }));
        quanLyThuoc.ThemThuoc(new Thuoc("Ibuprofen", 40, 7.8m, "Thuốc đau", new List<DuocPham> { new DuocPham("Ibuprofen", 400, 1) }));

        // Các chức năng khác
    }
}
