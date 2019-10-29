using System;

namespace CsItselfPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boiling Point
            Predicate<int> IsBoilingPoint = delegate (int temperature) { return temperature == 100; };
            int waterTemperature = 100;

            if (IsBoilingPoint(waterTemperature))
            {
                Console.WriteLine("It is time to steam punk!");
            }
            else
            {
                Console.WriteLine("We need some more energy to create steam!");
            }
            #endregion

            #region Number Is Even
            Predicate<int> isEven = IsEven;
            Console.WriteLine($"Число 15 - четное: {IsEven(15)}");
            Console.WriteLine($"Число 16 - четное: {IsEven(16)}");
            #endregion

        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
