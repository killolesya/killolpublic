using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentialWithForms
{
    class TrigonometricFunction
    {
        int function_number;
        string function;
        public string Function
        {
            get { return function; }
        }

        public TrigonometricFunction() { }
        public TrigonometricFunction(int function_number)
        {
            const string sin = "sin(x)";
            const string cos = "cos(x)";
            const string tg = "tg(x)";
            const string ctg = "ctg(x)";

            this.function_number = function_number;
            switch (function_number)
            {
                case 1: function = sin; break;
                case 2: function = cos; break;
                case 3: function = tg; break;
                case 4: function = ctg; break;
                default: Console.WriteLine("Номер функции указан неверно."); break;
            }
        }

        public TrigonometricFunction Input()
        {
            Console.WriteLine("Выберите тригонометрическую функцию для дифференцирования: \n1 - sin(x); 2 - cos(x); 3 - tg(x); 4 - ctg(x);");
            function_number = int.Parse(Console.ReadLine());
            return new TrigonometricFunction(function_number);
        }

        public string Differential()
        {
            const string sin_differential = "cos(x)dx";
            const string cos_differential = "-sin(x)dx";
            const string tg_differential = "dx/(cos^2(x))";
            const string ctg_differential = "-dx/(sin^2(x))";

            string differential = null;
            switch (function_number)
            {
                case 1: differential = sin_differential; break;
                case 2: differential = cos_differential; break;
                case 3: differential = tg_differential; break;
                case 4: differential = ctg_differential; break;
                default: Console.WriteLine("Номер функции указан неверно."); break;
            }
            return differential;
        }

        public void Output()
        {
            Console.WriteLine("Функция: " + function);
        }
        public void DifferentialOutput()
        {
            Console.WriteLine("d({0}) = {1}", function, Differential());
        }
    }
}
