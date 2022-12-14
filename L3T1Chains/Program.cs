
namespace L3T1
{
    class L3T1
    {
        [STAThread]
        static void Main()
        {
            int a = 6;
            if (a > 0)
            {
                Console.WriteLine("Положительное число");
            }
            else if (a == 0)
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