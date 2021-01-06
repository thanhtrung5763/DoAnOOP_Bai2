using System;
using System.Collections.Generic;
using System.Linq;
namespace QuanLyQuanCaPhe
{
    static class QuanLiThucDon {
        private static List<ThucDon> lThucDon  = new List<ThucDon>();
        private static List<ThucAn> lThucAn  = new List<ThucAn>();
        private static List<ThucUong> lThucUong  = new List<ThucUong>();
        public static List<ThucDon> DSThucDon{
            get { return QuanLiThucDon.lThucDon; }
            set { QuanLiThucDon.lThucDon = value; }
        }
        public static List<ThucAn> DSThucAn{
            get { return QuanLiThucDon.lThucAn; }
            set { QuanLiThucDon.lThucAn = value; }
        }
        public static List<ThucUong> DSThucUong{
            get { return QuanLiThucDon.lThucUong; }
            set { QuanLiThucDon.lThucUong = value; }
        }

        static QuanLiThucDon() {

        }
        public static void ThemThucAn() {
            ThucAn ta = new ThucAn();
            ta.TaoThucAn();
            QuanLiThucDon.DSThucAn.Add(ta);
            QuanLiThucDon.DSThucDon.Add(ta);
        }
        public static void ThemThucUong() {
            ThucUong tu = new ThucUong();
            tu.TaoThucUong();
            QuanLiThucDon.DSThucUong.Add(tu);
            QuanLiThucDon.DSThucDon.Add(tu);
        }
        public static void XoaThucAn() {
            Console.WriteLine("Nhap Thuc An Muon Xoa: ");
            string TenThucAn = Console.ReadLine();
            ThucAn ta = QuanLiThucDon.DSThucAn.Find(x => x.Ten == TenThucAn);
            QuanLiThucDon.DSThucAn.Remove(ta);
            QuanLiThucDon.DSThucDon.Remove(ta);
        }
        public static void XoaThucUong() {
            Console.WriteLine("Nhap Thuc Uong Muon Xoa: ");
            string TenThucUong = Console.ReadLine();
            ThucUong tu = QuanLiThucDon.DSThucUong.Find(x => x.Ten == TenThucUong);
            QuanLiThucDon.DSThucUong.Remove(tu);
            QuanLiThucDon.DSThucDon.Remove(tu);
        }
        public static void ThucDon() {
            Console.WriteLine("\t\t\t -----------------------------------THUC DON-----------------------------------\n");
            Console.WriteLine("\t\t\t Thuc An");
            Console.WriteLine("\t\t\t ------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t Ten Mon             | Gia      | Tinh Trang | Thoi Diem Ban            | Loai");
            Console.WriteLine("\t\t\t ------------------------------------------------------------------------------\n");
            QuanLiThucDon.DSThucAn.ForEach(x => x.HienThi());
            Console.WriteLine("\t\t\t ------------------------------------------------------------------------------\n");
            Console.WriteLine("\t\t\t Thuc Uong");
            Console.WriteLine("\t\t\t ------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t Ten Mon             | Gia      | Tinh Trang | Thoi Diem Ban            | Loai");
            Console.WriteLine("\t\t\t ------------------------------------------------------------------------------\n");
            QuanLiThucDon.DSThucUong.ForEach(x => x.HienThi());
            Console.WriteLine("\t\t\t ------------------------------------------------------------------------------");
        }
        public static List<ThucDon> SapXepThucDon(int flag) {
            List<ThucDon> temp = QuanLiThucDon.DSThucDon;
            if(flag == 1)
                temp = temp.OrderBy(x => x.Gia).ToList();
            else if(flag == 2)
                temp = temp.OrderByDescending(x => x.Gia).ToList();
            return temp;
        }
        public static List<ThucAn> SapXepThucAn(int flag) {
            List<ThucAn> temp = QuanLiThucDon.DSThucAn;
            if(flag == 1)
                temp = temp.OrderBy(x => x.Gia).ToList();
            else if(flag == 2)
                temp = temp.OrderByDescending(x => x.Gia).ToList();
            return temp;
        }
        public static List<ThucUong> SapXepThucUong(int flag) {
            List<ThucUong> temp = QuanLiThucDon.DSThucUong;
            if(flag == 1)
                temp = temp.OrderBy(x => x.Gia).ToList();
            else if(flag == 2)
                temp = temp.OrderByDescending(x => x.Gia).ToList();
            return temp;
        }
        public static List<ThucAn> TimKiemThucAnTheoKhoangGia(int Gia1, int Gia2) {
            List<ThucAn> lThucAn = QuanLiThucDon.DSThucAn.FindAll(x => (x.Gia >= Gia1 && x.Gia <= Gia2));
            return lThucAn;
        }
        public static List<ThucUong> TimKiemThucUongTheoKhoangGia(int Gia1, int Gia2) {
            List<ThucUong> lThucUong = QuanLiThucDon.DSThucUong.FindAll(x => (x.Gia >= Gia1 && x.Gia <= Gia2));
            return lThucUong;
        }
        public static List<ThucDon> TimKiemThucDonTheoKhoangGia(int Gia1, int Gia2) {
            List<ThucDon> lThucDon = QuanLiThucDon.DSThucDon.FindAll(x => (x.Gia >= Gia1 && x.Gia <= Gia2));
            return lThucDon;
        }
        public static void MenuQuanLiThucDon() {
            int chon;
            do {
                Console.WriteLine("\t\t\t |==============================Quan Li Thuc Don===============================|\n");
                Console.WriteLine("\t\t\t |                            0. Quay Lai                                      |\n");
                Console.WriteLine("\t\t\t |                            1. Thuc Don                                      |\n");
                Console.WriteLine("\t\t\t |                            2. Them Mon                                      |\n");
                Console.WriteLine("\t\t\t |                            3. Xoa Mon                                       |\n");
                Console.WriteLine("\t\t\t |                            4. Sap Xep                                       |\n");
                Console.WriteLine("\t\t\t |                            5. Tim Kiem Theo Khoang Gia                      |\n");
                Console.WriteLine("\t\t\t |                            6. Thoat                                         |\n");
                Console.WriteLine("\t\t\t |===================================CHOOSE====================================|\n");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    switch(chon) {
                        case 0:
                                QuanLiQuan.MenuQuanLiQuanCaPhe();
                                break;
                        case 1:
                                QuanLiThucDon.ThucDon();
                                break;
                        case 2:
                                QuanLiThucDon.MenuThem();
                                break;
                        case 3:
                                QuanLiThucDon.MenuXoa();
                                break;
                        case 4:
                                QuanLiThucDon.MenuThuTuSapXep();
                                break;
                        case 5:
                                QuanLiThucDon.MenuTimKiem();
                                break;
                        case 6:
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
            while(chon != 0 || chon != 7);
        }
        public static void MenuThem() {
            int chon;
            do {
                Console.WriteLine("\t\t\t |===================================Them Mon==================================|\n");
                Console.WriteLine("\t\t\t |                                 0. Quay Lai                                 |\n");
                Console.WriteLine("\t\t\t |                                 1. Thuc An                                  |\n");
                Console.WriteLine("\t\t\t |                                 2. Thuc Uong                                |\n");
                Console.WriteLine("\t\t\t |                                 3. Thoat                                    |\n");
                Console.WriteLine("\t\t\t |===================================CHOOSE====================================|\n");
                Console.WriteLine("Ban Chon: ");

                chon = int.Parse(Console.ReadLine());
                try {
                    switch(chon) {
                        case 0:
                                QuanLiThucDon.MenuQuanLiThucDon();
                                break;
                        case 1:
                                QuanLiThucDon.ThemThucAn();
                                break;
                        case 2:
                                QuanLiThucDon.ThemThucUong();
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
        public static void MenuXoa() {
            int chon;
            do {
                Console.WriteLine("\t\t\t |===================================Xoa Mon===================================|\n");
                Console.WriteLine("\t\t\t |                                 0. Quay Lai                                 |\n");
                Console.WriteLine("\t\t\t |                                 1. Thuc An                                  |\n");
                Console.WriteLine("\t\t\t |                                 2. Thuc Uong                                |\n");
                Console.WriteLine("\t\t\t |                                 3. Thoat                                    |\n");
                Console.WriteLine("\t\t\t |===================================CHOOSE====================================|\n");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    switch(chon) {
                        case 0:
                                QuanLiThucDon.MenuQuanLiThucDon();
                                break;
                        case 1:
                                QuanLiThucDon.XoaThucAn();
                                break;
                        case 2:
                                QuanLiThucDon.XoaThucUong();
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
        public static void MenuThuTuSapXep() {
            int chon;
            do {
                Console.WriteLine("\t\t\t |===================================Sap Xep===================================|\n");
                Console.WriteLine("\t\t\t |                                 0. Quay Lai                                 |\n");
                Console.WriteLine("\t\t\t |                                 1. Tang Dan                                 |\n");
                Console.WriteLine("\t\t\t |                                 2. Giam Dan                                 |\n");
                Console.WriteLine("\t\t\t |                                 3. Thoat                                    |\n");
                Console.WriteLine("\t\t\t |===================================CHOOSE====================================|\n");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    switch(chon) {
                        case 0:
                                QuanLiThucDon.MenuQuanLiThucDon();
                                break;
                        case 1: 
                                QuanLiThucDon.MenuSapXep(chon);
                                break;
                        case 2:
                                QuanLiThucDon.MenuSapXep(chon);
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
        public static void MenuSapXep(int flag) {
            int chon;
            do {
                if(flag == 1) {
                    Console.WriteLine("\t\t\t |===============================Sap Xep Tang Dan==============================|\n");

                }
                else if(flag == 2) {
                    Console.WriteLine("\t\t\t |===============================Sap Xep Giam Dan==============================|\n");

                }
                Console.WriteLine("\t\t\t |                                 0. Quay Lai                                 |\n");
                Console.WriteLine("\t\t\t |                                 1. Thuc Don                                 |\n");
                Console.WriteLine("\t\t\t |                                 2. Thuc An                                  |\n");
                Console.WriteLine("\t\t\t |                                 3. Thuc Uong                                |\n");
                Console.WriteLine("\t\t\t |                                 4. Thoat                                    |\n");
                Console.WriteLine("\t\t\t |===================================CHOOSE====================================|\n");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    switch(chon) {
                        case 0:
                                QuanLiThucDon.MenuThuTuSapXep();
                                break;
                        case 1: 
                                List<ThucDon> lTD = QuanLiThucDon.SapXepThucDon(flag);
                                if(flag == 1) {
                                    Console.WriteLine("Danh Sach Mon Tang Dan Theo Gia: ");
                                }
                                else
                                    Console.WriteLine("Danh Sach Mon Giam Dan Theo Gia: ");

                                Console.WriteLine("\t\t\t Ten Mon             | Gia      | Tinh Trang | Thoi Diem Ban            | Loai");
                                Console.WriteLine("\t\t\t ------------------------------------------------------------------------------\n");
                                lTD.ForEach(x => x.HienThi());
                                break;
                        case 2:
                                List<ThucAn> lTA = QuanLiThucDon.SapXepThucAn(flag);
                                if(flag == 1) {
                                    Console.WriteLine("Danh Sach Thuc An Tang Dan Theo Gia: ");
                                }
                                else
                                    Console.WriteLine("Danh Sach Thuc An Giam Dan Theo Gia: ");
                                Console.WriteLine("\t\t\t Ten Mon             | Gia      | Tinh Trang | Thoi Diem Ban            | Loai");
                                Console.WriteLine("\t\t\t ------------------------------------------------------------------------------\n");
                                lTA.ForEach(x => x.HienThi());
                                break;
                        case 3:
                                List<ThucUong> lTU = QuanLiThucDon.SapXepThucUong(flag);
                                if(flag == 1) {
                                    Console.WriteLine("Danh Sach Thuc Uong Tang Dan Theo Gia: ");
                                }
                                else
                                    Console.WriteLine("Danh Sach Thuc Uong Giam Dan Theo Gia: ");
                                Console.WriteLine("\t\t\t Ten Mon             | Gia      | Tinh Trang | Thoi Diem Ban            | Loai");
                                Console.WriteLine("\t\t\t ------------------------------------------------------------------------------\n");
                                lTU.ForEach(x => x.HienThi());
                                break;   
                        case 4:
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
            while(chon != 0 || chon != 4);
        }
        public static void MenuTimKiem() {
            int chon, Gia1, Gia2;
            do {
                Console.WriteLine("\t\t\t |===================================Tim Kiem==================================|\n");
                Console.WriteLine("\t\t\t |                                 0. Quay Lai                                 |\n");
                Console.WriteLine("\t\t\t |                                 1. Thuc Don                                 |\n");
                Console.WriteLine("\t\t\t |                                 2. Thuc An                                  |\n");
                Console.WriteLine("\t\t\t |                                 3. Thuc Uong                                |\n");
                Console.WriteLine("\t\t\t |                                 4. Thoat                                    |\n");
                Console.WriteLine("\t\t\t |===================================CHOOSE====================================|\n");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    switch(chon) {
                        case 0:
                                QuanLiThucDon.MenuQuanLiThucDon();
                                break;
                        case 1: 
                                Console.WriteLine("Gia 1: ");
                                Gia1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Gia 2: ");
                                Gia2 = int.Parse(Console.ReadLine());
                                List<ThucDon> lTD = QuanLiThucDon.TimKiemThucDonTheoKhoangGia(Gia1, Gia2);
                                if(lTD.Count != 0) {
                                    Console.WriteLine($"Danh Sach Mon Gia Tu {Gia1} - {Gia2}: ");
                                    Console.WriteLine("\t\t\t Ten Mon             | Gia      | Tinh Trang | Thoi Diem Ban            | Loai");
                                    Console.WriteLine("\t\t\t ------------------------------------------------------------------------------\n");
                                    lTD.ForEach(x => x.HienThi());
                                }
                                else
                                    Console.WriteLine($"Khong Co Mon Nao Trong Khoang {Gia1} - {Gia2}");
                                break;
                        case 2:
                                Console.WriteLine("Gia 1: ");
                                Gia1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Gia 2: ");
                                Gia2 = int.Parse(Console.ReadLine());
                                List<ThucAn> lTA = QuanLiThucDon.TimKiemThucAnTheoKhoangGia(Gia1, Gia2);
                                 if(lTA.Count != 0) {
                                    Console.WriteLine($"Danh Sach Thuc An Gia Tu {Gia1} - {Gia2}: ");
                                    Console.WriteLine("\t\t\t Ten Mon             | Gia      | Tinh Trang | Thoi Diem Ban            | Loai");
                                    Console.WriteLine("\t\t\t ------------------------------------------------------------------------------\n");
                                    lTA.ForEach(x => x.HienThi());
                                }
                                else
                                    Console.WriteLine($"Khong Co Thuc An Nao Trong Khoang {Gia1} - {Gia2}");
                                lTA.ForEach(x => x.HienThi());
                                break;
                        case 3:
                                Console.WriteLine("Gia 1: ");
                                Gia1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Gia 2: ");
                                Gia2 = int.Parse(Console.ReadLine());
                                List<ThucUong> lTU = QuanLiThucDon.TimKiemThucUongTheoKhoangGia(Gia1, Gia2);
                                 if(lTU.Count != 0) {
                                    Console.WriteLine($"Danh Sach Thuc Uong Gia Tu {Gia1} - {Gia2}: ");
                                    Console.WriteLine("\t\t\t Ten Mon             | Gia      | Tinh Trang | Thoi Diem Ban            | Loai");
                                    Console.WriteLine("\t\t\t ------------------------------------------------------------------------------\n");
                                    lTU.ForEach(x => x.HienThi());
                                }
                                else
                                    Console.WriteLine($"Khong Co Thuc Uong Nao Trong Khoang {Gia1} - {Gia2}");
                                lTU.ForEach(x => x.HienThi());
                                break;   
                        case 4:
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
            while(chon != 0 || chon != 4);
        }
    }
}