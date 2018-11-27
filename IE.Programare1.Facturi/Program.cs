using System;

namespace IE.Programare1.Facturi
{
    class Program
    {
        static void Main(string[] args)
        {

            //secventa de preluare date
            Console.WriteLine("Introduceti factura");
            Factura fact = new Factura();
            Console.WriteLine("Data:");
            fact.Data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Numar:");
            fact.Numar = int.Parse(Console.ReadLine());

            Produs[] produse = new Produs[0];
            do
            {
                Array.Resize(ref produse, produse.Length + 1);

                Console.WriteLine("Introduceti produs");
                Console.WriteLine("Denumire:");
                produse[produse.Length - 1].Denumire = Console.ReadLine();
                Console.WriteLine("Pret:");
                produse[produse.Length - 1].Pret = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Cantitate:");
                produse[produse.Length - 1].Cantitate = int.Parse(Console.ReadLine());
                Console.WriteLine("Cota TVA:");
                produse[produse.Length - 1].CotaTva = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Apasa Esc daca nu mai sunt produse.");

            } while(Console.ReadKey().Key != ConsoleKey.Escape);

            fact.Produse = produse;           

            decimal valoare = 0;
            for(int i = 0; i < fact.Produse.Length; i++)
            {
                valoare += fact.Produse[i].Pret + fact.Produse[i].Pret * fact.Produse[i].CotaTva;
            }

            //string mesajFact = fact.ToString();

            Console.WriteLine("Valoarea totala a facturii " + fact + " este " + valoare);
            Console.ReadKey();

        }
    }


}
