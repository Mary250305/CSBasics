namespace L6T3Degrees
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите температуру в градусах Цельсия для перевода в градусы Кельвина: ");
            Console.WriteLine("Температура по шкале Кельвина: " + ConversionKelvin(Convert.ToDouble(Console.ReadLine())));
            Console.Write("Введите температуру в градусах Цельсия для перевода в градусы Фаренгейта: ");
            Console.WriteLine("Температура по шкале Фаренгейта: " +ConversionFahrenheit(Convert.ToDouble(Console.ReadLine())));
        }

        public static double ConversionKelvin(double x)
        {
            double T = 273.15;
            return (double) (x + T);
        }

        public static double ConversionFahrenheit (double x)
        {
            return (double)(1.8 * x + 32);
        }
    }
}