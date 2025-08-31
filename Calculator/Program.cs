namespace Calculator
{
    using System;

    class Calculator
    {
        private int lastResult = 0; 

        
        public int Add(int a, int b) { lastResult = a + b; return lastResult; }
        public int Sub(int a, int b) { lastResult = a - b; return lastResult; }
        public int Mul(int a, int b) { lastResult = a * b; return lastResult; }
        public int Div(int a, int b) { lastResult = a / b; return lastResult; }


        public int Add(int b) { lastResult = lastResult + b; return lastResult; }
        public int Sub(int b) { lastResult = lastResult - b; return lastResult; }
        public int Mul(int b) { lastResult = lastResult * b; return lastResult; }
        public int Div(int b) { lastResult = lastResult / b; return lastResult; }

        public int GetLastResult() { return lastResult; }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Wähle eine Operation (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.WriteLine("Erste Zahl: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Zweite Zahl: ");
            int b = int.Parse(Console.ReadLine());

            int result = 0;

            if (op == "+")
            {
                result = calc.Add(a, b);
            }
            else if (op == "-")
            {
                result = calc.Sub(a, b);
            }
            else if (op == "*")
            {
                result = calc.Mul(a, b);
            }
            else if (op == "/")
            {
                result = calc.Div(a, b);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe!");
                return;
            }

            Console.WriteLine("Ergebnis: " + result);
        }
    }
}

