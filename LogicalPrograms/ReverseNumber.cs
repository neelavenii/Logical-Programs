using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public static void FindReverse()
        {
            int number, reverse = 0, remainder;
            Console.WriteLine("enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            while(number > 0)
            {
                remainder =number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("after reverse:");
            Console.WriteLine("Reverse number is:{0}", reverse);
            Console.ReadLine();
        }
    }
}
