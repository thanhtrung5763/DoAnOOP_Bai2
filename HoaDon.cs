using System;
using System.Collections.Generic;
namespace QuanLyQuanCaPhe
{
    class HoaDon {
        private static int ID = 0;
        public NhanVien NVThuNgan { get; set; }
        public List<ThucDon> lMon { get; set; }
        public List<int> SoLuong { get; set; }
        public string MaHoaDon { get; set; }
        public Ban bBan { get; set; }
        public DateTime ThoiGian { get; set; }
        public string ThoiDiem { get; set; }
        public int TienKhachDua { get; set; }
        public HoaDon() {
            ID++;
            this.lMon = new List<ThucDon>();
            this.SoLuong = new List<int>();
        }
        ~HoaDon() {

        }
        public HoaDon(string MaNV, List<ThucDon> DSMon, List<int> sl, Ban b,  string TG, string TD, int TKD) {
            ID++;
            this.MaHoaDon = ID.ToString();
            this.bBan = b;
            this.NVThuNgan = QuanLiNhanVien.DSNhanVien.Find(x => x.MaNV == MaNV);
            this.lMon = DSMon;
            this.SoLuong = sl;
            for(int i = 0; i < this.SoLuong.Count; i++) {
                this.lMon[i].SoLuong = this.SoLuong[i];
            }
            this.ThoiGian = DateTime.Parse(TG);
            this.ThoiDiem = TD;
            this.TienKhachDua = TKD;
            QuanLiHoaDon.DSHoaDon.Add(this);
        }
        public void TaoHoaDon() {
            string mb, mnv, tm;
            int sl;
            ThucDon td;
            this.MaHoaDon = ID.ToString();
            while(true) {
                Console.WriteLine("Ma Ban Muon Dat: ");
                mb = Console.ReadLine();
                this.bBan = QuanLiBan.DSBan.Find(x => x.MaBan == mb);
                if(this.bBan.TinhTrang == "Trong") {
                    this.bBan.TinhTrang = "Day";
                    break;
                }
                else
                    Console.WriteLine("Ban Muon Dat Da Day, Vui Long Chon Ban Khac. ");
            }

            Console.WriteLine("Ma Nhan Vien Thu Ngan: ");
            mnv = Console.ReadLine();
            this.NVThuNgan = QuanLiNhanVien.DSNhanVien.Find(x => x.MaNV == mnv);
            Console.WriteLine("Thoi Diem(Sang/Trua/Chieu/Toi): ");
            this.ThoiDiem = Console.ReadLine();
            this.ThoiGian = DateTime.Now;
            Console.WriteLine("So Luong Mon: ");
            sl = int.Parse(Console.ReadLine());
            for(int i = 0; i < sl; i++) {
                Console.WriteLine("Ten Mon: ");
                tm = Console.ReadLine();
                td = QuanLiThucDon.DSThucDon.Find(x => x.Ten == tm);
                Console.WriteLine("So Luong: ");
                td.SoLuong = int.Parse(Console.ReadLine());
                this.SoLuong.Add(td.SoLuong);
                this.lMon.Add(td);
            }
            Console.WriteLine($"Tong Tien: {this.TinhTien()}");
            Console.WriteLine("Tien Khach Dua: ");
            this.TienKhachDua = int.Parse(Console.ReadLine());
        }
        public int TinhTien() {
            ThucDon tdSum = new ThucDon();
            foreach(ThucDon td in this.lMon) {
                tdSum = tdSum + td;
            }
            return tdSum.Gia;
        }
        public static int operator + (int s, HoaDon hd2) {
            s = s + hd2.TinhTien();
            return s;
        }
        public void HoaDonChoKhach() {
            Console.WriteLine("---------***----------");
            Console.WriteLine($"Thu Ngan: {this.NVThuNgan.HoTen}");
            Console.WriteLine($"Thoi Gian: {this.ThoiDiem} {this.ThoiGian.ToString("dd/MM/yyyy")}");
            Console.WriteLine("---------***----------");
            Console.WriteLine("Ten               S/L   Gia       Tong");
            Console.WriteLine("---------***----------");
            for(int i = 0; i < this.lMon.Count; i++) {
                Console.WriteLine($"{this.lMon[i].Ten, -3}               {this.SoLuong[i], -3}   {this.lMon[i].Gia, -3}       {this.SoLuong[i] * this.lMon[i].Gia, -4}");
            }
            Console.WriteLine("---------***----------");
            Console.WriteLine($"Tong So Luong Mon: {this.lMon.Count}");
            Console.WriteLine("---------***----------");
            Console.WriteLine($"Tong Phai Thanh Toan: {this.TinhTien()}");
            Console.WriteLine("---------***----------");
            Console.WriteLine($"Tien Khach Dua: {this.TienKhachDua}");
            Console.WriteLine("---------***----------");
            Console.WriteLine($"Tra Lai: {this.TienKhachDua - this.TinhTien()}");
        }
        public void ThongTinHoaDon() {
            Console.WriteLine($"{this.MaHoaDon, -10} | {this.ThoiDiem, -9} {this.ThoiGian.ToString("dd/MM/yyyy")} | {this.TinhTien(), -9}");
        }
    }
}