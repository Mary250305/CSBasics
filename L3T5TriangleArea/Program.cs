namespace L3T5TriangleArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координаты точек");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());

            int X1 = x2 - x1;
            int Y1 = y2 - y1;
            int X2 = x3 - x2;
            int Y2 = y3 - y2;
            int X3 = x1 - x3;
            int Y3 = y1 - y3;

            int AB = (int)Math.Sqrt(Math.Pow(X1, 2) + Math.Pow(Y1, 2));
            int BC = (int)Math.Sqrt(Math.Pow(X2, 2) + Math.Pow(Y2, 2));
            int CA = (int)Math.Sqrt(Math.Pow(X3, 2) + Math.Pow(Y3, 2));


            if ((x3 - x1) / (x2 - x1) == (y3 - y1) / (y2 - y1))
            {
                Console.WriteLine("Площадь вычислять не нужно");

            }            
            else
            {
                int halfMeter = (AB + BC + CA) / 2;
                double square = Math.Sqrt(halfMeter * (halfMeter - AB) * (halfMeter - BC) * (halfMeter - CA));
                Console.WriteLine("Площадь треугольника = " + Math.Round(square));
            }
        }
    }
}