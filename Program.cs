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
            QuanLiNhanVien.CapNhatThongTinNhanVien();
        }
    }
}
