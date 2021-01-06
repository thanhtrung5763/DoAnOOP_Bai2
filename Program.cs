using System;
using System.Collections.Generic;
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
            NhanVien nv1 = new NhanVien("Thanh", "Nam", "DN", "20/09/2020", "12/03/2001", "Phuc Vu");
            NhanVien nv2 = new NhanVien("Trung", "Nam", "HCM", "21/10/2020", "14/02/200", "Thu Ngan");
            NhanVien nv3 = new NhanVien("Tram", "Nu", "HN", "02/03/2020", "17/09/1999", "Thu Ngan");
            NhanVien nv4 = new NhanVien("Hieu", "Nam", "BB", "14/07/2020", "19/11/1990", "Quan Li");
            NhanVien nv5 = new NhanVien("Nhi", "Nu", "BB", "09/01/2020", "21/07/2001", "Pha Che");

            ThucDon f1 = new ThucAn("Banh flan vo trung", 30000, "Con", "Sang, Trua, Chieu", "Chay");
            ThucDon f2 = new ThucAn("Bap xao", 15000, "Het", "Sang, Trua", "Chay");
            ThucDon f3 = new ThucAn("Com tam", 20000, "Con", "Sang, Trua, Chieu", "Khong Chay");
            ThucDon f4 = new ThucAn("Com chay", 15000, "Con", "Trua, Chieu", "Chay");
            ThucDon f5 = new ThucAn("Goi bo", 20000, "Con", "Chieu, Toi", "Khong Chay");
            ThucDon d1 = new ThucUong("Tra Sua Tran Chau", 30000, "Con", "Sang, Trua, Chieu, Toi", "Da");
            ThucDon d2 = new ThucUong("Sua Nong", 20000, "Con", "Trua, Toi", "Khong Da");
            ThucDon d3 = new ThucUong("Coffe Da", 15000, "Con", "Sang, Toi", "Da");
            ThucDon d4 = new ThucUong("Coffe", 15000, "Con", "Sang, Toi", "Khong Da");
            ThucDon d5 = new ThucUong("Nuoc Cam", 30000, "Con", "Sang, Trua, Chieu", "Da");

            Ban b1 = new Ban("Trong", 4);
            Ban b2 = new Ban("Trong", 2);
            Ban b3 = new Ban("Trong", 2);
            Ban b4 = new Ban("Day", 4);
            Ban b5 = new Ban("Day", 6);
            
            List<int> sl1 = new List<int>(new List<int> { 1, 2, 3 });
            List<int> sl2 = new List<int>(new List<int> { 2, 1, 3 });
            List<int> sl3 = new List<int>(new List<int> { 1, 4 });
            List<ThucDon> td1 = new List<ThucDon>(new List<ThucDon> { f1, f4, d5});
            List<ThucDon> td2 = new List<ThucDon>(new List<ThucDon> { f2, f1, d5});
            List<ThucDon> td3 = new List<ThucDon>(new List<ThucDon> { d5, f3});
            HoaDon hd1 = new HoaDon("2", td1, sl1, b2, "05/01/2021", "Trua", 100000);
            HoaDon hd2 = new HoaDon("3", td2, sl2, b1, "07/05/2021", "Sang", 500000);
            HoaDon hd3 = new HoaDon("3", td3, sl3, b3, "05/09/2021", "Sang", 200000);
            // QuanLiNhanVien.MenuQuanLiNhanVien();
            // QuanLiThucDon.MenuQuanLiThucDon();
            // QuanLiHoaDon.MenuQuanLiHoaDon();
            // QuanLiBan.MenuQuanLiBan();
            // QuanLiBoPhan.MenuQuanLiBoPhan();
            QuanLiQuan.MenuQuanLiQuanCaPhe();
        }
    }
}
