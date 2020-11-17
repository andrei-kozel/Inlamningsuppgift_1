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
                double result = Convert.ToDouble(new DataTable().Compute(expression, null));
                Console.WriteLine($"{expression} = {result}");
                calculations.Add(result);

                Console.WriteLine("6. Another try? [Yes]/[No]");
                string answer = Console.ReadLine();
                Console.WriteLine("=========================");

                if (answer.ToLower() == "no")
                {
                    isRunning = false; 
                } 
            }

            calculations.ForEach(item => totalSum = Convert.ToDouble(totalSum) + Convert.ToDouble(item));

            Console.WriteLine($"Total sum: {totalSum}");

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