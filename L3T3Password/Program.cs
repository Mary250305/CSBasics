namespace L3T3
{
    class L3T3
    {
        static void Main()
        {
            string password = "masha";

            Console.WriteLine("Введите пароль");
            string enteringPassword = Console.ReadLine();

            int lenghtPassword = password.Length;

            if (lenghtPassword > enteringPassword.Length && password != enteringPassword)
            {
                Console.WriteLine("Пароль неверный, возможно строка слишком короткая");
            }
            else if (password == enteringPassword)
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