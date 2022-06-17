using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Calculate : ICalculate
    {
        public int Divide(int Num1, int Num2)
        {
            return Num1 / Num2;
        }

        public int Minus(int Num1, int Num2)
        {
            return Num1 - Num2;
        }

        public int Multiple(int Num1, int Num2)
        {
            return Num1 * Num2;
        }

        public int Sum(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
    }
}
