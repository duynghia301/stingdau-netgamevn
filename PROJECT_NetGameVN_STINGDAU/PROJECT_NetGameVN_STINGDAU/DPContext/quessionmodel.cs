using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_NetGameVN_STINGDAU.DPContext
{
     public class quessionmodel
    {

        public int Madv { get; set; }
        public string Tendv { get; set; }
        public Nullable<double> Giatien { get; set; }
        public double? GiaTien { get; internal set; }
        public Nullable<int> soluong { get; set; }
        public Nullable<System.DateTime> ngaynhap { get; set; }
    }
}
