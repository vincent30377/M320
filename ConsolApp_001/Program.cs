namespace ConsolApp_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zum ggT/kgV-Rechner!");

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

            Console.WriteLine("\n--- Array Test ---");
            int[] arr = MyMath.ReadArray();
            Console.WriteLine($"Mittelwert: {MyMath.Avg(arr)}");
            Console.WriteLine($"Kleinster Wert: {MyMath.Min(arr)}");
            Console.WriteLine($"Grösster Wert: {MyMath.Max(arr)}");

            Console.WriteLine("\n--- Swap Test ---");
            int x = 5, y = 10;
            Console.WriteLine($"Vor Swap: x={x}, y={y}");
            MyMath.Swap(ref x, ref y);
            Console.WriteLine($"Nach Swap: x={x}, y={y}");

            Console.WriteLine("Programm beendet.");
        }
    }
}