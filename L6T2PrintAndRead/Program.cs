namespace L6T2PrintAndRead
{
    class Program
    {
        public static void Main()
        {
            int a = PrintAndRead("Введите первое число: ");
            int b = PrintAndRead("Введите второе число: ");
            int c = PrintAndRead("Введите третье число: ");

            Console.WriteLine("Введеные числа это - {0}, {1}, {2}", a, b, c);
        }

        public static int PrintAndRead(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}