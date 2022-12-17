namespace L3T1Chains
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Положительное число");
            }
            else if (number == 0)
            {
                Console.WriteLine("Число = 0");
            }
            else
            {
                Console.WriteLine("Отрицательное число");
            }
        }
    }
}