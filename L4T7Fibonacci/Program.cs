namespace L4T7Fibonacci
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int f0 = 0;
            int f1 = 1;
            int fibonacci = 0;
            int i = 2;

            if (number == 0)
            {
                fibonacci = 0;
            }
            else if (number == 1)
            {
                fibonacci = 1;
            }
            else
            {
                while (i <= number)
                {
                    fibonacci = f0 + f1;
                    f0 = f1;
                    f1 = fibonacci;
                    i += 1;
                }
            }
            Console.WriteLine("Число Фибаначчи под номером {1} = {0} ", fibonacci, number);
        }
    }
}