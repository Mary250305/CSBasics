namespace L5T6PrimeNumbers
{
    class Progrem
    {

        public static void Main()
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i.ToString() + "\n");
                }
            }
        }
        public static bool IsPrime(int N)
        {
            for (int i = 2; i <=(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }
    }
}