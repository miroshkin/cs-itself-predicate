using System;

namespace CsItselfPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Predicate<int> IsBoilingPoint = delegate(int temperature) { return temperature == 100;};

            Predicate<int> isEven = IsEven;

            Console.WriteLine($"Число 15 - четное: {IsEven(15)}");
            Console.WriteLine($"Число 16 - четное: {IsEven(16)}");

            int waterTemperature = 100;

            if (IsBoilingPoint(waterTemperature))
            {
                Console.WriteLine("It is time to steam punk!");
            }
            else
            {
                Console.WriteLine("We need some more energy to create steam!");
            }

        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
