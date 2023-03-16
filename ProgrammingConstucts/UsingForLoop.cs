using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstucts
{
    internal class UsingForLoop
    {
        public static void PowerOf2()
        {
            Console.WriteLine("==> Table of 2^n ");
            Console.Write("Enter a value for 2^n : ");
            int n=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
               Console.WriteLine("2^{0} : {1} ",i,Math.Pow(2,i));
            }
        }
        //2
        public static void SumOfSquare()
        {
            Console.WriteLine("\n  ==> for calculating sum of square of n number strting from n");
            Console.Write("Enter a number n :");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= num; i++)
            {
                int result=Convert.ToInt32(Math.Pow(2, i));
                sum=sum+result;
                
            }
            Console.WriteLine("Sum of square of n number : " +sum);
        }
        //3
        public static void factorial()
        {
            Console.WriteLine(" \n ==> computes a factorial of a number taken as input");
            Console.Write("Enter a number : ");
            int number=Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= number; i++)
            {
                fact = fact * i;
                Console.Write(i + " * " );
            }
            Console.WriteLine("\n {0}! = {1} ",number, fact);
        }

    }
}
