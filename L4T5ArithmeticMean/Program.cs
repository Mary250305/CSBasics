namespace L4T5ArithmeticMean
{
    class Program
    {
        static void Main()
        {
            int i = 3;
            int sum = 3;
            int quantity = 0;

            while (i < 5)
            {
                sum += i;
                quantity += 1;
                i += 1;
                Console.WriteLine(sum);
            }

            double arithmeticMean = sum / quantity;
            Console.WriteLine(arithmeticMean);
        }
    }
}