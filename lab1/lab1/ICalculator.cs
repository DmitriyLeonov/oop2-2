using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal interface ICalculator
    {
        int Summ(int x, int y);
        int Subtr(int x, int y);
        double Division(int x, int y);
        int Multiply(int x, int y);
        double Divide(int x, int y);
        int Module(int x, int y);
        void GetResult(double x);
        double SetResult();
    }
}
