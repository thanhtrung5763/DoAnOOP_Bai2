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
                Console.WriteLine("\t\t\t |=============================Quan Li Quan Ca Phe=============================|\n");
                Console.WriteLine("\t\t\t |                            0. Quan Li Nhan Vien                             |\n");
                Console.WriteLine("\t\t\t |                            1. Quan Li Ban                                   |\n");
                Console.WriteLine("\t\t\t |                            2. Quan Li Bo Phan                               |\n");
                Console.WriteLine("\t\t\t |                            3. Quan Li Thuc Don                              |\n");
                Console.WriteLine("\t\t\t |                            4. Quan Li Hoa Don                               |\n");
                Console.WriteLine("\t\t\t |                            5. Thoat                                         |\n");
                Console.WriteLine("\t\t\t |===================================CHOOSE====================================|\n");
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