using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Programare1.Util
{
    public class FunctiiMat
    {
        public static double[] FctGrad2(double a, double b, double c, out bool infinitateSolutie)
        {
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
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if(delta >= 0)
            {
                Array.Resize(ref radacini, 2);
                if(delta == 0)
                {
                    radacini[0] = radacini[1] = -b / 2 * a;
                }
                else
                {
                    radacini[0] = (-b + Math.Sqrt(delta)) / 2 * a;
                    radacini[1] = (-b - Math.Sqrt(delta)) / 2 * a;
                }
            }
            return radacini;
        }

    }
}
