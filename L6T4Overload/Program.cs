namespace L6T4Overload
{
    class Program
    {
        public static void Main()
        {
            byte b = 2;
            short s = 5;
            int i = 18;
            long l = 1234567890;
            float f = 3.14f;
            double d = 6.283185307;

            Console.WriteLine(GetTypeSize(b));
            Console.WriteLine(GetTypeSize(s));
            Console.WriteLine(GetTypeSize(i));
            Console.WriteLine(GetTypeSize(l));
            Console.WriteLine(GetTypeSize(f));
            Console.WriteLine(GetTypeSize(d));
        }
        static int GetTypeSize(byte b)
        {
            return sizeof(byte);
        }

        static int GetTypeSize(short s)
        {
            return sizeof(short);
        }

        static int GetTypeSize(int i)
        {
            return sizeof(int);
        }

        static int GetTypeSize(long l)
        {
            return sizeof(long);
        }

        static int GetTypeSize(float f)
        {
            return sizeof(float);
        }

        static int GetTypeSize(double d)
        {
            return sizeof(double);
        }
    }
}