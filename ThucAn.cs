using System;

namespace QuanLyQuanCaPhe
{
    public class ThucAn: ThucDon {
        public string Chay { get; set; }

        public ThucAn(): base() {
        }
        public ThucAn(string Ten, int Gia, string TinhTrang, string ThoiDiemBan, string Chay): base(Ten, Gia, TinhTrang, ThoiDiemBan) {
            this.Chay = Chay;
            QuanLiThucDon.DSThucAn.Add(this);
            QuanLiThucDon.DSThucDon.Add(this);
        }
        ~ThucAn()
        {
        }
        public void TaoThucAn() {
            base.TaoThucDon();
            Console.WriteLine("Nhap loai mon(Chay/Khong Chay): ");
            this.Chay = Console.ReadLine();
        }
        public override void HienThi() {
            base.HienThi();
            Console.WriteLine($"{this.Chay, -10}");
        }
    }
}