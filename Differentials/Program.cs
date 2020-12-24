using System;

namespace Differentials
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerFunction f1 = new PowerFunction(1, 2, 3, 4, 5, 6, 7);
            f1.Output();
            f1.DifferentialOutput();
            Console.WriteLine();

            PowerFunction f2 = new PowerFunction();
            f2 = f2.Input();
            f2.Output();
            f2.DifferentialOutput();
            Console.WriteLine();

            TrigonometricFunction f3 = new TrigonometricFunction(1);
            f3.Output();
            f3.DifferentialOutput();
            Console.WriteLine();

            TrigonometricFunction f4 = new TrigonometricFunction();
            f4 = f4.Input();
            f4.Output();
            f4.DifferentialOutput();
            Console.WriteLine();

        }
    }
}
