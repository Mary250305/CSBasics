namespace L4T3Switch
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите команду от 1 до 4 включительно: ");
            double command = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            switch (command)
            {
                case 1:
                    double summa = number1 + number2;
                    Console.WriteLine("Сумма = " + summa);
                    break;
                case 2:
                    double subtraction = number1 - number2;
                    Console.WriteLine("Вычитание чисел = " + subtraction);
                    break;
                case 3:
                    double multiplication = number1 * number2;
                    Console.WriteLine("Умножение чисел = " + multiplication);
                    break;
                case 4:
                    double division = number1 / number2;
                    Console.WriteLine("Деление чисел = " + division);
                    break;
                default:
                    Console.WriteLine("Такой команды не существует");
                    break;
            }
        }
    }
}