namespace L3T2
{
    class L3T2
    {
        static void Main()
        {
            Console.WriteLine("Введите число а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            int max = (a > b) ? a : b;
            int min = (a < b) ? a : b;
            Console.WriteLine("Максимальное " + max);
            Console.WriteLine("Минимальное " + min);
        }
    }
}