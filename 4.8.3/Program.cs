using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //программа эмитирует размножение бактерий в чашке Петри

            bool[,] cup = new bool[30, 30];
            Random r = new Random();

            for (int i = 0; i < cup.GetLength(0); i++)
            {
                for (int j = 0; j < cup.GetLength(1); j++)
                {
                    cup[i, j] = Convert.ToBoolean(r.Next(50));
                }
            }

            while (true)
            {
                Console.WriteLine("Жми Enter чтобы посмотреть за развитием жизни");

                for (int i = 0; i < cup.GetLength(0); i++)
                {
                    Console.Write("_");
                }
                Console.WriteLine();
                for (int i = 0; i < cup.GetLength(0); i++)
                {
                    for (int j = 0; j < cup.GetLength(1); j++)
                    {
                        if (cup[i, j])
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("X");
                        }
                    }
                    Console.WriteLine("|");
                }
                for (int i = 0; i < cup.GetLength(1); i++)
                {
                    Console.Write("_");
                }
                Console.Write("|");
                Console.ReadLine();
                Console.Clear();

                for (int i = 1; i < cup.GetLength(0) - 1; i++)
                {
                    for (int j = 1; j < cup.GetLength(1) - 1; j++)
                    {
                        if (cup[i, j] == false)
                        {
                            if (((cup[i, j] == cup[i, j + 1]) && (cup[i, j] == cup[i + 1, j]) && (cup[i, j] == cup[i + 1, j + 1])) ||
                                ((cup[i, j] == cup[i, j - 1]) && (cup[i, j] == cup[i - 1, j])) && (cup[i, j] == cup[i - 1, j - 1]))
                            {
                                cup[i, j] = true;
                            }
                            if (cup[i, j] != cup[i, j + 1])
                            {
                                cup[i, j + 1] = Convert.ToBoolean(r.Next(2));
                            }
                            if (cup[i, j] != cup[i + 1, j])
                            {
                                cup[i + 1, j] = Convert.ToBoolean(r.Next(2));
                                break;
                            }
                            if (cup[i, j] != cup[i + 1, j + 1])
                            {
                                cup[i + 1, j + 1] = Convert.ToBoolean(r.Next(4));
                            }
                            if (cup[i, j] != cup[i, j - 1])
                            {
                                cup[i, j - 1] = Convert.ToBoolean(r.Next(2));
                                break;
                            }
                            if (cup[i, j] != cup[i - 1, j])
                            {
                                cup[i - 1, j] = Convert.ToBoolean(r.Next(2));
                            }
                            if (cup[i, j] != cup[i - 1, j - 1])
                            {
                                cup[i - 1, j - 1] = Convert.ToBoolean(r.Next(4));
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
