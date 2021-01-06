using System;
using System.Collections.Generic;

namespace QuanLyQuanCaPhe 
{
    static class QuanLiHoaDon {
        private static List<HoaDon> lHoaDon = new List<HoaDon>();
        public static List<HoaDon> DSHoaDon {
            get { return QuanLiHoaDon.lHoaDon; }
            set { QuanLiHoaDon.lHoaDon = value; }
        }
        static QuanLiHoaDon() 
        {

        }
        public static int TinhTien(List<HoaDon> DanhSachHoaDon) {
            int s = 0;
            foreach(HoaDon hd in DanhSachHoaDon) {
                s = s + hd;
            }
            return s;
        }
        public static void DanhSachHoaDon(List<HoaDon> DanhSachHoaDon) {
            Console.WriteLine("Ma Hoa Don | Thoi Gian            | Tong Tien");
            DanhSachHoaDon.ForEach(x => x.ThongTinHoaDon());
        }
        public static void DoanhThuTheoThang(string Thang) {
            List<HoaDon> lHD = QuanLiHoaDon.lHoaDon.FindAll(x => x.ThoiGian.Month.ToString() == Thang);
            QuanLiHoaDon.DanhSachHoaDon(lHD);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Tong:                               {QuanLiHoaDon.TinhTien(lHD), -9}");
        }
        public static void TongDoanhThu() {
            QuanLiHoaDon.DanhSachHoaDon(QuanLiHoaDon.lHoaDon);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Tong:                               {QuanLiHoaDon.TinhTien(QuanLiHoaDon.lHoaDon), -9}");
        }
        public static void MenuDoanhThu() {
            int chon;
            do {
                Console.WriteLine("---Quan Li Doanh Thu---");
                Console.WriteLine("0. Quay Lai");
                Console.WriteLine("1. Theo Thang");
                Console.WriteLine("2. Tong Doanh Thu");
                Console.WriteLine("3. Thoat");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    switch(chon) {
                        case 0:
                                QuanLiHoaDon.MenuQuanLiHoaDon();
                                break;
                        case 1:
                                string Thang;
                                Console.WriteLine("Thang Muon Tinh Doanh Thu: ");
                                Thang = Console.ReadLine();
                                Console.WriteLine("---Doanh Thu Thang {Thang}---");
                                QuanLiHoaDon.DoanhThuTheoThang(Thang);
                                break;
                        case 2:
                                Console.WriteLine("---Tong Doanh Thu---");
                                QuanLiHoaDon.TongDoanhThu();
                                break;
                        case 3:
                                Environment.Exit(0);
                                break; 
                        default:
                                Console.WriteLine("Vui Long Nhap Lai");
                                break;
                    }              
                }
                catch(System.FormatException) {
                    Console.WriteLine("Vui Long Nhap Chu So");
                }
            }
            while(chon != 0 || chon != 3);
        }
        public static void MenuQuanLiHoaDon() {
            int chon;
            do {
                Console.WriteLine("---Quan Li Hoa Don---");
                Console.WriteLine("0. Quay Lai");
                Console.WriteLine("1. Danh Sach Hoa Don");
                Console.WriteLine("2. Doanh Thu");
                Console.WriteLine("3. Thoat");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    switch(chon) {
                        case 0:
                                QuanLiQuan.MenuQuanLiQuanCaPhe();
                                break;
                        case 1:
                                QuanLiHoaDon.DanhSachHoaDon(QuanLiHoaDon.lHoaDon);
                                break;
                        case 2:
                                QuanLiHoaDon.MenuDoanhThu();
                                break;
                        case 3:
                                Environment.Exit(0);
                                break; 
                        default:
                                Console.WriteLine("Vui Long Nhap Lai");
                                break;
                    }              
                }
                catch(System.FormatException) {
                    Console.WriteLine("Vui Long Nhap Chu So");
                }
            }
            while(chon != 0 || chon != 3);
        }
    }
}