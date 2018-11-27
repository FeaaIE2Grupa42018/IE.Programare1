using IE.Programare1.Util;
using System;

namespace IE.Programare1.CursSchimb
{
    class Program
    {
        static void Main(string[] args)
        {
            int lunaCurenta = DateTime.Today.Month;
            double[] cursuri = new double[lunaCurenta];
            //populare
            for(int i = 0; i < cursuri.Length; i++)
            {
                Console.WriteLine("Introduceti cursul pentru luna " + (i + 1));
                cursuri[i] = double.Parse(Console.ReadLine());
            }

            double min = cursuri[0];
            double max = cursuri[0];
            double suma = cursuri[0];
            double medie;

            for(int i = 1; i < cursuri.Length; i++)
            {
                if(cursuri[i] < min)
                {
                    min = cursuri[i];
                }
                if(cursuri[i] > max)
                {
                    max = cursuri[i];
                }
                suma += cursuri[i];
            }
            medie = suma / cursuri.Length;

            int[] luniMin = new int[0];
            int[] luniMax = new int[0];
            int[] luniMaiMareCaMedia = new int[0];
            for(int i = 0; i < cursuri.Length; i++)
            {
                if(cursuri[i] == min)
                {
                    Array.Resize(ref luniMin, luniMin.Length + 1);
                    luniMin[luniMin.Length - 1] = i;
                }
                if(cursuri[i] == max)
                {
                    Array.Resize(ref luniMax, luniMax.Length + 1);
                    luniMax[luniMax.Length - 1] = i;
                }
                if(cursuri[i] > medie)
                {
                    Array.Resize(ref luniMaiMareCaMedia, luniMaiMareCaMedia.Length + 1);
                    luniMaiMareCaMedia[luniMaiMareCaMedia.Length - 1] = i;
                }

            }


            Console.WriteLine("Lunile de minim:");
            for(int i = 0; i < luniMin.Length; i++)
            {
                Console.Write(FunctiiDateTime.ObtineNumeLuna(luniMin[i] + 1) + " ");
            }

            //afisare max si > decat media

            Console.ReadKey();

        }

        //private static string ObtineNumaLuna(int pozitieLuna)
        //{
        //    string[] luni = new string[12] { "Ian", "Feb", "Mar", "Apr", "Mai", "Iun", "Iul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        //    string numeLuna = luni[pozitieLuna - 1];
        //    return numeLuna;
        //}
    }
}
