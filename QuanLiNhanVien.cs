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
                Console.WriteLine("---Cap Nhat Thong Tin Nhan Vien---");
                Console.WriteLine("0. Quay Lai");
                Console.WriteLine("1. Cap Nhat Ho Ten");
                Console.WriteLine("2. Cap Nhat Gioi Tinh");
                Console.WriteLine("3. Cap Nhat Que Quan");
                Console.WriteLine("4. Cap Nhat Ngay Vao Lam");
                Console.WriteLine("5. Cap Nhat Ngay Sinh");
                Console.WriteLine("6. Cap Nhat Vi Tri");
                Console.WriteLine("7. Thoat");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    if(chon == 0) {
                        QuanLiNhanVien.CapNhatThongTinNhanVien();
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
                            QuanLiNhanVien.CapNhatThongTinNhanVien();
                        }
                        else {
                            Console.WriteLine("Thong Tin Nhan Vien Can Chinh Sua: ");
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
                Console.WriteLine("---Tra Cuu Thong Tin Nhan Vien---");
                Console.WriteLine("0. Quay Lai");
                Console.WriteLine("1. Theo Ma Nhan Vien");
                Console.WriteLine("2. Theo Ten");
                Console.WriteLine("3. Theo Gioi Tinh");
                Console.WriteLine("4. Theo Que Quan");
                Console.WriteLine("5. Theo Nam Vao Lam");
                Console.WriteLine("6. Theo Nam Sinh");
                Console.WriteLine("7. Theo Vi Tri");
                Console.WriteLine("8. Thoat");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    List<NhanVien> lNhanVien;
                    switch(chon) {
                        case 0:
                                QuanLiNhanVien.CapNhatThongTinNhanVien();
                                break;
                        case 1:
                                Console.WriteLine("Ma Nhan Vien Muon Tra Cuu: ");
                                string MaNV = Console.ReadLine();
                                lNhanVien = TraCuu.TheoMaNV(MaNV);
                                if(lNhanVien.Count != 0)
                                    lNhanVien.ForEach(x => x.HienThi());
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 2:
                                Console.WriteLine("Ten Muon Tra Cuu: ");
                                string Ten = Console.ReadLine();
                                lNhanVien = TraCuu.TheoTen(Ten);
                                if(lNhanVien.Count != 0)
                                    lNhanVien.ForEach(x => x.HienThi());
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 3:
                                Console.WriteLine("Gioi Tinh Muon Tra Cuu: ");
                                string GioiTinh = Console.ReadLine();
                                lNhanVien = TraCuu.TheoGioiTinh(GioiTinh);
                                if(lNhanVien.Count != 0)
                                    lNhanVien.ForEach(x => x.HienThi());
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 4:
                                Console.WriteLine("Que Quan Muon Tra Cuu: ");
                                string QueQuan = Console.ReadLine();
                                lNhanVien = TraCuu.TheoQueQuan(QueQuan);
                                if(lNhanVien.Count != 0)
                                    lNhanVien.ForEach(x => x.HienThi());
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 5:
                                Console.WriteLine("Nam Vao Lam Muon Tra Cuu: ");
                                string NamVaoLam = Console.ReadLine();
                                lNhanVien = TraCuu.TheoNamVaoLam(NamVaoLam);
                                if(lNhanVien.Count != 0)
                                    lNhanVien.ForEach(x => x.HienThi());
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 6:
                                Console.WriteLine("Nam Sinh Muon Tra Cuu: ");
                                string NamSinh = Console.ReadLine();
                                lNhanVien = TraCuu.TheoNamSinh(NamSinh);
                                if(lNhanVien.Count != 0)
                                    lNhanVien.ForEach(x => x.HienThi());
                                else {
                                    Console.WriteLine("Khong Tim Thay");
                                }
                                break;
                        case 7:
                                Console.WriteLine("Ten Bo Phan Muon Tra Cuu: ");
                                string TenBoPhan = Console.ReadLine();
                                lNhanVien = TraCuu.TheoBoPhan(TenBoPhan);
                                if(lNhanVien.Count != 0)
                                    lNhanVien.ForEach(x => x.HienThi());
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
        public static void CapNhatThongTinNhanVien() {
            int chon;
            do {
                Console.WriteLine("---Quan Li Nhan Vien---");
                Console.WriteLine("0. Danh Sach Nhan Vien");
                Console.WriteLine("1. Them Nhan Vien");
                Console.WriteLine("2. Xoa Nhan Vien");
                Console.WriteLine("3. Cap Nhat Thong Tin Nhan Vien");
                Console.WriteLine("4. Tra Cuu Thong Tin Nhan Vien");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("Ban Chon: ");
                chon = int.Parse(Console.ReadLine());
                try {
                    if(chon == 5)
                        break;
                    if(chon == 0) {
                        Console.WriteLine("---DANH SACH NHAN VIEN---");
                        QuanLiNhanVien.lNhanVien.ForEach(x => x.HienThi());
                    }
                    else if(chon == 1) {
                        QuanLiNhanVien.ThemNhanVien();
                    }
                    else if(chon == 2) {
                        QuanLiNhanVien.XoaNhanVien();
                    }
                    else if(chon > 2 && chon < 5){
                        switch(chon) {
                            case 3:
                                    QuanLiNhanVien.MenuCapNhat();
                                    break;
                            case 4:
                                    QuanLiNhanVien.MenuTraCuu();
                                    break;
                            default:
                                    break;
                        }                
                    }
                    else 
                        Console.WriteLine("Vui Long Nhap Lai");
                }
                catch(System.FormatException) {
                    Console.WriteLine("Vui Long Nhap Chu So");
                }
            }
            while(chon != 9);
        }
    }
}
