using System;

namespace IE.Programare1.NumerePare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n:");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int contor = 0;

            //fara "for"
            int j = 0;
            while(j < n)
            {
                //if(j % 2 == 0)
                //{
                contor++;
                suma += j;
                //}
                j += 2;
            }
            double medie = suma / contor;
            Console.WriteLine($"Media este {medie}");

            suma = 0;
            contor = 0;
            //for(int i = 0; i < n; i++)
            //{
            for(int i = 2; i < n; i += 2)
            {
                //if(i % 2 == 0)
                //{
                contor++;
                suma += i;
                //}
            }
            medie = suma / contor;
            Console.WriteLine($"Media este {medie}");
        }
    }
}
