namespace L3Y4
{
    class L3T4
    {
        static void Main()
        {
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 1)))
            {
                Console.WriteLine("Високосный год");
            }
            else
            {
                Console.WriteLine("Не високосный год");
            }
        }
    }
}