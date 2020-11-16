using System;
using System.Collections.Generic;

namespace MiniCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean isRunning = true;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Title = "Miniräknare | Inlämningsuppgift 1";
            Console.WriteLine("Let's do some calculations!");
            List<int> calculations = new List<int>();
            int totalSum = 0;

            while (isRunning)
            {
                Console.WriteLine(" ");
                Console.WriteLine("=========================");
                Console.WriteLine("1. Enter first operator: ");
                string firstOperator = Console.ReadLine();
                Console.WriteLine("2. Enter second operator: ");
                string secondOperator = Console.ReadLine();
                Console.WriteLine("3. Enter first term: ");
                string firstTerm = Console.ReadLine();
                Console.WriteLine("4. Enter second term: ");
                string secondTerm = Console.ReadLine();
                Console.WriteLine("5. Enter third term: ");
                string thirdTerm = Console.ReadLine();
                string expression = $"{firstTerm} {firstOperator} {secondTerm} {secondOperator} {thirdTerm}";

                Console.WriteLine("6. Another try? [Yes]/[No]");
                string answer = Console.ReadLine();
                Console.WriteLine("=========================");

                if (answer.ToLower() == "no")
                {
                    isRunning = false; 
                } 
            }

            if (totalSum == 100)
            {
                Console.WriteLine("Cool, now you have a hundred, clap clap");
            }
            else if (totalSum > 100)
            {
                Console.WriteLine("More then a hundred");
            }
            else if (totalSum < 100)
            {
                Console.WriteLine("Less then a hundred");
            }
        }
    }
}