using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // программа создает матрицу случайных чисел
            // числа в диапазоне от 0 до 100, не включая 100

            Console.Write("Введите количество строк матрицы: ");
            int lines = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов матрицы: ");
            int colums = int.Parse(Console.ReadLine());

            int[,] matrix = new int[lines, colums];
            Random rand = new Random();

            int sum = 0;

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matrix[i, j] = rand.Next(100);
                    Console.Write($"{matrix[i, j]} ");
                    sum += matrix[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма элементов матрицы: {0}", sum);
            Console.ReadLine();
        }
    }
}
