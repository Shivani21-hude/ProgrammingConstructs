using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstucts
{
    internal class IfElseIfElseStatement
    {
        public static void FindLargerNumber()
        {
            Console.WriteLine("\n==> Check greater number between tree numbers ");

            int a = 12, b = 10, c = 23;
            if (a > b & a > c)
            {
                Console.WriteLine("The number {0} is greater than {1} and {2} ", a, b, c);
            }
            else if (b > a & b > c)
            {
                Console.WriteLine("The number {1} is greater than {0} and {2} ", b, a, c);
            }
            else
            {
                Console.WriteLine("The number {1} is greater than {1} and {2} ", c, a, b);
            }
        }
        public static void CheckEligibleForAdission()
        {
            Console.WriteLine("\n==> Check the candidate is eligible for admission or not ");
            int physics = 65;
            int chem = 51;
            int maths = 72;
            int Total = physics + chem + maths;
           
            if(maths >=65 && physics >= 55 && chem>=50)
            {
                if (Total >= 180 || Total >= 140)
                {
                    Console.WriteLine("The candidate is eligible for admission");
                }
                else
                {
                    Console.WriteLine("The candidate is not eligible for admission");
                }
            }
        }
    }
}

