namespace L5T7Evklid
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            while (number2 != 0)
            {
                int result = number2;
                number2 = number1%number2;
                number1 = result;
            }
            Console.WriteLine("НОД = {0}", number1);
        }
    }
}