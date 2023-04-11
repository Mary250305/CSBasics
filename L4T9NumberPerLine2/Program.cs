namespace L4T9NumberPerLine2
{
    class Program
    {
        static void Main()
        {
            Console.Write("От какого числа вывести таблицу: ");
            int initialNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("До какого числа вывести таблицу: ");
            int finiteNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какое количество чисел в одной стрке: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (initialNumber <= finiteNumber)
            {
                Console.Write(initialNumber.ToString().PadLeft(10));
                if (initialNumber % number == 0)
                {
                    Console.WriteLine();
                }
                initialNumber += 1;
            }
        }
    }
}