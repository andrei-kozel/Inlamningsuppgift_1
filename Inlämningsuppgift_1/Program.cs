using System;
using System.Collections.Generic;
using System.Data;

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
            List<double> calculations = new List<double>();
            double totalSum = 0;

            while (isRunning)
            {
                Console.WriteLine(" ");
                Console.WriteLine("=========================");
                Console.Write("1. Enter first operator: ");
                string firstOperator = Console.ReadLine();
                Console.Write("2. Enter second operator: ");
                string secondOperator = Console.ReadLine();
                Console.Write("3. Enter first term: ");
                string firstTerm = Console.ReadLine();
                Console.Write("4. Enter second term: ");
                string secondTerm = Console.ReadLine();
                Console.Write("5. Enter third term: ");
                string thirdTerm = Console.ReadLine();
                string expression = $"{firstTerm} {firstOperator} {secondTerm} {secondOperator} {thirdTerm}";
                double sum = Convert.ToDouble(new DataTable().Compute(expression, null));
                Console.WriteLine($"{expression} = {sum}");
                calculations.Add(sum);

                if (sum == 100)
                {
                    Console.WriteLine("Cool, now you have a hundred, clap clap");
                }
                else if (sum > 100)
                {
                    Console.WriteLine("More then a hundred");
                }
                else if (sum < 100)
                {
                    Console.WriteLine("Less then a hundred");
                }

                Console.Write("Another try? [Yes]/[No]: ");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "no")
                {
                    isRunning = false; 
                } 
            }

            calculations.ForEach(item => totalSum = Convert.ToDouble(totalSum) + Convert.ToDouble(item));
            Console.WriteLine(" ");
            Console.WriteLine($"Thank you for playing. The sum of all round is {totalSum}. Bye");
            Console.WriteLine("=========================");
        }
    }
}