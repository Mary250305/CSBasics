namespace L2T2Circle
{
    class Program
    {
        static void Main()
        {
            double radius = 4;
            double square = Math.Pow(radius, 2) * Math.PI;
            double length = 2 * Math.PI * radius;
            Console.WriteLine("Площадь круга " + Math.Round(square) + Environment.NewLine + "Длина окружности " + Math.Round(length));

           /* double square = 50;
            double radius = Math.Sqrt(square / Math.PI);
            Console.WriteLine("Радиус круга " + Math.Round(radius));

            double radius = 4;
            double degree = 40;
            double s = Math.Round(Math.PI * Math.Pow(radius, 2));
            double sektor = Math.PI * Math.Pow(radius, 2) * (degree / 360);
            Console.WriteLine("Сектор круга " + Math.Round(sektor));*/
        }
    }
}