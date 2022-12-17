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

            int discriminant = (int) Math.Pow(b, 2) - 4 * a * c;

            if (a > 0 || b > 0 || c > 0)
            {
                if (discriminant>0)
                {
                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine(Math.Round(root1));
                    Console.WriteLine(Math.Round(root2));
                }

                else if (discriminant==0)
                {
                    double root = (-b) / (2 * a);
                    Console.WriteLine(root);
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