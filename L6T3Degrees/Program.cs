namespace L6T3Degrees
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите температуру в градусах Цельсия для перевода в градусы Кельвина: ");
            double degrees = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Температура по шкале Кельвина: " + ConversionKelvin(degrees) + Environment.NewLine + "Температура по шкале Фаренгейта: " + ConversionFahrenheit(degrees));
        }

        public static double ConversionKelvin(double x)
        {
            return (double)(x + 273.15);
        }

        public static double ConversionFahrenheit(double x)
        {
            return (double)(1.8 * x + 32);
        }
    }
}