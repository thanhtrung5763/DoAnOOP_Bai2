using System;
using System.Collections.Generic;
namespace QuanLyQuanCaPhe
{
    static class QuanLiBoPhan
    {
        private static List<BoPhan> lBoPhan = new List<BoPhan>();
        static QuanLiBoPhan() {
            
        }
        public static List<BoPhan> DSBoPhan {
            get { return QuanLiBoPhan.lBoPhan; }
            set { QuanLiBoPhan.lBoPhan = value; }
        }
        public static void HienThi() {
            Console.WriteLine("---DANH SACH BO PHAN HIEN CO---");
            QuanLiBoPhan.lBoPhan.ForEach(x => x.HienThi());
        }
    }
}
