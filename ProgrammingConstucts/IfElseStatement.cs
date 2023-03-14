using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstucts
{
    internal class IfElseStatement
    {
        public void CheckIntegervalueEqualOrNot()
        {

            int a = 12;
            int b = 13;
            if(a== b)
            {
                Console.WriteLine("The ablove two integer i.e a={0} and b={1} are equal ",a,b);
            }
            else
            {
                Console.WriteLine("The ablove two integer i.e a={0} and b={1} are not equal ",a,b);
            }
        }
        public void CheckNumberEvenOrOdd()
        {
            int number = 12;
            if (number % 2 == 0)
            {
                Console.WriteLine("The number {0} is even",number);
            }
            else
            {
                Console.WriteLine("The number {0} is not even",number);
            }
        }
        public void EligibleForVotes()
        {
            Console.Write("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age>=18 && age <= 60)
            {
                Console.WriteLine("You are Eligible for Voting");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are below 18 Scholl and stud");
            }
            else
            {
                Console.WriteLine("You are not Eligible for voting");
            }
        }
    }
}
