namespace L5T4Continue
{
    class Pogram
    {
        static void Main()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i != 5 && i % 3 != 0 && (i < 60 || i > 80))
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            int j = 0;

            while (j <= 100)
            {
                if (j != 5 && j % 3 != 0 && (j < 60 || j > 80))
                {
                    Console.WriteLine(j);
                }
                j++;
            }
        }
    }
}