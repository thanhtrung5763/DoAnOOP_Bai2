using System;

namespace QuanLyQuanCaPhe
{
    static class QuanLiQuan 
    {
        static QuanLiQuan() {

        }
        public static void MenuQuanLiQuanCaPhe() {
            int chon;
            do {
                Console.WriteLine("---Quan Li Quan Ca Phe---");
                Console.WriteLine("0. Quay Li Nhan Vien");
                Console.WriteLine("1. Quan Li Ban");
                Console.WriteLine("2. Quan Li Bo Phan");
                Console.WriteLine("3. Quan Li Thuc Don");
                Console.WriteLine("4. Quan Li Hoa Don");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    switch(chon) {
                        case 0:
                                QuanLiNhanVien.MenuQuanLiNhanVien();
                                break;
                        case 1:
                                QuanLiBan.MenuQuanLiBan();
                                break;
                        case 2:
                                QuanLiBoPhan.MenuQuanLiBoPhan();
                                break; 
                        case 3:
                                QuanLiThucDon.MenuQuanLiThucDon();
                                break; 
                        case 4:
                                QuanLiHoaDon.MenuQuanLiHoaDon();
                                break; 
                        case 5:
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
            while(chon != 0 || chon != 5);
        }
    }
}