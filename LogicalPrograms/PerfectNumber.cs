using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public static int Find_Factors(int input)
        {
            int sum = 0;
            for(int i = 1;i< input;i++)
            {
                if(input%i==0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        public static void Perfect()
        {
            Console.WriteLine("Please provide input Value:");
            int input =int.Parse(Console.ReadLine());
           int result= Find_Factors(input);

            if(input==result)
            {
                Console.WriteLine("${input}is perfect number");
            }
            else
            {
                Console.WriteLine("${input}is not a perfect number");
            }
        }
    }
}
