using System;

namespace FizzBuzz
{
    public class CountGame
    {
        public string OrdMapping(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            };
            return number.ToString();
        }
    }
}
