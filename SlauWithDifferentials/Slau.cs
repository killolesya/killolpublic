using System;
using System.Collections.Generic;
using System.Text;

namespace SlauWithDifferetials
{
    class Slau
    {
        int m;         // количество уравнений
        int n;         // количество переменных
        Matrix a;      // матрица коэффициентов
        Matrix b;      // вектор правой части
        Matrix x;      // вектор решений
        bool isSolved; // признак совместности
        int[] reoder; // перестановка переменных,
                      // полученная в методе Жордана-Гаусса
        int rang;      // ранг матрицы коэффициентов

        // конструктор
        public Slau(int m1, int n1)
        {
            m = m1;     // инициализация количества уравнений
            n = n1;     // инициализация количества переменных
            // выделение памяти под матрицу коэффициентов
            a = new Matrix(m1, n1);
            // выделение памяти под вектор свободных членов
            b = new Matrix(1, m1);
            // выделение памяти под вектор-решения
            x = new Matrix(1, n1);
            // выделение памяти и заполнение массива
            // для хранения перестановки переменных
            reoder = new int[n];
            for (int i = 0; i < n; i++)
                reoder[i] = i;
        }


        // метод ввода системы уравнения
       public void Input()
        {
            Console.WriteLine("Матрица коэффициентов (элементы матрицы - значения дифференциалов функций при заданных значениях переменной): ");
            a.InputMatrix();
            Console.WriteLine("Вектор свободных членов (элементы матрицы - значения дифференциалов функций при заданных значениях переменной): ");
            b.InputMatrix();
        }

        public void SelfInput()// метод ввода системы с консоли
        {
            Console.WriteLine("Матрица коэффициентов: ");
            a.SelfInputMatrix();
            Console.WriteLine("Вектор свободных членов: ");
            b.SelfInputMatrix();
        }

        public void SelfInputSlauDif()// метод ввода системы с коэффициентами-значениями дифференциалов
        {
            Console.WriteLine("Матрица коэффициентов: ");
            a.SelfInputMatrixDif();
            Console.WriteLine("Вектор свободных членов: ");
            b.SelfInputMatrixDif();
        }
        // метод вывода системы уравнения и ее решения
        public void Print()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("" + a[i, j] + "\t");
                Console.WriteLine("\t" + b[0, i]);
            }
            try
            {
                Console.WriteLine("Решение СЛАУ: ");
                PrintSolution();
            }
            catch (Exception e)
            {
                // печать возможной ошибки
                Console.WriteLine(e.Message);
            }
        }

        // метод вывода полученного решения
        public void PrintSolution()
        {
            if (!isSolved)
            {
                Console.WriteLine("Система несовместна");
                return;
            }
            if (rang < n)
            {
                // будет получено общее решение системы
                for (int i = 0; i < rang; i++)
                {
                    Console.Write("x" + (reoder[i] + 1) + " = " + x[i, 0]);
                    for (int j = 1; j <= n - rang; j++)
                    {
                        if (x[i, j] == 0)
                            continue;
                        if (x[i, j] > 0)
                            Console.Write("+" + x[i, j] + "*x" + (reoder[rang + j - 1] + 1));
                        else
                            Console.Write("" + x[i, j] + "*x" + (reoder[rang + j - 1] + 1));
                    }
                    Console.WriteLine();
                }
            }
            else
            {

                // получен единственный вектор решений
                Console.Write("(");
                for (int i = 0; i < n - 1; i++)
                    Console.Write("" + x[0, i] + ", ");
                Console.WriteLine("" + x[0, n - 1] + ")");
            }
        }


        // выбор метода осуществляется функцией Solve
        // метод Solve - выбор метода решения линейного уравнения
        public void Solve()
        {

            if (m == n)
                try
                {
                    // матрица коэффициентов квадратная –
                    // предоставляется выбор метода решения
                    // пользователю
                    Console.WriteLine("Метод Крамера - 1, С помощью обратной матрицы - 2");

                    int i = int.Parse(Console.ReadLine());
                    if (i == 1)
                        Kramer();
                    else
                        InverseMatrix();
                }
                catch (Exception e)
                {
                    // генерация исключения происходит при
                    // равенстве нулю определителя матрицы
                    // коэффициентов. Поэтому осуществляется получение
                    // общего решения системы
                    JordanGauss();
                }
            else
                // СЛАУ с прямоугольной матрицей коэффициентов
                // решается методом Жордана-Гаусса для получения
                // общего решения
                JordanGauss();
        }

        public void Kramer()// метод Крамера
        {
            // проверка, является ли матрица прямоугольной
            if (m != n)
                throw new Exception("Матрица не является квадратной");
            double det = a.Determinant(); // вычисление определителя
                                          // матрицы коэффициентов
                                          // проверка определенности системы
            if (det == 0)
                throw new Exception("Деление на 0");

            rang = m;
            // вычисление корней по формулам Крамера
            Matrix temp = a.Copy();
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                    temp[i, j] = b[0, i];
                x[0, j] = temp.Determinant() / det;
                for (int i = 0; i < n; i++)
                    temp[i, j] = a[i, j];
            }
            isSolved = true;
        }

        public void InverseMatrix()//метод обратной матрицы
        {
            // проверка, является ли матрица прямоугольной
            if (m != n)
                throw new Exception("Матрица не является квадратной");
            // вычисление обратной матрицы
            Matrix obr = ~a;
            Matrix B = !b;
            // получение решения СЛАУ
            x = obr * B;
            x = !x;
            rang = m;
            isSolved = true;
        }

        public void JordanGauss()        // метод Жордана-Гаусса
        {
            // создание копий матрицы коэффициентов и свободных
            // членов для последующих преобразований
            Matrix A = a.Copy();
            Matrix B = b.Copy();
            int count_null_cols = 0;
            // проведение исключений по формулам Жордана-Гаусса
            for (int i = 0; i < m; i++)
            {
                // исключение по i-ой строке
                // проверка возможности исключения
                // по значению ведущего элемента
                if (A[i, i] != 0)
                {
                    // исключение во всех строках, кроме ведущей
                    for (int k = 0; k < m; k++)
                    {
                        if (k == i)
                            continue;
                        double d = A[k, i] / A[i, i];
                        for (int j = i; j < n; j++)
                            A[k, j] = A[k, j] - d * A[i, j];
                        B[0, k] = B[0, k] - d * B[0, i];
                    }
                    // преобразование ведущей строки
                    for (int j = i + 1; j < n; j++)
                        A[i, j] /= A[i, i];
                    // преобразование i-ого свободного члена
                    B[0, i] /= A[i, i];
                    A[i, i] = 1;
                }

                else
                {

                    // элемент главной диагонали
                    // в i-ой строке равен нулю
                    int k;
                    // поиск ненулевого элемента ниже
                    // в i-ом столбце
                    for (k = i + 1; k < m; k++)
                        if (A[k, i] != 0)
                            break;
                    if (k == m)
                    {
                        // все элементы столбца нулевые
                        if (i == n - 1 - count_null_cols)
                        {
                            // элементов, которые могут быть
                            // ведущими, больше нет
                            count_null_cols++;
                            break;
                        }
                        // меняем местами столбцы - текущий и
                        // последний из непросмотренных
                        for (int j = 0; j < m; j++)
                        {
                            double t = A[j, i];
                            A[j, i] = A[j, n - count_null_cols - 1];
                            A[j, n - count_null_cols - 1] = t;
                        }
                        // отражаем смену столбцов в перестановке
                        int te = reoder[i];
                        reoder[i] = reoder[n - count_null_cols - 1];
                        reoder[n - count_null_cols - 1] = te;
                        count_null_cols++;
                        // далее пытаемся провести исключения
                        // с той же строкой
                        i--;
                    }

                    else
                    {
                        // нашли в столбце элемент, который может
                        // быть ведущим - меняем местами строки
                        for (int l = 0; l < n; l++)
                        {
                            double t = A[i, l];
                            A[i, l] = A[k, l];
                            A[k, l] = t;
                        }
                        double p = B[0, i];
                        B[0, i] = B[0, k];
                        B[0, k] = p;
                        // далее пытаемся провести исключения
                        // с той же строкой
                        i--;
                    }
                }

            }
            // вычисление ранга матрицы после проведения исключения
            rang = m < n - count_null_cols ? m : n - count_null_cols;
            // подсчет количества нулевых строк матрицы
            int null_rows = m - rang;
            // проверка на несовместность системы, если в нулевой строке свободный член не равен 0
            for (int i = rang; i < m; i++)
                if (B[0, i] != 0)
                {
                    isSolved = false;
                    return;
                }
            // формирование общего решения для совместной слау путем переноса свободных переменных в правую часть
            Matrix res = new Matrix(rang, 1 + n - rang);
            for (int i = 0; i < rang; i++)
            {
                res[i, 0] = B[0, i];
                for (int j = rang; j < n; j++)
                    res[i, j - rang + 1] = -A[i, j];
            }
            x = res;
            isSolved = true;
       }
        

    }
}
