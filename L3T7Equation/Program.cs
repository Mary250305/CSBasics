using System.Security.Cryptography.X509Certificates;

namespace L3T6
{
    class L3T6
    {
        private static double x1;
        private static double x2;

        static void Main()
        {
            Console.WriteLine("Введите коэфициент а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэфициент b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите с");
            int c = Convert.ToInt32(Console.ReadLine());
            int D = (int) Math.Pow(b, 2) - 4 * a * c;

            if (a > 0 || b > 0 || c > 0)
            {
                if (D>0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine(Math.Round(x1));
                    Console.WriteLine(Math.Round(x2));
                }
                else if (D==0)
                {
                    x1 = (-b) / (2 * a);
                    Console.WriteLine(Math.Round(x1));
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