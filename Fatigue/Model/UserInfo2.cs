using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatigue.Model
{
    internal class UserInfo2
    {
        public string SNCurve { get; set; }
        public double NomStress { get; set; }
        public double SCF { get; set; }
        public double WeibullShape { get; set; }
        public double CycleN1 { get; set; }
        public double m1 { get; set; }
        public double logam1 { get; set; }
        public double m2 { get; set; }
        public double logam2 { get; set; }
        public double YearInService { get; set; }
        public double V0 { get; set; }
        public double EffectiveThickness { get; set; }
        public double ReferThickness { get; set; }
        public double k { get; set; }
        public double Td { get; set; }
        public double n0 { get; set; }
        public double q { get; set; }
        public double ThickSize { get; set; }
        public double Gammam1 { get; set; }
        public double Gammam2 { get; set; }
        public double S1 { get; set; }
        public double S1h { get; set; }
        public double Gammadism1 { get; set; }
        public double Gammadism2 { get; set; }
        public double D { get; set; }
        public double T { get; set; }
        public UserInfo2()
        {

        }
    }

}
