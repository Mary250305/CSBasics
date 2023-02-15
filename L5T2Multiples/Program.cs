using System.Globalization;

namespace L5T2Multiples
{
    class Program
    {
        static void Main()
        {
            for ( int i = 100; i >= 1; i-- )
            {
                Console.WriteLine( i );
            }

            Console.WriteLine();

            int number = 5;
            for (int j = 1; j <= number; j++)
            {
                Console.WriteLine(Math.Pow( j, 2 ) );
            }
        }
    }
}