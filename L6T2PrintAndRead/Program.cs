namespace L6T2PrintAndRead
{
    class Program
    {
        public static void Main()
        {
            int a = PrintAndRead("Введите первое число: ");
            int b = PrintAndRead("Введите второе число: ");
            int c = PrintAndRead("Введите третье число: ");
        }

        public static int PrintAndRead(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
    }
}