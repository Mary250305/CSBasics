namespace L4T4Sum
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            int sum = 0;
            while (i < 10)
            {
                sum += i;
                i += 1;
            }
            Console.WriteLine("Сумма чисел от 0 до 9 = " + sum);

            Console.WriteLine();

            i = 3;
            int sum1 = 3;
            while (i < 22)
            {
                sum1 += i;
                i += 1;
            }
            Console.WriteLine("Сумма чисел от 3 до 21 включительно =  " + sum1);

            Console.WriteLine();

            i = 3;
            int sum2 = 3;
            while (i < 22)
            {
                if (i % 2 == 0)
                {
                    sum2 += i;
                }
                i += 1;
            }
            Console.WriteLine("Сумма четных чисел от 3 до 21 включительно = " + sum2);

            Console.WriteLine();

            i = 3;
            int sum3 = 3;
            int evenNumbers = 0;
            while (i < 22)
            {
                if (i % 2 == 0)
                {
                    sum3 += i;
                    evenNumbers += 1;
                }
                i += 1;
            }
            Console.WriteLine("Сумма чисел от 3 до 21 включительно = {0} , кол-во четных чисел = {1}",sum3,evenNumbers);
        }
    }
}