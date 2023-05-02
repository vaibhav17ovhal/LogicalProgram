using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PrimeNumber
    {
        public static void Prime()
        { 
            int count = 0;
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 1)
            {
                Console.WriteLine($"{num} is prime number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number.");
            }
        }
    }
}
