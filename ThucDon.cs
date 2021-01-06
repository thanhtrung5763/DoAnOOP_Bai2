using System;

namespace QuanLyQuanCaPhe
{
    public class ThucDon {
        public int SoLuong { get; set; }
        public string Ten { get; set; }
        public int Gia { get; set; }
        public string TinhTrang { get; set; }
        public string ThoiDiemBan { get; set; }

        public ThucDon() {
            Gia = 0;
            SoLuong = 1;
        }
        public ThucDon(string Ten, int Gia, string TinhTrang, string ThoiDiemBan) {
            this.SoLuong = 1;
            this.Ten = Ten;
            this.Gia = Gia;
            this.TinhTrang = TinhTrang;
            this.ThoiDiemBan = ThoiDiemBan;
        }
        ~ThucDon()
        {
        }
        public static ThucDon operator + (ThucDon td1, ThucDon td2) {
            ThucDon td3 = new ThucDon();
            td3.Gia = td1.SoLuong * td1 + td2.SoLuong * td2;
            return td3;
        }
        public static int operator * (int sl, ThucDon td2) {
            ThucDon td3 = new ThucDon();
            td3.Gia = sl * td2.Gia;
            return td3.Gia;
        }
        public virtual void HienThi() {
            Console.Write($"\t\t\t {this.Ten, -19} | {this.Gia, -8} | {this.TinhTrang, -10} | {this.ThoiDiemBan, -24} | ");
        }
        public virtual void TaoThucDon() {
            Console.WriteLine("Nhap ten thuc an: ");
            this.Ten = Console.ReadLine();
            Console.WriteLine("Nhap gia: ");
            this.Gia = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tinh trang(Con/Het): ");
            this.TinhTrang = Console.ReadLine();
            Console.WriteLine("Nhap thoi diem ban(Sang/Trua/Chieu/Toi): ");
            this.ThoiDiemBan = Console.ReadLine();
        }
    }
}