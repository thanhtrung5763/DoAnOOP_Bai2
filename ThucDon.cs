using System;

namespace QuanLyQuanCaPhe
{
    public class ThucDon {
        public string Ten { get; set; }
        public int Gia { get; set; }
        public string TinhTrang { get; set; }
        public string ThoiDiemBan { get; set; }

        public ThucDon() {
            
        }
        public ThucDon(string Ten, int Gia, string TinhTrang, string ThoiDiemBan) {
            this.Ten = Ten;
            this.Gia = Gia;
            this.TinhTrang = TinhTrang;
            this.ThoiDiemBan = ThoiDiemBan;
        }
        ~ThucDon()
        {
        }
        public virtual void HienThi() {
            Console.Write($"{this.Ten} | {this.Gia} | {this.TinhTrang} | {this.ThoiDiemBan}| ");
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