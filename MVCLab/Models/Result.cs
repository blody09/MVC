using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLab.Models
{
    public class Result
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Result1
        {
            get { return Num1 / Num2; }
        }
        public double Result2
        {
            get { return Num1 % Num2; }
        }

    }
}
