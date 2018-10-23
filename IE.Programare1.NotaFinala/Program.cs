using System;

namespace IE.Programare1.NotaFinala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nota test BlackBoard 1:");
            float notaBb1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota test BlackBoard 2:");
            float notaBb2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nota test practic:");
            float notaPractic = float.Parse(Console.ReadLine());

            const float prag = 5;

            if(notaPractic < 5 || (notaBb1 + notaBb2) / 2 < 5)
            {
                Console.WriteLine("Nepromovat");
            }
            else
            {
                Console.WriteLine("Promovat.");
                float media = (notaBb1 + notaBb2) * 0.3f + notaPractic * 0.4f;
                Console.WriteLine("Cu " + (media - prag) + " peste prag.");
            }

            Console.ReadKey();
        }
    }
}
