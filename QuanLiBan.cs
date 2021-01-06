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
            do {
                Console.WriteLine("---Cap Nhat Thong Tin Ban---");
                Console.WriteLine("0. Quay Lai");
                Console.WriteLine("1. Tinh Trang");
                Console.WriteLine("2. Suc Chua");
                Console.WriteLine("3. Thoat");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
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
                Console.WriteLine("---Quan Li Ban---");
                Console.WriteLine("0. Quay Lai");
                Console.WriteLine("1. Danh Sach Ban");
                Console.WriteLine("2. Dat ban");
                Console.WriteLine("3. Them Ban");
                Console.WriteLine("4. Xoa Ban");
                Console.WriteLine("5. Cap Nhat Thong Tin Ban");
                Console.WriteLine("6. Xem Hoa Don");
                Console.WriteLine("7. Thoat");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    switch(chon) {
                        case 0:
                                QuanLiQuan.MenuQuanLiQuanCaPhe();
                                break;
                        case 1:
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
                                    Console.WriteLine($"---Hoa Don So {mhd}---");
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