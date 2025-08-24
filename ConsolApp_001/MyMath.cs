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


        static internal int ReadInt()
        {
            int value;
            while (true)
            {
                Console.Write("Bitte eine positive ganze Zahl eingeben: ");
                if (int.TryParse(Console.ReadLine(), out value) && value > 0)
                    return value;

                Console.WriteLine("Ungültige Eingabe! Zahl muss > 0 sein.");
            }
        }

        static internal string ShowResult(string type, int a, int b, int result)
        {
            return $"{type} von {a} und {b} ist {result}";
        }

        bool weiter = true;
        while (weiter)
{
            int a = MyMath.ReadInt();
            int b = MyMath.ReadInt();

            Console.WriteLine("Möchten Sie ggT oder kgV berechnen? (ggt/kgv) ");
            string choice = Console.ReadLine().Trim().ToLower();

            if (choice == "ggt")
            {
            int ggt = MyMath.Calc_ggT(a, b);
            int ggt_r = MyMath.Calc_ggT_r(a, b);
            Console.WriteLine(MyMath.ShowResult("ggt", a, b, ggt));
            Console.WriteLine($"rekursiv berechnet: {ggt_r}");
            }
            else if (choice == "kgv")
            {
            int kgv = MyMath.Calc_kgv(a, b);
            Console.WriteLine(MyMath.ShowResult("kgv", a, b, kgv));
            }
            else
            {
            Console.WriteLine("Ungültige Auswahl!");
            }

            Console.Write("Neue Berechnung? (j/n): ");
            string answer = Console.ReadLine().Trim().ToLower();
            if (answer != "j")
            {
            weiter = false;
            }
        }
    }
}
