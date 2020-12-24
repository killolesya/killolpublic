using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentialWithForms
{
    class PowerFunction
    {
        double a; // коэффициент 1
        double m; // степень 1
        double b; // коэффициент 2
        double n; // степень 2
        double c; // коэффициент 3
        double k; // степень 3
        double d; // свободный член
        string function; // функция
        public string Function
        {
            get { return function; }
        }

        public PowerFunction() // конструктор по умолчанию
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            m = 0;
            n = 0;
            k = 0;
            PowerFunctionToString();
        }

        public PowerFunction(double a, double b, double c, double d, double m, double n, double k) // конструктор с входными данными
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.m = m;
            this.n = n;
            this.k = k;
            PowerFunctionToString();
        }

        public PowerFunction Input() // метод ввода степенной функции
        {
            try
            {
                Console.WriteLine("Введите данные многочлена.");
                Console.WriteLine("Вид многочлена: a(x^m) + b(x^n) + c(x^k) + d");
                Console.WriteLine("a, b, c, - коэффициенты многочлена; m, n, k - соответственно степени переменной x при данных коэффииентах; d - свободный член.");
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("m = ");
                double m = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("n = ");
                double n = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("k = ");
                double k = double.Parse(Console.ReadLine());
                Console.Write("d = ");
                double d = double.Parse(Console.ReadLine());
                return new PowerFunction(a, b, c, d, m, n, k);
            }
            catch
            {
                Console.WriteLine("Данные введены неверно.");
                return new PowerFunction();
            }
        }

        private void PowerFunctionToString()//метод приведения функции в строковый тип
        {
            function = a.ToString() + "x^" + m.ToString() + " + " + b.ToString() + "x^" + n.ToString() + " + " + c.ToString() + "x^" + k.ToString() + " + " + d.ToString();
        }

        public string Differential() // метод вычисления дифференциала(в виде строки)
        {
            PowerFunction temp = DifferentialFunc();
            string differential = "(" + temp.a.ToString() + "x^" + temp.m.ToString() + " + " + temp.b.ToString() + "x^" + temp.n.ToString() + " + " + temp.c.ToString() + "x^" + temp.k.ToString() + ")dx";

            return differential;
        }

        public PowerFunction DifferentialFunc() //метод вычисления дифференциала(с виде степенной функции)
        {
            PowerFunction temp = new PowerFunction();
            temp.a = this.a * this.m;
            temp.m = this.m - 1;
            temp.b = this.b * this.n;
            temp.n = this.n - 1;
            temp.c = this.c * this.k;
            temp.k = this.k - 1;
            temp.d = 0;
            return temp;
        }

        public double Result(double x)// метод вычисления значения функции при заданном значении переменной
        {
            return a * Math.Pow(x, m) + b * Math.Pow(x, n) + c * Math.Pow(x, k) + d;
        }
        public void Output()//вывод функции
        {
            Console.WriteLine("Функция: " + function);
        }
        public void DifferentialOutput()//вывод дифференциала
        {
            Console.WriteLine("d({0}) = {1}", function, Differential());
        }
    }
}
