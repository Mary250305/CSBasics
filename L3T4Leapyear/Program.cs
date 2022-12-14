namespace L3Y4
{
    class L3T4
    {
        static void Main()
        {
            int year = 1675;
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