using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseNumber
    {
        public static void Reverse()
        {
            int reverse = 0;
            int rem;

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine($"Reversed number is: {reverse}");
        }
    }
}
