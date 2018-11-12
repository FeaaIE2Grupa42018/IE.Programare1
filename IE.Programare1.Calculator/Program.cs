using System;

namespace IE.Programare1.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, rezultat;
            string operatie;
            ConsoleKeyInfo tasta;
            do
            {
                //preluam operanzii si operatorul de la utilizator
                Console.WriteLine("Introduceti a:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti b:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Operatorul:");
                operatie = Console.ReadLine();

                rezultat = 0;
                switch(operatie)
                {
                    case "+":
                        rezultat = a + b;
                        break;
                    case "-":
                        rezultat = a - b;
                        break;
                    case "*":
                        rezultat = a * b;
                        break;
                    case ":":
                    case "/":
                        rezultat = a / b;
                        break;
                    default:
                        Console.WriteLine("Operator invalid");
                        break;
                }
                Console.WriteLine("Rezultat" + rezultat);
                tasta = Console.ReadKey();
            } while(tasta.Key != ConsoleKey.Escape);

        }
    }
}
