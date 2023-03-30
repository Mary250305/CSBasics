namespace L6T3Degrees
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(ConversionKelvin(5));
            Console.WriteLine(ConversionFahrenheit(5));
        }

        public static double ConversionKelvin(int x)
        {
            double T = 273.15;
            return (double) (x + T);
        }

        public static double ConversionFahrenheit (int x)
        {
            return (double)(1.8 * x + 32);
        }
    }
}