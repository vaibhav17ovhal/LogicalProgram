using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class FibonacciSeries
    {
        public static void Series()
        {
            int a = 0;
            int b = 1;
            int c;

            Console.Write("Enter the size: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 2;  i < num; i++)
            {
                c = a + b;
                Console.WriteLine(c);

                a = b;
                b = c;
            }
        }
    }
}
