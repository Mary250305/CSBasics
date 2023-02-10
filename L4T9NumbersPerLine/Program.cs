namespace L4T9NumberPerLine
{
    class Program
    {
        static void Main()
        {
            int i = 1;
            while (i <= 100)
            {
                Console.Write(i.ToString().PadLeft(10));
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                i += 1;
            }
        }
    }
}