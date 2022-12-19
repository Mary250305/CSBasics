namespace L3T8Date
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введие день: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введение год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (day < 32 && month < 12)
            {
                if (day == 30 && (month == 4 || month == 6 || month == 9 || month == 11))
                {
                    month = month + 1;
                    day = 1;
                    Console.WriteLine(day + "." + month + "." + year);
                }
                else if (day == 28 && month == 2)
                {
                    month = month + 1;
                    day = 1;
                    Console.WriteLine(day + "." + month + "." + year);
                }
                else if (day == 31 && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10))
                {
                    month = month + 1;
                    day = 1;
                    Console.WriteLine(day + "." + month + "." + year);
                }
                else if (day < 30 && (month == 4 || month == 6 || month == 9 || month == 11))
                {
                    day = day + 1;
                    Console.WriteLine(day + "." + month + "." + year);
                }
                else if (day < 31 && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10))
                {
                    day = day + 1;
                    Console.WriteLine(day + "." + month + "." + year);
                }
            }
            else if (day == 31 && month == 12)
            {
                month = 1;
                day = 1;
                year = year + 1;
                Console.WriteLine(day + "." + month + "." + year);
            }
            else if (day > 32 || month > 12)
            {
                Console.WriteLine("Дата не корректна");
            }
        }
    }
}