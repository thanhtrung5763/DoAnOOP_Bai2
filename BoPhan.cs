using System;

namespace QuanLyQuanCaPhe
{
    class BoPhan
    {
        private static int ID = 0;
        public string MaBP { get; set; }
        public string TenBoPhan { get; set; }
        public BoPhan(string TenBoPhan) {
            ID++;
            this.MaBP = ID.ToString();
            this.TenBoPhan = TenBoPhan;
            QuanLiBoPhan.DSBoPhan.Add(this);
        }
        ~BoPhan()
        {
        }
        public void HienThi() {
            Console.WriteLine($"\t\t\t {this.MaBP, -35} | {this.TenBoPhan, -10}");
        }
    }
}
