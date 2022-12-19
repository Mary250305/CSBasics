namespace L1T1Expressions
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите переменную 1: ");
            int variable1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите переменную 2: ");
            int variable2 = Convert.ToInt32(Console.ReadLine());

            int expressions = (variable1 + variable2) * (variable1 - variable2);
            Console.WriteLine(expressions);
        }
    }
}