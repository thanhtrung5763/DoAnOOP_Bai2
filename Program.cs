using System;

namespace QuanLyQuanCaPhe
{
    class Program
    {
        static void Main(string[] args)
        {
            BoPhan bp1 = new BoPhan("Quan Li");
            BoPhan bp2 = new BoPhan("Phuc Vu");
            BoPhan bp3 = new BoPhan("Pha Che");
            BoPhan bp4 = new BoPhan("Thu Ngan");
            NhanVien nv1 = new NhanVien("Thanh", "Nam", "DN", "20/08/2020", "19/10/2001", "Phuc Vu");
            nv1.HienThi();
            nv1.CapNhatViTri("Pha Che");
            nv1.CapNhatNgayVaoLam("20/09/2020");
            nv1.HienThi();
            // NhanVien nv2 = new NhanVien();
            // nv2.TaoNhanVien();
            // nv2.HienThi();
            // QuanLiBoPhan.HienThi();
            // QuanLiNhanVien.ThemNhanVien();
            // QuanLiNhanVien.CapNhatThongTinNhanVien();
            ThucDon f1 = new ThucAn("Banh flan vo trung", 30000, "Con", "Sang, Trua, Chieu", "Chay");
            ThucDon f2 = new ThucAn("Bap xao", 15000, "Het", "Sang, Trua", "Chay");
            ThucDon f3 = new ThucAn("Com tam", 20000, "Con", "Trua, Chieu", "Khong Chay");
            ThucDon f4 = new ThucAn("Com chay", 15000, "Con", "Trua, Chieu", "Chay");
            ThucDon f5 = new ThucAn("Goi bo", 20000, "Con", "Chieu, Toi", "Khong Chay");
            ThucDon d1 = new ThucUong("Tra Sua Tran Chau", 30000, "Con", "Sang, Trua, Chieu, Toi", "Da");
            ThucDon d2 = new ThucUong("Sua Nong", 20000, "Con", "Trua, Toi", "Khong Da");
            ThucDon d3 = new ThucUong("Coffe Da", 15000, "Con", "Sang, Toi", "Da");
            ThucDon d4 = new ThucUong("Coffe", 15000, "Con", "Sang, Toi", "Khong Da");
            ThucDon d5 = new ThucUong("Nuoc Cam", 30000, "Con", "Sang, Trua, Chieu", "Da");

            f1.HienThi();
            d1.HienThi();
            f2.HienThi();
            QuanLiThucDon.MenuQuanLiThucDon();
        }
    }
}
