using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstucts
{
    internal class UsingWhileLoop
    {
        public static void FlipCoin()
        {
            Console.WriteLine(" *** Find Tail or Head Wins *** ");
           
            int CountHead = 0;
            int CountTail = 0;
            int i = 0; 
            while(i <= 20) 
            {
                Random random = new Random();
                int num = random.Next(2);
                if (num == 0)
                {
                    CountHead++;
                }
                else
                {
                    CountTail++;
                }
                i++;
            }          
            if(CountHead > CountTail)
            {
                Console.WriteLine("number of Heads :{0} out of 20 rounds  \n'Head Wins'", CountHead);
            }
            else if(CountTail>CountHead)
            {
                Console.WriteLine("number of tails : {0} out of 20 rounds \n 'Tail Wins'", CountTail);
            }
            else
            {
                Console.WriteLine("Head and tail both are same ");
            }
        }
        //2
        public static void ReverseWord()
        {
            Console.WriteLine(" \n *** Reverse word using while loop");
            Console.Write("Enter a word : ");
            string word = Console.ReadLine();
            char[] array=word.ToCharArray();
            int i = word.Length - 1; 
            while(i >= 0)
            {
                Console.Write(array[i]);
                i--;
            }
        }

        //3
        public static void PrintNaturalNumbers()
        {
            int i = 1;
            Console.WriteLine("\n ** Print Natural Numbers : ** ");
            while (5 >= i)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
