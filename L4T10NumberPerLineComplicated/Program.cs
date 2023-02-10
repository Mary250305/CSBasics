namespace L4T9NumberPerLineComplicated
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите начальное число: ");
            int initialNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное число диапазона: ");
            int finiteNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество строк: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            int i = initialNumber;

            while (i <= finiteNumber)
            {
                Console.Write(i.ToString().PadLeft(quantity));
                if (i % quantity == 0)
                {
                    Console.WriteLine();
                }
                i += 1;
            }
        }
    }
}