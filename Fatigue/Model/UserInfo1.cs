using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Fatigue.Model
{
    internal class UserInfo1
    {
        public string SN { get; set; }
        public double SN5 { get; set; }
        public double SN6 { get; set; }
        public double SN7 { get; set; }
        public double SN8 { get; set; }
        public double SN9 { get; set; }
        public double SN10 { get; set; }
        public double SN11 { get; set; }
        public double SN12 { get; set; }
        public double m1 { get; set; }
        public double logd1 { get; set; }
        public double logd2 { get; set; }
        public double FTlim { get; set; }
        public double k { get; set; }
        public double SCE { get; set; }

        public UserInfo1()
        {

        }
        public void SetData1(int col, string val)
        {
            switch (col)
            {
                case 0:
                    SN = val;
                    break;
                case 1:
                    SN5 = Convert.ToDouble(val);
                    break;
                case 2:
                    SN6 = Convert.ToDouble(val);
                    break;
                case 3:
                    SN7 = Convert.ToDouble(val);
                    break;
                case 4:
                    SN8 = Convert.ToDouble(val);
                    break;
                case 5:
                    SN9 = Convert.ToDouble(val);
                    break;
                case 6:
                    SN10 = Convert.ToDouble(val);
                    break;
                case 7:
                    SN11 = Convert.ToDouble(val);
                    break;
                case 8:
                    SN12 = Convert.ToDouble(val);
                    break;
                case 9:
                    m1 = Convert.ToDouble(val);
                    break;
                case 10:
                    logd1 = Convert.ToDouble(val);
                    break;
                case 11:
                    logd2 = Convert.ToDouble(val);
                    break;
                case 12:
                    FTlim = Convert.ToDouble(val);
                    break;
                case 13:
                    k = Convert.ToDouble(val);
                    break;
                case 14:
                    SCE = Convert.ToDouble(val);
                    break;
                default:
                    break;

            }
        }
    }
}
