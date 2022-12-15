
namespace L3T1
{
    class L3T1
    {
        static void Main()
        {
            Console.WriteLine("Введите число ");
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