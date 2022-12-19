namespace L3T6Equation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Решение квадратного уравнения вида: ax^2 + bx + c");
            Console.WriteLine();

            Console.Write("Введите а: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите с: ");
            int numberC = Convert.ToInt32(Console.ReadLine());

            int discriminant = (int) Math.Pow(numberB, 2) - 4 * numberA * numberC;

            if (numberA > 0 || numberB > 0 || numberC > 0)
            {
                if (discriminant>0)
                {
                    double root1 = (-numberB + Math.Sqrt(discriminant)) / (2 * numberA);
                    double root2 = (-numberB - Math.Sqrt(discriminant)) / (2 * numberA);
                    Console.WriteLine(Math.Round(root1));
                    Console.WriteLine(Math.Round(root2));
                }
                else if (discriminant==0)
                {
                    double root = (-numberB) / (2 * numberA);
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