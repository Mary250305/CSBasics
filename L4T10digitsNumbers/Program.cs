namespace L4T10digitsNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int sum1 = 0;
            int max = 0;

            while (number != 0)
            {
                sum += number % 10;

                if (number % 2 != 0)
                {
                    sum1 += number % 10;
                }

                max = Math.Max(max, number % 10);
                number /= 10;
            }

            Console.WriteLine("Сумма цифр = {0}", sum);
            Console.WriteLine("Сумма нечетных цифр = {0}", sum1);
            Console.WriteLine("Максимальная цифра числа: {0}",max);
        }
    }
}