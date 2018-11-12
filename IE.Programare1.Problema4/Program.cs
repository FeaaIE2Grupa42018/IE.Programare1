using System;

namespace IE.Programare1.Problema4
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

            for(int i = 0; i < valori.Length - 1; i += 2)
            {
                double suma = valori[i] + valori[i + 1];
                Array.Resize(ref valori, valori.Length + 1);
                int j = valori.Length - 1;
                while(j > i)
                {
                    valori[j] = valori[j - 1];
                    j--;
                }
                valori[i + 1] = suma;
            }

            Console.WriteLine(string.Join(" ", valori));
            Console.ReadKey();

        }
    }
}
