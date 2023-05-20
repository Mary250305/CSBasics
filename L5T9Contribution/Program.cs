namespace L5T9Contribution
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите сумму вклада: ");
            double deposit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ставку годовых, %: ");
            double interestRate = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("Введите срок вклада, мес.: ");
            int depositTerm = Convert.ToInt32(Console.ReadLine());

            double profit = 0;

            for (int i = 1; i <= depositTerm; i++)
            {
                double monthInterestRate = interestRate / 12;
                double monthInterest = deposit * monthInterestRate;
                deposit += monthInterest;
                profit += monthInterest;
            }

            Console.WriteLine("Сумма вклада с капитализацией: " + Math.Round(deposit,1));
            Console.WriteLine("Прибыль на вклад: " + Math.Round(profit,1));
        }
    }
}

