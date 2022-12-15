namespace L3T3
{
    class L3T3
    {
        static void Main()
        {
            string password = "masha";
            int password1 = password.Length;

            Console.WriteLine("Введите пароль");
            string pass = Console.ReadLine();
            if (password1 > pass.Length && password!= pass)
            {
                Console.WriteLine("Пароль неверный, возможно строка слишком короткая");
            }
            else if (password1 == pass.Length && password == pass)
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