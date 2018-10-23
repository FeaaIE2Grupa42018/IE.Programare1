using System;

namespace IE.Programare1.Cerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti raza cercului:");
            double raza = double.Parse(Console.ReadLine());
            const double pi = 3.14159;

            double aria = pi * raza * raza;
            double perimetrul = 2 * pi * raza;

            Console.WriteLine("Aria cercului este: " + aria);
            Console.WriteLine("Perimetrul cercului este: " + perimetrul);

            Console.ReadKey();

        }
    }
}
