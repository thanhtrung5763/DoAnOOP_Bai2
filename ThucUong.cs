using System;

namespace QuanLyQuanCaPhe
{
    public class ThucUong: ThucDon {
        public string Da { get; set; }

        public ThucUong(): base() {
        }
        public ThucUong(string Ten, int Gia, string TinhTrang, string ThoiDiemBan, string Da): base(Ten, Gia, TinhTrang, ThoiDiemBan) {
            this.Da = Da;
            QuanLiThucDon.DSThucUong.Add(this);
            QuanLiThucDon.DSThucDon.Add(this);
        }
        ~ThucUong()
        {
        }
        public void TaoThucUong() {
            base.TaoThucDon();
            Console.WriteLine("Da hay Khong Da: ");
            this.Da = Console.ReadLine();
        }
        public override void HienThi() {
            base.HienThi();
            Console.WriteLine($"{this.Da, -10}");
        }
    }
}