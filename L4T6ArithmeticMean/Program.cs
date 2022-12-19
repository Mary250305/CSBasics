namespace L4T5ArithmeticMean
{
    class Program
    {
        static void Main()
        {
            int i = 3;
            int sum = 3;
            int quantity = 0;

            do
            {
                sum += i;
                quantity += 1;
                i += 1;
            }
            while (i < 54);

            double arithmeticMean = sum / quantity;
            Console.WriteLine(Math.Round(arithmeticMean));
        }
    }
}