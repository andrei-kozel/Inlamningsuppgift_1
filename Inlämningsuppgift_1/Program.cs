using System;

namespace MiniCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean isRunning = true;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Title = "Miniräknare";
            Console.WriteLine("Välkommen til miniräknaren!");

            while (isRunning)
            {
                Console.WriteLine(" ");
                Console.WriteLine("=========================");
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1. Addera två tal");
                Console.WriteLine("2. Sub två tal");
                Console.WriteLine("3. Multiplicera två tal");
                Console.WriteLine("4. Dividera två tal");
                Console.WriteLine("5. Returnera återstoden");
                Console.WriteLine("6. Avsluta");
                Console.WriteLine("=========================");

                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.Beep();

                if (userInput == 1)
                {
                    Console.WriteLine("Du valde +");
                    Console.Write("Skriv in det första talet: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Beep();
                    Console.Write("Skriv in det andra talet: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Beep();
                    int result = a + b;
                    Console.WriteLine("Resultat är: " + result);
                }
                if (userInput == 2)
                {
                    Console.WriteLine("Du valde -");
                    Console.Write("Skriv in det första talet: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Beep();
                    Console.Write("Skriv in det andra talet: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Beep();
                    int result = a - b;
                    Console.WriteLine("Resultat är: " + result);
                }
                if (userInput == 3)
                {
                    Console.WriteLine("Du valde *");
                    Console.Write("Skriv in det första talet: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Beep();
                    Console.Write("Skriv in det andra talet: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Beep();
                    int result = a * b;
                    Console.WriteLine("Resultat är: " + result);
                }
                if (userInput == 4)
                {
                    Console.WriteLine("Du valde /");
                    Console.Write("Skriv in det första talet: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Beep();
                    Console.Write("Skriv in det andra talet: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Beep();
                    int result = a / b;
                    Console.WriteLine("Resultat är: " + result);
                }
                if (userInput == 5)
                {
                    Console.WriteLine("Du valde %");
                    Console.Write("Skriv in det första talet: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Beep();
                    Console.Write("Skriv in det andra talet: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Beep();
                    int result = a % b;
                    Console.WriteLine("Resultat är: " + result);
                }
                if (userInput == 6)
                {
                    isRunning = false;
                }
            }
            Console.WriteLine("Tack och hej då!");
        }
    }
}