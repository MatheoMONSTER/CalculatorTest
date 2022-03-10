using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp124
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Calculator calc = new Calculator();
                Console.WriteLine(calc.Add(5, 6)); //11
                Console.WriteLine(calc.Substract(-2, 2)); //-4
                Console.WriteLine(calc.Multiply(2, 5)); //10
                Console.WriteLine(calc.Divide(1, 3)); //2
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
