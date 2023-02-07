namespace L3T5TriangleArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координаты точек для нахождения по ним площади треугольника");
            Console.WriteLine();

            Console.Write("Введите координату х1: ");
            int coordinateX1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату у1: ");
            int coordinateY1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату х2: ");
            int coordinateX2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату у2: ");
            int coordinateY2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату х3: ");
            int coordinateX3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату у3: ");
            int coordinateY3 = Convert.ToInt32(Console.ReadLine());

            int pointCoordinateX1 = coordinateX2 - coordinateX1;
            int pointCoordinateY1 = coordinateY2 - coordinateY1;

            int pointCoordinateX2 = coordinateX3 - coordinateX2;
            int pointCoordinateY2 = coordinateY3 - coordinateY2;

            int pointCoordinateX3 = coordinateX1 - coordinateX3;
            int pointCoordinateY3 = coordinateY1 - coordinateY3;

            double segmentAB = Math.Sqrt(Math.Pow(pointCoordinateX1, 2) + Math.Pow(pointCoordinateY1, 2));
            double segmentBC = Math.Sqrt(Math.Pow(pointCoordinateX2, 2) + Math.Pow(pointCoordinateY2, 2));
            double segmentCA = Math.Sqrt(Math.Pow(pointCoordinateX3, 2) + Math.Pow(pointCoordinateY3, 2));

            double xPartCheckBeOnLine = (coordinateX3 - coordinateX1) / (coordinateX2 - coordinateX1);
            double yPartCheckBeOnLine = (coordinateY3 - coordinateY1) / (coordinateY2 - coordinateY1);

            if (xPartCheckBeOnLine == yPartCheckBeOnLine)
            {
                Console.WriteLine("Площадь вычислять не нужно");
            }            
            else
            {
                double halfMeter = (segmentAB + segmentBC + segmentCA) / 2;
                double square = Math.Sqrt(halfMeter * (halfMeter - segmentAB) * (halfMeter - segmentBC) * (halfMeter - segmentCA));
                Console.WriteLine("Площадь треугольника = " + Math.Round(square));
            }
        }
    }
}