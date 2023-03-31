namespace L5T8Table
{
    class Program
    {
        static void Main()
        {
            Console.Write("До какого числа вывести таблицу: ");
            int number = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine(string.Empty.PadLeft(number*10, '-'));

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    int result = i * j;
                    Console.Write(result.ToString().PadRight(10));
                }
                Console.WriteLine();
                Console.WriteLine(string.Empty.PadLeft(number * 10, '-'));
            }
        }
    }
}