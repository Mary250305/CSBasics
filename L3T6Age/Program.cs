namespace L3T6
{
    class L3T6
    {
        static void Main()
        {
            Console.WriteLine("Введите свой возраст ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 1)
            {
                Console.WriteLine("Вы слишком малы");
            }
            else if (age > 112)
            {
                Console.WriteLine("Вы слишком стары");
            }

            while (1<age<112);
            if (age % 10 == 1)
            {
                Console.WriteLine("Вам " + age + " год");
            }
            else if ((age % 10 == 2) || (age % 10 == 3) || (age % 10 == 4))
            {
                Console.WriteLine("Вам " + age + " года");
            }
            else if ((age % 10 == 5) || (age % 10 == 6) || (age % 10 == 7) || (age % 10 == 8) || (age % 10 == 9) || (age % 10 == 0))
            {
                Console.WriteLine("Вам " + age + " лет");
            }
        }
    }
}

 