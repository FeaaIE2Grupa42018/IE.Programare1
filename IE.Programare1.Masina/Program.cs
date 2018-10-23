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

            Console.WriteLine("Au trecut 2 ani");

            pret = pret - pret * depreciere;
            pret = pret - pret * depreciere;

            deAfisat = "Masina " + marca + " de culoare " + culoare +
                " fabricata la data " + dataFabricatie + areEuro6DeAfisat +
                " costa " + pret;

            Console.WriteLine(deAfisat);

            Console.WriteLine("Au trecut 4 ani");
            pret = pret - pret * depreciere;
            pret = pret - pret * depreciere;

            Console.WriteLine("Noua culoare:");
            culoare = Console.ReadLine();

            deAfisat = "Masina " + marca + " de culoare " + culoare +
               " fabricata la data " + dataFabricatie + areEuro6DeAfisat +
               " costa " + pret;
            Console.WriteLine(deAfisat);

            Console.WriteLine("Au trecut 6 ani");

            if(areEuro6)
            {
                areEuro6 = false;
                Console.WriteLine("S-a stricat filtrul!");
            }

            areEuro6DeAfisat = areEuro6 ? " are euro6 " : " nu are euro6 ";          

            pret = pret - pret * depreciere;
            pret = pret - pret * depreciere;

            deAfisat = "Masina " + marca + " de culoare " + culoare +
             " fabricata la data " + dataFabricatie + areEuro6DeAfisat +
             " costa " + pret;
            Console.WriteLine(deAfisat);

            Console.WriteLine("Final. Apasati orice tasta pentru a inchide");
            Console.ReadKey();
        }
    }
}

