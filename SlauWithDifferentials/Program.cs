using System;

namespace SlauWithDifferetials
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("Введите количество уравнений системы: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество переменных системы: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Slau s = new Slau(m, n);
            s.SelfInputSlauDif();
            s.Solve();
            s.Print();
        }
    }
}
