using System;

namespace QuanLyQuanCaPhe
{
    class NhanVien
    {
        private static int ID = 0;
        public string MaNV { get; set; }
        public string  HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public DateTime NgaySinh { get; set; }
        public BoPhan ViTri {get; set; }
        public NhanVien() {

        }
        ~NhanVien()
        {
        }
        public NhanVien(string HoTen, string GioiTinh, string QueQuan, string NgayVaoLam, string NgaySinh, string TenBoPhan) {
            ID++;
            this.MaNV = ID.ToString();
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.QueQuan = QueQuan;
            this.NgayVaoLam = DateTime.Parse(NgayVaoLam);
            this.NgaySinh = DateTime.Parse(NgaySinh);
            this.ViTri = QuanLiBoPhan.DSBoPhan.Find(x => x.TenBoPhan == TenBoPhan);
            QuanLiNhanVien.DSNhanVien.Add(this);
        }
        public void TaoNhanVien() {
            ID++;
            this.MaNV = ID.ToString();
            Console.WriteLine("Nhap ho ten nhan vien: ");
            this.HoTen = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            this.GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhap que quan: ");
            this.QueQuan = Console.ReadLine();
            Console.WriteLine("Nhap ngay vao lam(dd/mm/yyyy): ");
            this.NgayVaoLam = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay thang nam sinh(dd/mm/yyyy): ");
            this.NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap bo phan lam viec: ");
            string TenBoPhan = Console.ReadLine();
            this.ViTri = QuanLiBoPhan.DSBoPhan.Find(x => x.TenBoPhan == TenBoPhan);
        }
        public void CapNhatHoTen(string HoTen) {
            this.HoTen = HoTen;
        }
        public void CapNhatGioiTinh(string GioiTinh) {
            this.GioiTinh = GioiTinh;
        }
        public void CapNhatQueQuan(string QueQuan) {
            this.QueQuan = QueQuan;
        }
        public void CapNhatNgayVaoLam(string NgayVaoLam) {
            this.NgayVaoLam = DateTime.Parse(NgayVaoLam);
        }
        public void CapNhatNgaySinh(string NgaySinh) {
            this.NgaySinh = DateTime.Parse(NgaySinh);
        }
        public void CapNhatViTri(string ViTri) {
            BoPhan ViTriMoi = QuanLiBoPhan.DSBoPhan.Find(x => x.TenBoPhan == ViTri);
            this.ViTri = ViTriMoi;
        }
        public void HienThi() {
            Console.WriteLine($"\t\t\t {this.MaNV, -12} | {this.HoTen, -20} | {this.GioiTinh, -9} | {this.QueQuan, -12} | {this.NgaySinh.ToString("dd/MM/yyyy"), -13} | {this.NgayVaoLam.ToString("dd/MM/yyyy"), -16} | {this.ViTri.TenBoPhan, -7}");
        }
    }
}
