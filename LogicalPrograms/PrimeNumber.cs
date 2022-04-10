using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void CheckPrime()
        {
            int n, k = 0, r=0, i=0;
            Console.WriteLine("Enter a Number:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<=n;i++)
            {
                r = n % i;
                    if(r==0)
                {
                    k++;
                }
            }
            if(k<=2)
            {
                Console.WriteLine("Given number is PrimeNumber");
            }
            else
            {
                Console.WriteLine("Given number is not a PrimeNumber");
            }
            Console.ReadLine();
        }
    }
}
