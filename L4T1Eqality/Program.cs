namespace Test
{
    class Test
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1.0e-10;

            if (Math.Abs(a - b) <= epsilon)
            {
                Console.WriteLine("Они равны");
            }
            else
            {
                Console.WriteLine("Они не равны");
            }
        }
    }
}