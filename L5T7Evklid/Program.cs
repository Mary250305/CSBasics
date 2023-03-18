namespace L5T7Evklid
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            int number2 = Convert.ToInt32(Console.ReadLine());

            while (number1 != number2)
            {
                if (number1%number2== 0)
                {
                    Console.WriteLine(number2);
                }
                else                                         //нод (б, а%б)
                {

                }
            }
        }
    }
}