using System;

namespace IE.Programare1.Cerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti raza cercului:");
            double raza = double.Parse(Console.ReadLine());
            //const double pi = 3.14159;

            //folosim clasa Math pentru operatii mai complexe
            double aria = Math.PI * Math.Pow(raza, 2);
            double perimetrul = 2 * Math.PI * raza;

            Console.WriteLine("Aria cercului este: " + aria);
            Console.WriteLine("Perimetrul cercului este: " + perimetrul);

            Console.ReadKey();

        }
    }
}
