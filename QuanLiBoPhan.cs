using System;
using System.Collections.Generic;
namespace QuanLyQuanCaPhe
{
    static class QuanLiBoPhan
    {
        private static List<BoPhan> lBoPhan = new List<BoPhan>();
        static QuanLiBoPhan() {
            
        }
        public static List<BoPhan> DSBoPhan {
            get { return QuanLiBoPhan.lBoPhan; }
            set { QuanLiBoPhan.lBoPhan = value; }
        }
        public static void HienThi() {
            Console.WriteLine("\t\t\t ----------------DANH SACH BO PHAN----------------");
            Console.WriteLine("\t\t\t Ma Bo Phan                          | Ten Bo Phan");
            Console.WriteLine("\t\t\t -------------------------------------------------");
            QuanLiBoPhan.lBoPhan.ForEach(x => x.HienThi());
        }
        public static void MenuQuanLiBoPhan() {
            int chon;
            do {
                Console.WriteLine("\t\t\t |===============================Quan Li Bo Phan===============================|\n");
                Console.WriteLine("\t\t\t |                            0. Quay Lai                                      |\n");
                Console.WriteLine("\t\t\t |                            1. Danh Sach Bo Phan                             |\n");
                Console.WriteLine("\t\t\t |                            2. Thoat                                         |\n");
                Console.WriteLine("\t\t\t |===================================CHOOSE====================================|\n");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    switch(chon) {
                        case 0:
                                QuanLiQuan.MenuQuanLiQuanCaPhe();
                                break;
                        case 1:
                                QuanLiBoPhan.HienThi();
                                break;
                        case 2:
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
