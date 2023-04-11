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
            double decision1 = 0;
            double decision2 = 0;

            double discriminant = Math.Pow(numberB, 2) - 4 * numberA * numberC;

            if (discriminant > 0 || discriminant == 0)
            {
                decision1 = (-numberB + Math.Sqrt(discriminant)) / (2 * numberA);
                decision2 = (-numberB - Math.Sqrt(discriminant)) / (2 * numberA);
                Console.WriteLine("x1= {0}\n x2= {1}", decision1, decision2);
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
            }
        }
    }
}