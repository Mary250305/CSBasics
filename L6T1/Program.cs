namespace Test
{
    class Test
    {
        public static void Main()
        {
            Console.WriteLine(GetSolution(3, 5));
            Console.WriteLine(GetSolution(4, 5));
            Console.WriteLine(GetArithmeticMean(1, 2));
            Console.WriteLine(GetMaximum(1, 3));
            Console.WriteLine(GetMinimum(1, 3));
        }

        public static double GetSolution(int x, int y)
        {
            return 3 * x + 4 * y;
        }

        public static double GetArithmeticMean(int begin, int end)
        {
            int sum = 0;
            int quantity = 0;

            for (int i = begin; i <= end; i++)
            {
                sum += i;
                quantity += 1;
            }
            return (double)sum / quantity;
        }

        public static double GetMaximum(int x, int y)
        {
            return Math.Max(x, y);
        }

        private static double GetMinimum( int x, int y)
        {
            return Math.Min(x, y);
        }
    }
}