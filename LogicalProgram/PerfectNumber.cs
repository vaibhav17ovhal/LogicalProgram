using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PerfectNumber
    {
        public static void Number()
        {
            int n;
            int i;
            int sum;

            Console.WriteLine("Enter the perfect number within the range\n");

            Console.Write("Enter the minimum range: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the maximum range: ");
            int max = Convert.ToInt32(Console.ReadLine());
            
            for (n = min; n <= max; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine($"Perfect number is {n}");
            }


        }
    }
}
