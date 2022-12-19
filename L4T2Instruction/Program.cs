namespace L4T2Instruction
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите команду: ");
            string command = Console.ReadLine();

            switch (command)
            {
                case "print":
                    Console.Write("Введите слово ");
                    string command1 = Console.ReadLine();
                    Console.WriteLine(command1);
                    break;
                case "sum":
                    Console.WriteLine("Введите первое вещественное число:");
                    double number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе вещественное число:");
                    double number2 = Convert.ToDouble(Console.ReadLine());

                    double summa = number1 + number2;
                    Console.WriteLine("Сумма = " + summa);
                    break;
                default:
                    Console.WriteLine("Это неизвестная команда");
                    break;
            }
        }
    }
}