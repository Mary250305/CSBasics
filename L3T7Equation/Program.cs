namespace L3T6Equation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Решение квадратного уравнения вида: ax^2 + bx + c");
            Console.WriteLine();

            Console.Write("Введите а: ");
            double numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            double numberB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите с: ");
            double numberC = Convert.ToInt32(Console.ReadLine());

            double discriminant = Math.Pow(numberB, 2) - 4 * numberA * numberC;

            double epsilon = 1.0e-10;

            if (numberA == 0)
            {
                if (numberB == 0 && numberC == 0)
                {
                    Console.WriteLine("x может быть любым числом");
                }
                else if (numberB == 0)
                {
                    Console.WriteLine("Нет корней");
                }
                else
                {
                    double x = -numberC / numberB;
                    Console.WriteLine("x = " + x);
                }
            }
            else if (discriminant > 0)
            {
                double rootEquation1 = (-numberB + Math.Sqrt(discriminant)) / (2 * numberA);
                double rootEquation2 = (-numberB - Math.Sqrt(discriminant)) / (2 * numberA);
                Console.WriteLine("x1 = " + rootEquation1 + ", x2 = " + rootEquation2);
            }
            else if (discriminant == 0)
            {
                double rootEquation = -numberB / (2 * numberA);
                Console.WriteLine("x = " + rootEquation);
            }
            else
            {
                Console.WriteLine("Нет корней");
            }
        }
    }
}