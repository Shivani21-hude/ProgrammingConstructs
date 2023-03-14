using System;
namespace ProgrammingConstucts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **** Welcome to Programming Constructs Problems **** ");

            IfElseStatement statement = new IfElseStatement();

            Console.WriteLine("==> Check Whether two integer are equal or not ");
            statement.CheckIntegervalueEqualOrNot();

            Console.WriteLine("\n==> To Check the given number is even or odd " );
            statement.CheckNumberEvenOrOdd();

            Console.WriteLine("\n==> To check whether the person is eligible or not for voting");
            statement.EligibleForVotes();

            IfElseIfElseStatement.FindLargerNumber();

            IfElseIfElseStatement.CheckEligibleForAdission();
        }
    }
}