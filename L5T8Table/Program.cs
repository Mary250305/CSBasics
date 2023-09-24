﻿namespace L5T8Table
{
    class Program
    {
        static void Main()
        {
            Console.Write("До какого числа вывести таблицу: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("   | ");

            for (int i = 1; i <= number; i++)
            {
                Console.Write(i.ToString().PadRight(4, ' '));
            }

            Console.WriteLine("");
            Console.Write("---+");

            for(int i = 0; i < number; i++)
            {
                Console.Write("----");
            }

            Console.WriteLine();

            for (int i = 1; i <= number; i++)
            {
                Console.Write(" ");
                Console.Write(i.ToString().PadRight(2, ' '));
                Console.Write("| ");

                for (int j = 1; j <= number; j++)
                {
                    int result = i * j;
                    Console.Write(result.ToString().PadRight(4, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}