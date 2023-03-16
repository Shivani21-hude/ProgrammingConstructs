using System;
namespace ProgrammingConstucts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **** Welcome to Programming Constructs Problems **** ");
            while (true)
            {

            Console.WriteLine("\n Choose a number between following : \n 1) IF else statement problems \n 2) if, else if, else statement problems \n 3) " +
                "Switch case problems \n 4) Using For loop problems \n 5) Usinhg while loop");
            int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        IfElseStatement statement = new IfElseStatement();

                        Console.WriteLine("==> Check Whether two integer are equal or not ");
                        statement.CheckIntegervalueEqualOrNot();

                        Console.WriteLine("\n==> To Check the given number is even or odd ");
                        statement.CheckNumberEvenOrOdd();

                        Console.WriteLine("\n==> To check whether the person is eligible or not for voting");
                        statement.EligibleForVotes();
                        break;

                    case 2:
                        //find largest number bet 3 numbers
                        IfElseIfElseStatement.FindLargerNumber();

                        //Check eligible candidate for admission
                        IfElseIfElseStatement.CheckEligibleForAdission();
                        break;

                    case 3:
                        //calling weekdays
                        Console.WriteLine("Day : " + SwitchCase.WeekDays());
                        Console.WriteLine("\n *** Arithamtic operations ***");
                        SwitchCase.ArithmaticOperation();
                        break;

                    case 4:
                        UsingForLoop.PowerOf2();
                        UsingForLoop.SumOfSquare();
                        UsingForLoop.factorial();
                        break;

                    case 5:
                        UsingWhileLoop.FlipCoin();
                        UsingWhileLoop.ReverseWord();
                        UsingWhileLoop.PrintNaturalNumbers();
                        break;
                }

            }
        }
    }
}