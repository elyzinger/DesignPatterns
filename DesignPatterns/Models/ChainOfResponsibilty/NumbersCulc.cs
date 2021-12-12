using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.ChainOfResponsibilty
{
    class NumbersCulc
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public string CalcOption { get; set; }

        public NumbersCulc(int number1, int number2, string calcOption)
        {
            Number1 = number1;
            Number2 = number2;
            CalcOption = calcOption;
        }
    }
}
