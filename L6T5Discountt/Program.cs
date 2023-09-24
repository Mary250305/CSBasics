namespace L6T5Discount
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите сумму заказа:");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество позиций:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("К оплате " + ConversionDiscount(price, quantity));
        }

        public static double ConversionDiscount(double price, int quantity)
        {
            if (price >= 1000 && quantity >= 10)
            {
                return price - ((price * 10) / 100);
            }
            else if (price >= 1000 && quantity < 10)
            {
                return price - ((price * 5) / 100);
            }
            else if (price < 1000 && quantity >= 10)
            {
                return price - ((price * 5) / 100);
            }
            else
            {
                return price;
            }
        }
    }
}