namespace L2T3Apartments
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число этажей: ");
            int floor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число подъездов: ");
            int entrance = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введте номер квартиры: ");
            int apartment = Convert.ToInt32(Console.ReadLine());

            int currentEntrance = (apartment - 1) / (floor * 4) + 1;
            int currentFloor = (apartment - (( currentEntrance - 1) * floor * 4) - 1) / 4 + 1;
            int apartmentPos = apartment % 4;

           if (apartment > floor * entrance *4 || apartment < 0)
            {
                Console.WriteLine("Такой квартиры нет");
            }
            else
            {
                string flatPosition = "";
                switch (apartmentPos)
                {
                    case 0:
                        flatPosition = "ближняя справа";
                        break;
                    case 1:
                        flatPosition = "ближняя слева";
                        break;  
                    case 2:
                        flatPosition = "дальняя слева";
                        break;
                    case 3:
                        flatPosition = "дальняя справа";
                        break;
                }
                Console.WriteLine("Эта квартира находится в {0} подъезде на {1} этаже и эта квартира {2} ", currentEntrance, currentFloor, flatPosition);
            }
        }
    }
}