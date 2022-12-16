using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // программа создает 2 матрицы случайных чисел
            // числа в диапазоне от 0 до 10, не включая 10
            // складывает 2 матрицы и выводит на экрвн полученную матрицу

            Console.Write("Введите количество строк матрицы: ");
            int lines = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            int colums = int.Parse(Console.ReadLine());

            int[,] A = new int[lines, colums];
            int[,] B = new int[lines, colums];
            int[,] C = new int[lines, colums];
            Random r = new Random();

            Console.WriteLine("Первая матрица: ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = r.Next(10);
                    Console.Write($"{A[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Вторая матрица: ");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = r.Next(10);
                    Console.Write($"{B[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма первой и второй матриц: ");
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write($"{C[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
