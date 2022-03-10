using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp124
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b; 
        }
        public int Substract(int a, int b)
        {
          /*  if (a > b)
            {
                return a - b;
            }
          */
            return a-b;
        }
        public int Multiply(int a, int b)
        {
            return a * b; 
        }
        public double Divide(double a, double b)
        {
            if(b == 0)
            {
                Console.WriteLine("Cannot divide by 0!");
            }
            return a / b;
        }
    }
}
