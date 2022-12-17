namespace L3T8
{
    class L3T8
    {
        static void Main()
        {
            Console.WriteLine("Введие день");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введение год");
            int year = Convert.ToInt32(Console.ReadLine());
            if (day < 32 && month < 13)
            {
                if (day> 31 && month <12)
                {
                    month = month + 1;
                    year = year + 1;
                    Console.WriteLine(day + "." + month + "." + year);
                }
            }
        }
    }
}