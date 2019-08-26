using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;
            int result = MakeComplicatedCalculation(a, b);
            Console.WriteLine(result);
        }

        static int MakeComplicatedCalculation(int a, int b)
        {
            try
            {
                return a / b;
            }

            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Error. You cannot divide by zero");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Unknown Error");
            }

            return 0;

        }
    }
}
