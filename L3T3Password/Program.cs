namespace L3T3
{
    class L3T3
    {
        static void Main()
        {
            string password = "Masha";
            int pw = password.Length;
            string parol = "Mariya";
            if (pw> parol.Length)
            {
                Console.WriteLine("Пароль неверный строка слишком короткая");
            }
            else if (pw == parol.Length)
            {
                Console.WriteLine("Пароль верный");
            }
            else
            {
                Console.WriteLine("Пароль неверный строка слишком длинная");
            }
        }
    }
}