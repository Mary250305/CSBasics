namespace L5T5Break
{
    class Pogram
    {
        static void Main()
        {
            for (; ; )
            {
                Console.WriteLine();
                Console.Write("Введите слово: ");
                string line = Convert.ToString(Console.ReadLine());

                string inventedLine = "рука";

                if (line == inventedLine)
                {
                    Console.WriteLine("Верно");
                    break;
                }
            }
        }
    }
}