using System;

namespace IE.Programare1.Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n:");
            int n = int.Parse(Console.ReadLine());
            double[] valori = new double[n];
            //populam vectorul
            for(int i = 0; i < valori.Length; i++)
            {
                Console.WriteLine("Introduceti valoarea " + (i + 1));
                valori[i] = double.Parse(Console.ReadLine());
            }

            //preluam a si b
            Console.WriteLine("Introduceti a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b:");
            double b = double.Parse(Console.ReadLine());

            //stabilim ordinea intre a si b
            /*if(b < a)
            {
                double temp = a;
                a = b;
                b = temp;
            }*/

            double suma = 0;
            int j = 0;
            for(int i = 0; i < valori.Length; i++)
            {
                //if(valori[i] > a && valori[i] < b)
                //if(valori[i] > Math.Min(a,b) && valori[i] < Math.Max(a,b))
                if((valori[i] > a && valori[i] < b) || (valori[i] > b && valori[i] < a))
                {
                    suma += valori[i];
                    j++;
                }
            }

            Console.WriteLine($"Media valorilor intre {a} si {b} este {suma / j}");
            Console.ReadKey();


        }
    }
}
