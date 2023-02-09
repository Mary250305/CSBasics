namespace L4T5ArithmeticMean
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

            while (i <= finiteNumber)
            {
                sum += i;
                quantity += 1;
                i += 1;

            }
            double arithmeticMean = (double)sum / quantity;
            Console.WriteLine("Среднее арефмитическое = " + arithmeticMean);

            i = initialNumber;
            int sumEvnNumber = 0;
            int quantityEvenNumber = 0;
            while (i <= finiteNumber)
            {
                if (i % 2 == 0)
                {
                    sumEvnNumber += i;
                    quantityEvenNumber += 1;
                }
                i += 1;
            }

            double arithmeticMeanEvenNumber = (double) sumEvnNumber / quantityEvenNumber;
            Console.WriteLine("Среднее арефмитическое четных чисел = " + arithmeticMeanEvenNumber);
        }
    }
}