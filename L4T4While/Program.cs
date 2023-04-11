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
            Console.WriteLine(sum);

            Console.WriteLine();

            int j = 3;
            int sum1 = 3;
            while (j < 22)
            {
                sum1 += j;
                j += 1;
            }
            Console.WriteLine(sum1);

            Console.WriteLine();

            int k = 3;
            int sum2 = 3;
            while (k < 22)
            {
                if (k % 2 == 0)
                {
                    sum2 += k;
                }
                k += 1;
            }
            Console.WriteLine(sum2);

            Console.WriteLine();

            int m = 3;
            int sum3 = 3;
            int evenNumbers = 0;
            while (m < 22)
            {
                if (m % 2 == 0)
                {
                    sum3 += m;
                    evenNumbers += 1;
                }
                m += 1;
            }
            Console.WriteLine(sum3);
            Console.WriteLine("Кол-во четных чисел = " + evenNumbers);
        }
    }
}