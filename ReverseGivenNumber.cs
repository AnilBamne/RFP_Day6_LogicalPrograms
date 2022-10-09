using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class ReverseGivenNumber
    {
        public static void revNum()
        {
            int rev = 0;
            Console.WriteLine("Enter a number");
            //string n=Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before : " + num);
            while (num != 0)
            {
                int reminder = num % 10;
                rev = rev * 10 + reminder;
                num=num / 10;
            }

            
            Console.WriteLine("after : " +rev);
        }
    }
}
