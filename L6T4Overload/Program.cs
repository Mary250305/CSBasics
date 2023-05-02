namespace L6T4Overload
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(GetTypeSize(2));
            Console.WriteLine(GetTypeSize(5));
            Console.WriteLine(GetTypeSize(18));
            Console.WriteLine(GetTypeSize(1234567890));
            Console.WriteLine(GetTypeSize(3.14));
            Console.WriteLine(GetTypeSize(6.2837));
        }
        static int GetTypeSize(byte value)
        {
            return sizeof(byte);
        }

        static int GetTypeSize(short value)
        {
            return sizeof(short);
        }

        static int GetTypeSize(int value)
        {
            return sizeof(int);
        }

        static int GetTypeSize(long value)
        {
            return sizeof(long);
        }

        static int GetTypeSize(float value)
        {
            return sizeof(float);
        }

        static int GetTypeSize(double value)
        {
            return sizeof(double);
        }
    }
}