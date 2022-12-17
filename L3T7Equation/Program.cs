namespace L3T6Equation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Решение квадратного уравнения вида: ax^2 + bx + c");
            Console.WriteLine();

            Console.Write("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите с: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int D = (int) Math.Pow(b, 2) - 4 * a * c;

            if (a > 0 || b > 0 || c > 0)
            {
                if (D>0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine(Math.Round(x1));
                    Console.WriteLine(Math.Round(x2));
                }
                else if (D==0)
                {
                    double x = (-b) / (2 * a);
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine("Корней нет");
                }
            }
            else
            {
                Console.WriteLine("Уравнение не имеет значеня");
            }
            
        }
    }
}