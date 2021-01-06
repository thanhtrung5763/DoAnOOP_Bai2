using System;
using System.Collections.Generic;
namespace QuanLyQuanCaPhe
{
    static class QuanLiNhanVien
    {
        private static List<NhanVien> lNhanVien = new List<NhanVien>();
        public static List<NhanVien> DSNhanVien {
            get { return QuanLiNhanVien.lNhanVien; }
            set { QuanLiNhanVien.lNhanVien = value; }
        }
        static QuanLiNhanVien() {

        }
        public static void ThemNhanVien() {
            NhanVien nv = new NhanVien();
            nv.TaoNhanVien();
            QuanLiNhanVien.DSNhanVien.Add(nv);
        }
        public static void XoaNhanVien() {
            Console.WriteLine("Nhap ma nhan vien: ");
            string MaNV = Console.ReadLine();
            NhanVien nv = QuanLiNhanVien.DSNhanVien.Find(x => x.MaNV == MaNV);
            QuanLiNhanVien.DSNhanVien.Remove(nv);
        }
        public static void MenuCapNhat() {
            int chon;
            do {
                Console.WriteLine("\t\t\t |=============================Cap Nhat Thong Tin Nhan Vien=============================|\n");
                Console.WriteLine("\t\t\t |                            0. Quay Lai                                               |\n");
                Console.WriteLine("\t\t\t |                            1. Cap Nhat Ho Ten                                        |\n");
                Console.WriteLine("\t\t\t |                            2. Cap Nhat Gioi Tinh                                     |\n");
                Console.WriteLine("\t\t\t |                            3. Cap Nhat Que Quan                                      |\n");
                Console.WriteLine("\t\t\t |                            4. Cap Nhat Ngay Vao Lam                                  |\n");
                Console.WriteLine("\t\t\t |                            5. Cap Nhat Ngay Sinh                                     |\n");
                Console.WriteLine("\t\t\t |                            6. Cap Nhat Ngay Vi Tri                                   |\n");
                Console.WriteLine("\t\t\t |                            7. Thoat                                                  |\n");
                Console.WriteLine("\t\t\t |========================================CHOOSE========================================|\n");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    if(chon == 0) {
                        QuanLiNhanVien.MenuQuanLiNhanVien();
                        break;
                    }
                    if(chon == 7)
                        Environment.Exit(0);
                    else if(chon > 0 && chon < 7){
                        string MaNV;
                        Console.WriteLine("Nhap Ma Nhan Vien Can Cap Nhat: ");
                        MaNV = Console.ReadLine();
                        NhanVien nv = QuanLiNhanVien.DSNhanVien.Find(x => x.MaNV == MaNV);
                        if(nv == null) {
                            Console.WriteLine("Nhan Vien Khong Co Trong He Thong");
                            QuanLiNhanVien.MenuQuanLiNhanVien();
                        }
                        else {
                            Console.WriteLine("Thong Tin Nhan Vien Can Cap Nhat: ");
                            Console.WriteLine("\t\t\t Ma Nhan Vien | Ho Ten               | Gioi Tinh | Que Quan     | Ngay Sinh     | Ngay Vao Lam     | Bo Phan");
                            nv.HienThi();
                        }
                        switch(chon) {
                            case 1:
                                    Console.WriteLine("Ho Ten Moi: ");
                                    string HoTen = Console.ReadLine();
                                    CapNhat.HoTen(nv, HoTen);
                                    break;
                            case 2:
                                    Console.WriteLine("Gioi Tinh Moi: ");
                                    string GioiTinh = Console.ReadLine();
                                    CapNhat.GioiTinh(nv, GioiTinh);
                                    break;
                            case 3:
                                    Console.WriteLine("Que Quan Moi: ");
                                    string QueQuan = Console.ReadLine();
                                    CapNhat.QueQuan(nv, QueQuan);
                                    break;
                            case 4:
                                    Console.WriteLine("Ngay Vao Lam Moi: ");
                                    string NgayVaoLam = Console.ReadLine();
                                    CapNhat.NgayVaoLam(nv, NgayVaoLam);
                                    break;
                            case 5:
                                    Console.WriteLine("Ngay Sinh Moi: ");
                                    string NgaySinh = Console.ReadLine();
                                    CapNhat.NgaySinh(nv, NgaySinh);
                                    break;
                            case 6:
                                    Console.WriteLine("Ten Bo Phan Moi: ");
                                    string TenBoPhan = Console.ReadLine();
                                    CapNhat.ViTri(nv, TenBoPhan);
                                    break;
                            default:
                                    break;
                        }
                        Console.WriteLine("Thong Tin Nhan Vien Sau Cap Nhat: ");
                        Console.WriteLine("\t\t\t Ma Nhan Vien | Ho Ten               | Gioi Tinh | Que Quan     | Ngay Sinh     | Ngay Vao Lam     | Bo Phan");
                        nv.HienThi();                    
                    }
                    else 
                        Console.WriteLine("Vui Long Nhap Lai");
                }
                catch(System.FormatException) {
                    Console.WriteLine("Vui Long Nhap Chu So");
                }
            }
            while(chon != 0 || chon != 7);
        }
        
        public static void MenuTraCuu() {
            int chon;
            do {
                Console.WriteLine("\t\t\t |=============================Tra Cuu Thong Tin Nhan Vien=============================|\n");
                Console.WriteLine("\t\t\t |                            0. Quay Lai                                              |\n");
                Console.WriteLine("\t\t\t |                            1. Theo Ma Nhan Vien                                     |\n");
                Console.WriteLine("\t\t\t |                            2. Theo Ten                                              |\n");
                Console.WriteLine("\t\t\t |                            3. Theo Gioi Tinh                                        |\n");
                Console.WriteLine("\t\t\t |                            4. Theo Que Quan                                         |\n");
                Console.WriteLine("\t\t\t |                            5. Theo Nam Vao Lam                                      |\n");
                Console.WriteLine("\t\t\t |                            6. Theo Nam Sinh                                         |\n");
                Console.WriteLine("\t\t\t |                            7. Theo Vi Tri                                           |\n");
                Console.WriteLine("\t\t\t |                            8. Thoat                                                 |\n");
                Console.WriteLine("\t\t\t |=======================================CHOOSE========================================|\n");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    List<NhanVien> lNhanVien;
                    switch(chon) {
                        case 0:
                                QuanLiNhanVien.MenuQuanLiNhanVien();
                                break;
                        case 1:
                                Console.WriteLine("Ma Nhan Vien Muon Tra Cuu: ");
                                string MaNV = Console.ReadLine();
                                lNhanVien = TraCuu.TheoMaNV(MaNV);
                                if(lNhanVien.Count != 0) {
                                    Console.WriteLine("\t\t\t Ma Nhan Vien | Ho Ten               | Gioi Tinh | Que Quan     | Ngay Sinh     | Ngay Vao Lam     | Bo Phan");
                                    lNhanVien.ForEach(x => x.HienThi());
                                }
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 2:
                                Console.WriteLine("Ten Muon Tra Cuu: ");
                                string Ten = Console.ReadLine();
                                lNhanVien = TraCuu.TheoTen(Ten);
                                if(lNhanVien.Count != 0) {
                                    Console.WriteLine("\t\t\t Ma Nhan Vien | Ho Ten               | Gioi Tinh | Que Quan     | Ngay Sinh     | Ngay Vao Lam     | Bo Phan");
                                    lNhanVien.ForEach(x => x.HienThi());
                                }
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 3:
                                Console.WriteLine("Gioi Tinh Muon Tra Cuu: ");
                                string GioiTinh = Console.ReadLine();
                                lNhanVien = TraCuu.TheoGioiTinh(GioiTinh);
                                if(lNhanVien.Count != 0) {
                                    Console.WriteLine("\t\t\t Ma Nhan Vien | Ho Ten               | Gioi Tinh | Que Quan     | Ngay Sinh     | Ngay Vao Lam     | Bo Phan");
                                    lNhanVien.ForEach(x => x.HienThi());
                                }
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 4:
                                Console.WriteLine("Que Quan Muon Tra Cuu: ");
                                string QueQuan = Console.ReadLine();
                                lNhanVien = TraCuu.TheoQueQuan(QueQuan);
                                if(lNhanVien.Count != 0) {
                                    Console.WriteLine("\t\t\t Ma Nhan Vien | Ho Ten               | Gioi Tinh | Que Quan     | Ngay Sinh     | Ngay Vao Lam     | Bo Phan");
                                    lNhanVien.ForEach(x => x.HienThi());
                                }
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 5:
                                Console.WriteLine("Nam Vao Lam Muon Tra Cuu: ");
                                string NamVaoLam = Console.ReadLine();
                                lNhanVien = TraCuu.TheoNamVaoLam(NamVaoLam);
                                if(lNhanVien.Count != 0) {
                                    Console.WriteLine("\t\t\t Ma Nhan Vien | Ho Ten               | Gioi Tinh | Que Quan     | Ngay Sinh     | Ngay Vao Lam     | Bo Phan");
                                    lNhanVien.ForEach(x => x.HienThi());
                                }
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 6:
                                Console.WriteLine("Nam Sinh Muon Tra Cuu: ");
                                string NamSinh = Console.ReadLine();
                                lNhanVien = TraCuu.TheoNamSinh(NamSinh);
                                if(lNhanVien.Count != 0) {
                                    Console.WriteLine("\t\t\t Ma Nhan Vien | Ho Ten               | Gioi Tinh | Que Quan     | Ngay Sinh     | Ngay Vao Lam     | Bo Phan");
                                    lNhanVien.ForEach(x => x.HienThi());
                                }
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 7:
                                Console.WriteLine("Ten Bo Phan Muon Tra Cuu: ");
                                string TenBoPhan = Console.ReadLine();
                                lNhanVien = TraCuu.TheoBoPhan(TenBoPhan);
                                if(lNhanVien.Count != 0) {
                                    Console.WriteLine("\t\t\t Ma Nhan Vien | Ho Ten               | Gioi Tinh | Que Quan     | Ngay Sinh     | Ngay Vao Lam     | Bo Phan");
                                    lNhanVien.ForEach(x => x.HienThi());
                                }
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 8:
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
            while(chon != 0 || chon != 8);
        }
        public static void MenuQuanLiNhanVien() {
            int chon;
            do {
                Console.WriteLine("\t\t\t |==============================Quan Li Nhan Vien==============================|\n");
                Console.WriteLine("\t\t\t |                            0. Quay Lai                                      |\n");
                Console.WriteLine("\t\t\t |                            1. Danh Sach Nhan Vien                           |\n");
                Console.WriteLine("\t\t\t |                            2. Them Nhan Vien                                |\n");
                Console.WriteLine("\t\t\t |                            3. Xoa Nhan Vien                                 |\n");
                Console.WriteLine("\t\t\t |                            4. Cap Nhat Thong Tin Nhan Vien                  |\n");
                Console.WriteLine("\t\t\t |                            5. Tra Cuu Thong Tin Nhan Vien                   |\n");
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
                                Console.WriteLine("\t\t\t --------------------------------------------DANH SACH NHAN VIEN--------------------------------------------");
                                Console.WriteLine("\t\t\t Ma Nhan Vien | Ho Ten               | Gioi Tinh | Que Quan     | Ngay Sinh     | Ngay Vao Lam     | Bo Phan");
                                QuanLiNhanVien.lNhanVien.ForEach(x => x.HienThi());
                                break;
                        case 2:
                                QuanLiNhanVien.ThemNhanVien();
                                break;
                        case 3:
                                QuanLiNhanVien.XoaNhanVien();
                                break;
                        case 4:
                                QuanLiNhanVien.MenuCapNhat();
                                break;
                        case 5:
                                QuanLiNhanVien.MenuTraCuu();
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
            while(chon != 9);
        }
    }
}
