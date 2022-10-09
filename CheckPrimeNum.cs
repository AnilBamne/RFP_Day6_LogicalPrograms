using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class CheckPrimeNum
    {
        public static void isPrimeNum()
        {
            Console.WriteLine("Enter a number");
            //string n=Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
        }
    }
}
