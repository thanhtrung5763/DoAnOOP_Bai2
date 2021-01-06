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
            Console.WriteLine("\t\t\t -----------------DANH SACH HOA DON-----------------");
            Console.WriteLine("\t\t\t Ma Hoa Don    | Thoi Gian             | Tong Tien");
            Console.WriteLine("\t\t\t ---------------------------------------------------");
            DanhSachHoaDon.ForEach(x => x.ThongTinHoaDon());
        }
        public static void DoanhThuTheoThang(string Thang) {
            List<HoaDon> lHD = QuanLiHoaDon.lHoaDon.FindAll(x => x.ThoiGian.Month.ToString() == Thang);
            if(lHD.Count != 0) {
                Console.WriteLine($"\t\t\t Doanh Thu Thang {Thang}: ");
                QuanLiHoaDon.DanhSachHoaDon(lHD);
                Console.WriteLine("\t\t\t ---------------------------------------------------");
                Console.WriteLine($"\t\t\t Tong:                                 | {QuanLiHoaDon.TinhTien(lHD), -12}");
                Console.WriteLine("\t\t\t ---------------------------------------------------");
            }
            else
                Console.WriteLine($"Thang {Thang} Khong Co Doanh Thu");
        }
        public static void TongDoanhThu() {
            Console.WriteLine($"\t\t\t Doanh Thu Ca Nam: ");
            QuanLiHoaDon.DanhSachHoaDon(QuanLiHoaDon.lHoaDon);
            Console.WriteLine("\t\t\t ---------------------------------------------------");
            Console.WriteLine($"\t\t\t Tong:                                 | {QuanLiHoaDon.TinhTien(QuanLiHoaDon.lHoaDon), -12}");
            Console.WriteLine("\t\t\t ---------------------------------------------------");
        }
        public static void MenuDoanhThu() {
            int chon;
            do {
                Console.WriteLine("\t\t\t |==============================Quan Li Doanh Thu==============================|\n");
                Console.WriteLine("\t\t\t |                            0. Quay Lai                                      |\n");
                Console.WriteLine("\t\t\t |                            1. Theo Thang                                    |\n");
                Console.WriteLine("\t\t\t |                            2. Tong Doanh Thu                                |\n");
                Console.WriteLine("\t\t\t |                            3. Thoat                                         |\n");
                Console.WriteLine("\t\t\t |===================================CHOOSE====================================|\n");
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
                                QuanLiHoaDon.DoanhThuTheoThang(Thang);
                                break;
                        case 2:
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
                Console.WriteLine("\t\t\t |===============================Quan Li Hoa Don===============================|\n");
                Console.WriteLine("\t\t\t |                            0. Quay Lai                                      |\n");
                Console.WriteLine("\t\t\t |                            1. Danh Sach Hoa Don                             |\n");
                Console.WriteLine("\t\t\t |                            2. Doanh Thu                                     |\n");
                Console.WriteLine("\t\t\t |                            3. Thoat                                         |\n");
                Console.WriteLine("\t\t\t |===================================CHOOSE====================================|\n");
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