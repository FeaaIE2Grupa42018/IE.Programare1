using System;

namespace IE.Programare1.Problema5
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

            int j = 0;
            bool ordonat = true;
            while(j < valori.Length - 1)
            {
                if(valori[j] > valori[j + 1])
                {
                    ordonat = false;
                    break;
                }
                j++;
            }

            string mesaj = "Valorile sunt " + (ordonat ? "ordonate." : "dezordonate.");
            Console.WriteLine(mesaj);

            Console.ReadKey();
        }
    }
}
