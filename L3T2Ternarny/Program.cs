namespace L3T2Ternarny
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int max = (a > b) ? a : b;
            int min = (a < b) ? a : b;

            Console.WriteLine("Максимальное = {0}", max);
            Console.WriteLine("Минимальное = {0} ", min);
        }
    }
}