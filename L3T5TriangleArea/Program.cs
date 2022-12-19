namespace L3T5TriangleArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координаты точек для нахождения по ним площади треугольника");
            Console.WriteLine();

            Console.Write("Введите координату х1: ");
            int coordinatex1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату у1: ");
            int coordinatey1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату х2: ");
            int coordinatex2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату у2: ");
            int coordinatey2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату х3: ");
            int coordinatex3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату у3: ");
            int coordinatey3 = Convert.ToInt32(Console.ReadLine());

            int pointCoordinateX1 = coordinatex2 - coordinatex1;
            int pointCoordinateY1 = coordinatey2 - coordinatey1;
            int pointCoordinateX2 = coordinatex3 - coordinatex2;
            int pointCoordinateY2 = coordinatey3 - coordinatey2;
            int pointCoordinateX3 = coordinatex1 - coordinatex3;
            int pointCoordinateY3 = coordinatey1 - coordinatey3;

            int segmentAB = (int)Math.Sqrt(Math.Pow(pointCoordinateX1, 2) + Math.Pow(pointCoordinateY1, 2));
            int segmentBC = (int)Math.Sqrt(Math.Pow(pointCoordinateX2, 2) + Math.Pow(pointCoordinateY2, 2));
            int segmentCA = (int)Math.Sqrt(Math.Pow(pointCoordinateX3, 2) + Math.Pow(pointCoordinateY3, 2));


            if ((coordinatex3 - coordinatex1) / (coordinatex2 - coordinatex1) == (coordinatey3 - coordinatey1) / (coordinatey2 - coordinatey1))
            {
                Console.WriteLine("Площадь вычислять не нужно");

            }            
            else
            {
                int halfMeter = (segmentAB + segmentBC + segmentCA) / 2;
                double square = Math.Sqrt(halfMeter * (halfMeter - segmentAB) * (halfMeter - segmentBC) * (halfMeter - segmentCA));
                Console.WriteLine("Площадь треугольника = " + Math.Round(square));
            }
        }
    }
}