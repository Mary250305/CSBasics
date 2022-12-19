namespace L3T3Password
{
    class Program
    {
        static void Main()
        {
            string password = "masha";

            Console.WriteLine("Введите пароль");
            string enteringPassword = Console.ReadLine();

            int lenghtPassword = password.Length;

            if (password == enteringPassword)
            {
                Console.WriteLine("Пароль верный");
            }
            else if (enteringPassword.Length > lenghtPassword)
            {
                Console.WriteLine("Пароль неверный, возможно строка слишком длинная");
            }
            else if (enteringPassword.Length < lenghtPassword)
            {
                Console.WriteLine("Пароль неверный, возможно строка слишком короткая");
            }
            else
            {
                Console.WriteLine("Пароль не верный");
            }
        }
    }
}