namespace L4T4Sum
{
    class Program
    {
        static void Main()
        {
            /*int i = 0;
            int sum = 0;
            while (i < 10)
            {
                sum += i;
                i += 1;
            }
            Console.WriteLine(sum);*/

            /*int i = 3;
            int sum = 3;
            while (i < 22)
            {
                sum += i;
                i += 1;
            }
            Console.WriteLine(sum);*/

            /*int i = 3;
            int sum = 3;
            while (i < 22)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                i += 1;
            }
            Console.WriteLine(sum);*/

            int i = 3;
            int sum = 3;
            int evenNumbers = 0;
            while (i < 22)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    evenNumbers += 1;
                }
                i += 1;
            }
            Console.WriteLine(sum);
            Console.WriteLine("Кол-во четных чисел = " + evenNumbers);
        }
    }
}