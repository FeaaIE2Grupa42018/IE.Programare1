using System;
namespace IE.Programare1.Masina
{
    class Program
    {
        static void Main(string[] args)
        {
            //string marca = "Opel", culoare = "Rosie";
            /* declarare
             variabile
             */
            Console.WriteLine("Introduuceti marca:");
            string marca;
            marca = Console.ReadLine();

            Console.WriteLine("Culoarea:");
            string culoare = Console.ReadLine();

            Console.WriteLine("Are euro 6?");
            bool areEuro6 = Convert.ToBoolean(Console.ReadLine());
            //bool areEuro6 = bool.Parse(Console.ReadLine());

            Console.WriteLine("Pretul:");
            float pret = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Data fabricatiei");
            DateTime dataFabricatie = Convert.ToDateTime(Console.ReadLine());

            const float depreciere = 0.1f;

            //varianta 1 difefrenta anilor celor doua date
            //int aniTrecuti = DateTime.Today.Year - dataFabricatie.Year;

            //varianta 2 pentru determinarea anilor trecuti
            TimeSpan timp = DateTime.Today - dataFabricatie;
            
            //double rest = timp.TotalDays % 365;
            //int aniTrecuti = (int)(timp.TotalDays / 365);
            //if(rest > 0)
            //{
            //    aniTrecuti++;
            //}
            int aniTrecuti = (int)Math.Ceiling(timp.TotalDays / 365);

            for(int i = 1; i <= aniTrecuti; i++)
            {

                if(i == 3)
                {
                    Console.WriteLine("Revopsim masina in culoarea:");
                    culoare = Console.ReadLine();
                }
                if(i == 5 && areEuro6)
                {
                    areEuro6 = false;
                    Console.WriteLine("S-a stricat filtrul!");
                }
                pret = pret - pret * depreciere;

                if(i == 2 || i == 4 || i == 6)
                {
                    Console.WriteLine($"Au trecut {i} ani");

                    string areEuro6DeAfisat;
                    if(areEuro6)
                    {
                        areEuro6DeAfisat = " are euro6 ";
                    }
                    else
                    {
                        areEuro6DeAfisat = " nu are euro6 ";
                    }
                    string deAfisat = "Masina " + marca + " de culoare " + culoare +
                   " fabricata la data " + dataFabricatie + areEuro6DeAfisat +
                   " costa " + pret;
                    Console.WriteLine(deAfisat);
                }

            }


            Console.WriteLine("Final. Apasati orice tasta pentru a inchide");
            Console.ReadKey();
        }
    }
}

