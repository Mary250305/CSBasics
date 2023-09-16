namespace L3T5TriangleArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Находим площадь треугольника по координатам");
            Console.WriteLine();

            Console.WriteLine("Введите координаты точки A:");
            double coordinateX1 = Convert.ToDouble(Console.ReadLine());
            double coordinateY1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки B:");
            double coordinateX2 = Convert.ToDouble(Console.ReadLine());
            double coordinateY2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки C:");
            double coordinateX3 = Convert.ToDouble(Console.ReadLine());
            double coordinateY3 = Convert.ToDouble(Console.ReadLine());

            double sectionA = Math.Sqrt(Math.Pow(coordinateX2 - coordinateX1, 2) + Math.Pow(coordinateY2 - coordinateY1, 2));
            double sectionB = Math.Sqrt(Math.Pow(coordinateX3 - coordinateX2, 2) + Math.Pow(coordinateY3 - coordinateY2, 2));
            double sectionC = Math.Sqrt(Math.Pow(coordinateX1 - coordinateX3, 2) + Math.Pow(coordinateY1 - coordinateY3, 2));

            if ((coordinateX3 - coordinateX1) / (coordinateX2 - coordinateX1) == (coordinateY3 - coordinateY1) / (coordinateY2 - coordinateY1))
            {
                Console.WriteLine("Точки лежат на одной прямой, площадь вычислять не нужно.");
            }
            else
            {
                double halfMeter = (sectionA + sectionB + sectionC) / 2;
                double square = Math.Sqrt(halfMeter * (halfMeter - sectionA) * (halfMeter - sectionB) * (halfMeter - sectionC));
                Console.WriteLine("Площадь треугольника: " + Math.Round(square));
            }
        }
    }
}