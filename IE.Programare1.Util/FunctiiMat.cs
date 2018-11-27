using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.Util
{
    public class FunctiiMat
    {
        public double[] FctGrad2(double a, double b, double c, out bool infinitateSolutie)
        {
            double delta;
            double[] radacini = new double[0];
            infinitateSolutie = false;
            if (a == 0 && b == 0 && c == 0)
            {
                infinitateSolutie = true;
                return radacini;
            }
            if (a == 0 && b == 0)
            {
                return radacini;
           
            }
            if (a == 0)
            {
                Array.Resize(ref radacini, 1);
                radacini[0] = -c / b;
                return radacini;
            }
            delta = b * b - 4 * a * c;
            //cazurile lui delta, negativ, 0, pozitiv...
        }
    }
}
