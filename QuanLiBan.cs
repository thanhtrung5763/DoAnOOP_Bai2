using System;
using System.Collections.Generic;

namespace QuanLyQuanCaPhe
{
    static class QuanLiBan {
        private static List<Ban> lBan = new List<Ban>();
        public static List<Ban> DSBan {
            get { return QuanLiBan.lBan; }
            set { QuanLiBan.lBan = value; }
        }
        static QuanLiBan() {
            
        }
        public static void ThemBan() {
            Ban b = new Ban();
            b.TaoThemBan();
            QuanLiBan.DSBan.Add(b);
        }
        public static void XoaBan() {
            string MaBan;
            Console.WriteLine("Nhap Ma Ban Muon Xoa: ");
            MaBan = Console.ReadLine();
            Ban b = QuanLiBan.DSBan.Find(x => x.MaBan == MaBan);
            if(b != null)
                QuanLiBan.DSBan.Remove(b);
        }
        public static void MenuCapNhat() {
            int chon;
            string MaBan;
            Console.WriteLine("Nhap Ma Ban Muon Cap Nhat: ");
            MaBan = Console.ReadLine();
            Ban ban = QuanLiBan.DSBan.Find(x => x.MaBan == MaBan);
            if(ban == null) {
                Console.WriteLine("Ban Khong Co Trong He Thong. Xin Nhap Lai");
                QuanLiBan.MenuCapNhat();
            }
            do {
                Console.WriteLine("\t\t\t |=============================Cap Nhat Thong Tin Ban=============================|\n");
                Console.WriteLine("\t\t\t |                            0. Quay Lai                                         |\n");
                Console.WriteLine("\t\t\t |                            1. Tinh Trang                                       |\n");
                Console.WriteLine("\t\t\t |                            2. Suc Chua                                         |\n");
                Console.WriteLine("\t\t\t |                            3. Thoat                                            |\n");
                Console.WriteLine("\t\t\t |====================================CHOOSE======================================|\n");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    Console.WriteLine("Thong Tin Ban Can Cap Nhat: ");
                    Console.WriteLine("\t\t\t Ma Ban                          | Tinh Trang                         | Suc Chua");
                    ban.HienThi();
                    switch(chon) {
                        case 0:
                                QuanLiBan.MenuQuanLiBan();
                                break;
                        case 1: 
                                string tt;
                                Console.WriteLine("Nhap Tinh Trang(Trong/Day): ");
                                tt = Console.ReadLine();
                                ban.CapNhatTinhTrang(tt);
                                break;
                        case 2:
                                int sc;
                                Console.WriteLine("Nhap Suc Chua: ");
                                sc = int.Parse(Console.ReadLine());
                                if(sc > 0) {
                                    ban.CapNhatSucChua(sc);
                                }
                                break;
                        default:
                                Console.WriteLine("Vui Long Nhap Lai");
                                break;
                    }
                    Console.WriteLine("Thong Tin Ban Sau Cap Nhat: ");
                    Console.WriteLine("\t\t\t Ma Ban                          | Tinh Trang                         | Suc Chua");
                    ban.HienThi();    
                }
                catch(System.FormatException) {
                    Console.WriteLine("Vui Long Nhap Chu So");
                }
            }
            while(chon != 0 || chon != 3);
        }

        public static void DatBan() {
            HoaDon hd = new HoaDon();
            hd.TaoHoaDon();
            QuanLiHoaDon.DSHoaDon.Add(hd);
        }
        public static void MenuQuanLiBan() {
            int chon;
            do {
                Console.WriteLine("\t\t\t |=================================Quan Li Ban=================================|\n");
                Console.WriteLine("\t\t\t |                            0. Quay Lai                                      |\n");
                Console.WriteLine("\t\t\t |                            1. Danh Sach Ban                                 |\n");
                Console.WriteLine("\t\t\t |                            2. Dat Ban                                       |\n");
                Console.WriteLine("\t\t\t |                            3. Them Ban                                      |\n");
                Console.WriteLine("\t\t\t |                            4. Xoa Ban                                       |\n");
                Console.WriteLine("\t\t\t |                            5. Cap Nhat Thong Tin Ban                        |\n");
                Console.WriteLine("\t\t\t |                            6. Xem Hoa Hon                                   |\n");
                Console.WriteLine("\t\t\t |                            7. Thoat                                         |\n");
                Console.WriteLine("\t\t\t |===================================CHOOSE====================================|\n");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    switch(chon) {
                        case 0:
                                QuanLiQuan.MenuQuanLiQuanCaPhe();
                                break;
                        case 1:
                                Console.WriteLine("\t\t\t ---------------------------------Danh Sach Ban---------------------------------\n");
                                Console.WriteLine("\t\t\t Ma Ban                          | Tinh Trang                         | Suc Chua");
                                Console.WriteLine("\t\t\t -------------------------------------------------------------------------------");
                                QuanLiBan.DSBan.ForEach(x => x.HienThi());
                                break;
                        case 2:
                                QuanLiBan.DatBan();
                                break;
                        case 3:
                                QuanLiBan.ThemBan();
                                break;
                        case 4:
                                QuanLiBan.XoaBan();
                                break;
                        case 5:
                                QuanLiBan.MenuCapNhat();
                                break;
                        case 6:
                                string mhd;
                                Console.WriteLine("Ma Hoa Don:  ");
                                mhd = Console.ReadLine();
                                HoaDon hd = QuanLiHoaDon.DSHoaDon.Find(x => x.MaHoaDon == mhd);
                                if( hd != null) {
                                    Console.WriteLine($"\t\t\t ----------------------------------Hoa Don So {mhd}---------------------------------\n");
                                    hd.HoaDonChoKhach();
                                }
                                break;
                        case 7:
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
            while(chon != 0 || chon != 6);
        }
    }
}