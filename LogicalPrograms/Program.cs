using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical programs");
            Fibonacci.FibonacciNum();
            PerfectNumber.Perfect();
            PrimeNumber.CheckPrime();
            ReverseNumber.FindReverse();
            CoupanNumber.CheckCoupon();
            Console.ReadLine();

        }
    }
}
