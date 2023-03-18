using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace L5T8Table
{
    class Program
    {
        static void Main()
        {
            Console.Write("До какого числа вывести таблицу: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            Console.WriteLine(string.Empty.PadLeft(number*10, '-'));

            for (int i = 1; i <= number; i++)
            {
                if (i % (number + 1) == 0)
                {
                    Console.WriteLine();
                }

                for (int j = 1; j <= number; j++)
                {
                    result = i * j;

                    if ((i * j) % (number + 1) == 0)
                    {
                        Console.WriteLine();
                    }
                    
                    Console.Write(result.ToString().PadRight(10));
                }

                Console.Write(i.ToString().PadLeft(10));
                Console.WriteLine();
            }

            Console.WriteLine();
           /*for (int k = 1; k <= number; k++)
            {
                Console.WriteLine(" " + k.ToString().PadLeft('|'));
            }*/
            Console.WriteLine(string.Empty.PadLeft(number*10, '-'));
        }
    }
}