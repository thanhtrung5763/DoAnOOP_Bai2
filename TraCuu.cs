using System;
using System.Collections.Generic;

namespace QuanLyQuanCaPhe
{
    static class TraCuu {
        public static List<NhanVien> TheoMaNV(string MaNV) {
            List<NhanVien> lNhanVien = QuanLiNhanVien.DSNhanVien.FindAll(x => x.MaNV.Contains(MaNV));
            return lNhanVien;
        }
        public static List<NhanVien> TheoTen(string Ten) {
            List<NhanVien> lNhanVien = QuanLiNhanVien.DSNhanVien.FindAll(x => x.HoTen.Contains(Ten));
            return lNhanVien;
        }
        public static List<NhanVien> TheoGioiTinh(string GioiTinh) {
            List<NhanVien> lNhanVien = QuanLiNhanVien.DSNhanVien.FindAll(x => x.GioiTinh.Contains(GioiTinh));
            return lNhanVien;
        }
        public static List<NhanVien> TheoQueQuan(string QueQuan) {
            List<NhanVien> lNhanVien = QuanLiNhanVien.DSNhanVien.FindAll(x => x.QueQuan.Contains(QueQuan));
            return lNhanVien;
        }
        public static List<NhanVien> TheoNamVaoLam(string NamVaoLam) {
            List<NhanVien> lNhanVien = QuanLiNhanVien.DSNhanVien.FindAll(x => x.NgayVaoLam.Year.ToString() == NamVaoLam);
            return lNhanVien;
        }
        public static List<NhanVien> TheoNamSinh(string NamSinh) {
            List<NhanVien> lNhanVien = QuanLiNhanVien.DSNhanVien.FindAll(x => x.NgaySinh.Year.ToString() == NamSinh);
            return lNhanVien;
        }
        public static List<NhanVien> TheoBoPhan(string TenBoPhan) {
            List<NhanVien> lNhanVien = QuanLiNhanVien.DSNhanVien.FindAll(x => x.ViTri.TenBoPhan == TenBoPhan);
            return lNhanVien;
        }
    }
}