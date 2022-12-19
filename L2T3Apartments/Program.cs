internal class Program
{
    private static void Main()
    {
        /*Console.Write("Введите этаж: ");
        int floor = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите подъезд: ");
        int entrance = Convert.ToInt32(Console.ReadLine());*/
        Console.Write("Введите квартиру: ");
        int apartments = Convert.ToInt32(Console.ReadLine());

            if (apartments % 10 == 1)
            {
                double number = Math.Ceiling((double)apartments / 4);

                Console.WriteLine("Подъезд 1");
                Console.WriteLine("Этаж " + number);
                Console.WriteLine("Квартира находится в левом нижнем углу");
            }
            else if (apartments % 10 == 2)
            {
                double number = Math.Ceiling((double)apartments / 4);

                Console.WriteLine("Подъезд 1");
                Console.WriteLine("Этаж " + number);
                Console.WriteLine("Квартира находится в левом верхнем углу");
            }
            else if (apartments % 10 == 3) 
            {
                double number = Math.Ceiling((double)apartments / 4);

                Console.WriteLine("Подъезд 1");
                Console.WriteLine("Этаж " + number);
                Console.WriteLine("Квартира находится в правом верхнем углу");
            }
            else if (apartments % 10 ==4)
            {
                double number = Math.Ceiling((double)apartments / 4);

                Console.WriteLine("Подъезд 1");
                Console.WriteLine("Этаж " + number);
                Console.WriteLine("Квартира находится в правом нижнем углу");
            }
    }
}