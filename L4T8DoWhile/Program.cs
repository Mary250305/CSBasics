namespace L4T8DoWhile
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число диапазона: ");
            int initialNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное число диапазона: ");
            int finiteNumber = Convert.ToInt32(Console.ReadLine());

            int quantity = 0;
            int sum = 0;
            int i = initialNumber;

            do
            {
                sum += i;
                quantity += 1;
                i += 1;
            }
            while (i <= finiteNumber);

            double arithmeticMean = (double)sum / quantity;
            Console.WriteLine("Среднее арефмитическое = " + arithmeticMean);
        }
    }
}