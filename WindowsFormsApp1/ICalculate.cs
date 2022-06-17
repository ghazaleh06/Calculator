using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface ICalculate
    {
        int Sum(int Num1,int Num2);

        int Minus(int Num1,int Num2);

        int Multiple(int Num1,int Num2);

        int Divide(int Num1,int Num2);
    }
}
