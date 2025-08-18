namespace ConsolApp_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 3;
            int b = 5;
            int summe = MyMath.Addiere(a, b);
            Console.WriteLine($"Summe von {a} und {b} = {summe}");

            int ggt = MyMath.Calc_ggT(a, b);
            Console.WriteLine($"Der ggt von {a} und {b} ist {ggt}");

            int kgv = MyMath.Calc_kgv(a, b);
            Console.WriteLine($"Der kgv von {a} und {b} ist {kgv}");

        }
    }
}   
