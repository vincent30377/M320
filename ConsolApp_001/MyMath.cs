using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolApp_001;

namespace ConsolApp_001
{
    internal class MyMath
    {
        static internal int Calc_ggT(int a, int b)
        {
            while (b != 0)
            {
                int z = a % b;
                a = b;
                b = z;
            }
            return a;
        }

        static internal int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
                return a;
            return Calc_ggT_r(b, a % b);
        }

        static internal int Calc_kgv(int a, int b)
        {
            if (a == 0 || b == 0) return 0;
            int ggt = Calc_ggT(a, b);
            return (a / ggt) * b;
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

        static internal int[] ReadArray()
        {
            Console.Write("Wie viele Zahlen möchten Sie eingeben? ");
            int n = ReadInt();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = ReadInt();
            }

            return arr;
        }

        static internal double Avg(int[] arr)
        {
            double sum = 0;
            foreach (int val in arr) sum += val;
            return sum / arr.Length;
        }

        static internal int Min(int[] arr)
        {
            int min = arr[0];
            foreach (int val in arr) if (val < min) min = val;
            return min;
        }

        static internal int Max(int[] arr)
        {
            int max = arr[0];
            foreach (int val in arr) if (val > max) max = val;
            return max;
        }

        static internal void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
