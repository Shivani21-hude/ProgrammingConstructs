using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstucts
{
    internal class SwitchCase
    {
        public static string WeekDays()
        {

            Console.WriteLine("Give the input as from 1 to 7 for weekday");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    return "Monday";
                    break;
                case 2:
                    return "Tuesday";
                    break;
                case 3:
                    return "Wednesday";
                    break;
                case 4:
                    return "Thursday";
                    break;
                case 5:
                    return "Friday";
                    break;
                case 6:
                    return "Satarday";
                    break;
                case 7:
                    return "Sunday";
                    break;
                default:
                    return "invalid input";
                    break;

            }
        }

            //2 
         public static void ArithmaticOperation()
        {
            Console.WriteLine("Ener two numbers : ");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give a number fo following : \n 1) Addition of two numbers \n 2) Substraction of two numbers \n 3) Multiplication of two numbers \n 4) " +
                "Division of two numbers ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("a + b  : "+( a + b));
                    break;
                case 2:
                    Console.WriteLine("a - b : " +(a-b));
                    break;
                case 3:
                    Console.WriteLine("a * b :" +(a*b));
                    break;
                case 4:
                    Console.WriteLine("a / b : "+(a/b));
                    break;
            }
        }

        
    }
}
