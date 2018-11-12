using System;

namespace IE.Programare1.Problema14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n:");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int m = n;
            //int l = 0;
            //while(m != 0)
            //{
            //    m = m / 10;
            //    l++;
            //}

            int[] cifre=new int[0];

            //l = 0;
            while(n != 0)
            {
                int cifra = n % 10;
                Array.Resize(ref cifre, cifre.Length + 1);

                cifre[cifre.Length-1] = cifra;
                suma += cifra;
                n = n / 10;
                //l++;
            }
            Console.WriteLine("Suma " + suma);
            for(int i = 0; i < cifre.Length; i++)
            {
                Console.Write(cifre[i]);
            }
            Console.ReadKey();
        }
    }
}
