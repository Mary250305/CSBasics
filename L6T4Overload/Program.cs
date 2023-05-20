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

        public static int GetTypeSize(byte x)
        {
            int byteAmount = 1;
            return byteAmount;
        }
        public static int GetTypeSize(short x)
        {
            int byteAmount = 2;
            return byteAmount;
        }
        public static int GetTypeSize(int x)
        {
            int byteAmount = 4;
            return byteAmount;
        }
        public static int GetTypeSize(long x)
        {
            int byteAmount = 4;
            return byteAmount;
        }
        public static int GetTypeSize(float x)
        {
            int byteAmount = 4;
            return byteAmount;
        }
        public static int GetTypeSize(double x)
        {
            int byteAmount = 8;
            return byteAmount;
        }
    }
}