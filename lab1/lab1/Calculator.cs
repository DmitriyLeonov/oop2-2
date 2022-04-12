using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Calculator : ICalculator
    {
        private static double savedValue = 0;
        public double Divide(int x, int y)
        {
            return x % y;
        }

        public double Division(int x, int y)
        {
            return (double)x / y;
        }

        public void GetResult(double x)
        {
            savedValue = x;
        }

        public int Module(int x, int y)
        {
            return x / y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public double SetResult()
        {
            return savedValue;
        }

        public int Subtr(int x, int y)
        {
            return x - y;
        }

        public int Summ(int x, int y)
        {
            return x + y;
        }
    }
}
