using IE.Programare1.Util;
using System;

namespace IE.Programare1.CursSchimb2
{
    class Program
    {
        static void Main(string[] args)
        {
            //aflam luna curenta
            int lunaCurenta = DateTime.Today.Month;

            //declaram si populam matricea de cursuri
            double[,] cursuri = new double[2, lunaCurenta];
            for(int i = 0; i < cursuri.GetLength(0); i++)
            {
                for(int j = 0; j < cursuri.GetLength(1); j++)
                {
                    string luna = FunctiiDateTime.ObtineNumaLuna(j + 1);
                    if(i == 0)
                    {
                        Console.WriteLine("Introduceti cursul EUR " + luna);
                    }
                    else
                    {
                        Console.WriteLine("Introduceti cursul USD " + luna);
                    }

                    cursuri[i, j] = double.Parse(Console.ReadLine());
                }
            }

            string[] luniCursuriEgale = new string[0];
            for(int i = 0; i < cursuri.GetLength(1); i++)
            {
                if(cursuri[0, i] == cursuri[1, i])
                {
                    Array.Resize(ref luniCursuriEgale, luniCursuriEgale.Length + 1);
                    luniCursuriEgale[luniCursuriEgale.Length - 1] = FunctiiDateTime.ObtineNumaLuna(i + 1);
                }
            }

            //de afisat luniCursuriEgale


        }
    }
}
