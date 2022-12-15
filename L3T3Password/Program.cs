namespace L3T3
{
    class L3T3
    {
        static void Main()
        {
            string password = "masha";
            int password1 = password.Length;

            Console.WriteLine("Введите пароль");
            string parol = Console.ReadLine();
            if (password1 > parol.Length && password!= parol)
            {
                Console.WriteLine("Пароль неверный, возможно строка слишком короткая");
            }
            else if (password1 == parol.Length && password == parol)
            {
                Console.WriteLine("Пароль верный");
            }
            else
            {
                Console.WriteLine("Пароль неверный, возможно строка слишком длинная");
            }
        }
    }
}