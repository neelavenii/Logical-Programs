using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fibonacci
    {
        public static void FibonacciNum()
        {
            int n, f1 = 0, f2 = 1, f3;
            Console.WriteLine("Enter the number of element :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The fibonacci Serirs is :");
            Console.WriteLine(f1 + "" + f2 + "");
            f3 = f1 + f2;
            while (f3 <= n)
            {
                Console.WriteLine(f3 + "");
                f1 = f2;
                f2 = f3;
                f3 = f1 + f2;

            }
            Console.ReadLine();


        }
    }
}
