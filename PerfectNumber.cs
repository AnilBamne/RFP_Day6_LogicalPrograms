using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class PerfectNumber
    {
        public static void checkPerfect()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for(int i = 1; i < num; i++)
            {
                if(num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum == num)
            {
                Console.WriteLine("this is a Perfect Number");
            }
            else
            {
                Console.WriteLine("This is not a Perfect Number");
            }
        }
    }
}
