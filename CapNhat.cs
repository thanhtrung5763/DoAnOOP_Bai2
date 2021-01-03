using System;
using System.Collections.Generic;

namespace QuanLyQuanCaPhe
{
    static class CapNhat {
        public static void HoTen(NhanVien nv, string HoTen) {
            nv.HoTen = HoTen;
        }
        public static void GioiTinh(NhanVien nv, string GioiTinh) {
            nv.GioiTinh = GioiTinh;
        }
        public static void QueQuan(NhanVien nv,  string QueQuan) {
            nv.QueQuan = QueQuan;
        }
        public static void NgayVaoLam(NhanVien nv, string NgayVaoLam) {
            nv.NgayVaoLam = DateTime.Parse(NgayVaoLam);
        }
        public static void NgaySinh(NhanVien nv, string NgaySinh) {
            nv.NgaySinh = DateTime.Parse(NgaySinh);
        }
        public static void ViTri(NhanVien nv, string TenBoPhan) {
            BoPhan ViTriMoi = QuanLiBoPhan.DSBoPhan.Find(x => x.TenBoPhan == TenBoPhan);
            nv.ViTri = ViTriMoi;
        }
    }
}