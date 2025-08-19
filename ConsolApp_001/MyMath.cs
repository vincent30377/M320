using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolApp_001
{
    internal class MyMath
    {
        static internal int Addiere(int a, int b)
        {
            return a + 2 * b; 
        }

        static internal int Calc_ggT(int a, int b)
        {
            int z;

            ;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }

            return a;
            
        }
        static internal int Calc_kgv(int a, int b)
        {
            return a * b / Calc_ggT(a, b);
        }


        

    }
}
