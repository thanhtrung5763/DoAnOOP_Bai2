using System;

namespace QuanLyQuanCaPhe
{
    class Ban {
        private static int ID = 0;
        public string MaBan { get; set; }
        public string TinhTrang { get; set; }
        public int SucChua { get; set;}
        public Ban() {
            ID++;
        }
        ~Ban()
        {
        }
        public Ban(string TinhTrang, int SucChua) {
            ID++;
            this.MaBan = "B" + ID.ToString();
            this.TinhTrang = TinhTrang;
            this.SucChua = SucChua;
            QuanLiBan.DSBan.Add(this);
        }
        public void TaoThemBan() {
            ID++;
            this.MaBan = "B" + ID.ToString();
            this.TinhTrang = "Trong";
            Console.WriteLine("Nhap Suc Chua: ");
            this.SucChua = int.Parse(Console.ReadLine());
        }
        public void CapNhatTinhTrang(string TinhTrang) {
            this.TinhTrang = TinhTrang;
        }
        public void CapNhatSucChua(int SucChua) {
            this.SucChua = SucChua;
        }
        public void HienThi() {
            Console.WriteLine($"\t\t\t {this.MaBan, -31} | {this.TinhTrang, -34} | {this.SucChua, -8}");
        }
    }
}