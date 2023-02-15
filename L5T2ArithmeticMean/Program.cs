namespace L5T2ArithmeticMean
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

            for (int i = initialNumber; i <= finiteNumber; i++) 
            {
                sum += i;
                quantity += 1;
            }
            double arithmeticMean = (double)sum / quantity;
            Console.WriteLine("Среднее арефмитическое = " + arithmeticMean);

            int sumEvnNumber = 0;
            int quantityEvenNumber = 0;

            for (int j = initialNumber; j <= finiteNumber; j++)
            {
                if (j % 2 == 0)
                {
                    sumEvnNumber += j;
                    quantityEvenNumber += 1;
                }
            }

            double arithmeticMeanEvenNumber = (double)sumEvnNumber / quantityEvenNumber;
            Console.WriteLine("Среднее арефмитическое четных чисел = " + arithmeticMeanEvenNumber);
        }
    }
}