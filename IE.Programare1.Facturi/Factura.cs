using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.Facturi
{
    public struct Factura
    {
        public DateTime Data;
        public int Numar;
        public Produs[] Produse;

        public override string ToString()
        {
            return "Factura nr " + Numar + " din data " + Data;
        }
    }
}
